// FMSynthDLL.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"

namespace OPL3 {
#define OPLTYPE_IS_OPL3
#include "opl.cpp"
}

#include "FMSynthDLL.h"


// This is an example of an exported variable
//FMSYNTHDLL_API int nFMSynthDLL=0;

// This is an example of an exported function.
//FMSYNTHDLL_API int fnFMSynthDLL(void)
//{
//    return 42;
//}

// This is the constructor of a class that has been exported.
// see FMSynthDLL.h for the class definition
//CFMSynthDLL::CFMSynthDLL()
//{
//    return;
//}

FMSYNTHDLL_API void __stdcall FMSynth_init(OPL3::Bit32u samplerate)
{
	OPL3::adlib_init(samplerate);
}

FMSYNTHDLL_API void __stdcall FMSynth_write(OPL3::Bitu index, OPL3::Bit8u val)
{
	OPL3::adlib_write(index, val);
}

FMSYNTHDLL_API void __stdcall FMSynth_getsample(OPL3::Bit16s * sndptr, OPL3::Bits numsamples)
{
	OPL3::adlib_getsample(sndptr, numsamples);
}
