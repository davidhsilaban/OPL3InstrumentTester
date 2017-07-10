using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OPL3FMInstrumentTester
{
    [StructLayout(LayoutKind.Explicit)]
    class IBKHeader
    {
        [FieldOffset(0)]
        public Byte[] Signature = new Byte[]{ (byte)'I', (byte)'B', (byte)'K', 0x1A };
        [FieldOffset(4)]
        public IBKInstrument[] InstrumentData; // 128 entries
        [FieldOffset(2052)]
        public String[] Names;
    }
}
