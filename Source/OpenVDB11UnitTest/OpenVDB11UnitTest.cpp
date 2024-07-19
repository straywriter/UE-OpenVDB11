#include <gtest/gtest.h>

#include "Misc/AutomationTest.h"

IMPLEMENT_SIMPLE_AUTOMATION_TEST(FOpenVDB11UnitTest, "OpenVDB11.UnitTest", EAutomationTestFlags::ApplicationContextMask | EAutomationTestFlags::EngineFilter)

bool FOpenVDB11UnitTest::RunTest(const FString& Parameters)
{ 
	::testing::InitGoogleTest();

	return RUN_ALL_TESTS() == 0;
}