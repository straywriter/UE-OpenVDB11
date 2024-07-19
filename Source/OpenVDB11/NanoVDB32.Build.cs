using System.IO;
using UnrealBuildTool;

public class NanoVDB32 : ModuleRules
{
	public NanoVDB32(ReadOnlyTargetRules Target) : base(Target)
	{
		Type = ModuleType.External;
		bUseRTTI = true;

		PublicDependencyModuleNames.Add("OpenVDB11");
		
		PublicDefinitions.Add("NANOVDB_USE_OPENVDB");
		PublicDefinitions.Add("NANOVDB_USE_TBB");
		PublicDefinitions.Add("NANOVDB_USE_ZIP");
		PublicDefinitions.Add("NANOVDB_USE_BLOSC");
		// PublicDefinitions.Add("NANOVDB_USE_IOSTREAMS");

		// string NanoVDBVersion = "32.6";
	}
}
