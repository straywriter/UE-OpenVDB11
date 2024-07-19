#include "NanoVDB32UnitTestModule.h"

DEFINE_LOG_CATEGORY(NanoVDB32UnitTest);

#define LOCTEXT_NAMESPACE "FNanoVDB32UnitTest"

void FNanoVDB32UnitTestModule::StartupModule()
{
	UE_LOG(NanoVDB32UnitTest, Warning, TEXT("NanoVDB32UnitTest module has been loaded"));
}

void FNanoVDB32UnitTestModule::ShutdownModule()
{
	UE_LOG(NanoVDB32UnitTest, Warning, TEXT("NanoVDB32UnitTest module has been unloaded"));
}

#undef LOCTEXT_NAMESPACE

IMPLEMENT_MODULE(FNanoVDB32UnitTestModule, NanoVDB32UnitTest)