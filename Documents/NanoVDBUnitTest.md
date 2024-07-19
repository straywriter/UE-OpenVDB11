Test Environment:

```
UE5.4
Using Visual Studio 2022 14.38.33134 toolchain (C:\Program Files\Microsoft Visual Studio\2022\Professional\VC\Tools\MSVC\14.38.33130) and Windows 10.0.19041.0 SDK (C:\Program Files (x86)\Windows Kits\10).
```



Result:

```
D:\UnrealEngine\UE_5.3\Engine\Binaries\Win64\UnrealEditor.exe K:\Project\PluginDev\PluginDev.uproject -skipcompile
LogLiveCodingServer: Display: Registered process D:\UnrealEngine\UE_5.3\Engine\Binaries\Win64\UnrealEditor.exe (PID: 102764)
LogLiveCodingServer: Display: Loading module K:\Project\PluginDev\Binaries\Win64\UnrealEditor-PluginDev.dll (6.302 MB)
LogLiveCodingServer: Display: Loading module K:\Project\PluginDev\Plugins\GTEMathematics\Binaries\Win64\UnrealEditor-GTEMathematics.dll (0.049 MB)
LogLiveCodingServer: Display: Loading module K:\Project\PluginDev\Plugins\OpenVDB11\Binaries\Win64\UnrealEditor-OpenVDB11UnitTest.dll (58.601 MB)
LogLiveCodingServer: Display: Loading module K:\Project\PluginDev\Plugins\OpenVDB11\Binaries\Win64\UnrealEditor-NanoVDB32UnitTest.dll (14.458 MB)
LogLiveCodingServer: Display: Loaded 4 module(s), 676 lazy load module(s), and 449 reserved page ranges (0.000s, 416 translation units)
LogLiveCodingServer: Display: Live coding ready - Save changes and press Ctrl+Alt+F11 to re-compile code
[==========] Running 157 tests from 24 test suites.
[----------] Global test environment set-up.
[----------] 105 tests from TestNanoVDB
[ RUN      ] TestNanoVDB.Version
[       OK ] TestNanoVDB.Version (0 ms)
[ RUN      ] TestNanoVDB.Basic
[       OK ] TestNanoVDB.Basic (0 ms)
[ RUN      ] TestNanoVDB.toStr
[       OK ] TestNanoVDB.toStr (0 ms)
[ RUN      ] TestNanoVDB.Assumptions
[       OK ] TestNanoVDB.Assumptions (0 ms)
[ RUN      ] TestNanoVDB.Magic
[       OK ] TestNanoVDB.Magic (0 ms)
[ RUN      ] TestNanoVDB.FindBits
[       OK ] TestNanoVDB.FindBits (0 ms)
[ RUN      ] TestNanoVDB.CRC32
[       OK ] TestNanoVDB.CRC32 (0 ms)
[ RUN      ] TestNanoVDB.Range1D
[       OK ] TestNanoVDB.Range1D (0 ms)
[ RUN      ] TestNanoVDB.Range2D
[       OK ] TestNanoVDB.Range2D (0 ms)
[ RUN      ] TestNanoVDB.Range3D
[       OK ] TestNanoVDB.Range3D (0 ms)
[ RUN      ] TestNanoVDB.invoke
[       OK ] TestNanoVDB.invoke (1 ms)
[ RUN      ] TestNanoVDB.forEach
[       OK ] TestNanoVDB.forEach (0 ms)
[ RUN      ] TestNanoVDB.reduce
[       OK ] TestNanoVDB.reduce (0 ms)
[ RUN      ] TestNanoVDB.prefixSum
[       OK ] TestNanoVDB.prefixSum (308 ms)
[ RUN      ] TestNanoVDB.DitherLUT
[       OK ] TestNanoVDB.DitherLUT (0 ms)
[ RUN      ] TestNanoVDB.Traits
[       OK ] TestNanoVDB.Traits (0 ms)
[ RUN      ] TestNanoVDB.Rgba8
[       OK ] TestNanoVDB.Rgba8 (0 ms)
[ RUN      ] TestNanoVDB.Coord
[       OK ] TestNanoVDB.Coord (0 ms)
[ RUN      ] TestNanoVDB.BBox
[       OK ] TestNanoVDB.BBox (0 ms)
[ RUN      ] TestNanoVDB.CoordBBox
[       OK ] TestNanoVDB.CoordBBox (0 ms)
[ RUN      ] TestNanoVDB.Vec3
[       OK ] TestNanoVDB.Vec3 (0 ms)
[ RUN      ] TestNanoVDB.Vec4
[       OK ] TestNanoVDB.Vec4 (0 ms)
[ RUN      ] TestNanoVDB.Map
[       OK ] TestNanoVDB.Map (0 ms)
[ RUN      ] TestNanoVDB.Extrema
[       OK ] TestNanoVDB.Extrema (0 ms)
[ RUN      ] TestNanoVDB.RayEmptyBBox
[       OK ] TestNanoVDB.RayEmptyBBox (0 ms)
[ RUN      ] TestNanoVDB.RayBasic
[       OK ] TestNanoVDB.RayBasic (0 ms)
[ RUN      ] TestNanoVDB.Ray
[       OK ] TestNanoVDB.Ray (0 ms)
[ RUN      ] TestNanoVDB.HDDA
[       OK ] TestNanoVDB.HDDA (0 ms)
[ RUN      ] TestNanoVDB.Mask
[       OK ] TestNanoVDB.Mask (0 ms)
[ RUN      ] TestNanoVDB.LeafNode
[       OK ] TestNanoVDB.LeafNode (0 ms)
[ RUN      ] TestNanoVDB.LeafNodeBool
[       OK ] TestNanoVDB.LeafNodeBool (0 ms)
[ RUN      ] TestNanoVDB.LeafNodeValueMask
[       OK ] TestNanoVDB.LeafNodeValueMask (0 ms)
[ RUN      ] TestNanoVDB.InternalNode
[       OK ] TestNanoVDB.InternalNode (0 ms)
[ RUN      ] TestNanoVDB.InternalNodeValueMask
[       OK ] TestNanoVDB.InternalNodeValueMask (0 ms)
[ RUN      ] TestNanoVDB.RootNode
[       OK ] TestNanoVDB.RootNode (0 ms)
[ RUN      ] TestNanoVDB.Offsets
[       OK ] TestNanoVDB.Offsets (0 ms)
[ RUN      ] TestNanoVDB.BasicGrid
[       OK ] TestNanoVDB.BasicGrid (0 ms)
[ RUN      ] TestNanoVDB.GridBuilderEmpty
[       OK ] TestNanoVDB.GridBuilderEmpty (0 ms)
[ RUN      ] TestNanoVDB.BuilderGridEmpty
[       OK ] TestNanoVDB.BuilderGridEmpty (0 ms)
[ RUN      ] TestNanoVDB.CreateNanoGrid_Basic1
[       OK ] TestNanoVDB.CreateNanoGrid_Basic1 (1 ms)
[ RUN      ] TestNanoVDB.CreateNanoGrid_addTile
[       OK ] TestNanoVDB.CreateNanoGrid_addTile (0 ms)
[ RUN      ] TestNanoVDB.GridBuilderValueMask
[       OK ] TestNanoVDB.GridBuilderValueMask (0 ms)
[ RUN      ] TestNanoVDB.GridBuilderBasic2
[       OK ] TestNanoVDB.GridBuilderBasic2 (1 ms)
[ RUN      ] TestNanoVDB.GridBuilderPrune
[       OK ] TestNanoVDB.GridBuilderPrune (34 ms)
[ RUN      ] TestNanoVDB.GridBuilder_Vec3f
[       OK ] TestNanoVDB.GridBuilder_Vec3f (1 ms)
[ RUN      ] TestNanoVDB.GridBuilder_Vec4f
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\nanovdb\unittest\TestNanoVDB.cc(3436): error: Expected equality of these values:
  (nanovdb::Vec4f(1.0f).lengthSqr() + nanovdb::Vec4f(2.0f).lengthSqr() + nanovdb::Vec4f(3.0f).lengthSqr())/3.0f
    Which is: 18.6667
  dstGrid->tree().root().average()
    Which is: 18.6667
[  FAILED  ] TestNanoVDB.GridBuilder_Vec4f (2 ms)
[ RUN      ] TestNanoVDB.GridBuilder_Fp4
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\nanovdb\unittest\TestNanoVDB.cc(3500): error: Expected equality of these values:
  3.0f
    Which is: 3
  dstGrid->tree().getValue(nanovdb::Coord( 50,-12, 30))
    Which is: 3
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\nanovdb\unittest\TestNanoVDB.cc(3502): error: Expected equality of these values:
  3.0f
    Which is: 3
  dstGrid->tree().root().maximum()
    Which is: 3
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\nanovdb\unittest\TestNanoVDB.cc(3528): error: Expected equality of these values:
  3.0f
    Which is: 3
  dstAcc.getValue(nanovdb::Coord( 50,-12, 30))
    Which is: 3
[  FAILED  ] TestNanoVDB.GridBuilder_Fp4 (47 ms)
[ RUN      ] TestNanoVDB.GridBuilder_Fp8
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\nanovdb\unittest\TestNanoVDB.cc(3636): error: Expected equality of these values:
  3.0f
    Which is: 3
  dstGrid->tree().root().maximum()
    Which is: 3
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\nanovdb\unittest\TestNanoVDB.cc(3663): error: Expected equality of these values:
  3.0f
    Which is: 3
  dstAcc.getValue(nanovdb::Coord( 50,-12, 30))
    Which is: 3
[  FAILED  ] TestNanoVDB.GridBuilder_Fp8 (35 ms)
[ RUN      ] TestNanoVDB.GridBuilder_Fp16
[       OK ] TestNanoVDB.GridBuilder_Fp16 (38 ms)
[ RUN      ] TestNanoVDB.GridBuilder_FpN_Basic1
[       OK ] TestNanoVDB.GridBuilder_FpN_Basic1 (0 ms)
[ RUN      ] TestNanoVDB.GridBuilder_FpN_Basic3
[       OK ] TestNanoVDB.GridBuilder_FpN_Basic3 (0 ms)
[ RUN      ] TestNanoVDB.GridBuilder_FpN_Sphere
[       OK ] TestNanoVDB.GridBuilder_FpN_Sphere (36 ms)
[ RUN      ] TestNanoVDB.NodeManager
[       OK ] TestNanoVDB.NodeManager (29 ms)
[ RUN      ] TestNanoVDB.GridBuilderBasicDense
[       OK ] TestNanoVDB.GridBuilderBasicDense (20 ms)
[ RUN      ] TestNanoVDB.GridBuilderBackground
[       OK ] TestNanoVDB.GridBuilderBackground (0 ms)
[ RUN      ] TestNanoVDB.GridBuilderSphere
[       OK ] TestNanoVDB.GridBuilderSphere (183 ms)
[ RUN      ] TestNanoVDB.createLevelSetSphere
[       OK ] TestNanoVDB.createLevelSetSphere (28 ms)
[ RUN      ] TestNanoVDB.createFogVolumeSphere
[       OK ] TestNanoVDB.createFogVolumeSphere (18 ms)
[ RUN      ] TestNanoVDB.createPointSphere
[       OK ] TestNanoVDB.createPointSphere (235 ms)
[ RUN      ] TestNanoVDB.createLevelSetTorus
[       OK ] TestNanoVDB.createLevelSetTorus (9 ms)
[ RUN      ] TestNanoVDB.createFogVolumeTorus
[       OK ] TestNanoVDB.createFogVolumeTorus (9 ms)
[ RUN      ] TestNanoVDB.createLevelSetBox
[       OK ] TestNanoVDB.createLevelSetBox (2 ms)
[ RUN      ] TestNanoVDB.createFogVolumeBox
[       OK ] TestNanoVDB.createFogVolumeBox (2 ms)
[ RUN      ] TestNanoVDB.createLevelSetOctahedron
[       OK ] TestNanoVDB.createLevelSetOctahedron (3 ms)
[ RUN      ] TestNanoVDB.GridStats
[       OK ] TestNanoVDB.GridStats (5 ms)
[ RUN      ] TestNanoVDB.ScalarSampleFromVoxels
[       OK ] TestNanoVDB.ScalarSampleFromVoxels (8 ms)
[ RUN      ] TestNanoVDB.VectorSampleFromVoxels
[       OK ] TestNanoVDB.VectorSampleFromVoxels (12 ms)
[ RUN      ] TestNanoVDB.GridChecksum
[       OK ] TestNanoVDB.GridChecksum (15 ms)
[ RUN      ] TestNanoVDB.GridValidator
[       OK ] TestNanoVDB.GridValidator (24 ms)
[ RUN      ] TestNanoVDB.RandomReadAccessor
[       OK ] TestNanoVDB.RandomReadAccessor (233 ms)
[ RUN      ] TestNanoVDB.StandardDeviation
[       OK ] TestNanoVDB.StandardDeviation (0 ms)
[ RUN      ] TestNanoVDB.BoxStencil
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\nanovdb\unittest\TestNanoVDB.cc(5711): error: The difference between b[1] and grad[1] is 3.4570693969726562e-06, which exceeds 3e-6f, where
b[1] evaluates to 0.77999997138977051,
grad[1] evaluates to 0.78000342845916748, and
3e-6f evaluates to 3.0000001061125658e-06.
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\nanovdb\unittest\TestNanoVDB.cc(5711): error: The difference between b[1] and grad[1] is 3.4570693969726562e-06, which exceeds 3e-6f, where
b[1] evaluates to 0.77999997138977051,
grad[1] evaluates to 0.78000342845916748, and
3e-6f evaluates to 3.0000001061125658e-06.
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\nanovdb\unittest\TestNanoVDB.cc(5711): error: The difference between b[1] and grad[1] is 3.4570693969726562e-06, which exceeds 3e-6f, where
b[1] evaluates to 0.77999997138977051,
grad[1] evaluates to 0.78000342845916748, and
3e-6f evaluates to 3.0000001061125658e-06.
[  FAILED  ] TestNanoVDB.BoxStencil (5 ms)
[ RUN      ] TestNanoVDB.CurvatureStencil
[       OK ] TestNanoVDB.CurvatureStencil (5 ms)
[ RUN      ] TestNanoVDB.GradStencil
[       OK ] TestNanoVDB.GradStencil (4 ms)
[ RUN      ] TestNanoVDB.WenoStencil
[       OK ] TestNanoVDB.WenoStencil (3 ms)
[ RUN      ] TestNanoVDB.StencilIntersection
[       OK ] TestNanoVDB.StencilIntersection (5 ms)
[ RUN      ] TestNanoVDB.MultiFile
[       OK ] TestNanoVDB.MultiFile (643 ms)
[ RUN      ] TestNanoVDB.HostBuffer
[       OK ] TestNanoVDB.HostBuffer (254 ms)
[ RUN      ] TestNanoVDB.NodeIterators
[       OK ] TestNanoVDB.NodeIterators (8 ms)
[ RUN      ] TestNanoVDB.BasicValueIndexStats
[       OK ] TestNanoVDB.BasicValueIndexStats (0 ms)
[ RUN      ] TestNanoVDB.BasicValueIndexStats2
[       OK ] TestNanoVDB.BasicValueIndexStats2 (0 ms)
[ RUN      ] TestNanoVDB.ValueMask2ValueIndex
[       OK ] TestNanoVDB.ValueMask2ValueIndex (1 ms)
[ RUN      ] TestNanoVDB.ValueMask2ValueOnIndex
[       OK ] TestNanoVDB.ValueMask2ValueOnIndex (0 ms)
[ RUN      ] TestNanoVDB.BasicValueIndexNoStats
[       OK ] TestNanoVDB.BasicValueIndexNoStats (0 ms)
[ RUN      ] TestNanoVDB.BasicValueIndexNoStatsNoTiles
[       OK ] TestNanoVDB.BasicValueIndexNoStatsNoTiles (0 ms)
[ RUN      ] TestNanoVDB.SparseIndexGridBuilder1
[       OK ] TestNanoVDB.SparseIndexGridBuilder1 (1 ms)
[ RUN      ] TestNanoVDB.IndexGridBuilder2
[       OK ] TestNanoVDB.IndexGridBuilder2 (953 ms)
[ RUN      ] TestNanoVDB.SparseIndexGridBuilder2
[       OK ] TestNanoVDB.SparseIndexGridBuilder2 (536 ms)
[ RUN      ] TestNanoVDB.ChannelIndexGridBuilder
[       OK ] TestNanoVDB.ChannelIndexGridBuilder (17 ms)
[ RUN      ] TestNanoVDB.HelloWorld_IndexGrid_Dense
[       OK ] TestNanoVDB.HelloWorld_IndexGrid_Dense (31 ms)
[ RUN      ] TestNanoVDB.HelloWorld_IndexGrid_Sparse
[       OK ] TestNanoVDB.HelloWorld_IndexGrid_Sparse (19 ms)
[ RUN      ] TestNanoVDB.HelloWorld_IndexGrid_Sparse2
[       OK ] TestNanoVDB.HelloWorld_IndexGrid_Sparse2 (20 ms)
[ RUN      ] TestNanoVDB.writeReadUncompressedGrid
[       OK ] TestNanoVDB.writeReadUncompressedGrid (18 ms)
[ RUN      ] TestNanoVDB.writeReadUncompressedGridRaw
[       OK ] TestNanoVDB.writeReadUncompressedGridRaw (19 ms)
[ RUN      ] TestNanoVDB.GridMetaData
[       OK ] TestNanoVDB.GridMetaData (9 ms)
[ RUN      ] TestNanoVDB.BuildTree
[       OK ] TestNanoVDB.BuildTree (1585 ms)
[ RUN      ] TestNanoVDB.CreateNanoGridFromFloat
[       OK ] TestNanoVDB.CreateNanoGridFromFloat (27 ms)
[ RUN      ] TestNanoVDB.CreateNanoGridFromVec3f
[       OK ] TestNanoVDB.CreateNanoGridFromVec3f (0 ms)
[ RUN      ] TestNanoVDB.LongGridName
[       OK ] TestNanoVDB.LongGridName (2 ms)
[ RUN      ] TestNanoVDB.mergeSplitGrids
[       OK ] TestNanoVDB.mergeSplitGrids (710 ms)
[ RUN      ] TestNanoVDB.writeReadRadGrid
[       OK ] TestNanoVDB.writeReadRadGrid (28 ms)
[ RUN      ] TestNanoVDB.GridHandleIO
[       OK ] TestNanoVDB.GridHandleIO (33 ms)
[ RUN      ] TestNanoVDB.GridCountAndIndex
[       OK ] TestNanoVDB.GridCountAndIndex (244 ms)
[ RUN      ] TestNanoVDB.CustomStreamIO
[       OK ] TestNanoVDB.CustomStreamIO (19 ms)
[ RUN      ] TestNanoVDB.CustomStreamGridHandleIO
[       OK ] TestNanoVDB.CustomStreamGridHandleIO (20 ms)
[----------] 105 tests from TestNanoVDB (6569 ms total)

[----------] 1 test from TestOffsets/0, where TypeParam = float
[ RUN      ] TestOffsets/0.NanoVDB
[       OK ] TestOffsets/0.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/0 (0 ms total)

[----------] 1 test from TestOffsets/1, where TypeParam = double
[ RUN      ] TestOffsets/1.NanoVDB
[       OK ] TestOffsets/1.NanoVDB (1 ms)
[----------] 1 test from TestOffsets/1 (1 ms total)

[----------] 1 test from TestOffsets/2, where TypeParam = class nanovdb::Fp4
[ RUN      ] TestOffsets/2.NanoVDB
[       OK ] TestOffsets/2.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/2 (0 ms total)

[----------] 1 test from TestOffsets/3, where TypeParam = class nanovdb::Fp8
[ RUN      ] TestOffsets/3.NanoVDB
[       OK ] TestOffsets/3.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/3 (0 ms total)

[----------] 1 test from TestOffsets/4, where TypeParam = class nanovdb::Fp16
[ RUN      ] TestOffsets/4.NanoVDB
[       OK ] TestOffsets/4.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/4 (0 ms total)

[----------] 1 test from TestOffsets/5, where TypeParam = class nanovdb::FpN
[ RUN      ] TestOffsets/5.NanoVDB
[       OK ] TestOffsets/5.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/5 (0 ms total)

[----------] 1 test from TestOffsets/6, where TypeParam = short
[ RUN      ] TestOffsets/6.NanoVDB
[       OK ] TestOffsets/6.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/6 (0 ms total)

[----------] 1 test from TestOffsets/7, where TypeParam = int
[ RUN      ] TestOffsets/7.NanoVDB
[       OK ] TestOffsets/7.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/7 (0 ms total)

[----------] 1 test from TestOffsets/8, where TypeParam = __int64
[ RUN      ] TestOffsets/8.NanoVDB
[       OK ] TestOffsets/8.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/8 (0 ms total)

[----------] 1 test from TestOffsets/9, where TypeParam = class nanovdb::Vec3<float>
[ RUN      ] TestOffsets/9.NanoVDB
[       OK ] TestOffsets/9.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/9 (0 ms total)

[----------] 1 test from TestOffsets/10, where TypeParam = class nanovdb::Vec3<double>
[ RUN      ] TestOffsets/10.NanoVDB
[       OK ] TestOffsets/10.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/10 (0 ms total)

[----------] 1 test from TestOffsets/11, where TypeParam = class nanovdb::ValueMask
[ RUN      ] TestOffsets/11.NanoVDB
[       OK ] TestOffsets/11.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/11 (0 ms total)

[----------] 1 test from TestOffsets/12, where TypeParam = class nanovdb::ValueIndex
[ RUN      ] TestOffsets/12.NanoVDB
[       OK ] TestOffsets/12.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/12 (0 ms total)

[----------] 1 test from TestOffsets/13, where TypeParam = class nanovdb::ValueOnIndex
[ RUN      ] TestOffsets/13.NanoVDB
[       OK ] TestOffsets/13.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/13 (0 ms total)

[----------] 1 test from TestOffsets/14, where TypeParam = class nanovdb::ValueIndexMask
[ RUN      ] TestOffsets/14.NanoVDB
[       OK ] TestOffsets/14.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/14 (0 ms total)

[----------] 1 test from TestOffsets/15, where TypeParam = class nanovdb::ValueOnIndexMask
[ RUN      ] TestOffsets/15.NanoVDB
[       OK ] TestOffsets/15.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/15 (0 ms total)

[----------] 1 test from TestOffsets/16, where TypeParam = bool
[ RUN      ] TestOffsets/16.NanoVDB
[       OK ] TestOffsets/16.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/16 (0 ms total)

[----------] 1 test from TestOffsets/17, where TypeParam = class nanovdb::Point
[ RUN      ] TestOffsets/17.NanoVDB
[       OK ] TestOffsets/17.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/17 (0 ms total)

[----------] 1 test from TestOffsets/18, where TypeParam = class nanovdb::Vec3<unsigned char>
[ RUN      ] TestOffsets/18.NanoVDB
[       OK ] TestOffsets/18.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/18 (0 ms total)

[----------] 1 test from TestOffsets/19, where TypeParam = class nanovdb::Vec3<unsigned short>
[ RUN      ] TestOffsets/19.NanoVDB
[       OK ] TestOffsets/19.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/19 (0 ms total)

[----------] 1 test from TestOffsets/20, where TypeParam = short
[ RUN      ] TestOffsets/20.NanoVDB
[       OK ] TestOffsets/20.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/20 (0 ms total)

[----------] 1 test from TestOffsets/21, where TypeParam = unsigned int
[ RUN      ] TestOffsets/21.NanoVDB
[       OK ] TestOffsets/21.NanoVDB (0 ms)
[----------] 1 test from TestOffsets/21 (0 ms total)

[----------] 30 tests from TestOpenVDB
[ RUN      ] TestOpenVDB.getExtrema
[       OK ] TestOpenVDB.getExtrema (39 ms)
[ RUN      ] TestOpenVDB.Basic
[       OK ] TestOpenVDB.Basic (0 ms)
[ RUN      ] TestOpenVDB.MapToNano
[       OK ] TestOpenVDB.MapToNano (0 ms)
[ RUN      ] TestOpenVDB.BasicGrid
[       OK ] TestOpenVDB.BasicGrid (0 ms)
[ RUN      ] TestOpenVDB.OpenToNanoVDB_Empty
[       OK ] TestOpenVDB.OpenToNanoVDB_Empty (0 ms)
[ RUN      ] TestOpenVDB.OpenToNanoVDB_Basic1
[       OK ] TestOpenVDB.OpenToNanoVDB_Basic1 (1 ms)
[ RUN      ] TestOpenVDB.OpenToNanoVDB_Model
[       OK ] TestOpenVDB.OpenToNanoVDB_Model (38 ms)
[ RUN      ] TestOpenVDB.OpenToNanoVDB_Fp4
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\nanovdb\unittest\TestOpenVDB.cc(702): error: Expected equality of these values:
  3.0f
    Which is: 3
  dstGrid->tree().root().maximum()
    Which is: 3
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\nanovdb\unittest\TestOpenVDB.cc(729): error: Expected equality of these values:
  3.0f
    Which is: 3
  dstAcc.getValue(nanovdb::Coord( 50,-12, 30))
    Which is: 3
[  FAILED  ] TestOpenVDB.OpenToNanoVDB_Fp4 (44 ms)
[ RUN      ] TestOpenVDB.OpenToNanoVDB_Fp8
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\nanovdb\unittest\TestOpenVDB.cc(795): error: Expected equality of these values:
  3.0f
    Which is: 3
  dstGrid->tree().root().maximum()
    Which is: 3
K:\Project\PluginDev\Plugins\OpenVDB11\Source\OpenVDB11\ThirdParty\src\nanovdb\unittest\TestOpenVDB.cc(812): error: Expected equality of these values:
  3.0f
    Which is: 3
  dstAcc.getValue(nanovdb::Coord( 50,-12, 30))
    Which is: 3
[  FAILED  ] TestOpenVDB.OpenToNanoVDB_Fp8 (50 ms)
[ RUN      ] TestOpenVDB.OpenToNanoVDB_Fp16
[       OK ] TestOpenVDB.OpenToNanoVDB_Fp16 (53 ms)
[ RUN      ] TestOpenVDB.OpenToNanoVDB_FpN
[       OK ] TestOpenVDB.OpenToNanoVDB_FpN (56 ms)
[ RUN      ] TestOpenVDB.PointIndexGrid
[       OK ] TestOpenVDB.PointIndexGrid (16 ms)
[ RUN      ] TestOpenVDB.PointDataGridBasic
[       OK ] TestOpenVDB.PointDataGridBasic (2 ms)
[ RUN      ] TestOpenVDB.PointDataGridRandom
[       OK ] TestOpenVDB.PointDataGridRandom (12 ms)
[ RUN      ] TestOpenVDB.NanoToOpenVDB_BuildGrid
[       OK ] TestOpenVDB.NanoToOpenVDB_BuildGrid (0 ms)
[ RUN      ] TestOpenVDB.NanoToOpenVDB
[       OK ] TestOpenVDB.NanoToOpenVDB (20 ms)
[ RUN      ] TestOpenVDB.File
[       OK ] TestOpenVDB.File (33 ms)
[ RUN      ] TestOpenVDB.MultiFile
[       OK ] TestOpenVDB.MultiFile (952 ms)
[ RUN      ] TestOpenVDB.LongGridName
[       OK ] TestOpenVDB.LongGridName (6 ms)
[ RUN      ] TestOpenVDB.LevelSetFiles
	Set the environment variable "VDB_DATA_PATH" to a directory
	containing OpenVDB level set files. They can be downloaded
	here: https://www.openvdb.org/download/
[       OK ] TestOpenVDB.LevelSetFiles (1 ms)
[ RUN      ] TestOpenVDB.FogFiles
	Set the environment variable "VDB_DATA_PATH" to a directory
	containing OpenVDB fog volume files. They can be downloaded
	here: https://www.openvdb.org/download/
[       OK ] TestOpenVDB.FogFiles (0 ms)
[ RUN      ] TestOpenVDB.PointFiles
	Set the environment variable "VDB_DATA_PATH" to a directory
	containing OpenVDB files with points. They can be downloaded
	here: https://www.openvdb.org/download/
[       OK ] TestOpenVDB.PointFiles (0 ms)
[ RUN      ] TestOpenVDB.Trilinear
[       OK ] TestOpenVDB.Trilinear (36 ms)
[ RUN      ] TestOpenVDB.Triquadratic
[       OK ] TestOpenVDB.Triquadratic (51 ms)
[ RUN      ] TestOpenVDB.Tricubic
[       OK ] TestOpenVDB.Tricubic (53 ms)
[ RUN      ] TestOpenVDB.GridValidator
[       OK ] TestOpenVDB.GridValidator (31 ms)
[ RUN      ] TestOpenVDB.BenchmarkHostBuffer
[       OK ] TestOpenVDB.BenchmarkHostBuffer (0 ms)
[ RUN      ] TestOpenVDB.DenseIndexGrid
[       OK ] TestOpenVDB.DenseIndexGrid (39 ms)
[ RUN      ] TestOpenVDB.SparseIndexGrid
[       OK ] TestOpenVDB.SparseIndexGrid (32 ms)
[ RUN      ] TestOpenVDB.BuildNodeManager
[       OK ] TestOpenVDB.BuildNodeManager (0 ms)
[----------] 30 tests from TestOpenVDB (1568 ms total)

[----------] Global test environment tear-down
[==========] 157 tests from 24 test suites ran. (8139 ms total)
[  PASSED  ] 151 tests.
[  FAILED  ] 6 tests, listed below:
[  FAILED  ] TestNanoVDB.GridBuilder_Vec4f
[  FAILED  ] TestNanoVDB.GridBuilder_Fp4
[  FAILED  ] TestNanoVDB.GridBuilder_Fp8
[  FAILED  ] TestNanoVDB.BoxStencil
[  FAILED  ] TestOpenVDB.OpenToNanoVDB_Fp4
[  FAILED  ] TestOpenVDB.OpenToNanoVDB_Fp8

 6 FAILED TESTS

```

