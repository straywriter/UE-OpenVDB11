#pragma once

THIRD_PARTY_INCLUDES_START
UE_PUSH_MACRO("check")
#undef check

#ifdef _MSC_VER
#pragma warning (push)
// Error
#pragma warning (disable : 4146) // unary minus operator applied to unsigned type, result still unsigned
#pragma warning (disable : 6297) // Arithmetic overflow:  32-bit value is shifted, then cast to 64-bit value.  Results might not be an expected value.
#pragma warning (disable : 4805) // '==': unsafe mix of type 'bool' and type 'int' in operation
#pragma warning (disable : 4804) // '+=': unsafe use of type 'bool' in operation
#pragma warning (disable : 4706) // assignment within conditional expression
#pragma warning (disable : 4723) // potential divide by 0

// Warning
#pragma warning (disable : 4305) // 'argument': truncation from 'int' to 'bool'
#pragma warning (disable : 4191) // 'reinterpret_cast': unsafe conversion from 'boost::xxx' to 'boost::xxx'
#pragma warning (disable : 4456) // declaration of 'filename' hides previous local declaration

#endif