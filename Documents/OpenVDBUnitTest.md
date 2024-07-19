Test Environment:

```
UE5.4
Using Visual Studio 2022 14.38.33134 toolchain (C:\Program Files\Microsoft Visual Studio\2022\Professional\VC\Tools\MSVC\14.38.33130) and Windows 10.0.19041.0 SDK (C:\Program Files (x86)\Windows Kits\10).
```



Result:

```
Test Completed. Result={Fail} Name={UnitTest} Path={OpenVDB11.UnitTest}

[==========] Running 682 tests from 108 test suites.
[----------] Global test environment set-up.
[----------] 5 tests from TestActivate
[ RUN      ] TestActivate.testActivate
[       OK ] TestActivate.testActivate (64 ms)
[ RUN      ] TestActivate.testActivateLeafValues
[       OK ] TestActivate.testActivateLeafValues (4 ms)
[ RUN      ] TestActivate.testActivateTiles
[       OK ] TestActivate.testActivateTiles (0 ms)
[ RUN      ] TestActivate.testDeactivateLeafValues
[       OK ] TestActivate.testDeactivateLeafValues (0 ms)
[ RUN      ] TestActivate.testDeactivateTiles
[       OK ] TestActivate.testDeactivateTiles (0 ms)
[----------] 5 tests from TestActivate (68 ms total)
[----------] 12 tests from TestAttributeArray
[ RUN      ] TestAttributeArray.testFixedPointConversion
[       OK ] TestAttributeArray.testFixedPointConversion (0 ms)
[ RUN      ] TestAttributeArray.testRegistry
[       OK ] TestAttributeArray.testRegistry (0 ms)
[ RUN      ] TestAttributeArray.testAttributeArray
[       OK ] TestAttributeArray.testAttributeArray (1 ms)
[ RUN      ] TestAttributeArray.testAttributeArrayCopy
[       OK ] TestAttributeArray.testAttributeArrayCopy (0 ms)
[ RUN      ] TestAttributeArray.testAccessorEval
[       OK ] TestAttributeArray.testAccessorEval (0 ms)
[ RUN      ] TestAttributeArray.testAttributeHandle
[       OK ] TestAttributeArray.testAttributeHandle (0 ms)
[ RUN      ] TestAttributeArray.testStrided
[       OK ] TestAttributeArray.testStrided (0 ms)
[ RUN      ] TestAttributeArray.testDelayedLoad
[       OK ] TestAttributeArray.testDelayedLoad (7 ms)
[ RUN      ] TestAttributeArray.testDefaultValue
[       OK ] TestAttributeArray.testDefaultValue (0 ms)
[ RUN      ] TestAttributeArray.testQuaternions
[       OK ] TestAttributeArray.testQuaternions (0 ms)
[ RUN      ] TestAttributeArray.testMatrices
[       OK ] TestAttributeArray.testMatrices (0 ms)
[ RUN      ] TestAttributeArray.testProfile
[       OK ] TestAttributeArray.testProfile (445 ms)
[----------] 12 tests from TestAttributeArray (454 ms total)
[----------] 6 tests from TestAttributeArrayString
[ RUN      ] TestAttributeArrayString.testStringMetaCache
[       OK ] TestAttributeArrayString.testStringMetaCache (0 ms)
[ RUN      ] TestAttributeArrayString.testStringMetaInserter
[       OK ] TestAttributeArrayString.testStringMetaInserter (0 ms)
[ RUN      ] TestAttributeArrayString.testStringAttribute
[       OK ] TestAttributeArrayString.testStringAttribute (0 ms)
[ RUN      ] TestAttributeArrayString.testStringAttributeHandle
[       OK ] TestAttributeArrayString.testStringAttributeHandle (1 ms)
[ RUN      ] TestAttributeArrayString.testStringAttributeWriteHandle
[       OK ] TestAttributeArrayString.testStringAttributeWriteHandle (0 ms)
[ RUN      ] TestAttributeArrayString.testProfile
[       OK ] TestAttributeArrayString.testProfile (19 ms)
[----------] 6 tests from TestAttributeArrayString (20 ms total)
[----------] 3 tests from TestAttributeGroup
[ RUN      ] TestAttributeGroup.testAttributeGroup
[       OK ] TestAttributeGroup.testAttributeGroup (0 ms)
[ RUN      ] TestAttributeGroup.testAttributeGroupHandle
[       OK ] TestAttributeGroup.testAttributeGroupHandle (0 ms)
[ RUN      ] TestAttributeGroup.testAttributeGroupFilter
[       OK ] TestAttributeGroup.testAttributeGroupFilter (0 ms)
[----------] 3 tests from TestAttributeGroup (0 ms total)
[----------] 3 tests from TestAttributeSet
[ RUN      ] TestAttributeSet.testAttributeSetDescriptor
[       OK ] TestAttributeSet.testAttributeSetDescriptor (1 ms)
[ RUN      ] TestAttributeSet.testAttributeSet
[       OK ] TestAttributeSet.testAttributeSet (0 ms)
[ RUN      ] TestAttributeSet.testAttributeSetGroups
[       OK ] TestAttributeSet.testAttributeSetGroups (0 ms)
[----------] 3 tests from TestAttributeSet (1 ms total)
[----------] 3 tests from TestBBox
[ RUN      ] TestBBox.testBBox
[       OK ] TestBBox.testBBox (0 ms)
[ RUN      ] TestBBox.testCenter
[       OK ] TestBBox.testCenter (0 ms)
[ RUN      ] TestBBox.testExtent
[       OK ] TestBBox.testExtent (0 ms)
[----------] 3 tests from TestBBox (0 ms total)
[----------] 7 tests from TestClip
[ RUN      ] TestClip.testBBox
[       OK ] TestClip.testBBox (5 ms)
[ RUN      ] TestClip.testFrustum
[       OK ] TestClip.testFrustum (73 ms)
[ RUN      ] TestClip.testMaskGrid
[       OK ] TestClip.testMaskGrid (4 ms)
[ RUN      ] TestClip.testBoolMask
[       OK ] TestClip.testBoolMask (4 ms)
[ RUN      ] TestClip.testInvertedBoolMask
[       OK ] TestClip.testInvertedBoolMask (11 ms)
[ RUN      ] TestClip.testNonBoolMask
[       OK ] TestClip.testNonBoolMask (4 ms)
[ RUN      ] TestClip.testInvertedNonBoolMask
[       OK ] TestClip.testInvertedNonBoolMask (12 ms)
[----------] 7 tests from TestClip (113 ms total)
[----------] 3 tests from TestConjGradient
[ RUN      ] TestConjGradient.testJacobi
[       OK ] TestConjGradient.testJacobi (0 ms)
[ RUN      ] TestConjGradient.testIncompleteCholesky
[       OK ] TestConjGradient.testIncompleteCholesky (0 ms)
[ RUN      ] TestConjGradient.testVectorDotProduct
[       OK ] TestConjGradient.testVectorDotProduct (32 ms)
[----------] 3 tests from TestConjGradient (32 ms total)
[----------] 5 tests from TestCoord
[ RUN      ] TestCoord.testCoord
[       OK ] TestCoord.testCoord (0 ms)
[ RUN      ] TestCoord.testConversion
[       OK ] TestCoord.testConversion (0 ms)
[ RUN      ] TestCoord.testIO
[       OK ] TestCoord.testIO (0 ms)
[ RUN      ] TestCoord.testCoordBBox
[       OK ] TestCoord.testCoordBBox (0 ms)
[ RUN      ] TestCoord.testCoordHash
[       OK ] TestCoord.testCoordHash (3 ms)
[----------] 5 tests from TestCoord (3 ms total)
[----------] 4 tests from TestCount
[ RUN      ] TestCount.testCount
[       OK ] TestCount.testCount (76 ms)
[ RUN      ] TestCount.testCountBBox
[       OK ] TestCount.testCountBBox (138 ms)
[ RUN      ] TestCount.testMemUsage
[       OK ] TestCount.testMemUsage (94 ms)
[ RUN      ] TestCount.testMinMax
[       OK ] TestCount.testMinMax (1 ms)
[----------] 4 tests from TestCount (309 ms total)
[----------] 5 tests from TestCpt
[ RUN      ] TestCpt.testCpt
[       OK ] TestCpt.testCpt (4 ms)
[ RUN      ] TestCpt.testCptStencil
[       OK ] TestCpt.testCptStencil (4 ms)
[ RUN      ] TestCpt.testCptTool
[       OK ] TestCpt.testCptTool (6 ms)
[ RUN      ] TestCpt.testCptMaskedTool
[       OK ] TestCpt.testCptMaskedTool (5 ms)
[ RUN      ] TestCpt.testOldStyleStencils
[       OK ] TestCpt.testOldStyleStencils (0 ms)
[----------] 5 tests from TestCpt (19 ms total)
[----------] 6 tests from TestCurl
[ RUN      ] TestCurl.testCurlTool
[       OK ] TestCurl.testCurlTool (4 ms)
[ RUN      ] TestCurl.testCurlMaskedTool
[       OK ] TestCurl.testCurlMaskedTool (3 ms)
[ RUN      ] TestCurl.testISCurl
[       OK ] TestCurl.testISCurl (9 ms)
[ RUN      ] TestCurl.testISCurlStencil
[       OK ] TestCurl.testISCurlStencil (6 ms)
[ RUN      ] TestCurl.testWSCurl
[       OK ] TestCurl.testWSCurl (8 ms)
[ RUN      ] TestCurl.testWSCurlStencil
[       OK ] TestCurl.testWSCurlStencil (5 ms)
[----------] 6 tests from TestCurl (36 ms total)
[----------] 1 test from TestDelayedLoadMetadata
[ RUN      ] TestDelayedLoadMetadata.test
[       OK ] TestDelayedLoadMetadata.test (0 ms)
[----------] 1 test from TestDelayedLoadMetadata (0 ms total)
[----------] 16 tests from TestDense
[ RUN      ] TestDense.testDenseZYX
[       OK ] TestDense.testDenseZYX (1 ms)
[ RUN      ] TestDense.testDenseXYZ
[       OK ] TestDense.testDenseXYZ (0 ms)
[ RUN      ] TestDense.testCopyZYX
[       OK ] TestDense.testCopyZYX (3 ms)
[ RUN      ] TestDense.testCopyXYZ
[       OK ] TestDense.testCopyXYZ (4 ms)
[ RUN      ] TestDense.testCopyBoolZYX
[       OK ] TestDense.testCopyBoolZYX (0 ms)
[ RUN      ] TestDense.testCopyBoolXYZ
[       OK ] TestDense.testCopyBoolXYZ (1 ms)
[ RUN      ] TestDense.testCopyFromDenseWithOffsetZYX
[       OK ] TestDense.testCopyFromDenseWithOffsetZYX (1 ms)
[ RUN      ] TestDense.testCopyFromDenseWithOffsetXYZ
[       OK ] TestDense.testCopyFromDenseWithOffsetXYZ (2 ms)
[ RUN      ] TestDense.testDense2SparseZYX
[       OK ] TestDense.testDense2SparseZYX (0 ms)
[ RUN      ] TestDense.testDense2SparseXYZ
[       OK ] TestDense.testDense2SparseXYZ (0 ms)
[ RUN      ] TestDense.testDense2Sparse2ZYX
[       OK ] TestDense.testDense2Sparse2ZYX (0 ms)
[ RUN      ] TestDense.testDense2Sparse2XYZ
[       OK ] TestDense.testDense2Sparse2XYZ (0 ms)
[ RUN      ] TestDense.testInvalidBBoxZYX
[       OK ] TestDense.testInvalidBBoxZYX (0 ms)
[ RUN      ] TestDense.testInvalidBBoxXYZ
[       OK ] TestDense.testInvalidBBoxXYZ (0 ms)
[ RUN      ] TestDense.testDense2Sparse2DenseZYX
[       OK ] TestDense.testDense2Sparse2DenseZYX (1 ms)
[ RUN      ] TestDense.testDense2Sparse2DenseXYZ
[       OK ] TestDense.testDense2Sparse2DenseXYZ (1 ms)
[----------] 16 tests from TestDense (14 ms total)
[----------] 6 tests from TestDenseSparseTools
[ RUN      ] TestDenseSparseTools.testExtractSparseFloatTree
[       OK ] TestDenseSparseTools.testExtractSparseFloatTree (3 ms)
[ RUN      ] TestDenseSparseTools.testExtractSparseBoolTree
[       OK ] TestDenseSparseTools.testExtractSparseBoolTree (2 ms)
[ RUN      ] TestDenseSparseTools.testExtractSparseAltDenseLayout
[       OK ] TestDenseSparseTools.testExtractSparseAltDenseLayout (5 ms)
[ RUN      ] TestDenseSparseTools.testExtractSparseMaskedTree
[       OK ] TestDenseSparseTools.testExtractSparseMaskedTree (3 ms)
[ RUN      ] TestDenseSparseTools.testDenseTransform
[       OK ] TestDenseSparseTools.testDenseTransform (2 ms)
[ RUN      ] TestDenseSparseTools.testOver
[       OK ] TestDenseSparseTools.testOver (3 ms)
[----------] 6 tests from TestDenseSparseTools (18 ms total)
[----------] 5 tests from TestDiagnostics
[ RUN      ] TestDiagnostics.testCheck
[       OK ] TestDiagnostics.testCheck (0 ms)
[ RUN      ] TestDiagnostics.testDiagnose
[       OK ] TestDiagnostics.testDiagnose (23 ms)
[ RUN      ] TestDiagnostics.testCheckLevelSet
[       OK ] TestDiagnostics.testCheckLevelSet (16 ms)
[ RUN      ] TestDiagnostics.testCheckFogVolume
[       OK ] TestDiagnostics.testCheckFogVolume (19 ms)
[ RUN      ] TestDiagnostics.testUniqueInactiveValues
[       OK ] TestDiagnostics.testUniqueInactiveValues (2635 ms)
[----------] 5 tests from TestDiagnostics (2693 ms total)
[----------] 7 tests from TestDivergence
[ RUN      ] TestDivergence.testDivergenceTool
[       OK ] TestDivergence.testDivergenceTool (4 ms)
[ RUN      ] TestDivergence.testDivergenceMaskedTool
[       OK ] TestDivergence.testDivergenceMaskedTool (4 ms)
[ RUN      ] TestDivergence.testStaggeredDivergence
[       OK ] TestDivergence.testStaggeredDivergence (3 ms)
[ RUN      ] TestDivergence.testISDivergence
[       OK ] TestDivergence.testISDivergence (7 ms)
[ RUN      ] TestDivergence.testISDivergenceStencil
[       OK ] TestDivergence.testISDivergenceStencil (5 ms)
[ RUN      ] TestDivergence.testWSDivergence
[       OK ] TestDivergence.testWSDivergence (13 ms)
[ RUN      ] TestDivergence.testWSDivergenceStencil
[       OK ] TestDivergence.testWSDivergenceStencil (8 ms)
[----------] 7 tests from TestDivergence (45 ms total)
[----------] 1 test from TestFloatMetadata
[ RUN      ] TestFloatMetadata.test
[       OK ] TestFloatMetadata.test (0 ms)
[----------] 1 test from TestFloatMetadata (0 ms total)
[----------] 10 tests from TestExceptions
[ RUN      ] TestExceptions.testArithmeticError
[       OK ] TestExceptions.testArithmeticError (0 ms)
[ RUN      ] TestExceptions.testIndexError
[       OK ] TestExceptions.testIndexError (0 ms)
[ RUN      ] TestExceptions.testIoError
[       OK ] TestExceptions.testIoError (0 ms)
[ RUN      ] TestExceptions.testKeyError
[       OK ] TestExceptions.testKeyError (0 ms)
[ RUN      ] TestExceptions.testLookupError
[       OK ] TestExceptions.testLookupError (0 ms)
[ RUN      ] TestExceptions.testNotImplementedError
[       OK ] TestExceptions.testNotImplementedError (0 ms)
[ RUN      ] TestExceptions.testReferenceError
[       OK ] TestExceptions.testReferenceError (0 ms)
[ RUN      ] TestExceptions.testRuntimeError
[       OK ] TestExceptions.testRuntimeError (0 ms)
[ RUN      ] TestExceptions.testTypeError
[       OK ] TestExceptions.testTypeError (0 ms)
[ RUN      ] TestExceptions.testValueError
[       OK ] TestExceptions.testValueError (0 ms)
[----------] 10 tests from TestExceptions (0 ms total)
[----------] 7 tests from TestFastSweeping
[ RUN      ] TestFastSweeping.dilateSignedDistance
[       OK ] TestFastSweeping.dilateSignedDistance (256 ms)
[ RUN      ] TestFastSweeping.testMaskSdf
[       OK ] TestFastSweeping.testMaskSdf (382 ms)
[ RUN      ] TestFastSweeping.testSdfToFogVolume
[       OK ] TestFastSweeping.testSdfToFogVolume (100 ms)
[ RUN      ] TestFastSweeping.testIntersection
[       OK ] TestFastSweeping.testIntersection (0 ms)
[ RUN      ] TestFastSweeping.fogToSdfAndExt
[       OK ] TestFastSweeping.fogToSdfAndExt (111 ms)
[ RUN      ] TestFastSweeping.sdfToSdfAndExt
[       OK ] TestFastSweeping.sdfToSdfAndExt (165 ms)
[ RUN      ] TestFastSweeping.sdfToSdfAndExt_velocity
[       OK ] TestFastSweeping.sdfToSdfAndExt_velocity (174 ms)
[----------] 7 tests from TestFastSweeping (1188 ms total)
[----------] 25 tests from TestFile
[ RUN      ] TestFile.testHeader
[       OK ] TestFile.testHeader (0 ms)
[ RUN      ] TestFile.testWriteGrid
[       OK ] TestFile.testWriteGrid (1 ms)
[ RUN      ] TestFile.testWriteMultipleGrids
[       OK ] TestFile.testWriteMultipleGrids (1 ms)
[ RUN      ] TestFile.testWriteFloatAsHalf
[       OK ] TestFile.testWriteFloatAsHalf (14 ms)
[ RUN      ] TestFile.testWriteInstancedGrids
[       OK ] TestFile.testWriteInstancedGrids (15 ms)
[ RUN      ] TestFile.testReadGridDescriptors
[       OK ] TestFile.testReadGridDescriptors (1 ms)
[ RUN      ] TestFile.testGridNaming
[       OK ] TestFile.testGridNaming (14 ms)
[ RUN      ] TestFile.testEmptyFile
[       OK ] TestFile.testEmptyFile (3 ms)
[ RUN      ] TestFile.testEmptyGridIO
[       OK ] TestFile.testEmptyGridIO (0 ms)
[ RUN      ] TestFile.testOpen
[       OK ] TestFile.testOpen (7 ms)
[ RUN      ] TestFile.testNonVdbOpen
[       OK ] TestFile.testNonVdbOpen (4 ms)
[ RUN      ] TestFile.testGetMetadata
[       OK ] TestFile.testGetMetadata (3 ms)
[ RUN      ] TestFile.testReadAll
[       OK ] TestFile.testReadAll (5 ms)
[ RUN      ] TestFile.testWriteOpenFile
[       OK ] TestFile.testWriteOpenFile (4 ms)
[ RUN      ] TestFile.testReadGridMetadata
[       OK ] TestFile.testReadGridMetadata (9 ms)
[ RUN      ] TestFile.testReadGrid
[       OK ] TestFile.testReadGrid (5 ms)
[ RUN      ] TestFile.testReadClippedGrid
[       OK ] TestFile.testReadClippedGrid (41 ms)
[ RUN      ] TestFile.testMultiPassIO
[       OK ] TestFile.testMultiPassIO (8 ms)
[ RUN      ] TestFile.testHasGrid
[       OK ] TestFile.testHasGrid (3 ms)
[ RUN      ] TestFile.testNameIterator
[       OK ] TestFile.testNameIterator (5 ms)
[ RUN      ] TestFile.testReadOldFileFormat
[       OK ] TestFile.testReadOldFileFormat (0 ms)
[ RUN      ] TestFile.testCompression
[       OK ] TestFile.testCompression (168 ms)
[ RUN      ] TestFile.testAsync
[       OK ] TestFile.testAsync (4539 ms)
[ RUN      ] TestFile.testBlosc
[       OK ] TestFile.testBlosc (1 ms)
[ RUN      ] TestFile.testDelayedLoadMetadata
[       OK ] TestFile.testDelayedLoadMetadata (18 ms)
[----------] 25 tests from TestFile (4869 ms total)
[----------] 4 tests from TestFilter
[ RUN      ] TestFilter.testOffset
[       OK ] TestFilter.testOffset (5 ms)
[ RUN      ] TestFilter.testMedian
[       OK ] TestFilter.testMedian (399 ms)
[ RUN      ] TestFilter.testMean
[       OK ] TestFilter.testMean (127 ms)
[ RUN      ] TestFilter.testFilterTiles
[       OK ] TestFilter.testFilterTiles (1088 ms)
[----------] 4 tests from TestFilter (1620 ms total)
[----------] 6 tests from TestFindActiveValues
[ RUN      ] TestFindActiveValues.testBasic
[       OK ] TestFindActiveValues.testBasic (0 ms)
[ RUN      ] TestFindActiveValues.testSphere1
[       OK ] TestFindActiveValues.testSphere1 (13 ms)
[ RUN      ] TestFindActiveValues.testSphere2
[       OK ] TestFindActiveValues.testSphere2 (16 ms)
[ RUN      ] TestFindActiveValues.testSparseBox
[       OK ] TestFindActiveValues.testSparseBox (1 ms)
[ RUN      ] TestFindActiveValues.testDenseBox
[       OK ] TestFindActiveValues.testDenseBox (80 ms)
[ RUN      ] TestFindActiveValues.testBenchmarks
[       OK ] TestFindActiveValues.testBenchmarks (82 ms)
[----------] 6 tests from TestFindActiveValues (192 ms total)
[----------] 1 test from TestDoubleMetadata
[ RUN      ] TestDoubleMetadata.test
[       OK ] TestDoubleMetadata.test (0 ms)
[----------] 1 test from TestDoubleMetadata (0 ms total)
[----------] 11 tests from TestGradient
[ RUN      ] TestGradient.testISGradient
[       OK ] TestGradient.testISGradient (3 ms)
[ RUN      ] TestGradient.testISGradientStencil
[       OK ] TestGradient.testISGradientStencil (3 ms)
[ RUN      ] TestGradient.testWSGradient
[       OK ] TestGradient.testWSGradient (1 ms)
[ RUN      ] TestGradient.testWSGradientStencilFrustum
[       OK ] TestGradient.testWSGradientStencilFrustum (25 ms)
[ RUN      ] TestGradient.testWSGradientStencil
[       OK ] TestGradient.testWSGradientStencil (1 ms)
[ RUN      ] TestGradient.testWSGradientNormSqr
[       OK ] TestGradient.testWSGradientNormSqr (0 ms)
[ RUN      ] TestGradient.testWSGradientNormSqrStencil
[       OK ] TestGradient.testWSGradientNormSqrStencil (1 ms)
[ RUN      ] TestGradient.testGradientTool
[       OK ] TestGradient.testGradientTool (5 ms)
[ RUN      ] TestGradient.testGradientMaskedTool
[       OK ] TestGradient.testGradientMaskedTool (4 ms)
[ RUN      ] TestGradient.testIntersectsIsoValue
[       OK ] TestGradient.testIntersectsIsoValue (1 ms)
[ RUN      ] TestGradient.testOldStyleStencils
[       OK ] TestGradient.testOldStyleStencils (0 ms)
[----------] 11 tests from TestGradient (45 ms total)
[----------] 10 tests from TestGrid
[ RUN      ] TestGrid.testGridRegistry
[       OK ] TestGrid.testGridRegistry (1 ms)
[ RUN      ] TestGrid.testConstPtr
[       OK ] TestGrid.testConstPtr (0 ms)
[ RUN      ] TestGrid.testGetGrid
[       OK ] TestGrid.testGetGrid (0 ms)
[ RUN      ] TestGrid.testIsType
[       OK ] TestGrid.testIsType (0 ms)
[ RUN      ] TestGrid.testIsTreeUnique
[       OK ] TestGrid.testIsTreeUnique (0 ms)
[ RUN      ] TestGrid.testTransform
[       OK ] TestGrid.testTransform (0 ms)
[ RUN      ] TestGrid.testCopyGrid
[       OK ] TestGrid.testCopyGrid (0 ms)
[ RUN      ] TestGrid.testValueConversion
[       OK ] TestGrid.testValueConversion (1 ms)
[ RUN      ] TestGrid.testClipping
[       OK ] TestGrid.testClipping (3 ms)
[ RUN      ] TestGrid.testApply
[       OK ] TestGrid.testApply (0 ms)
[----------] 10 tests from TestGrid (6 ms total)
[----------] 2 tests from TestGridBbox
[ RUN      ] TestGridBbox.testLeafBbox
[       OK ] TestGridBbox.testLeafBbox (0 ms)
[ RUN      ] TestGridBbox.testGridBbox
[       OK ] TestGridBbox.testGridBbox (0 ms)
[----------] 2 tests from TestGridBbox (0 ms total)
[----------] 3 tests from TestGridDescriptor
[ RUN      ] TestGridDescriptor.testIO
[       OK ] TestGridDescriptor.testIO (0 ms)
[ RUN      ] TestGridDescriptor.testCopy
[       OK ] TestGridDescriptor.testCopy (0 ms)
[ RUN      ] TestGridDescriptor.testName
[       OK ] TestGridDescriptor.testName (0 ms)
[----------] 3 tests from TestGridDescriptor (0 ms total)
[----------] 11 tests from TestGridTransformer
[ RUN      ] TestGridTransformer.testTransformBoolPoint
[       OK ] TestGridTransformer.testTransformBoolPoint (1777 ms)
[ RUN      ] TestGridTransformer.TransformFloatPoint
[       OK ] TestGridTransformer.TransformFloatPoint (1579 ms)
[ RUN      ] TestGridTransformer.TransformFloatBox
[       OK ] TestGridTransformer.TransformFloatBox (1747 ms)
[ RUN      ] TestGridTransformer.TransformFloatQuadratic
[       OK ] TestGridTransformer.TransformFloatQuadratic (5149 ms)
[ RUN      ] TestGridTransformer.TransformDoubleBox
[       OK ] TestGridTransformer.TransformDoubleBox (1657 ms)
[ RUN      ] TestGridTransformer.TransformInt32Box
[       OK ] TestGridTransformer.TransformInt32Box (1868 ms)
[ RUN      ] TestGridTransformer.TransformInt64Box
[       OK ] TestGridTransformer.TransformInt64Box (1971 ms)
[ RUN      ] TestGridTransformer.TransformVec3SPoint
[       OK ] TestGridTransformer.TransformVec3SPoint (1710 ms)
[ RUN      ] TestGridTransformer.TransformVec3DBox
[       OK ] TestGridTransformer.TransformVec3DBox (2092 ms)
[ RUN      ] TestGridTransformer.testResampleToMatch
[       OK ] TestGridTransformer.testResampleToMatch (6 ms)
[ RUN      ] TestGridTransformer.testDecomposition
[       OK ] TestGridTransformer.testDecomposition (728 ms)
[----------] 11 tests from TestGridTransformer (20284 ms total)
[----------] 7 tests from TestIndexFilter
[ RUN      ] TestIndexFilter.testActiveFilter
[       OK ] TestIndexFilter.testActiveFilter (1 ms)
[ RUN      ] TestIndexFilter.testMultiGroupFilter
[       OK ] TestIndexFilter.testMultiGroupFilter (0 ms)
[ RUN      ] TestIndexFilter.testRandomLeafFilter
[       OK ] TestIndexFilter.testRandomLeafFilter (0 ms)
[ RUN      ] TestIndexFilter.testAttributeHashFilter
[       OK ] TestIndexFilter.testAttributeHashFilter (1 ms)
[ RUN      ] TestIndexFilter.testLevelSetFilter
[       OK ] TestIndexFilter.testLevelSetFilter (1 ms)
[ RUN      ] TestIndexFilter.testBBoxFilter
[       OK ] TestIndexFilter.testBBoxFilter (1 ms)
[ RUN      ] TestIndexFilter.testBinaryFilter
[       OK ] TestIndexFilter.testBinaryFilter (0 ms)
[----------] 7 tests from TestIndexFilter (4 ms total)
[----------] 4 tests from TestIndexIterator
[ RUN      ] TestIndexIterator.testNullFilter
[       OK ] TestIndexIterator.testNullFilter (0 ms)
[ RUN      ] TestIndexIterator.testValueIndexIterator
[       OK ] TestIndexIterator.testValueIndexIterator (0 ms)
[ RUN      ] TestIndexIterator.testFilterIndexIterator
[       OK ] TestIndexIterator.testFilterIndexIterator (0 ms)
[ RUN      ] TestIndexIterator.testProfile
[       OK ] TestIndexIterator.testProfile (35 ms)
[----------] 4 tests from TestIndexIterator (35 ms total)
[----------] 2 tests from TestInit
[ RUN      ] TestInit.test
[       OK ] TestInit.test (0 ms)
[ RUN      ] TestInit.testMatGrids
[       OK ] TestInit.testMatGrids (0 ms)
[----------] 2 tests from TestInit (0 ms total)
[----------] 1 test from TestInt32Metadata
[ RUN      ] TestInt32Metadata.test
[       OK ] TestInt32Metadata.test (0 ms)
[----------] 1 test from TestInt32Metadata (0 ms total)
[----------] 1 test from TestInt64Metadata
[ RUN      ] TestInt64Metadata.test
[       OK ] TestInt64Metadata.test (0 ms)
[----------] 1 test from TestInt64Metadata (0 ms total)
[----------] 1 test from TestInternalOrigin
[ RUN      ] TestInternalOrigin.test
[       OK ] TestInternalOrigin.test (1 ms)
[----------] 1 test from TestInternalOrigin (1 ms total)
[----------] 8 tests from TestLaplacian
[ RUN      ] TestLaplacian.testISLaplacian
[       OK ] TestLaplacian.testISLaplacian (2 ms)
[ RUN      ] TestLaplacian.testISLaplacianStencil
[       OK ] TestLaplacian.testISLaplacianStencil (3 ms)
[ RUN      ] TestLaplacian.testWSLaplacian
[       OK ] TestLaplacian.testWSLaplacian (4 ms)
[ RUN      ] TestLaplacian.testWSLaplacianFrustum
[       OK ] TestLaplacian.testWSLaplacianFrustum (0 ms)
[ RUN      ] TestLaplacian.testWSLaplacianStencil
[       OK ] TestLaplacian.testWSLaplacianStencil (4 ms)
[ RUN      ] TestLaplacian.testOldStyleStencils
[       OK ] TestLaplacian.testOldStyleStencils (1 ms)
[ RUN      ] TestLaplacian.testLaplacianTool
[       OK ] TestLaplacian.testLaplacianTool (6 ms)
[ RUN      ] TestLaplacian.testLaplacianMaskedTool
[       OK ] TestLaplacian.testLaplacianMaskedTool (4 ms)
[----------] 8 tests from TestLaplacian (24 ms total)
[----------] 15 tests from TestLeaf
[ RUN      ] TestLeaf.testBuffer
[       OK ] TestLeaf.testBuffer (0 ms)
[ RUN      ] TestLeaf.testGetValue
[       OK ] TestLeaf.testGetValue (0 ms)
[ RUN      ] TestLeaf.testSetValue
[       OK ] TestLeaf.testSetValue (0 ms)
[ RUN      ] TestLeaf.testIsValueSet
[       OK ] TestLeaf.testIsValueSet (0 ms)
[ RUN      ] TestLeaf.testProbeValue
[       OK ] TestLeaf.testProbeValue (0 ms)
[ RUN      ] TestLeaf.testIterators
[       OK ] TestLeaf.testIterators (0 ms)
[ RUN      ] TestLeaf.testEquivalence
[       OK ] TestLeaf.testEquivalence (0 ms)
[ RUN      ] TestLeaf.testGetOrigin
[       OK ] TestLeaf.testGetOrigin (0 ms)
[ RUN      ] TestLeaf.testIteratorGetCoord
[       OK ] TestLeaf.testIteratorGetCoord (0 ms)
[ RUN      ] TestLeaf.testNegativeIndexing
[       OK ] TestLeaf.testNegativeIndexing (0 ms)
[ RUN      ] TestLeaf.testIsConstant
[       OK ] TestLeaf.testIsConstant (0 ms)
[ RUN      ] TestLeaf.testMedian
[       OK ] TestLeaf.testMedian (0 ms)
[ RUN      ] TestLeaf.testFill
[       OK ] TestLeaf.testFill (0 ms)
[ RUN      ] TestLeaf.testCount
[       OK ] TestLeaf.testCount (0 ms)
[ RUN      ] TestLeaf.testTransientData
[       OK ] TestLeaf.testTransientData (0 ms)
[----------] 15 tests from TestLeaf (0 ms total)
[----------] 15 tests from TestLeafBool
[ RUN      ] TestLeafBool.testGetValue
[       OK ] TestLeafBool.testGetValue (0 ms)
[ RUN      ] TestLeafBool.testSetValue
[       OK ] TestLeafBool.testSetValue (0 ms)
[ RUN      ] TestLeafBool.testProbeValue
[       OK ] TestLeafBool.testProbeValue (0 ms)
[ RUN      ] TestLeafBool.testIterators
[       OK ] TestLeafBool.testIterators (0 ms)
[ RUN      ] TestLeafBool.testIteratorGetCoord
[       OK ] TestLeafBool.testIteratorGetCoord (0 ms)
[ RUN      ] TestLeafBool.testEquivalence
[       OK ] TestLeafBool.testEquivalence (0 ms)
[ RUN      ] TestLeafBool.testGetOrigin
[       OK ] TestLeafBool.testGetOrigin (0 ms)
[ RUN      ] TestLeafBool.testNegativeIndexing
[       OK ] TestLeafBool.testNegativeIndexing (0 ms)
[ RUN      ] TestLeafBool.testIO
[       OK ] TestLeafBool.testIO (0 ms)
[ RUN      ] TestLeafBool.testConstructors
[       OK ] TestLeafBool.testConstructors (0 ms)
[ RUN      ] TestLeafBool.testMerge
[       OK ] TestLeafBool.testMerge (0 ms)
[ RUN      ] TestLeafBool.testCombine
[       OK ] TestLeafBool.testCombine (1 ms)
[ RUN      ] TestLeafBool.testBoolTree
[       OK ] TestLeafBool.testBoolTree (21 ms)
[ RUN      ] TestLeafBool.testMedian
[       OK ] TestLeafBool.testMedian (0 ms)
[ RUN      ] TestLeafBool.testTransientData
[       OK ] TestLeafBool.testTransientData (0 ms)
[----------] 15 tests from TestLeafBool (22 ms total)
[----------] 7 tests from TestLeafIOTest
[ RUN      ] TestLeafIOTest.testBufferInt
[       OK ] TestLeafIOTest.testBufferInt (0 ms)
[ RUN      ] TestLeafIOTest.testBufferFloat
[       OK ] TestLeafIOTest.testBufferFloat (0 ms)
[ RUN      ] TestLeafIOTest.testBufferDouble
[       OK ] TestLeafIOTest.testBufferDouble (0 ms)
[ RUN      ] TestLeafIOTest.testBufferBool
[       OK ] TestLeafIOTest.testBufferBool (0 ms)
[ RUN      ] TestLeafIOTest.testBufferByte
[       OK ] TestLeafIOTest.testBufferByte (0 ms)
[ RUN      ] TestLeafIOTest.testBufferString
[       OK ] TestLeafIOTest.testBufferString (1 ms)
[ RUN      ] TestLeafIOTest.testBufferVec3R
[       OK ] TestLeafIOTest.testBufferVec3R (0 ms)
[----------] 7 tests from TestLeafIOTest (1 ms total)
[----------] 5 tests from TestLeafManager
[ RUN      ] TestLeafManager.testBasics
[       OK ] TestLeafManager.testBasics (30 ms)
[ RUN      ] TestLeafManager.testActiveLeafVoxelCount
[       OK ] TestLeafManager.testActiveLeafVoxelCount (790 ms)
[ RUN      ] TestLeafManager.testForeach
[       OK ] TestLeafManager.testForeach (7 ms)
[ RUN      ] TestLeafManager.testReduce
[       OK ] TestLeafManager.testReduce (0 ms)
[ RUN      ] TestLeafManager.testTreeConfigurations
[       OK ] TestLeafManager.testTreeConfigurations (1 ms)
[----------] 5 tests from TestLeafManager (828 ms total)
[----------] 15 tests from TestLeafMask
[ RUN      ] TestLeafMask.testGetValue
[       OK ] TestLeafMask.testGetValue (0 ms)
[ RUN      ] TestLeafMask.testSetValue
[       OK ] TestLeafMask.testSetValue (0 ms)
[ RUN      ] TestLeafMask.testProbeValue
[       OK ] TestLeafMask.testProbeValue (0 ms)
[ RUN      ] TestLeafMask.testIterators
[       OK ] TestLeafMask.testIterators (0 ms)
[ RUN      ] TestLeafMask.testIteratorGetCoord
[       OK ] TestLeafMask.testIteratorGetCoord (0 ms)
[ RUN      ] TestLeafMask.testEquivalence
[       OK ] TestLeafMask.testEquivalence (0 ms)
[ RUN      ] TestLeafMask.testGetOrigin
[       OK ] TestLeafMask.testGetOrigin (0 ms)
[ RUN      ] TestLeafMask.testNegativeIndexing
[       OK ] TestLeafMask.testNegativeIndexing (0 ms)
[ RUN      ] TestLeafMask.testIO
[       OK ] TestLeafMask.testIO (0 ms)
[ RUN      ] TestLeafMask.testTopologyCopy
[       OK ] TestLeafMask.testTopologyCopy (0 ms)
[ RUN      ] TestLeafMask.testMerge
[       OK ] TestLeafMask.testMerge (0 ms)
[ RUN      ] TestLeafMask.testCombine
[       OK ] TestLeafMask.testCombine (0 ms)
[ RUN      ] TestLeafMask.testTopologyTree
[       OK ] TestLeafMask.testTopologyTree (48 ms)
[ RUN      ] TestLeafMask.testMedian
[       OK ] TestLeafMask.testMedian (0 ms)
[ RUN      ] TestLeafMask.testTransientData
[       OK ] TestLeafMask.testTransientData (0 ms)
[----------] 15 tests from TestLeafMask (48 ms total)
[----------] 3 tests from TestLeafOrigin
[ RUN      ] TestLeafOrigin.test
[       OK ] TestLeafOrigin.test (1 ms)
[ RUN      ] TestLeafOrigin.test2Values
[       OK ] TestLeafOrigin.test2Values (0 ms)
[ RUN      ] TestLeafOrigin.testGetValue
[       OK ] TestLeafOrigin.testGetValue (0 ms)
[----------] 3 tests from TestLeafOrigin (1 ms total)
[----------] 1 test from TestLevelSetRayIntersector
[ RUN      ] TestLevelSetRayIntersector.tests
[       OK ] TestLevelSetRayIntersector.tests (496 ms)
[----------] 1 test from TestLevelSetRayIntersector (496 ms total)
[----------] 4 tests from TestLevelSetUtil
[ RUN      ] TestLevelSetUtil.testSDFToFogVolume
[       OK ] TestLevelSetUtil.testSDFToFogVolume (18 ms)
[ RUN      ] TestLevelSetUtil.testSDFInteriorMask
[       OK ] TestLevelSetUtil.testSDFInteriorMask (10 ms)
[ RUN      ] TestLevelSetUtil.testExtractEnclosedRegion
[       OK ] TestLevelSetUtil.testExtractEnclosedRegion (14 ms)
[ RUN      ] TestLevelSetUtil.testSegmentationTools
[       OK ] TestLevelSetUtil.testSegmentationTools (28 ms)
[----------] 4 tests from TestLevelSetUtil (70 ms total)
[----------] 20 tests from TestLinearInterp
[ RUN      ] TestLinearInterp.testFloat
[       OK ] TestLinearInterp.testFloat (0 ms)
[ RUN      ] TestLinearInterp.testDouble
[       OK ] TestLinearInterp.testDouble (0 ms)
[ RUN      ] TestLinearInterp.testVec3S
[       OK ] TestLinearInterp.testVec3S (0 ms)
[ RUN      ] TestLinearInterp.testTreeFloat
[       OK ] TestLinearInterp.testTreeFloat (0 ms)
[ RUN      ] TestLinearInterp.testTreeDouble
[       OK ] TestLinearInterp.testTreeDouble (0 ms)
[ RUN      ] TestLinearInterp.testTreeVec3S
[       OK ] TestLinearInterp.testTreeVec3S (1 ms)
[ RUN      ] TestLinearInterp.testAccessorFloat
[       OK ] TestLinearInterp.testAccessorFloat (0 ms)
[ RUN      ] TestLinearInterp.testAccessorDouble
[       OK ] TestLinearInterp.testAccessorDouble (0 ms)
[ RUN      ] TestLinearInterp.testAccessorVec3S
[       OK ] TestLinearInterp.testAccessorVec3S (0 ms)
[ RUN      ] TestLinearInterp.testConstantValuesFloat
[       OK ] TestLinearInterp.testConstantValuesFloat (0 ms)
[ RUN      ] TestLinearInterp.testConstantValuesDouble
[       OK ] TestLinearInterp.testConstantValuesDouble (0 ms)
[ RUN      ] TestLinearInterp.testConstantValuesVec3S
[       OK ] TestLinearInterp.testConstantValuesVec3S (0 ms)
[ RUN      ] TestLinearInterp.testFillValuesFloat
[       OK ] TestLinearInterp.testFillValuesFloat (0 ms)
[ RUN      ] TestLinearInterp.testFillValuesDouble
[       OK ] TestLinearInterp.testFillValuesDouble (0 ms)
[ RUN      ] TestLinearInterp.testFillValuesVec3S
[       OK ] TestLinearInterp.testFillValuesVec3S (0 ms)
[ RUN      ] TestLinearInterp.testNegativeIndicesFloat
[       OK ] TestLinearInterp.testNegativeIndicesFloat (0 ms)
[ RUN      ] TestLinearInterp.testNegativeIndicesDouble
[       OK ] TestLinearInterp.testNegativeIndicesDouble (0 ms)
[ RUN      ] TestLinearInterp.testNegativeIndicesVec3S
[       OK ] TestLinearInterp.testNegativeIndicesVec3S (0 ms)
[ RUN      ] TestLinearInterp.testStencilsMatchFloat
[       OK ] TestLinearInterp.testStencilsMatchFloat (0 ms)
[ RUN      ] TestLinearInterp.testStencilsMatchDouble
[       OK ] TestLinearInterp.testStencilsMatchDouble (0 ms)
[----------] 20 tests from TestLinearInterp (1 ms total)
[----------] 11 tests from TestMaps
[ RUN      ] TestMaps.testApproxInverse
[       OK ] TestMaps.testApproxInverse (0 ms)
[ RUN      ] TestMaps.testUniformScale
[       OK ] TestMaps.testUniformScale (0 ms)
[ RUN      ] TestMaps.testTranslation
[       OK ] TestMaps.testTranslation (0 ms)
[ RUN      ] TestMaps.testScaleDefault
[       OK ] TestMaps.testScaleDefault (0 ms)
[ RUN      ] TestMaps.testRotation
[       OK ] TestMaps.testRotation (0 ms)
[ RUN      ] TestMaps.testScaleTranslate
[       OK ] TestMaps.testScaleTranslate (0 ms)
[ RUN      ] TestMaps.testUniformScaleTranslate
[       OK ] TestMaps.testUniformScaleTranslate (0 ms)
[ RUN      ] TestMaps.testDecomposition
[       OK ] TestMaps.testDecomposition (0 ms)
[ RUN      ] TestMaps.testFrustum
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestMaps.cc(533): error: Value of: frustumMap_from_camera.hasSimpleAffine()
  Actual: false
Expected: true
[  FAILED  ] TestMaps.testFrustum (0 ms)
[ RUN      ] TestMaps.testCalcBoundingBox
[       OK ] TestMaps.testCalcBoundingBox (0 ms)
[ RUN      ] TestMaps.testJacobians
[       OK ] TestMaps.testJacobians (0 ms)
[----------] 11 tests from TestMaps (0 ms total)
[----------] 2 tests from TestMat4Metadata
[ RUN      ] TestMat4Metadata.testMat4s
[       OK ] TestMat4Metadata.testMat4s (0 ms)
[ RUN      ] TestMat4Metadata.testMat4d
[       OK ] TestMat4Metadata.testMat4d (0 ms)
[----------] 2 tests from TestMat4Metadata (0 ms total)
[----------] 4 tests from TestMath
[ RUN      ] TestMath.testAll
[       OK ] TestMath.testAll (0 ms)
[ RUN      ] TestMath.testRandomInt
[       OK ] TestMath.testRandomInt (0 ms)
[ RUN      ] TestMath.testRandom01
[       OK ] TestMath.testRandom01 (0 ms)
[ RUN      ] TestMath.testMinMaxIndex
[       OK ] TestMath.testMinMaxIndex (0 ms)
[----------] 4 tests from TestMath (0 ms total)
[----------] 8 tests from TestMeanCurvature
[ RUN      ] TestMeanCurvature.testISMeanCurvature
[       OK ] TestMeanCurvature.testISMeanCurvature (3 ms)
[ RUN      ] TestMeanCurvature.testISMeanCurvatureStencil
[       OK ] TestMeanCurvature.testISMeanCurvatureStencil (3 ms)
[ RUN      ] TestMeanCurvature.testWSMeanCurvature
[       OK ] TestMeanCurvature.testWSMeanCurvature (3 ms)
[ RUN      ] TestMeanCurvature.testWSMeanCurvatureStencil
[       OK ] TestMeanCurvature.testWSMeanCurvatureStencil (3 ms)
[ RUN      ] TestMeanCurvature.testMeanCurvatureTool
[       OK ] TestMeanCurvature.testMeanCurvatureTool (7 ms)
[ RUN      ] TestMeanCurvature.testMeanCurvatureMaskedTool
[       OK ] TestMeanCurvature.testMeanCurvatureMaskedTool (5 ms)
[ RUN      ] TestMeanCurvature.testCurvatureStencil
[       OK ] TestMeanCurvature.testCurvatureStencil (4 ms)
[ RUN      ] TestMeanCurvature.testIntersection
[       OK ] TestMeanCurvature.testIntersection (1 ms)
[----------] 8 tests from TestMeanCurvature (30 ms total)
[----------] 5 tests from TestMerge
[ RUN      ] TestMerge.testTreeToMerge
[       OK ] TestMerge.testTreeToMerge (0 ms)
[ RUN      ] TestMerge.testCsgUnion
[       OK ] TestMerge.testCsgUnion (8 ms)
[ RUN      ] TestMerge.testCsgIntersection
[       OK ] TestMerge.testCsgIntersection (5 ms)
[ RUN      ] TestMerge.testCsgDifference
[       OK ] TestMerge.testCsgDifference (3 ms)
[ RUN      ] TestMerge.testSum
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestMerge.cc(2760): error: Expected equality of these values:
  1.1f+2.2f+3.3f
    Which is: 6.6
  *iter
    Which is: 6.6
[  FAILED  ] TestMerge.testSum (9 ms)
[----------] 5 tests from TestMerge (25 ms total)
[----------] 3 tests from TestMeshToVolume
[ RUN      ] TestMeshToVolume.testUtils
[       OK ] TestMeshToVolume.testUtils (0 ms)
[ RUN      ] TestMeshToVolume.testConversion
[       OK ] TestMeshToVolume.testConversion (2 ms)
[ RUN      ] TestMeshToVolume.testCreateLevelSetBox
[       OK ] TestMeshToVolume.testCreateLevelSetBox (4 ms)
[----------] 3 tests from TestMeshToVolume (6 ms total)
[----------] 3 tests from TestMetadata
[ RUN      ] TestMetadata.testMetadataRegistry
[       OK ] TestMetadata.testMetadataRegistry (0 ms)
[ RUN      ] TestMetadata.testMetadataAsBool
[       OK ] TestMetadata.testMetadataAsBool (0 ms)
[ RUN      ] TestMetadata.testCustomMetadata
[       OK ] TestMetadata.testCustomMetadata (0 ms)
[----------] 3 tests from TestMetadata (0 ms total)
[----------] 16 tests from TestMetadataIO
[ RUN      ] TestMetadataIO.testInt
[       OK ] TestMetadataIO.testInt (0 ms)
[ RUN      ] TestMetadataIO.testMultipleInt
[       OK ] TestMetadataIO.testMultipleInt (0 ms)
[ RUN      ] TestMetadataIO.testInt64
[       OK ] TestMetadataIO.testInt64 (0 ms)
[ RUN      ] TestMetadataIO.testMultipleInt64
[       OK ] TestMetadataIO.testMultipleInt64 (0 ms)
[ RUN      ] TestMetadataIO.testFloat
[       OK ] TestMetadataIO.testFloat (0 ms)
[ RUN      ] TestMetadataIO.testMultipleFloat
[       OK ] TestMetadataIO.testMultipleFloat (0 ms)
[ RUN      ] TestMetadataIO.testDouble
[       OK ] TestMetadataIO.testDouble (0 ms)
[ RUN      ] TestMetadataIO.testMultipleDouble
[       OK ] TestMetadataIO.testMultipleDouble (0 ms)
[ RUN      ] TestMetadataIO.testString
[       OK ] TestMetadataIO.testString (0 ms)
[ RUN      ] TestMetadataIO.testMultipleString
[       OK ] TestMetadataIO.testMultipleString (0 ms)
[ RUN      ] TestMetadataIO.testVec3R
[       OK ] TestMetadataIO.testVec3R (0 ms)
[ RUN      ] TestMetadataIO.testMultipleVec3R
[       OK ] TestMetadataIO.testMultipleVec3R (0 ms)
[ RUN      ] TestMetadataIO.testVec2i
[       OK ] TestMetadataIO.testVec2i (0 ms)
[ RUN      ] TestMetadataIO.testMultipleVec2i
[       OK ] TestMetadataIO.testMultipleVec2i (0 ms)
[ RUN      ] TestMetadataIO.testVec4d
[       OK ] TestMetadataIO.testVec4d (0 ms)
[ RUN      ] TestMetadataIO.testMultipleVec4d
[       OK ] TestMetadataIO.testMultipleVec4d (0 ms)
[----------] 16 tests from TestMetadataIO (0 ms total)
[----------] 9 tests from TestMetaMap
[ RUN      ] TestMetaMap.testInsert
[       OK ] TestMetaMap.testInsert (0 ms)
[ RUN      ] TestMetaMap.testRemove
[       OK ] TestMetaMap.testRemove (0 ms)
[ RUN      ] TestMetaMap.testGetMetadata
[       OK ] TestMetaMap.testGetMetadata (0 ms)
[ RUN      ] TestMetaMap.testIO
[       OK ] TestMetaMap.testIO (0 ms)
[ RUN      ] TestMetaMap.testEmptyIO
[       OK ] TestMetaMap.testEmptyIO (0 ms)
[ RUN      ] TestMetaMap.testCopyConstructor
[       OK ] TestMetaMap.testCopyConstructor (0 ms)
[ RUN      ] TestMetaMap.testCopyConstructorEmpty
[       OK ] TestMetaMap.testCopyConstructorEmpty (0 ms)
[ RUN      ] TestMetaMap.testAssignment
[       OK ] TestMetaMap.testAssignment (0 ms)
[ RUN      ] TestMetaMap.testEquality
[       OK ] TestMetaMap.testEquality (0 ms)
[----------] 9 tests from TestMetaMap (0 ms total)
[----------] 13 tests from TestMorphology
[ RUN      ] TestMorphology.testFloatFaceActiveLeafValues
[       OK ] TestMorphology.testFloatFaceActiveLeafValues (192 ms)
[ RUN      ] TestMorphology.testFloatFaceActiveValues
[       OK ] TestMorphology.testFloatFaceActiveValues (7 ms)
[ RUN      ] TestMorphology.testFloatEdgeActiveLeafValues
[       OK ] TestMorphology.testFloatEdgeActiveLeafValues (508 ms)
[ RUN      ] TestMorphology.testFloatEdgeActiveValues
[       OK ] TestMorphology.testFloatEdgeActiveValues (28 ms)
[ RUN      ] TestMorphology.testFloatVertexActiveLeafValues
[       OK ] TestMorphology.testFloatVertexActiveLeafValues (675 ms)
[ RUN      ] TestMorphology.testFloatVertexActiveValues
[       OK ] TestMorphology.testFloatVertexActiveValues (29 ms)
[ RUN      ] TestMorphology.testMaskFaceActiveLeafValues
[       OK ] TestMorphology.testMaskFaceActiveLeafValues (76 ms)
[ RUN      ] TestMorphology.testMaskFaceActiveValues
[       OK ] TestMorphology.testMaskFaceActiveValues (6 ms)
[ RUN      ] TestMorphology.testMaskEdgeActiveLeafValues
[       OK ] TestMorphology.testMaskEdgeActiveLeafValues (398 ms)
[ RUN      ] TestMorphology.testMaskEdgeActiveValues
[       OK ] TestMorphology.testMaskEdgeActiveValues (23 ms)
[ RUN      ] TestMorphology.testMaskVertexActiveLeafValues
[       OK ] TestMorphology.testMaskVertexActiveLeafValues (518 ms)
[ RUN      ] TestMorphology.testMaskVertexActiveValues
[       OK ] TestMorphology.testMaskVertexActiveValues (25 ms)
[ RUN      ] TestMorphology.testPreserveMaskLeafNodes
[       OK ] TestMorphology.testPreserveMaskLeafNodes (2 ms)
[----------] 13 tests from TestMorphology (2487 ms total)
[----------] 3 tests from TestName
[ RUN      ] TestName.test
[       OK ] TestName.test (0 ms)
[ RUN      ] TestName.testIO
[       OK ] TestName.testIO (0 ms)
[ RUN      ] TestName.testMultipleIO
[       OK ] TestName.testMultipleIO (0 ms)
[----------] 3 tests from TestName (0 ms total)
[----------] 5 tests from TestNodeIterator
[ RUN      ] TestNodeIterator.testEmpty
[       OK ] TestNodeIterator.testEmpty (0 ms)
[ RUN      ] TestNodeIterator.testSinglePositive
[       OK ] TestNodeIterator.testSinglePositive (0 ms)
[ RUN      ] TestNodeIterator.testSingleNegative
[       OK ] TestNodeIterator.testSingleNegative (0 ms)
[ RUN      ] TestNodeIterator.testMultipleBlocks
[       OK ] TestNodeIterator.testMultipleBlocks (0 ms)
[ RUN      ] TestNodeIterator.testDepthBounds
[       OK ] TestNodeIterator.testDepthBounds (0 ms)
[----------] 5 tests from TestNodeIterator (0 ms total)
[----------] 3 tests from TestNodeManager
[ RUN      ] TestNodeManager.testAll
[       OK ] TestNodeManager.testAll (25 ms)
[ RUN      ] TestNodeManager.testConst
[       OK ] TestNodeManager.testConst (1 ms)
[ RUN      ] TestNodeManager.testDynamic
[       OK ] TestNodeManager.testDynamic (31 ms)
[----------] 3 tests from TestNodeManager (57 ms total)
[----------] 5 tests from TestNodeMask
[ RUN      ] TestNodeMask.testCompress
[       OK ] TestNodeMask.testCompress (0 ms)
[ RUN      ] TestNodeMask.testAll4
[       OK ] TestNodeMask.testAll4 (3 ms)
[ RUN      ] TestNodeMask.testAll3
[       OK ] TestNodeMask.testAll3 (1 ms)
[ RUN      ] TestNodeMask.testAll2
[       OK ] TestNodeMask.testAll2 (0 ms)
[ RUN      ] TestNodeMask.testAll1
[       OK ] TestNodeMask.testAll1 (0 ms)
[----------] 5 tests from TestNodeMask (4 ms total)
[----------] 6 tests from TestNodeVisitor
[ RUN      ] TestNodeVisitor.testNodeCount
[       OK ] TestNodeVisitor.testNodeCount (25 ms)
[ RUN      ] TestNodeVisitor.testLeafCount
[       OK ] TestNodeVisitor.testLeafCount (27 ms)
[ RUN      ] TestNodeVisitor.testDepthFirst
[       OK ] TestNodeVisitor.testDepthFirst (29 ms)
[ RUN      ] TestNodeVisitor.testOriginArray
[       OK ] TestNodeVisitor.testOriginArray (25 ms)
[ RUN      ] TestNodeVisitor.testPartialDeactivate
[       OK ] TestNodeVisitor.testPartialDeactivate (26 ms)
[ RUN      ] TestNodeVisitor.testOffset
[       OK ] TestNodeVisitor.testOffset (34 ms)
[----------] 6 tests from TestNodeVisitor (166 ms total)
[----------] 1 test from TestParticleAtlas
[ RUN      ] TestParticleAtlas.testParticleAtlas
[       OK ] TestParticleAtlas.testParticleAtlas (9 ms)
[----------] 1 test from TestParticleAtlas (9 ms total)
[----------] 2 tests from TestPointAdvect
[ RUN      ] TestPointAdvect.testAdvect
[       OK ] TestPointAdvect.testAdvect (5 ms)
[ RUN      ] TestPointAdvect.testZalesaksDisk
[       OK ] TestPointAdvect.testZalesaksDisk (797 ms)
[----------] 2 tests from TestPointAdvect (802 ms total)
[----------] 3 tests from TestPointAttribute
[ RUN      ] TestPointAttribute.testAppendDrop
[       OK ] TestPointAttribute.testAppendDrop (2 ms)
[ RUN      ] TestPointAttribute.testRename
[       OK ] TestPointAttribute.testRename (1 ms)
[ RUN      ] TestPointAttribute.testBloscCompress
[       OK ] TestPointAttribute.testBloscCompress (1 ms)
[----------] 3 tests from TestPointAttribute (4 ms total)
[----------] 4 tests from TestPointCount
[ RUN      ] TestPointCount.testCount
[       OK ] TestPointCount.testCount (0 ms)
[ RUN      ] TestPointCount.testGroup
[       OK ] TestPointCount.testGroup (5 ms)
[ RUN      ] TestPointCount.testOffsets
[       OK ] TestPointCount.testOffsets (5 ms)
[ RUN      ] TestPointCount.testCountGrid
[       OK ] TestPointCount.testCountGrid (27 ms)
[----------] 4 tests from TestPointCount (38 ms total)
[----------] 14 tests from TestPointDataLeaf
[ RUN      ] TestPointDataLeaf.testEmptyLeaf
[       OK ] TestPointDataLeaf.testEmptyLeaf (0 ms)
[ RUN      ] TestPointDataLeaf.testOffsets
[       OK ] TestPointDataLeaf.testOffsets (0 ms)
[ RUN      ] TestPointDataLeaf.testSetValue
[       OK ] TestPointDataLeaf.testSetValue (0 ms)
[ RUN      ] TestPointDataLeaf.testMonotonicity
[       OK ] TestPointDataLeaf.testMonotonicity (0 ms)
[ RUN      ] TestPointDataLeaf.testAttributes
[       OK ] TestPointDataLeaf.testAttributes (0 ms)
[ RUN      ] TestPointDataLeaf.testSteal
[       OK ] TestPointDataLeaf.testSteal (0 ms)
[ RUN      ] TestPointDataLeaf.testTopologyCopy
[       OK ] TestPointDataLeaf.testTopologyCopy (8 ms)
[ RUN      ] TestPointDataLeaf.testEquivalence
[       OK ] TestPointDataLeaf.testEquivalence (0 ms)
[ RUN      ] TestPointDataLeaf.testIterators
[       OK ] TestPointDataLeaf.testIterators (0 ms)
[ RUN      ] TestPointDataLeaf.testReadWriteCompression
[       OK ] TestPointDataLeaf.testReadWriteCompression (0 ms)
[ RUN      ] TestPointDataLeaf.testIO
[       OK ] TestPointDataLeaf.testIO (14 ms)
[ RUN      ] TestPointDataLeaf.testSwap
[       OK ] TestPointDataLeaf.testSwap (0 ms)
[ RUN      ] TestPointDataLeaf.testCopyOnWrite
[       OK ] TestPointDataLeaf.testCopyOnWrite (0 ms)
[ RUN      ] TestPointDataLeaf.testCopyDescriptor
[       OK ] TestPointDataLeaf.testCopyDescriptor (0 ms)
[----------] 14 tests from TestPointDataLeaf (22 ms total)
[----------] 1 test from TestPointDelete
[ RUN      ] TestPointDelete.testDeleteFromGroups
[       OK ] TestPointDelete.testDeleteFromGroups (3 ms)
[----------] 1 test from TestPointDelete (3 ms total)
[----------] 5 tests from TestPointGroup
[ RUN      ] TestPointGroup.testDescriptor
[       OK ] TestPointGroup.testDescriptor (0 ms)
[ RUN      ] TestPointGroup.testAppendDrop
[       OK ] TestPointGroup.testAppendDrop (1 ms)
[ RUN      ] TestPointGroup.testCompact
[       OK ] TestPointGroup.testCompact (0 ms)
[ RUN      ] TestPointGroup.testSet
[       OK ] TestPointGroup.testSet (6 ms)
[ RUN      ] TestPointGroup.testFilter
[       OK ] TestPointGroup.testFilter (1 ms)
[----------] 5 tests from TestPointGroup (8 ms total)
[----------] 3 tests from TestPointIndexGrid
[ RUN      ] TestPointIndexGrid.testPointIndexGrid
[       OK ] TestPointIndexGrid.testPointIndexGrid (14 ms)
[ RUN      ] TestPointIndexGrid.testPointIndexFilter
[       OK ] TestPointIndexGrid.testPointIndexFilter (13 ms)
[ RUN      ] TestPointIndexGrid.testWorldSpaceSearchAndUpdate
[       OK ] TestPointIndexGrid.testWorldSpaceSearchAndUpdate (101 ms)
[----------] 3 tests from TestPointIndexGrid (128 ms total)
[----------] 1 test from TestPointInstantiate
[ RUN      ] TestPointInstantiate.test
[       OK ] TestPointInstantiate.test (1 ms)
[----------] 1 test from TestPointInstantiate (1 ms total)
[----------] 2 tests from TestPointMask
[ RUN      ] TestPointMask.testMask
[       OK ] TestPointMask.testMask (1 ms)
[ RUN      ] TestPointMask.testMaskDeformer
[       OK ] TestPointMask.testMaskDeformer (1 ms)
[----------] 2 tests from TestPointMask (2 ms total)
[----------] 6 tests from TestPointMove
[ RUN      ] TestPointMove.testCachedDeformer
[       OK ] TestPointMove.testCachedDeformer (1 ms)
[ RUN      ] TestPointMove.testMoveLocal
[       OK ] TestPointMove.testMoveLocal (1 ms)
[ RUN      ] TestPointMove.testMoveGlobal
[       OK ] TestPointMove.testMoveGlobal (3 ms)
[ RUN      ] TestPointMove.testCustomDeformer
[       OK ] TestPointMove.testCustomDeformer (1 ms)
[ RUN      ] TestPointMove.testPointData
[       OK ] TestPointMove.testPointData (7 ms)
[ RUN      ] TestPointMove.testPointOrder
[       OK ] TestPointMove.testPointOrder (161 ms)
[----------] 6 tests from TestPointMove (174 ms total)
[----------] 1 test from TestPointPartitioner
[ RUN      ] TestPointPartitioner.testPartitioner
[       OK ] TestPointPartitioner.testPartitioner (1 ms)
[----------] 1 test from TestPointPartitioner (1 ms total)
[----------] 12 tests from TestPointRasterizeFrustum
[ RUN      ] TestPointRasterizeFrustum.testScaleByVoxelVolume
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestPointRasterizeFrustum.cc(148): error: Expected equality of these values:
  sum / static_cast<float>(voxelVolume)
    Which is: 145.6
  *iter
    Which is: 145.6
[  FAILED  ] TestPointRasterizeFrustum.testScaleByVoxelVolume (2 ms)
[ RUN      ] TestPointRasterizeFrustum.testPointRasterization
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestPointRasterizeFrustum.cc(423): error: Expected equality of these values:
  sum
    Which is: 18.2
  *iter
    Which is: 18.2
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestPointRasterizeFrustum.cc(447): error: Expected equality of these values:
  sum / 4
    Which is: 4.55
  *iter
    Which is: 4.55
[  FAILED  ] TestPointRasterizeFrustum.testPointRasterization (5 ms)
[ RUN      ] TestPointRasterizeFrustum.testSphereRasterization
[       OK ] TestPointRasterizeFrustum.testSphereRasterization (5 ms)
[ RUN      ] TestPointRasterizeFrustum.testVelocityMotionBlur
[       OK ] TestPointRasterizeFrustum.testVelocityMotionBlur (2 ms)
[ RUN      ] TestPointRasterizeFrustum.testCameraMotionBlur
[       OK ] TestPointRasterizeFrustum.testCameraMotionBlur (1 ms)
[ RUN      ] TestPointRasterizeFrustum.testBool
[       OK ] TestPointRasterizeFrustum.testBool (1 ms)
[ RUN      ] TestPointRasterizeFrustum.testInt
[       OK ] TestPointRasterizeFrustum.testInt (1 ms)
[ RUN      ] TestPointRasterizeFrustum.testInputs
[       OK ] TestPointRasterizeFrustum.testInputs (0 ms)
[ RUN      ] TestPointRasterizeFrustum.testInterrupter
[       OK ] TestPointRasterizeFrustum.testInterrupter (44 ms)
[ RUN      ] TestPointRasterizeFrustum.testClipping
[       OK ] TestPointRasterizeFrustum.testClipping (32 ms)
[ RUN      ] TestPointRasterizeFrustum.testStreaming
[       OK ] TestPointRasterizeFrustum.testStreaming (954 ms)
[ RUN      ] TestPointRasterizeFrustum.testProfile
[       OK ] TestPointRasterizeFrustum.testProfile (3775 ms)
[----------] 12 tests from TestPointRasterizeFrustum (4822 ms total)
[----------] 6 tests from TestPointRasterizeSDF
[ RUN      ] TestPointRasterizeSDF.testRasterizeSpheres
[       OK ] TestPointRasterizeSDF.testRasterizeSpheres (139 ms)
[ RUN      ] TestPointRasterizeSDF.testRasterizeVariableSpheres
[       OK ] TestPointRasterizeSDF.testRasterizeVariableSpheres (213 ms)
[ RUN      ] TestPointRasterizeSDF.testRasterizeSmoothSpheres
[       OK ] TestPointRasterizeSDF.testRasterizeSmoothSpheres (54 ms)
[ RUN      ] TestPointRasterizeSDF.testRasterizeVariableSmoothSpheres
[       OK ] TestPointRasterizeSDF.testRasterizeVariableSmoothSpheres (69 ms)
[ RUN      ] TestPointRasterizeSDF.testAttrTransfer
[       OK ] TestPointRasterizeSDF.testAttrTransfer (94 ms)
[ RUN      ] TestPointRasterizeSDF.testVariableAttrTransfer
[       OK ] TestPointRasterizeSDF.testVariableAttrTransfer (53 ms)
[----------] 6 tests from TestPointRasterizeSDF (622 ms total)
[----------] 9 tests from TestPointRasterize
[ RUN      ] TestPointRasterize.testTrilinearRasterizeFloat
[       OK ] TestPointRasterize.testTrilinearRasterizeFloat (5 ms)
[ RUN      ] TestPointRasterize.testTrilinearRasterizeDouble
[       OK ] TestPointRasterize.testTrilinearRasterizeDouble (4 ms)
[ RUN      ] TestPointRasterize.testTrilinearRasterizeVec3f
[       OK ] TestPointRasterize.testTrilinearRasterizeVec3f (4 ms)
[ RUN      ] TestPointRasterize.testTrilinearRasterizeVec3d
[       OK ] TestPointRasterize.testTrilinearRasterizeVec3d (4 ms)
[ RUN      ] TestPointRasterize.testRasterizeWithFilter
[       OK ] TestPointRasterize.testRasterizeWithFilter (1 ms)
[ RUN      ] TestPointRasterize.testRasterizeWithInitializeAndFinalize
[       OK ] TestPointRasterize.testRasterizeWithInitializeAndFinalize (0 ms)
[ RUN      ] TestPointRasterize.tetsSingleTreeRasterize
[       OK ] TestPointRasterize.tetsSingleTreeRasterize (1 ms)
[ RUN      ] TestPointRasterize.testMultiTreeRasterize
[       OK ] TestPointRasterize.testMultiTreeRasterize (1 ms)
[ RUN      ] TestPointRasterize.testMultiTreeRasterizeWithMask
[       OK ] TestPointRasterize.testMultiTreeRasterizeWithMask (0 ms)
[----------] 9 tests from TestPointRasterize (20 ms total)
[----------] 3 tests from TestPointReplicate
[ RUN      ] TestPointReplicate.testReplicate
[       OK ] TestPointReplicate.testReplicate (6 ms)
[ RUN      ] TestPointReplicate.testReplicateScale
[       OK ] TestPointReplicate.testReplicateScale (4 ms)
[ RUN      ] TestPointReplicate.testReplicateZero
[       OK ] TestPointReplicate.testReplicateZero (1 ms)
[----------] 3 tests from TestPointReplicate (11 ms total)
[----------] 2 tests from TestPointSample
[ RUN      ] TestPointSample.testPointSample
[       OK ] TestPointSample.testPointSample (4 ms)
[ RUN      ] TestPointSample.testPointSampleWithGroups
[       OK ] TestPointSample.testPointSampleWithGroups (0 ms)
[----------] 2 tests from TestPointSample (4 ms total)
[----------] 3 tests from TestPointScatter
[ RUN      ] TestPointScatter.testUniformPointScatter
[       OK ] TestPointScatter.testUniformPointScatter (68 ms)
[ RUN      ] TestPointScatter.testDenseUniformPointScatter
[       OK ] TestPointScatter.testDenseUniformPointScatter (15 ms)
[ RUN      ] TestPointScatter.testNonUniformPointScatter
[       OK ] TestPointScatter.testNonUniformPointScatter (9 ms)
[----------] 3 tests from TestPointScatter (93 ms total)
[----------] 4 tests from TestPointStatistics
[ RUN      ] TestPointStatistics.testEvalMinMax
[       OK ] TestPointStatistics.testEvalMinMax (5 ms)
[ RUN      ] TestPointStatistics.testEvalAverage
[       OK ] TestPointStatistics.testEvalAverage (4 ms)
[ RUN      ] TestPointStatistics.testAccumulate
[       OK ] TestPointStatistics.testAccumulate (4 ms)
[ RUN      ] TestPointStatistics.testEvalExtents
[       OK ] TestPointStatistics.testEvalExtents (0 ms)
[----------] 4 tests from TestPointStatistics (13 ms total)
[----------] 1 test from TestPointsToMask
[ RUN      ] TestPointsToMask.testPointsToMask
[       OK ] TestPointsToMask.testPointsToMask (1340 ms)
[----------] 1 test from TestPointsToMask (1340 ms total)
[----------] 6 tests from TestPoissonSolver
[ RUN      ] TestPoissonSolver.testIndexTree
[       OK ] TestPoissonSolver.testIndexTree (0 ms)
[ RUN      ] TestPoissonSolver.testTreeToVectorToTree
[       OK ] TestPoissonSolver.testTreeToVectorToTree (31 ms)
[ RUN      ] TestPoissonSolver.testLaplacian
[       OK ] TestPoissonSolver.testLaplacian (2 ms)
[ RUN      ] TestPoissonSolver.testSolve
[       OK ] TestPoissonSolver.testSolve (281 ms)
[ RUN      ] TestPoissonSolver.testSolveWithBoundaryConditions
[       OK ] TestPoissonSolver.testSolveWithBoundaryConditions (9 ms)
[ RUN      ] TestPoissonSolver.testSolveWithSegmentedDomain
[       OK ] TestPoissonSolver.testSolveWithSegmentedDomain (190 ms)
[----------] 6 tests from TestPoissonSolver (513 ms total)
[----------] 4 tests from TestPotentialFlow
[ RUN      ] TestPotentialFlow.testMask
[       OK ] TestPotentialFlow.testMask (53 ms)
[ RUN      ] TestPotentialFlow.testNeumannVelocities
[       OK ] TestPotentialFlow.testNeumannVelocities (38 ms)
[ RUN      ] TestPotentialFlow.testUniformStream
[       OK ] TestPotentialFlow.testUniformStream (4526 ms)
[ RUN      ] TestPotentialFlow.testFlowAroundSphere
[       OK ] TestPotentialFlow.testFlowAroundSphere (4899 ms)
[----------] 4 tests from TestPotentialFlow (9516 ms total)
[----------] 7 tests from TestPrePostAPI
[ RUN      ] TestPrePostAPI.testMat4
[       OK ] TestPrePostAPI.testMat4 (0 ms)
[ RUN      ] TestPrePostAPI.testMat4Rotate
[       OK ] TestPrePostAPI.testMat4Rotate (0 ms)
[ RUN      ] TestPrePostAPI.testMat4Scale
[       OK ] TestPrePostAPI.testMat4Scale (0 ms)
[ RUN      ] TestPrePostAPI.testMat4Shear
[       OK ] TestPrePostAPI.testMat4Shear (0 ms)
[ RUN      ] TestPrePostAPI.testMaps
[       OK ] TestPrePostAPI.testMaps (0 ms)
[ RUN      ] TestPrePostAPI.testLinearTransform
[       OK ] TestPrePostAPI.testLinearTransform (1 ms)
[ RUN      ] TestPrePostAPI.testFrustumTransform
[       OK ] TestPrePostAPI.testFrustumTransform (0 ms)
[----------] 7 tests from TestPrePostAPI (1 ms total)
[----------] 12 tests from TestQuadraticInterpTest
[ RUN      ] TestQuadraticInterpTest.testFloat
[       OK ] TestQuadraticInterpTest.testFloat (0 ms)
[ RUN      ] TestQuadraticInterpTest.testDouble
[       OK ] TestQuadraticInterpTest.testDouble (0 ms)
[ RUN      ] TestQuadraticInterpTest.testVec3S
[       OK ] TestQuadraticInterpTest.testVec3S (0 ms)
[ RUN      ] TestQuadraticInterpTest.testConstantValuesFloat
[       OK ] TestQuadraticInterpTest.testConstantValuesFloat (0 ms)
[ RUN      ] TestQuadraticInterpTest.testConstantValuesDouble
[       OK ] TestQuadraticInterpTest.testConstantValuesDouble (0 ms)
[ RUN      ] TestQuadraticInterpTest.testConstantValuesVec3S
[       OK ] TestQuadraticInterpTest.testConstantValuesVec3S (0 ms)
[ RUN      ] TestQuadraticInterpTest.testFillValuesFloat
[       OK ] TestQuadraticInterpTest.testFillValuesFloat (0 ms)
[ RUN      ] TestQuadraticInterpTest.testFillValuesDouble
[       OK ] TestQuadraticInterpTest.testFillValuesDouble (0 ms)
[ RUN      ] TestQuadraticInterpTest.testFillValuesVec3S
[       OK ] TestQuadraticInterpTest.testFillValuesVec3S (0 ms)
[ RUN      ] TestQuadraticInterpTest.testNegativeIndicesFloat
[       OK ] TestQuadraticInterpTest.testNegativeIndicesFloat (0 ms)
[ RUN      ] TestQuadraticInterpTest.testNegativeIndicesDouble
[       OK ] TestQuadraticInterpTest.testNegativeIndicesDouble (0 ms)
[ RUN      ] TestQuadraticInterpTest.testNegativeIndicesVec3S
[       OK ] TestQuadraticInterpTest.testNegativeIndicesVec3S (0 ms)
[----------] 12 tests from TestQuadraticInterpTest (0 ms total)
[----------] 1 test from TestQuantizedUnitVec
[ RUN      ] TestQuantizedUnitVec.testQuantization
[       OK ] TestQuantizedUnitVec.testQuantization (7 ms)
[----------] 1 test from TestQuantizedUnitVec (7 ms total)
[----------] 7 tests from TestQuat
[ RUN      ] TestQuat.testConstructor
[       OK ] TestQuat.testConstructor (0 ms)
[ RUN      ] TestQuat.testAxisAngle
[       OK ] TestQuat.testAxisAngle (0 ms)
[ RUN      ] TestQuat.testOpPlus
[       OK ] TestQuat.testOpPlus (0 ms)
[ RUN      ] TestQuat.testOpMinus
[       OK ] TestQuat.testOpMinus (0 ms)
[ RUN      ] TestQuat.testOpMultiply
[       OK ] TestQuat.testOpMultiply (0 ms)
[ RUN      ] TestQuat.testInvert
[       OK ] TestQuat.testInvert (0 ms)
[ RUN      ] TestQuat.testEulerAngles
[       OK ] TestQuat.testEulerAngles (0 ms)
[----------] 7 tests from TestQuat (0 ms total)
[----------] 4 tests from TestRay
[ RUN      ] TestRay.testInfinity
[       OK ] TestRay.testInfinity (0 ms)
[ RUN      ] TestRay.testRay
[       OK ] TestRay.testRay (0 ms)
[ RUN      ] TestRay.testTimeSpan
[       OK ] TestRay.testTimeSpan (0 ms)
[ RUN      ] TestRay.testDDA
[       OK ] TestRay.testDDA (0 ms)
[----------] 4 tests from TestRay (0 ms total)
[----------] 8 tests from TestStats
[ RUN      ] TestStats.testMinMax
[       OK ] TestStats.testMinMax (0 ms)
[ RUN      ] TestStats.testExtrema
[       OK ] TestStats.testExtrema (0 ms)
[ RUN      ] TestStats.testStats
[       OK ] TestStats.testStats (0 ms)
[ RUN      ] TestStats.testHistogram
[       OK ] TestStats.testHistogram (4 ms)
[ RUN      ] TestStats.testGridExtrema
[       OK ] TestStats.testGridExtrema (289 ms)
[ RUN      ] TestStats.testGridStats
[       OK ] TestStats.testGridStats (344 ms)
[ RUN      ] TestStats.testGridOperatorStats
[       OK ] TestStats.testGridOperatorStats (1095 ms)
[ RUN      ] TestStats.testGridHistogram
[       OK ] TestStats.testGridHistogram (43 ms)
[----------] 8 tests from TestStats (1775 ms total)
[----------] 1 test from TestStencils
[ RUN      ] TestStencils.testMinMax
[       OK ] TestStencils.testMinMax (0 ms)
[----------] 1 test from TestStencils (0 ms total)
[----------] 3 tests from TestStream
[ RUN      ] TestStream.testWrite
[       OK ] TestStream.testWrite (3 ms)
[ RUN      ] TestStream.testRead
[       OK ] TestStream.testRead (3 ms)
[ RUN      ] TestStream.testFileReadFromStream
[       OK ] TestStream.testFileReadFromStream (5 ms)
[----------] 3 tests from TestStream (11 ms total)
[----------] 2 tests from TestStreamCompression
[ RUN      ] TestStreamCompression.testBlosc
[       OK ] TestStreamCompression.testBlosc (1 ms)
[ RUN      ] TestStreamCompression.testPagedStreams
[       OK ] TestStreamCompression.testPagedStreams (28 ms)
[----------] 2 tests from TestStreamCompression (29 ms total)
[----------] 1 test from TestStringMetadata
[ RUN      ] TestStringMetadata.test
[       OK ] TestStringMetadata.test (0 ms)
[----------] 1 test from TestStringMetadata (0 ms total)
[----------] 20 tests from TestTools
[ RUN      ] TestTools.testInteriorMask
[       OK ] TestTools.testInteriorMask (6 ms)
[ RUN      ] TestTools.testLevelSetSphere
[       OK ] TestTools.testLevelSetSphere (2 ms)
[ RUN      ] TestTools.testLevelSetPlatonic
[       OK ] TestTools.testLevelSetPlatonic (17 ms)
[ RUN      ] TestTools.testLevelSetAdvect
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestTools.cc(240): error: The difference between (gamma) and (grid->background()) is 8.7998983100412431e-11, which exceeds 0.0, where
(gamma) evaluates to 0.023622047244094488,
(grid->background()) evaluates to 0.023622047156095505, and
0.0 evaluates to 0.
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestTools.cc(266): error: The difference between (4*voxelSize) and (grid->background()) is 1.1733197746721657e-10, which exceeds 0.0, where
(4*voxelSize) evaluates to 0.031496062992125984,
(grid->background()) evaluates to 0.031496062874794006, and
0.0 evaluates to 0.
[  FAILED  ] TestTools.testLevelSetAdvect (3 ms)
[ RUN      ] TestTools.testLevelSetMorph
[       OK ] TestTools.testLevelSetMorph (99 ms)
[ RUN      ] TestTools.testLevelSetMeasure
[       OK ] TestTools.testLevelSetMeasure (305 ms)
[ RUN      ] TestTools.testMagnitude
[       OK ] TestTools.testMagnitude (6 ms)
[ RUN      ] TestTools.testMaskedMagnitude
[       OK ] TestTools.testMaskedMagnitude (6 ms)
[ RUN      ] TestTools.testNormalize
[       OK ] TestTools.testNormalize (9 ms)
[ RUN      ] TestTools.testMaskedNormalize
[       OK ] TestTools.testMaskedNormalize (13 ms)
[ RUN      ] TestTools.testPointAdvect
[       OK ] TestTools.testPointAdvect (153 ms)
[ RUN      ] TestTools.testPointScatter
[       OK ] TestTools.testPointScatter (158 ms)
[ RUN      ] TestTools.testVolumeAdvect
[       OK ] TestTools.testVolumeAdvect (1074 ms)
[ RUN      ] TestTools.testFloatApply
[       OK ] TestTools.testFloatApply (82 ms)
[ RUN      ] TestTools.testVectorApply
[       OK ] TestTools.testVectorApply (88 ms)
[ RUN      ] TestTools.testAccumulate
[       OK ] TestTools.testAccumulate (37 ms)
[ RUN      ] TestTools.testTransformValues
[       OK ] TestTools.testTransformValues (62 ms)
[ RUN      ] TestTools.testUtil
[       OK ] TestTools.testUtil (9 ms)
[ RUN      ] TestTools.testVectorTransformer
[       OK ] TestTools.testVectorTransformer (4 ms)
[ RUN      ] TestTools.testPrune
[       OK ] TestTools.testPrune (1 ms)
[----------] 20 tests from TestTools (2135 ms total)
[----------] 2 tests from TopologyToLevelSet
[ RUN      ] TopologyToLevelSet.testConversion
[       OK ] TopologyToLevelSet.testConversion (4 ms)
[ RUN      ] TopologyToLevelSet.testInputTiles
[       OK ] TopologyToLevelSet.testInputTiles (3 ms)
[----------] 2 tests from TopologyToLevelSet (7 ms total)
[----------] 5 tests from TestTransform
[ RUN      ] TestTransform.testLinearTransform
[       OK ] TestTransform.testLinearTransform (0 ms)
[ RUN      ] TestTransform.testTransformEquality
[       OK ] TestTransform.testTransformEquality (0 ms)
[ RUN      ] TestTransform.testBackwardCompatibility
[       OK ] TestTransform.testBackwardCompatibility (0 ms)
[ RUN      ] TestTransform.testIsIdentity
[       OK ] TestTransform.testIsIdentity (0 ms)
[ RUN      ] TestTransform.testBoundingBoxes
[       OK ] TestTransform.testBoundingBoxes (0 ms)
[----------] 5 tests from TestTransform (0 ms total)
[----------] 32 tests from TestTree
[ RUN      ] TestTree.testChangeBackground
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestTree.cc(67): error: The difference between (gamma) and (tree.getValue(outside)) is 1.1733197746721657e-10, which exceeds 0.0, where
(gamma) evaluates to 0.031496062992125984,
(tree.getValue(outside)) evaluates to 0.031496062874794006, and
0.0 evaluates to 0.
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestTree.cc(70): error: The difference between (-gamma) and (tree.getValue(inside)) is 1.1733197746721657e-10, which exceeds 0.0, where
(-gamma) evaluates to -0.031496062992125984,
(tree.getValue(inside)) evaluates to -0.031496062874794006, and
0.0 evaluates to 0.
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestTree.cc(76): error: The difference between (background) and (tree.getValue(outside)) is 1.7599796620082486e-09, which exceeds 0.0, where
(background) evaluates to 0.10803149816558116,
(tree.getValue(outside)) evaluates to 0.1080314964056015, and
0.0 evaluates to 0.
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestTree.cc(79): error: The difference between (-background) and (tree.getValue(inside)) is 1.7599796620082486e-09, which exceeds 0.0, where
(-background) evaluates to -0.10803149816558116,
(tree.getValue(inside)) evaluates to -0.1080314964056015, and
0.0 evaluates to 0.
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestTree.cc(88): error: The difference between (gamma) and (tree.getValue(outside)) is 1.1733197746721657e-10, which exceeds 0.0, where
(gamma) evaluates to 0.031496062992125984,
(tree.getValue(outside)) evaluates to 0.031496062874794006, and
0.0 evaluates to 0.
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestTree.cc(91): error: The difference between (-gamma) and (tree.getValue(inside)) is 1.1733197746721657e-10, which exceeds 0.0, where
(-gamma) evaluates to -0.031496062992125984,
(tree.getValue(inside)) evaluates to -0.031496062874794006, and
0.0 evaluates to 0.
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestTree.cc(97): error: The difference between (v1) and (tree.getValue(outside)) is 1.7599796620082486e-09, which exceeds 0.0, where
(v1) evaluates to 0.10803149816558116,
(tree.getValue(outside)) evaluates to 0.1080314964056015, and
0.0 evaluates to 0.
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestTree.cc(100): error: The difference between (v2) and (tree.getValue(inside)) is 7.2745826307230033e-09, which exceeds 0.0, where
(v2) evaluates to -0.20337007177157665,
(tree.getValue(inside)) evaluates to -0.20337006449699402, and
0.0 evaluates to 0.
[  FAILED  ] TestTree.testChangeBackground (3 ms)
[ RUN      ] TestTree.testHalf
[       OK ] TestTree.testHalf (71 ms)
[ RUN      ] TestTree.testValues
[       OK ] TestTree.testValues (95 ms)
[ RUN      ] TestTree.testSetValue
[       OK ] TestTree.testSetValue (1 ms)
[ RUN      ] TestTree.testSetValueOnly
[       OK ] TestTree.testSetValueOnly (0 ms)
[ RUN      ] TestTree.testSetValueInPlace
[       OK ] TestTree.testSetValueInPlace (0 ms)
[ RUN      ] TestTree.testResize
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestTree.cc(499): error: The difference between (sum) and ((0.234f + 4.5678f)) is 2.0861625671386719e-07, which exceeds 0.0, where
(sum) evaluates to 4.8018002510070801,
((0.234f + 4.5678f)) evaluates to 4.8018000423908234, and
0.0 evaluates to 0.
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestTree.cc(523): error: The difference between (sum) and ((0.234f + 4.5678f)) is 2.0861625671386719e-07, which exceeds 0.0, where
(sum) evaluates to 4.8018002510070801,
((0.234f + 4.5678f)) evaluates to 4.8018000423908234, and
0.0 evaluates to 0.
[  FAILED  ] TestTree.testResize (0 ms)
[ RUN      ] TestTree.testHasSameTopology
[       OK ] TestTree.testHasSameTopology (1 ms)
[ RUN      ] TestTree.testTopologyCopy
[       OK ] TestTree.testTopologyCopy (0 ms)
[ RUN      ] TestTree.testIterators
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestTree.cc(668): error: The difference between ((0.234f + 4.5678f)) and (sum) is 2.0861625671386719e-07, which exceeds 0.0, where
((0.234f + 4.5678f)) evaluates to 4.8018000423908234,
(sum) evaluates to 4.8018002510070801, and
0.0 evaluates to 0.
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestTree.cc(696): error: The difference between ((0.234f + 4.5678f)) and (sum) is 2.0861625671386719e-07, which exceeds 0.0, where
((0.234f + 4.5678f)) evaluates to 4.8018000423908234,
(sum) evaluates to 4.8018002510070801, and
0.0 evaluates to 0.
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestTree.cc(726): error: The difference between ((0.234f + 4.5678f)) and (v_sum) is 2.0861625671386719e-07, which exceeds 0.0, where
((0.234f + 4.5678f)) evaluates to 4.8018000423908234,
(v_sum) evaluates to 4.8018002510070801, and
0.0 evaluates to 0.
[  FAILED  ] TestTree.testIterators (1 ms)
[ RUN      ] TestTree.testIO
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\unittest\TestTree.cc(781): error: The difference between (sum) and ((0.234f + 4.5678f)) is 2.0861625671386719e-07, which exceeds 0.0, where
(sum) evaluates to 4.8018002510070801,
((0.234f + 4.5678f)) evaluates to 4.8018000423908234, and
0.0 evaluates to 0.
[  FAILED  ] TestTree.testIO (2 ms)
[ RUN      ] TestTree.testNegativeIndexing
[       OK ] TestTree.testNegativeIndexing (2 ms)
[ RUN      ] TestTree.testDeepCopy
[       OK ] TestTree.testDeepCopy (0 ms)
[ RUN      ] TestTree.testMerge
[       OK ] TestTree.testMerge (2 ms)
[ RUN      ] TestTree.testVoxelizeActiveTiles
[       OK ] TestTree.testVoxelizeActiveTiles (2 ms)
[ RUN      ] TestTree.testTopologyUnion
[       OK ] TestTree.testTopologyUnion (8 ms)
[ RUN      ] TestTree.testTopologyIntersection
[       OK ] TestTree.testTopologyIntersection (4 ms)
[ RUN      ] TestTree.testTopologyDifference
[       OK ] TestTree.testTopologyDifference (5 ms)
[ RUN      ] TestTree.testFill
[       OK ] TestTree.testFill (56 ms)
[ RUN      ] TestTree.testSignedFloodFill
[       OK ] TestTree.testSignedFloodFill (5 ms)
[ RUN      ] TestTree.testPruneInactive
[       OK ] TestTree.testPruneInactive (1 ms)
[ RUN      ] TestTree.testPruneLevelSet
[       OK ] TestTree.testPruneLevelSet (2 ms)
[ RUN      ] TestTree.testTouchLeaf
[       OK ] TestTree.testTouchLeaf (0 ms)
[ RUN      ] TestTree.testProbeLeaf
[       OK ] TestTree.testProbeLeaf (0 ms)
[ RUN      ] TestTree.testAddLeaf
[       OK ] TestTree.testAddLeaf (0 ms)
[ RUN      ] TestTree.testAddTile
[       OK ] TestTree.testAddTile (0 ms)
[ RUN      ] TestTree.testGetNodes
[       OK ] TestTree.testGetNodes (26 ms)
[ RUN      ] TestTree.testStealNodes
[       OK ] TestTree.testStealNodes (25 ms)
[ RUN      ] TestTree.testStealNode
[       OK ] TestTree.testStealNode (0 ms)
[ RUN      ] TestTree.testNodeCount
[       OK ] TestTree.testNodeCount (137 ms)
[ RUN      ] TestTree.testRootNode
[       OK ] TestTree.testRootNode (2 ms)
[ RUN      ] TestTree.testInternalNode
[       OK ] TestTree.testInternalNode (0 ms)
[----------] 32 tests from TestTree (451 ms total)
[----------] 12 tests from TestTreeCombine
[ RUN      ] TestTreeCombine.testCombine
[       OK ] TestTreeCombine.testCombine (2 ms)
[ RUN      ] TestTreeCombine.testCompMax
[       OK ] TestTreeCombine.testCompMax (1 ms)
[ RUN      ] TestTreeCombine.testCompMin
[       OK ] TestTreeCombine.testCompMin (1 ms)
[ RUN      ] TestTreeCombine.testCompSum
[       OK ] TestTreeCombine.testCompSum (1 ms)
[ RUN      ] TestTreeCombine.testCompProd
[       OK ] TestTreeCombine.testCompProd (1 ms)
[ RUN      ] TestTreeCombine.testCompDiv
[       OK ] TestTreeCombine.testCompDiv (0 ms)
[ RUN      ] TestTreeCombine.testCompDivByZero
[       OK ] TestTreeCombine.testCompDivByZero (1 ms)
[ RUN      ] TestTreeCombine.testCompReplace
[       OK ] TestTreeCombine.testCompReplace (1 ms)
[ RUN      ] TestTreeCombine.testCombine2
[       OK ] TestTreeCombine.testCombine2 (1 ms)
[ RUN      ] TestTreeCombine.testBoolTree
[       OK ] TestTreeCombine.testBoolTree (1 ms)
[ RUN      ] TestTreeCombine.testCsgCopy
[       OK ] TestTreeCombine.testCsgCopy (5 ms)
[ RUN      ] TestTreeCombine.testCompActiveLeafVoxels
[       OK ] TestTreeCombine.testCompActiveLeafVoxels (1 ms)
[----------] 12 tests from TestTreeCombine (16 ms total)
[----------] 7 tests from TestTreeGetSetValues
[ RUN      ] TestTreeGetSetValues.testGetBackground
[       OK ] TestTreeGetSetValues.testGetBackground (0 ms)
[ RUN      ] TestTreeGetSetValues.testGetValues
[       OK ] TestTreeGetSetValues.testGetValues (0 ms)
[ RUN      ] TestTreeGetSetValues.testSetValues
[       OK ] TestTreeGetSetValues.testSetValues (0 ms)
[ RUN      ] TestTreeGetSetValues.testUnsetValues
[       OK ] TestTreeGetSetValues.testUnsetValues (0 ms)
[ RUN      ] TestTreeGetSetValues.testFill
[       OK ] TestTreeGetSetValues.testFill (7 ms)
[ RUN      ] TestTreeGetSetValues.testSetActiveStates
[       OK ] TestTreeGetSetValues.testSetActiveStates (1 ms)
[ RUN      ] TestTreeGetSetValues.testHasActiveTiles
[       OK ] TestTreeGetSetValues.testHasActiveTiles (3 ms)
[----------] 7 tests from TestTreeGetSetValues (11 ms total)
[----------] 8 tests from TestTreeIterators
[ RUN      ] TestTreeIterators.testLeafIterator
[       OK ] TestTreeIterators.testLeafIterator (1 ms)
[ RUN      ] TestTreeIterators.testEmptyLeafIterator
[       OK ] TestTreeIterators.testEmptyLeafIterator (0 ms)
[ RUN      ] TestTreeIterators.testOnlyNegative
[       OK ] TestTreeIterators.testOnlyNegative (1 ms)
[ RUN      ] TestTreeIterators.testValueAllIterator
[       OK ] TestTreeIterators.testValueAllIterator (1 ms)
[ RUN      ] TestTreeIterators.testValueOnIterator
[       OK ] TestTreeIterators.testValueOnIterator (0 ms)
[ RUN      ] TestTreeIterators.testValueOffIterator
[       OK ] TestTreeIterators.testValueOffIterator (0 ms)
[ RUN      ] TestTreeIterators.testModifyValue
[       OK ] TestTreeIterators.testModifyValue (0 ms)
[ RUN      ] TestTreeIterators.testDepthBounds
[       OK ] TestTreeIterators.testDepthBounds (6 ms)
[----------] 8 tests from TestTreeIterators (9 ms total)
[----------] 3 tests from TestTypeList
[ RUN      ] TestTypeList.testTypeList
[       OK ] TestTypeList.testTypeList (0 ms)
[ RUN      ] TestTypeList.testTupleList
[       OK ] TestTypeList.testTupleList (0 ms)
[ RUN      ] TestTypeList.testOpenVDBTypeLists
[       OK ] TestTypeList.testOpenVDBTypeLists (0 ms)
[----------] 3 tests from TestTypeList (0 ms total)
[----------] 6 tests from TestTypes
[ RUN      ] TestTypes.testVecTraits
[       OK ] TestTypes.testVecTraits (0 ms)
[ RUN      ] TestTypes.testQuatTraits
[       OK ] TestTypes.testQuatTraits (0 ms)
[ RUN      ] TestTypes.testMatTraits
[       OK ] TestTypes.testMatTraits (0 ms)
[ RUN      ] TestTypes.testValueTraits
[       OK ] TestTypes.testValueTraits (0 ms)
[ RUN      ] TestTypes.testConvertElementType
[       OK ] TestTypes.testConvertElementType (0 ms)
[ RUN      ] TestTypes.testPromoteType
[       OK ] TestTypes.testPromoteType (0 ms)
[----------] 6 tests from TestTypes (193 ms total)
[----------] 4 tests from TestUtil
[ RUN      ] TestUtil.testFormats
[       OK ] TestUtil.testFormats (0 ms)
[ RUN      ] TestUtil.testCpuTimer
[       OK ] TestUtil.testCpuTimer (800 ms)
[ RUN      ] TestUtil.testPagedArray
[       OK ] TestUtil.testPagedArray (32 ms)
[ RUN      ] TestUtil.testStringUtils
[       OK ] TestUtil.testStringUtils (0 ms)
[----------] 4 tests from TestUtil (833 ms total)
[----------] 38 tests from TestValueAccessor
[ RUN      ] TestValueAccessor.testTree2Accessor
[       OK ] TestValueAccessor.testTree2Accessor (1 ms)
[ RUN      ] TestValueAccessor.testTree2AccessorRW
[       OK ] TestValueAccessor.testTree2AccessorRW (0 ms)
[ RUN      ] TestValueAccessor.testTree2ConstAccessor
[       OK ] TestValueAccessor.testTree2ConstAccessor (0 ms)
[ RUN      ] TestValueAccessor.testTree2ConstAccessorRW
[       OK ] TestValueAccessor.testTree2ConstAccessorRW (0 ms)
[ RUN      ] TestValueAccessor.testTree3Accessor
[       OK ] TestValueAccessor.testTree3Accessor (0 ms)
[ RUN      ] TestValueAccessor.testTree3AccessorRW
[       OK ] TestValueAccessor.testTree3AccessorRW (0 ms)
[ RUN      ] TestValueAccessor.testTree3ConstAccessor
[       OK ] TestValueAccessor.testTree3ConstAccessor (0 ms)
[ RUN      ] TestValueAccessor.testTree3ConstAccessorRW
[       OK ] TestValueAccessor.testTree3ConstAccessorRW (0 ms)
[ RUN      ] TestValueAccessor.testTree4Accessor
[       OK ] TestValueAccessor.testTree4Accessor (0 ms)
[ RUN      ] TestValueAccessor.testTree4AccessorRW
[       OK ] TestValueAccessor.testTree4AccessorRW (0 ms)
[ RUN      ] TestValueAccessor.testTree4ConstAccessor
[       OK ] TestValueAccessor.testTree4ConstAccessor (0 ms)
[ RUN      ] TestValueAccessor.testTree4ConstAccessorRW
[       OK ] TestValueAccessor.testTree4ConstAccessorRW (0 ms)
[ RUN      ] TestValueAccessor.testTree5Accessor
[       OK ] TestValueAccessor.testTree5Accessor (0 ms)
[ RUN      ] TestValueAccessor.testTree5AccessorRW
[       OK ] TestValueAccessor.testTree5AccessorRW (1 ms)
[ RUN      ] TestValueAccessor.testTree5ConstAccessor
[       OK ] TestValueAccessor.testTree5ConstAccessor (0 ms)
[ RUN      ] TestValueAccessor.testTree5ConstAccessorRW
[       OK ] TestValueAccessor.testTree5ConstAccessorRW (0 ms)
[ RUN      ] TestValueAccessor.testTreeRecursive2
[       OK ] TestValueAccessor.testTreeRecursive2 (0 ms)
[ RUN      ] TestValueAccessor.testTreeRecursive4
[       OK ] TestValueAccessor.testTreeRecursive4 (0 ms)
[ RUN      ] TestValueAccessor.testTreeRecursive5
[       OK ] TestValueAccessor.testTreeRecursive5 (0 ms)
[ RUN      ] TestValueAccessor.testTreeRecursive6
[       OK ] TestValueAccessor.testTreeRecursive6 (1 ms)
[ RUN      ] TestValueAccessor.testTreeRecursive7
[       OK ] TestValueAccessor.testTreeRecursive7 (0 ms)
[ RUN      ] TestValueAccessor.testTreeRecursive8
[       OK ] TestValueAccessor.testTreeRecursive8 (0 ms)
[ RUN      ] TestValueAccessor.testTree3Accessor2
[       OK ] TestValueAccessor.testTree3Accessor2 (0 ms)
[ RUN      ] TestValueAccessor.testTree3ConstAccessor2
[       OK ] TestValueAccessor.testTree3ConstAccessor2 (0 ms)
[ RUN      ] TestValueAccessor.testTree4Accessor2
[       OK ] TestValueAccessor.testTree4Accessor2 (1 ms)
[ RUN      ] TestValueAccessor.testTree4ConstAccessor2
[       OK ] TestValueAccessor.testTree4ConstAccessor2 (0 ms)
[ RUN      ] TestValueAccessor.testTree5Accessor2
[       OK ] TestValueAccessor.testTree5Accessor2 (0 ms)
[ RUN      ] TestValueAccessor.testTree5ConstAccessor2
[       OK ] TestValueAccessor.testTree5ConstAccessor2 (0 ms)
[ RUN      ] TestValueAccessor.testTree4Accessor1
[       OK ] TestValueAccessor.testTree4Accessor1 (1 ms)
[ RUN      ] TestValueAccessor.testTree4ConstAccessor1
[       OK ] TestValueAccessor.testTree4ConstAccessor1 (0 ms)
[ RUN      ] TestValueAccessor.testTree4Accessor0
[       OK ] TestValueAccessor.testTree4Accessor0 (1 ms)
[ RUN      ] TestValueAccessor.testTree4ConstAccessor0
[       OK ] TestValueAccessor.testTree4ConstAccessor0 (0 ms)
[ RUN      ] TestValueAccessor.testTree4Accessor12
[       OK ] TestValueAccessor.testTree4Accessor12 (0 ms)
[ RUN      ] TestValueAccessor.testTree5Accessor213
[       OK ] TestValueAccessor.testTree5Accessor213 (1 ms)
[ RUN      ] TestValueAccessor.testMultiThreadedRWAccessors
[       OK ] TestValueAccessor.testMultiThreadedRWAccessors (54 ms)
[ RUN      ] TestValueAccessor.testAccessorRegistration
[       OK ] TestValueAccessor.testAccessorRegistration (0 ms)
[ RUN      ] TestValueAccessor.testGetNode
[       OK ] TestValueAccessor.testGetNode (0 ms)
[ RUN      ] TestValueAccessor.testBypassLeafAPI
[       OK ] TestValueAccessor.testBypassLeafAPI (0 ms)
[----------] 38 tests from TestValueAccessor (62 ms total)
[----------] 3 tests from TestVec2Metadata
[ RUN      ] TestVec2Metadata.testVec2i
[       OK ] TestVec2Metadata.testVec2i (0 ms)
[ RUN      ] TestVec2Metadata.testVec2s
[       OK ] TestVec2Metadata.testVec2s (0 ms)
[ RUN      ] TestVec2Metadata.testVec2d
[       OK ] TestVec2Metadata.testVec2d (0 ms)
[----------] 3 tests from TestVec2Metadata (0 ms total)
[----------] 3 tests from TestVec3Metadata
[ RUN      ] TestVec3Metadata.testVec3i
[       OK ] TestVec3Metadata.testVec3i (0 ms)
[ RUN      ] TestVec3Metadata.testVec3s
[       OK ] TestVec3Metadata.testVec3s (0 ms)
[ RUN      ] TestVec3Metadata.testVec3d
[       OK ] TestVec3Metadata.testVec3d (0 ms)
[----------] 3 tests from TestVec3Metadata (0 ms total)
[----------] 1 test from TestVolumeRayIntersector
[ RUN      ] TestVolumeRayIntersector.testAll
[       OK ] TestVolumeRayIntersector.testAll (5 ms)
[----------] 1 test from TestVolumeRayIntersector (5 ms total)
[----------] 2 tests from TestVolumeToMesh
[ RUN      ] TestVolumeToMesh.testAuxiliaryDataCollection
[       OK ] TestVolumeToMesh.testAuxiliaryDataCollection (1 ms)
[ RUN      ] TestVolumeToMesh.testUniformMeshing
[       OK ] TestVolumeToMesh.testUniformMeshing (2 ms)
[----------] 2 tests from TestVolumeToMesh (3 ms total)
[----------] 4 tests from TestVolumeToSpheres
[ RUN      ] TestVolumeToSpheres.testFromLevelSet
[       OK ] TestVolumeToSpheres.testFromLevelSet (27 ms)
[ RUN      ] TestVolumeToSpheres.testFromFog
[       OK ] TestVolumeToSpheres.testFromFog (20 ms)
[ RUN      ] TestVolumeToSpheres.testMinimumSphereCount
[       OK ] TestVolumeToSpheres.testMinimumSphereCount (38 ms)
[ RUN      ] TestVolumeToSpheres.testClosestSurfacePoint
[       OK ] TestVolumeToSpheres.testClosestSurfacePoint (13 ms)
[----------] 4 tests from TestVolumeToSpheres (98 ms total)
[----------] Global test environment tear-down
[==========] 682 tests from 108 test suites ran. (60129 ms total)
[  PASSED  ] 673 tests.
[  FAILED  ] 9 tests, listed below:
[  FAILED  ] TestMaps.testFrustum
[  FAILED  ] TestMerge.testSum
[  FAILED  ] TestPointRasterizeFrustum.testScaleByVoxelVolume
[  FAILED  ] TestPointRasterizeFrustum.testPointRasterization
[  FAILED  ] TestTools.testLevelSetAdvect
[  FAILED  ] TestTree.testChangeBackground
[  FAILED  ] TestTree.testResize
[  FAILED  ] TestTree.testIterators
[  FAILED  ] TestTree.testIO
 9 FAILED TESTS
```

