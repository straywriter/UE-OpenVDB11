#include "OpenVDB11UnitTestModule.h"

#include "Interfaces/IPluginManager.h"
#include "Modules/ModuleManager.h"

#define LOCTEXT_NAMESPACE "OpenVDB11UnitTest"

IMPLEMENT_MODULE(OpenVDB11UnitTestModule, OpenVDB11UnitTest)

void OpenVDB11UnitTestModule::StartupModule()
{
	IModuleInterface::StartupModule();
}

void OpenVDB11UnitTestModule::ShutdownModule()
{
	IModuleInterface::ShutdownModule();
}

#undef LOCTEXT_NAMESPACE