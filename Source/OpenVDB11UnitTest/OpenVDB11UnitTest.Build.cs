
using System.IO;

namespace UnrealBuildTool.Rules
{
	public class OpenVDB11UnitTest : ModuleRules
	{
		public OpenVDB11UnitTest(ReadOnlyTargetRules Target) : base(Target)
		{
			bEnableExceptions = false;
			
			// For boost:: and TBB:: code
			bEnableUndefinedIdentifierWarnings = false;
			bUseRTTI = true;
			
			ModuleIncludePathWarningLevel = WarningLevel.Warning;
			bWarningsAsErrors = false;
			
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

			PublicDefinitions.Add("EnableTestActivate");
			PublicDefinitions.Add("EnableTestAttributeArray");
			PublicDefinitions.Add("EnableTestAttributeArrayString");
			PublicDefinitions.Add("EnableTestAttributeGroup");
			PublicDefinitions.Add("EnableTestAttributeSet");
			PublicDefinitions.Add("EnableTestBBox");
			PublicDefinitions.Add("EnableTestClip");
			PublicDefinitions.Add("EnableTestConjGradient");
			PublicDefinitions.Add("EnableTestCoord");
			PublicDefinitions.Add("EnableTestCount");
			PublicDefinitions.Add("EnableTestCpt");
			PublicDefinitions.Add("EnableTestCurl");
			PublicDefinitions.Add("EnableTestDelayedLoadMetadata");
			PublicDefinitions.Add("EnableTestDense");
			PublicDefinitions.Add("EnableTestDenseSparseTools");
			PublicDefinitions.Add("EnableTestDiagnostics");
			PublicDefinitions.Add("EnableTestDivergence");
			PublicDefinitions.Add("EnableTestDoubleMetadata");
			PublicDefinitions.Add("EnableTestExceptions");
			PublicDefinitions.Add("EnableTestFastSweeping");
			PublicDefinitions.Add("EnableTestFile");
			PublicDefinitions.Add("EnableTestFilter");
			PublicDefinitions.Add("EnableTestFindActiveValues");
			PublicDefinitions.Add("EnableTestFloatMetadata");
			PublicDefinitions.Add("EnableTestGradient");
			PublicDefinitions.Add("EnableTestGrid");
			PublicDefinitions.Add("EnableTestGridBbox");
			PublicDefinitions.Add("EnableTestGridDescriptor");
			PublicDefinitions.Add("EnableTestGridIO");
			PublicDefinitions.Add("EnableTestGridTransformer");
			PublicDefinitions.Add("EnableTestIndexFilter");
			PublicDefinitions.Add("EnableTestIndexIterator");
			PublicDefinitions.Add("EnableTestInit");
			PublicDefinitions.Add("EnableTestInt32Metadata");
			PublicDefinitions.Add("EnableTestInt64Metadata");
			PublicDefinitions.Add("EnableTestInternalOrigin");
			PublicDefinitions.Add("EnableTestLaplacian");
			PublicDefinitions.Add("EnableTestLeaf");
			PublicDefinitions.Add("EnableTestLeafBool");
			PublicDefinitions.Add("EnableTestLeafIO");
			PublicDefinitions.Add("EnableTestLeafManager");
			PublicDefinitions.Add("EnableTestLeafMask");
			PublicDefinitions.Add("EnableTestLeafOrigin");
			PublicDefinitions.Add("EnableTestLevelSetRayIntersector");
			PublicDefinitions.Add("EnableTestLevelSetUtil");
			PublicDefinitions.Add("EnableTestLinearInterp");
			PublicDefinitions.Add("EnableTestMaps");
			PublicDefinitions.Add("EnableTestMat4Metadata");
			PublicDefinitions.Add("EnableTestMath");
			PublicDefinitions.Add("EnableTestMeanCurvature");
			PublicDefinitions.Add("EnableTestMerge");
			PublicDefinitions.Add("EnableTestMeshToVolume");
			PublicDefinitions.Add("EnableTestMetadata");
			PublicDefinitions.Add("EnableTestMetadataIO");
			PublicDefinitions.Add("EnableTestMetaMap");
			PublicDefinitions.Add("EnableTestMorphology");
			PublicDefinitions.Add("EnableTestMultiResGrid");
			PublicDefinitions.Add("EnableTestName");
			PublicDefinitions.Add("EnableTestNodeIterator");
			PublicDefinitions.Add("EnableTestNodeManager");
			PublicDefinitions.Add("EnableTestNodeMask");
			PublicDefinitions.Add("EnableTestNodeVisitor");
			PublicDefinitions.Add("EnableTestParticleAtlas");
			PublicDefinitions.Add("EnableTestParticlesToLevelSet");
			PublicDefinitions.Add("EnableTestPointAdvect");
			PublicDefinitions.Add("EnableTestPointAttribute");
			PublicDefinitions.Add("EnableTestPointConversion");
			PublicDefinitions.Add("EnableTestPointCount");
			PublicDefinitions.Add("EnableTestPointDataLeaf");
			PublicDefinitions.Add("EnableTestPointDelete");
			PublicDefinitions.Add("EnableTestPointGroup");
			PublicDefinitions.Add("EnableTestPointIndexGrid");
			PublicDefinitions.Add("EnableTestPointInstantiate");
			PublicDefinitions.Add("EnableTestPointMask");
			PublicDefinitions.Add("EnableTestPointMove");
			PublicDefinitions.Add("EnableTestPointPartitioner");
			PublicDefinitions.Add("EnableTestPointRasterizeFrustum");
			PublicDefinitions.Add("EnableTestPointRasterizeSDF");
			PublicDefinitions.Add("EnableTestPointRasterizeTrilinear");
			PublicDefinitions.Add("EnableTestPointReplicate");
			PublicDefinitions.Add("EnableTestPointSample");
			PublicDefinitions.Add("EnableTestPointScatter");
			PublicDefinitions.Add("EnableTestPointStatistics");
			PublicDefinitions.Add("EnableTestPointsToMask");
			PublicDefinitions.Add("EnableTestPoissonSolver");
			PublicDefinitions.Add("EnableTestPotentialFlow");
			PublicDefinitions.Add("EnableTestPrePostAPI");
			PublicDefinitions.Add("EnableTestQuadraticInterp");
			PublicDefinitions.Add("EnableTestQuantizedUnitVec");
			PublicDefinitions.Add("EnableTestQuat");
			PublicDefinitions.Add("EnableTestRay");
			PublicDefinitions.Add("EnableTestStats");
			PublicDefinitions.Add("EnableTestStencils");
			PublicDefinitions.Add("EnableTestStream");
			PublicDefinitions.Add("EnableTestStreamCompression");
			PublicDefinitions.Add("EnableTestStringMetadata");
			PublicDefinitions.Add("EnableTestTools");
			PublicDefinitions.Add("EnableTestTopologyToLevelSet");
			PublicDefinitions.Add("EnableTestTransform");
			PublicDefinitions.Add("EnableTestTree");
			PublicDefinitions.Add("EnableTestTreeCombine");
			PublicDefinitions.Add("EnableTestTreeGetSetValues");
			PublicDefinitions.Add("EnableTestTreeIterators");
			PublicDefinitions.Add("EnableTestTypeList");
			PublicDefinitions.Add("EnableTestTypes");
			PublicDefinitions.Add("EnableTestUtil");
			PublicDefinitions.Add("EnableTestValueAccessor");
			PublicDefinitions.Add("EnableTestVec2Metadata");
			PublicDefinitions.Add("EnableTestVec3Metadata");
			PublicDefinitions.Add("EnableTestVolumeRayIntersector");
			PublicDefinitions.Add("EnableTestVolumeToMesh");
			PublicDefinitions.Add("EnableTestVolumeToSpheres");	
		}
	}
}