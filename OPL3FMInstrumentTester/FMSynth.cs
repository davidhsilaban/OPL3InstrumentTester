using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OPL3FMInstrumentTester
{
    class FMSynth
    {
        [DllImport("FMSynthDLL.dll")]
        private static extern void FMSynth_init(uint samplerate);

        [DllImport("FMSynthDLL.dll")]
        private static extern void FMSynth_write(uint index, byte val);

        [DllImport("FMSynthDLL.dll")]
        private static extern void FMSynth_getsample(IntPtr sndptr, int numsamples);

        public FMSynth()
        {
            FMSynth_init(44100);
        }

        public void write(uint index, byte val)
        {
            FMSynth_write(index, val);
        }

        public void getsample(short[] sndptr, int numsamples)
        {
            //short[] sampleData = new short[numsamples];
            IntPtr samplePtr = Marshal.AllocHGlobal(numsamples*sizeof(short)*2);
            FMSynth_getsample(samplePtr, numsamples);
            Marshal.Copy(samplePtr, sndptr, 0, sndptr.Length);
            Marshal.FreeHGlobal(samplePtr);
            //sndptr = sampleData;
        }
    }
}
