using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OPL3FMInstrumentTester
{
    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    class IBKInstrument
    {
        public Byte iModChar;
        public Byte iCarChar;
        public Byte iModScale;
        public Byte iCarScale;
        public Byte iModAttack;
        public Byte iCarAttack;
        public Byte iModSustain;
        public Byte iCarSustain;
        public Byte iModWaveSel;
        public Byte iCarWaveSel;
        public Byte iFeedback;
        //Byte[] Padding;
    }
}
