#include <gtest/gtest.h>

#include "Misc/AutomationTest.h"

IMPLEMENT_SIMPLE_AUTOMATION_TEST(FNanoVDB32UnitTest, "NanoVDB32.UnitTest", EAutomationTestFlags::ApplicationContextMask | EAutomationTestFlags::EngineFilter)

bool FNanoVDB32UnitTest::RunTest(const FString& Parameters)
{ 
	::testing::InitGoogleTest();

	return RUN_ALL_TESTS() == 0;
}