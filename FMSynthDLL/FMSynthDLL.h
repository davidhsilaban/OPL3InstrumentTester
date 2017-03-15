// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the FMSYNTHDLL_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// FMSYNTHDLL_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef FMSYNTHDLL_EXPORTS
#define FMSYNTHDLL_API __declspec(dllexport)
#else
#define FMSYNTHDLL_API __declspec(dllimport)
#endif

// This class is exported from the FMSynthDLL.dll
//class FMSYNTHDLL_API CFMSynthDLL {
//public:
//	CFMSynthDLL(void);
//	// TODO: add your methods here.
//};

//extern FMSYNTHDLL_API int nFMSynthDLL;

//FMSYNTHDLL_API int fnFMSynthDLL(void);

#ifdef __cplusplus
extern "C" {
#endif
FMSYNTHDLL_API void __stdcall FMSynth_init(OPL3::Bit32u samplerate);
FMSYNTHDLL_API void __stdcall FMSynth_write(OPL3::Bitu index, OPL3::Bit8u val);
FMSYNTHDLL_API void __stdcall FMSynth_getsample(OPL3::Bit16s *sndptr, OPL3::Bits numsamples);
#ifdef __cplusplus
}
#endif
