#include "OpenVDB11CompileBegin.h"
#ifdef EnableTestTransform
#undef PI
// TestTransform.cc(117): Error C2106 : '=': left operand must be l-value
// TestTransform.cc(485): Error C2106 : '=': left operand must be l-value
// TestTransform.cc(485): Error C2065 : 'SQRT2': undeclared identifier
// TestTransform.cc(493): Error C2065 : 'SQRT2': undeclared identifier
// TestTransform.cc(494): Error C2065 : 'SQRT2': undeclared identifier
#include "src/unittest/TestTransform.cc"
#endif
#include "OpenVDB11CompileEnd.h"
