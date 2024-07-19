// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "Modules/ModuleInterface.h"

class FOpenVDB11UnitTestModule : public IModuleInterface
{

public:
	virtual void StartupModule() override;

	virtual void ShutdownModule() override;

};