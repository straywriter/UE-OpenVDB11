#include "OpenVDB11CompileBegin.h"
#ifdef EnableTestMorphology
THIRD_PARTY_INCLUDES_START
#ifdef _MSC_VER
#pragma warning (push)
#pragma warning (disable : 4146) // unary minus operator applied to unsigned type, result still unsigned
#pragma warning (disable : 6297) // Arithmetic overflow:  32-bit value is shifted, then cast to 64-bit value.  Results might not be an expected value.
#pragma warning (disable : 4709)
#endif
#include "src/unittest/TestMorphology.cc"
THIRD_PARTY_INCLUDES_END
#endif
#include "OpenVDB11CompileEnd.h"
