using System.IO;
using UnrealBuildTool;

public class OpenVDB11 : ModuleRules
{
	public OpenVDB11(ReadOnlyTargetRules Target) : base(Target)
	{
		Type = ModuleType.External;
		
		// For boost:: and TBB:: code
		bEnableUndefinedIdentifierWarnings = false;
		bUseRTTI = true;

		bEnableExceptions = true;
		
		bool bDebug = (Target.Configuration == UnrealTargetConfiguration.Debug && Target.bDebugBuildsActuallyUseDebugCRT) || OptimizeCode == CodeOptimization.Never;

		string LibraryPath;

		if (bDebug)
		{
			LibraryPath = Path.Combine(ModuleDirectory, "ThirdParty/debug/lib");
		}
		else
		{
			LibraryPath = Path.Combine(ModuleDirectory, "ThirdParty/lib");
		}
		
		PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "ThirdParty"));
		PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "ThirdParty/include"));

        PublicDefinitions.Add("OPENVDB_STATICLIB");


		if (bDebug)
		{
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "zstd.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "zlibd.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "tbbmalloc_debug.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "tbb12_debug.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "snappy.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "OpenEXRUtil-3_2_d.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "OpenEXRCore-3_2_d.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "OpenEXR-3_2_d.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "lzma.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "lz4d.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "Imath-3_1_d.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "IlmThread-3_2_d.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "Iex-3_2_d.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "deflatestatic.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "bz2d.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_thread-vc140-mt-gd.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_system-vc140-mt-gd.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_regex-vc140-mt-gd.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_random-vc140-mt-gd.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_iostreams-vc140-mt-gd.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_exception-vc140-mt-gd.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_date_time-vc140-mt-gd.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_container-vc140-mt-gd.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_chrono-vc140-mt-gd.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_atomic-vc140-mt-gd.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "libblosc.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "libopenvdb.lib"));
			
		}
		else
		{
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "zstd.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "zlib.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "tbbmalloc.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "tbb12.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "snappy.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "OpenEXRUtil-3_2.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "OpenEXRCore-3_2.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "OpenEXR-3_2.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "lzma.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "lz4.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "Imath-3_1.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "IlmThread-3_2.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "Iex-3_2.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "deflatestatic.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "bz2.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_thread-vc140-mt.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_system-vc140-mt.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_regex-vc140-mt.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_random-vc140-mt.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_iostreams-vc140-mt.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_exception-vc140-mt.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_date_time-vc140-mt.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_container-vc140-mt.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_chrono-vc140-mt.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "boost_atomic-vc140-mt.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "libblosc.lib"));
			PublicAdditionalLibraries.Add(Path.Combine(LibraryPath, "libopenvdb.lib"));
		}

	}
}
