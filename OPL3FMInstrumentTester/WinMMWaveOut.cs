using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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

    public enum WaveFormats
    {
        WAVE_FORMAT_PCM = 1
    }

    class WinMMWaveOut : IDisposable
    {
        public const UInt32 WAVE_MAPPER = unchecked((uint)-1);

        public delegate void waveOutProc(IntPtr hWaveOut, UInt32 uMsg, UIntPtr dwInstance, UIntPtr dwParam1, UIntPtr dwParam2);

        [DllImport("winmm.dll")]
        private static extern WAVEERROR waveOutOpen(out IntPtr hWaveOut, UInt32 uDeviceID, ref WAVEFORMATEX wfx, waveOutProc dwCallback, UIntPtr dwInstance, WaveOutFlags fdwOpen);

        [DllImport("winmm.dll")]
        private static extern WAVEERROR waveOutClose(IntPtr hWaveOut);

        private IntPtr hWaveOut;

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
            if (hWaveOut != IntPtr.Zero) return;

            WAVEFORMATEX waveFormatEx = new WAVEFORMATEX();
            waveFormatEx.wFormatTag = (ushort)WaveFormats.WAVE_FORMAT_PCM;
            waveFormatEx.nChannels = (ushort)this.channels;
            waveFormatEx.nSamplesPerSec = (uint)this.frequency;
            waveFormatEx.wBitsPerSample = (ushort)this.bits;
            waveFormatEx.nBlockAlign = (ushort)(waveFormatEx.nChannels * (waveFormatEx.wBitsPerSample / 8));
            waveFormatEx.nAvgBytesPerSec = waveFormatEx.nSamplesPerSec * waveFormatEx.nBlockAlign;
            waveFormatEx.cbSize = 0;
            Debug.WriteLine(waveOutOpen(out hWaveOut, WAVE_MAPPER, ref waveFormatEx, null, UIntPtr.Zero, WaveOutFlags.CALLBACK_FUNCTION));
            Debug.WriteLine("hWaveOut: "+hWaveOut.ToString());
        }

        ~WinMMWaveOut()
        {
            Dispose(false);
        }

        public void Close()
        {
            if (hWaveOut != null)
            {
                Debug.WriteLine("Closing WaveOut");
                waveOutClose(hWaveOut);
            }
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
