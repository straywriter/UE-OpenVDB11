#include "OpenVDB11UnitTestModule.h"

#include "Modules/ModuleManager.h"

#define LOCTEXT_NAMESPACE "OpenVDB11UnitTest"

IMPLEMENT_MODULE(FOpenVDB11UnitTestModule, OpenVDB11UnitTest)

void FOpenVDB11UnitTestModule::StartupModule()
{
	IModuleInterface::StartupModule();
}

void FOpenVDB11UnitTestModule::ShutdownModule()
{
	IModuleInterface::ShutdownModule();
}

#undef LOCTEXT_NAMESPACE