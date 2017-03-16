using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OPL3FMInstrumentTester
{
    public enum WAVEERROR
    {
        //MMSYSERR_BASE = 0,
        MMSYSERR_BADDEVICEID = 0 + 2,
        MMSYSERR_ALLOCATED = 0 + 4,
        MMSYSERR_INVALHANDLE = 0 + 5,
        MMSYSERR_NODRIVER = 0 + 6,
        MMSYSERR_NOMEM = 0 + 7,
        //WAVERR_BASE = 32,
        WAVERR_BADFORMAT = 32 + 0,
        WAVERR_STILLPLAYING = 32 + 1,
        WAVERR_UNPREPARED = 32 + 2,
        WAVERR_SYNC = 32 + 3
    }

    [Flags]
    public enum WAVEHDRFlags
    {
        WHDR_DONE = 0x00000001,
        WHDR_PREPARED = 0x00000002,
        WHDR_BEGINLOOP = 0x00000004,
        WHDR_ENDLOOP = 0x00000008,
        WHDR_INQUEUE = 0x00000010
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WAVEFORMATEX
    {
        public UInt16 wFormatTag;
        public UInt16 nChannels;
        public UInt32 nSamplesPerSec;
        public UInt32 nAvgBytesPerSec;
        public UInt16 nBlockAlign;
        public UInt16 wBitsPerSample;
        public UInt16 cbSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WAVEHDR
    {
        public IntPtr lpData;
        public UInt32 dwBufferLength;
        public UInt32 dwBytesRecorded;
        public IntPtr dwUser;
        public WAVEHDRFlags dwFlags;
        public UInt32 dwLoops;
        public IntPtr lpNext;
        public IntPtr reserved;
    }

    [Flags]
    public enum WaveOutFlags
    {
        CALLBACK_NULL = 0x00000000,
        CALLBACK_WINDOW = 0x00010000,
        CALLBACK_TASK = 0x00020000,
        CALLBACK_FUNCTION = 0x00030000,
        CALLBACK_THREAD = CALLBACK_TASK,
        CALLBACK_EVENT = 0x00050000,
        WAVE_FORMAT_QUERY = 0x0001,
        WAVE_ALLOWSYNC = 0x0002,
        WAVE_MAPPED = 0x0004,
        WAVE_FORMAT_DIRECT = 0x0008,
        WAVE_FORMAT_DIRECT_QUERY = (WAVE_FORMAT_QUERY | WAVE_FORMAT_DIRECT),
        WAVE_MAPPED_DEFAULT_COMMUNICATION_DEVICE = 0x0010
    }

    public enum WaveOutMessages
    {
        WOM_OPEN = 0x03BB,
        WOM_CLOSE = 0x03BC,
        WOM_DONE = 0x03BD
    }

    public enum WaveFormats
    {
        WAVE_FORMAT_PCM = 1
    }

    class WinMMWaveOut : IDisposable
    {
        public const UInt32 WAVE_MAPPER = unchecked((uint)-1);

        public delegate void WaveOutProc(IntPtr hWaveOut, WaveOutMessages uMsg, IntPtr dwInstance, IntPtr dwParam1, IntPtr dwParam2);

        [DllImport("winmm.dll")]
        private static extern WAVEERROR waveOutOpen(out IntPtr hWaveOut, UInt32 uDeviceID, ref WAVEFORMATEX wfx, WaveOutProc dwCallback, UIntPtr dwInstance, WaveOutFlags fdwOpen);

        [DllImport("winmm.dll")]
        private static extern WAVEERROR waveOutClose(IntPtr hWaveOut);

        [DllImport("winmm.dll")]
        private static extern WAVEERROR waveOutPrepareHeader(IntPtr hWaveOut, IntPtr pwh, UInt32 cbwh);

        [DllImport("winmm.dll")]
        private static extern WAVEERROR waveOutUnprepareHeader(IntPtr hWaveOut, IntPtr pwh, UInt32 cbwh);

        [DllImport("winmm.dll")]
        private static extern WAVEERROR waveOutWrite(IntPtr hWaveOut, IntPtr pwh, UInt32 cbwh);

        private IntPtr hWaveOut;

        private WaveOutProc callbackProc;

        private Thread bufferMonitorThread;
        private Queue<IntPtr> bufferReleaseQueue = new Queue<IntPtr>();
        private bool isActive;
        private object bufferLock = new object();
        private object waveOpenCloseLock = new object();

        private int channels = 1, frequency = 44100, bits = 16;

        public WinMMWaveOut(int channels, int frequency, int bits)
        {
            this.channels = channels;
            this.frequency = frequency;
            this.bits = bits;
            Open();
        }

        public void Open()
        {
            lock (waveOpenCloseLock)
            {
                if (hWaveOut != IntPtr.Zero) return;

                WAVEFORMATEX waveFormatEx = new WAVEFORMATEX();
                waveFormatEx.wFormatTag = (ushort)WaveFormats.WAVE_FORMAT_PCM;
                waveFormatEx.nChannels = (ushort)this.channels;
                waveFormatEx.nSamplesPerSec = (uint)this.frequency;
                waveFormatEx.wBitsPerSample = (ushort)this.bits;
                waveFormatEx.nBlockAlign = (ushort)(waveFormatEx.nChannels * (waveFormatEx.wBitsPerSample / 8));
                waveFormatEx.nAvgBytesPerSec = waveFormatEx.nSamplesPerSec * waveFormatEx.nBlockAlign;
                waveFormatEx.cbSize = 0;

                Debug.WriteLine(waveOutOpen(out hWaveOut, WAVE_MAPPER, ref waveFormatEx, callbackProc, UIntPtr.Zero, WaveOutFlags.CALLBACK_FUNCTION));
                Debug.WriteLine("hWaveOut: " + hWaveOut.ToString());

                callbackProc = new WaveOutProc(WaveOutCallback);

                lock (bufferLock)
                {
                    isActive = true;
                    Monitor.Pulse(bufferLock);
                }

                bufferMonitorThread = new Thread(BufferMonitor);
                bufferMonitorThread.IsBackground = true;
                bufferMonitorThread.Start();
            }
        }

        ~WinMMWaveOut()
        {
            Dispose(false);
        }

        public void Close()
        {
            lock (waveOpenCloseLock)
            {
                if (hWaveOut != null)
                {
                    Debug.WriteLine("Closing WaveOut");

                    lock (bufferLock)
                    {
                        isActive = false;
                        Monitor.Pulse(bufferLock);
                    }

                    bufferMonitorThread.Join();

                    waveOutClose(hWaveOut);
                }
            }
        }

        public void Write(short[] samples)
        {
            lock (waveOpenCloseLock)
            {
                IntPtr data = Marshal.AllocHGlobal(samples.Length * sizeof(short));
                Marshal.Copy(samples, 0, data, samples.Length);

                WAVEHDR pwh = new WAVEHDR();
                pwh.lpData = data;
                pwh.dwBufferLength = (uint)samples.Length * sizeof(short);
                pwh.dwFlags = 0;

                IntPtr pwhHeader = Marshal.AllocHGlobal(Marshal.SizeOf(pwh));
                Marshal.StructureToPtr(pwh, pwhHeader, false);

                waveOutPrepareHeader(hWaveOut, pwhHeader, (uint)Marshal.SizeOf(typeof(WAVEHDR)));
                waveOutWrite(hWaveOut, pwhHeader, (uint)Marshal.SizeOf(typeof(WAVEHDR)));
            }
        }

        private void WaveOutCallback(IntPtr hWaveOut, WaveOutMessages uMsg, IntPtr dwInstance, IntPtr dwParam1, IntPtr dwParam2)
        {
            Debug.WriteLine(uMsg);
            switch (uMsg)
            {
                case WaveOutMessages.WOM_DONE:
                    //WAVEHDR waveHdr = (WAVEHDR)Marshal.PtrToStructure(dwParam1, typeof(WAVEHDR));
                    lock (bufferLock)
                    {
                        bufferReleaseQueue.Enqueue(dwParam1);
                        Monitor.Pulse(bufferLock);
                    }
                    break;
            }
        }

        private void BufferMonitor()
        {
            while (isActive)
            {
                lock (bufferLock)
                {
                    while (bufferReleaseQueue.Count == 0 && isActive)
                    {
                        Debug.WriteLine("Wait");
                        Monitor.Wait(bufferLock, 1000);
                    }
                }

                while (bufferReleaseQueue.Count > 0)
                {
                    ReleaseBuffer();
                }
            }
        }

        private void ReleaseBuffer()
        {
            IntPtr headerPtr;

            lock (bufferLock)
            {
                headerPtr = bufferReleaseQueue.Dequeue();
                Monitor.Pulse(bufferLock);
            }

            WAVEHDR pwh = (WAVEHDR)Marshal.PtrToStructure(headerPtr, typeof(WAVEHDR));
            IntPtr data = pwh.lpData;

            waveOutUnprepareHeader(hWaveOut, headerPtr, (uint)Marshal.SizeOf(typeof(WAVEHDR)));

            Marshal.FreeHGlobal(data);
            Marshal.FreeHGlobal(headerPtr);
        }

        protected void Dispose(bool disposing)
        {
            this.Close();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
