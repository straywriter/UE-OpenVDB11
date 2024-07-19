using UnrealBuildTool;
 
public class NanoVDB32UnitTest : ModuleRules
{
	public NanoVDB32UnitTest(ReadOnlyTargetRules Target) : base(Target)
	{
        bEnableExceptions = false;
			
        // For boost:: and TBB:: code
        bEnableUndefinedIdentifierWarnings = false;
        bUseRTTI = true;

		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"GoogleTest",
				"DeveloperSettings",
				"Projects",
				"OpenVDB11"
			}
		);
		
		PublicDefinitions.Add("NANOVDB_USE_OPENVDB");
		PublicDefinitions.Add("NANOVDB_USE_TBB");
		PublicDefinitions.Add("NANOVDB_USE_ZIP");
		PublicDefinitions.Add("NANOVDB_USE_BLOSC");
	}
}