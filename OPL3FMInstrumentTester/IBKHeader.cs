using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OPL3FMInstrumentTester
{
    [StructLayout(LayoutKind.Sequential)]
    class IBKHeader
    {
        //[FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        //public Byte[] Signature = new Byte[]{ (Byte)'I', (Byte)'B', (Byte)'K', 0x1A };
        private Byte[] _signature;

        //[FieldOffset(4)]
        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.Struct, SizeConst = 128)]
        private IBKInstrument[] _instrumentData; // 128 entries
        //[FieldOffset(2052)]
        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U1, SizeConst = 128 * 9)]
        //public String[] Names = new String[128];
        private Byte[] _instrumentNamesByteArray;

        private String[] m_InstrumentNames;

        public Byte[] Signature { get { return _signature; } }
        public IBKInstrument[] InstrumentData { get { return _instrumentData; } }

        public String[] InstrumentNames
        {
            get
            {
                if (m_InstrumentNames == null)
                {
                    m_InstrumentNames = new string[128];
                    for (int i = 0; i < 128; i++)
                    {
                        m_InstrumentNames[i] = Encoding.ASCII.GetString(_instrumentNamesByteArray, i * 9, 9);
                    }
                }

                return m_InstrumentNames;
            }
        }
    }
}
