````
Hello, World!
// Validating benchmarks:
// ***** BenchmarkRunner: Start   *****
// ***** Found 2 benchmark(s) in total *****
// ***** Building 1 exe(s) in Parallel: Start   *****
// start dotnet  restore /p:UseSharedCompilation=false /p:BuildInParallel=false /m:1 /p:Deterministic=true /p:Optimize=true /p:ArtifactsPath="C:\Users\s_irv\source\repos\JsonBenchmark\JsonBenchmark\JsonBenchmark\bin\Release\net9.0\JsonBenchmark-DefaultJob-1/" /p:OutDir="C:\Users\s_irv\source\repos\JsonBenchmark\JsonBenchmark\JsonBenchmark\bin\Release\net9.0\JsonBenchmark-DefaultJob-1\bin\Release\net9.0/" /p:OutputPath="C:\Users\s_irv\source\repos\JsonBenchmark\JsonBenchmark\JsonBenchmark\bin\Release\net9.0\JsonBenchmark-DefaultJob-1\bin\Release\net9.0/" /p:PublishDir="C:\Users\s_irv\source\repos\JsonBenchmark\JsonBenchmark\JsonBenchmark\bin\Release\net9.0\JsonBenchmark-DefaultJob-1\publish/" in C:\Users\s_irv\source\repos\JsonBenchmark\JsonBenchmark\JsonBenchmark\bin\Release\net9.0\JsonBenchmark-DefaultJob-1
// command took 0.74 sec and exited with 0
// start dotnet  build -c Release --no-restore /p:UseSharedCompilation=false /p:BuildInParallel=false /m:1 /p:Deterministic=true /p:Optimize=true /p:ArtifactsPath="C:\Users\s_irv\source\repos\JsonBenchmark\JsonBenchmark\JsonBenchmark\bin\Release\net9.0\JsonBenchmark-DefaultJob-1/" /p:OutDir="C:\Users\s_irv\source\repos\JsonBenchmark\JsonBenchmark\JsonBenchmark\bin\Release\net9.0\JsonBenchmark-DefaultJob-1\bin\Release\net9.0/" /p:OutputPath="C:\Users\s_irv\source\repos\JsonBenchmark\JsonBenchmark\JsonBenchmark\bin\Release\net9.0\JsonBenchmark-DefaultJob-1\bin\Release\net9.0/" /p:PublishDir="C:\Users\s_irv\source\repos\JsonBenchmark\JsonBenchmark\JsonBenchmark\bin\Release\net9.0\JsonBenchmark-DefaultJob-1\publish/" --output "C:\Users\s_irv\source\repos\JsonBenchmark\JsonBenchmark\JsonBenchmark\bin\Release\net9.0\JsonBenchmark-DefaultJob-1\bin\Release\net9.0/" in C:\Users\s_irv\source\repos\JsonBenchmark\JsonBenchmark\JsonBenchmark\bin\Release\net9.0\JsonBenchmark-DefaultJob-1
// command took 3.11 sec and exited with 0
// ***** Done, took 00:00:03 (3.89 sec)   *****
// Found 2 benchmarks:
//   JsonBenchmarker.NewtonsoftJson: DefaultJob
//   JsonBenchmarker.SystemTextJson: DefaultJob

Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************
// Benchmark: JsonBenchmarker.NewtonsoftJson: DefaultJob
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet JsonBenchmark-DefaultJob-1.dll --anonymousPipes 1400 1368 --benchmarkName JsonBenchmark.JsonBenchmarker.NewtonsoftJson --job Default --benchmarkId 0 in C:\Users\s_irv\source\repos\JsonBenchmark\JsonBenchmark\JsonBenchmark\bin\Release\net9.0\JsonBenchmark-DefaultJob-1\bin\Release\net9.0
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
// GC=Concurrent Workstation
// HardwareIntrinsics=AdvSIMD,AES,CRC32,DP,SHA1,SHA256 VectorSize=128
// Job: DefaultJob

OverheadJitting  1: 1 op, 78400.00 ns, 78.4000 us/op
WorkloadJitting  1: 1 op, 29722800.00 ns, 29.7228 ms/op

OverheadJitting  2: 16 op, 111600.00 ns, 6.9750 us/op
WorkloadJitting  2: 16 op, 608500.00 ns, 38.0313 us/op

WorkloadPilot    1: 16 op, 516300.00 ns, 32.2688 us/op
WorkloadPilot    2: 32 op, 934000.00 ns, 29.1875 us/op
WorkloadPilot    3: 64 op, 2027700.00 ns, 31.6828 us/op
WorkloadPilot    4: 128 op, 3431700.00 ns, 26.8102 us/op
WorkloadPilot    5: 256 op, 6965900.00 ns, 27.2105 us/op
WorkloadPilot    6: 512 op, 13153200.00 ns, 25.6898 us/op
WorkloadPilot    7: 1024 op, 25090300.00 ns, 24.5022 us/op
WorkloadPilot    8: 2048 op, 47329300.00 ns, 23.1100 us/op
WorkloadPilot    9: 4096 op, 149242900.00 ns, 36.4363 us/op
WorkloadPilot   10: 8192 op, 217046900.00 ns, 26.4950 us/op
WorkloadPilot   11: 16384 op, 87226500.00 ns, 5.3239 us/op
WorkloadPilot   12: 32768 op, 142484100.00 ns, 4.3483 us/op
WorkloadPilot   13: 65536 op, 280728200.00 ns, 4.2836 us/op
WorkloadPilot   14: 131072 op, 561377500.00 ns, 4.2830 us/op

OverheadWarmup   1: 131072 op, 230100.00 ns, 1.7555 ns/op
OverheadWarmup   2: 131072 op, 229100.00 ns, 1.7479 ns/op
OverheadWarmup   3: 131072 op, 284300.00 ns, 2.1690 ns/op
OverheadWarmup   4: 131072 op, 243600.00 ns, 1.8585 ns/op
OverheadWarmup   5: 131072 op, 228900.00 ns, 1.7464 ns/op
OverheadWarmup   6: 131072 op, 229000.00 ns, 1.7471 ns/op
OverheadWarmup   7: 131072 op, 228800.00 ns, 1.7456 ns/op

OverheadActual   1: 131072 op, 229100.00 ns, 1.7479 ns/op
OverheadActual   2: 131072 op, 229000.00 ns, 1.7471 ns/op
OverheadActual   3: 131072 op, 229000.00 ns, 1.7471 ns/op
OverheadActual   4: 131072 op, 228900.00 ns, 1.7464 ns/op
OverheadActual   5: 131072 op, 228900.00 ns, 1.7464 ns/op
OverheadActual   6: 131072 op, 229000.00 ns, 1.7471 ns/op
OverheadActual   7: 131072 op, 229000.00 ns, 1.7471 ns/op
OverheadActual   8: 131072 op, 302800.00 ns, 2.3102 ns/op
OverheadActual   9: 131072 op, 229000.00 ns, 1.7471 ns/op
OverheadActual  10: 131072 op, 228800.00 ns, 1.7456 ns/op
OverheadActual  11: 131072 op, 229000.00 ns, 1.7471 ns/op
OverheadActual  12: 131072 op, 228900.00 ns, 1.7464 ns/op
OverheadActual  13: 131072 op, 229200.00 ns, 1.7487 ns/op
OverheadActual  14: 131072 op, 229000.00 ns, 1.7471 ns/op
OverheadActual  15: 131072 op, 228800.00 ns, 1.7456 ns/op

OverheadWarmup   1: 131072 op, 228900.00 ns, 1.7464 ns/op
OverheadWarmup   2: 131072 op, 228900.00 ns, 1.7464 ns/op
OverheadWarmup   3: 131072 op, 229000.00 ns, 1.7471 ns/op
OverheadWarmup   4: 131072 op, 229000.00 ns, 1.7471 ns/op
OverheadWarmup   5: 131072 op, 229100.00 ns, 1.7479 ns/op
OverheadWarmup   6: 131072 op, 228900.00 ns, 1.7464 ns/op

// BeforeActualRun
WorkloadActual   1: 131072 op, 576102200.00 ns, 4.3953 us/op
WorkloadActual   2: 131072 op, 568300900.00 ns, 4.3358 us/op
WorkloadActual   3: 131072 op, 561283400.00 ns, 4.2823 us/op
WorkloadActual   4: 131072 op, 563008800.00 ns, 4.2954 us/op
WorkloadActual   5: 131072 op, 562297200.00 ns, 4.2900 us/op
WorkloadActual   6: 131072 op, 561297300.00 ns, 4.2824 us/op
WorkloadActual   7: 131072 op, 557339400.00 ns, 4.2522 us/op
WorkloadActual   8: 131072 op, 558546900.00 ns, 4.2614 us/op
WorkloadActual   9: 131072 op, 574899200.00 ns, 4.3861 us/op
WorkloadActual  10: 131072 op, 564051400.00 ns, 4.3034 us/op
WorkloadActual  11: 131072 op, 557359800.00 ns, 4.2523 us/op
WorkloadActual  12: 131072 op, 594363400.00 ns, 4.5346 us/op
WorkloadActual  13: 131072 op, 611544700.00 ns, 4.6657 us/op
WorkloadActual  14: 131072 op, 589605000.00 ns, 4.4983 us/op
WorkloadActual  15: 131072 op, 592927300.00 ns, 4.5237 us/op
WorkloadActual  16: 131072 op, 589123700.00 ns, 4.4947 us/op
WorkloadActual  17: 131072 op, 612313200.00 ns, 4.6716 us/op
WorkloadActual  18: 131072 op, 594552700.00 ns, 4.5361 us/op
WorkloadActual  19: 131072 op, 590640600.00 ns, 4.5062 us/op
WorkloadActual  20: 131072 op, 584528200.00 ns, 4.4596 us/op
WorkloadActual  21: 131072 op, 603408500.00 ns, 4.6036 us/op
WorkloadActual  22: 131072 op, 582239600.00 ns, 4.4421 us/op
WorkloadActual  23: 131072 op, 589165500.00 ns, 4.4950 us/op
WorkloadActual  24: 131072 op, 581719200.00 ns, 4.4382 us/op
WorkloadActual  25: 131072 op, 592830800.00 ns, 4.5229 us/op
WorkloadActual  26: 131072 op, 593684900.00 ns, 4.5295 us/op
WorkloadActual  27: 131072 op, 593148800.00 ns, 4.5254 us/op
WorkloadActual  28: 131072 op, 586060100.00 ns, 4.4713 us/op

// AfterActualRun
WorkloadResult   1: 131072 op, 575873200.00 ns, 4.3936 us/op
WorkloadResult   2: 131072 op, 568071900.00 ns, 4.3340 us/op
WorkloadResult   3: 131072 op, 561054400.00 ns, 4.2805 us/op
WorkloadResult   4: 131072 op, 562779800.00 ns, 4.2937 us/op
WorkloadResult   5: 131072 op, 562068200.00 ns, 4.2882 us/op
WorkloadResult   6: 131072 op, 561068300.00 ns, 4.2806 us/op
WorkloadResult   7: 131072 op, 557110400.00 ns, 4.2504 us/op
WorkloadResult   8: 131072 op, 558317900.00 ns, 4.2596 us/op
WorkloadResult   9: 131072 op, 574670200.00 ns, 4.3844 us/op
WorkloadResult  10: 131072 op, 563822400.00 ns, 4.3016 us/op
WorkloadResult  11: 131072 op, 557130800.00 ns, 4.2506 us/op
WorkloadResult  12: 131072 op, 594134400.00 ns, 4.5329 us/op
WorkloadResult  13: 131072 op, 611315700.00 ns, 4.6640 us/op
WorkloadResult  14: 131072 op, 589376000.00 ns, 4.4966 us/op
WorkloadResult  15: 131072 op, 592698300.00 ns, 4.5219 us/op
WorkloadResult  16: 131072 op, 588894700.00 ns, 4.4929 us/op
WorkloadResult  17: 131072 op, 612084200.00 ns, 4.6698 us/op
WorkloadResult  18: 131072 op, 594323700.00 ns, 4.5343 us/op
WorkloadResult  19: 131072 op, 590411600.00 ns, 4.5045 us/op
WorkloadResult  20: 131072 op, 584299200.00 ns, 4.4578 us/op
WorkloadResult  21: 131072 op, 603179500.00 ns, 4.6019 us/op
WorkloadResult  22: 131072 op, 582010600.00 ns, 4.4404 us/op
WorkloadResult  23: 131072 op, 588936500.00 ns, 4.4932 us/op
WorkloadResult  24: 131072 op, 581490200.00 ns, 4.4364 us/op
WorkloadResult  25: 131072 op, 592601800.00 ns, 4.5212 us/op
WorkloadResult  26: 131072 op, 593455900.00 ns, 4.5277 us/op
WorkloadResult  27: 131072 op, 592919800.00 ns, 4.5236 us/op
WorkloadResult  28: 131072 op, 585831100.00 ns, 4.4695 us/op
// GC:  238 0 0 996147200 131072
// Threading:  0 0 131072

// AfterAll
// Benchmark Process 27900 has exited with code 0.

Mean = 4.436 us, StdErr = 0.024 us (0.53%), N = 28, StdDev = 0.125 us
Min = 4.250 us, Q1 = 4.300 us, Median = 4.464 us, Q3 = 4.522 us, Max = 4.670 us
IQR = 0.223 us, LowerFence = 3.966 us, UpperFence = 4.856 us
ConfidenceInterval = [4.349 us; 4.523 us] (CI 99.9%), Margin = 0.087 us (1.97% of Mean)
Skewness = -0.01, Kurtosis = 1.85, MValue = 2

// ** Remained 1 (50.0%) benchmark(s) to run. Estimated finish 2025-08-15 16:38 (0h 0m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************
// Benchmark: JsonBenchmarker.SystemTextJson: DefaultJob
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet JsonBenchmark-DefaultJob-1.dll --anonymousPipes 1376 1420 --benchmarkName JsonBenchmark.JsonBenchmarker.SystemTextJson --job Default --benchmarkId 1 in C:\Users\s_irv\source\repos\JsonBenchmark\JsonBenchmark\JsonBenchmark\bin\Release\net9.0\JsonBenchmark-DefaultJob-1\bin\Release\net9.0
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
// GC=Concurrent Workstation
// HardwareIntrinsics=AdvSIMD,AES,CRC32,DP,SHA1,SHA256 VectorSize=128
// Job: DefaultJob

OverheadJitting  1: 1 op, 73700.00 ns, 73.7000 us/op
WorkloadJitting  1: 1 op, 14931600.00 ns, 14.9316 ms/op

OverheadJitting  2: 16 op, 114600.00 ns, 7.1625 us/op
WorkloadJitting  2: 16 op, 233100.00 ns, 14.5688 us/op

WorkloadPilot    1: 16 op, 140900.00 ns, 8.8063 us/op
WorkloadPilot    2: 32 op, 270100.00 ns, 8.4406 us/op
WorkloadPilot    3: 64 op, 533600.00 ns, 8.3375 us/op
WorkloadPilot    4: 128 op, 1085700.00 ns, 8.4820 us/op
WorkloadPilot    5: 256 op, 2201200.00 ns, 8.5984 us/op
WorkloadPilot    6: 512 op, 4171700.00 ns, 8.1479 us/op
WorkloadPilot    7: 1024 op, 8532200.00 ns, 8.3322 us/op
WorkloadPilot    8: 2048 op, 17533200.00 ns, 8.5611 us/op
WorkloadPilot    9: 4096 op, 37363200.00 ns, 9.1219 us/op
WorkloadPilot   10: 8192 op, 72264500.00 ns, 8.8214 us/op
WorkloadPilot   11: 16384 op, 136276600.00 ns, 8.3177 us/op
WorkloadPilot   12: 32768 op, 152073300.00 ns, 4.6409 us/op
WorkloadPilot   13: 65536 op, 109948000.00 ns, 1.6777 us/op
WorkloadPilot   14: 131072 op, 218375300.00 ns, 1.6661 us/op
WorkloadPilot   15: 262144 op, 433616500.00 ns, 1.6541 us/op
WorkloadPilot   16: 524288 op, 936371500.00 ns, 1.7860 us/op

OverheadWarmup   1: 524288 op, 1076300.00 ns, 2.0529 ns/op
OverheadWarmup   2: 524288 op, 1074700.00 ns, 2.0498 ns/op
OverheadWarmup   3: 524288 op, 1118400.00 ns, 2.1332 ns/op
OverheadWarmup   4: 524288 op, 1238500.00 ns, 2.3623 ns/op
OverheadWarmup   5: 524288 op, 1082600.00 ns, 2.0649 ns/op
OverheadWarmup   6: 524288 op, 1074700.00 ns, 2.0498 ns/op
OverheadWarmup   7: 524288 op, 1074500.00 ns, 2.0494 ns/op
OverheadWarmup   8: 524288 op, 1074300.00 ns, 2.0491 ns/op
OverheadWarmup   9: 524288 op, 1074800.00 ns, 2.0500 ns/op
OverheadWarmup  10: 524288 op, 1074400.00 ns, 2.0493 ns/op

OverheadActual   1: 524288 op, 1093700.00 ns, 2.0861 ns/op
OverheadActual   2: 524288 op, 1074700.00 ns, 2.0498 ns/op
OverheadActual   3: 524288 op, 1074700.00 ns, 2.0498 ns/op
OverheadActual   4: 524288 op, 1074300.00 ns, 2.0491 ns/op
OverheadActual   5: 524288 op, 1074400.00 ns, 2.0493 ns/op
OverheadActual   6: 524288 op, 1074400.00 ns, 2.0493 ns/op
OverheadActual   7: 524288 op, 1074400.00 ns, 2.0493 ns/op
OverheadActual   8: 524288 op, 1091800.00 ns, 2.0824 ns/op
OverheadActual   9: 524288 op, 1074500.00 ns, 2.0494 ns/op
OverheadActual  10: 524288 op, 1074600.00 ns, 2.0496 ns/op
OverheadActual  11: 524288 op, 1074400.00 ns, 2.0493 ns/op
OverheadActual  12: 524288 op, 1074400.00 ns, 2.0493 ns/op
OverheadActual  13: 524288 op, 1074300.00 ns, 2.0491 ns/op
OverheadActual  14: 524288 op, 1074400.00 ns, 2.0493 ns/op
OverheadActual  15: 524288 op, 1080800.00 ns, 2.0615 ns/op

OverheadWarmup   1: 524288 op, 1074400.00 ns, 2.0493 ns/op
OverheadWarmup   2: 524288 op, 1074400.00 ns, 2.0493 ns/op
OverheadWarmup   3: 524288 op, 1204400.00 ns, 2.2972 ns/op
OverheadWarmup   4: 524288 op, 1074400.00 ns, 2.0493 ns/op
OverheadWarmup   5: 524288 op, 1074500.00 ns, 2.0494 ns/op
OverheadWarmup   6: 524288 op, 1074500.00 ns, 2.0494 ns/op

// BeforeActualRun
WorkloadActual   1: 524288 op, 877872500.00 ns, 1.6744 us/op
WorkloadActual   2: 524288 op, 863085000.00 ns, 1.6462 us/op
WorkloadActual   3: 524288 op, 856037700.00 ns, 1.6328 us/op
WorkloadActual   4: 524288 op, 863354000.00 ns, 1.6467 us/op
WorkloadActual   5: 524288 op, 857359700.00 ns, 1.6353 us/op
WorkloadActual   6: 524288 op, 854731700.00 ns, 1.6303 us/op
WorkloadActual   7: 524288 op, 860289900.00 ns, 1.6409 us/op
WorkloadActual   8: 524288 op, 878672400.00 ns, 1.6759 us/op
WorkloadActual   9: 524288 op, 876272400.00 ns, 1.6714 us/op
WorkloadActual  10: 524288 op, 884680300.00 ns, 1.6874 us/op
WorkloadActual  11: 524288 op, 876648800.00 ns, 1.6721 us/op
WorkloadActual  12: 524288 op, 906103700.00 ns, 1.7283 us/op
WorkloadActual  13: 524288 op, 891129500.00 ns, 1.6997 us/op
WorkloadActual  14: 524288 op, 886511300.00 ns, 1.6909 us/op
WorkloadActual  15: 524288 op, 874310000.00 ns, 1.6676 us/op

// AfterActualRun
WorkloadResult   1: 524288 op, 876798100.00 ns, 1.6724 us/op
WorkloadResult   2: 524288 op, 862010600.00 ns, 1.6442 us/op
WorkloadResult   3: 524288 op, 854963300.00 ns, 1.6307 us/op
WorkloadResult   4: 524288 op, 862279600.00 ns, 1.6447 us/op
WorkloadResult   5: 524288 op, 856285300.00 ns, 1.6332 us/op
WorkloadResult   6: 524288 op, 853657300.00 ns, 1.6282 us/op
WorkloadResult   7: 524288 op, 859215500.00 ns, 1.6388 us/op
WorkloadResult   8: 524288 op, 877598000.00 ns, 1.6739 us/op
WorkloadResult   9: 524288 op, 875198000.00 ns, 1.6693 us/op
WorkloadResult  10: 524288 op, 883605900.00 ns, 1.6853 us/op
WorkloadResult  11: 524288 op, 875574400.00 ns, 1.6700 us/op
WorkloadResult  12: 524288 op, 905029300.00 ns, 1.7262 us/op
WorkloadResult  13: 524288 op, 890055100.00 ns, 1.6976 us/op
WorkloadResult  14: 524288 op, 885436900.00 ns, 1.6888 us/op
WorkloadResult  15: 524288 op, 873235600.00 ns, 1.6656 us/op
// GC:  200 0 0 838860800 524288
// Threading:  0 0 524288

// AfterAll
// Benchmark Process 16368 has exited with code 0.

Mean = 1.665 us, StdErr = 0.007 us (0.44%), N = 15, StdDev = 0.028 us
Min = 1.628 us, Q1 = 1.641 us, Median = 1.669 us, Q3 = 1.680 us, Max = 1.726 us
IQR = 0.038 us, LowerFence = 1.584 us, UpperFence = 1.737 us
ConfidenceInterval = [1.635 us; 1.695 us] (CI 99.9%), Margin = 0.030 us (1.80% of Mean)
Skewness = 0.43, Kurtosis = 2.25, MValue = 2

// ** Remained 0 (0.0%) benchmark(s) to run. Estimated finish 2025-08-15 16:38 (0h 0m from now) **
Successfully reverted power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// ***** BenchmarkRunner: Finish  *****

// * Export *
  BenchmarkDotNet.Artifacts\results\JsonBenchmark.JsonBenchmarker-report.csv
  BenchmarkDotNet.Artifacts\results\JsonBenchmark.JsonBenchmarker-report-github.md
  BenchmarkDotNet.Artifacts\results\JsonBenchmark.JsonBenchmarker-report.html

// * Detailed results *
JsonBenchmarker.NewtonsoftJson: DefaultJob
Runtime = .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD; GC = Concurrent Workstation
Mean = 4.436 us, StdErr = 0.024 us (0.53%), N = 28, StdDev = 0.125 us
Min = 4.250 us, Q1 = 4.300 us, Median = 4.464 us, Q3 = 4.522 us, Max = 4.670 us
IQR = 0.223 us, LowerFence = 3.966 us, UpperFence = 4.856 us
ConfidenceInterval = [4.349 us; 4.523 us] (CI 99.9%), Margin = 0.087 us (1.97% of Mean)
Skewness = -0.01, Kurtosis = 1.85, MValue = 2
-------------------- Histogram --------------------
[4.238 us ; 4.346 us) | @@@@@@@@@
[4.346 us ; 4.540 us) | @@@@@@@@@@@@@@@@
[4.540 us ; 4.690 us) | @@@
---------------------------------------------------

JsonBenchmarker.SystemTextJson: DefaultJob
Runtime = .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD; GC = Concurrent Workstation
Mean = 1.665 us, StdErr = 0.007 us (0.44%), N = 15, StdDev = 0.028 us
Min = 1.628 us, Q1 = 1.641 us, Median = 1.669 us, Q3 = 1.680 us, Max = 1.726 us
IQR = 0.038 us, LowerFence = 1.584 us, UpperFence = 1.737 us
ConfidenceInterval = [1.635 us; 1.695 us] (CI 99.9%), Margin = 0.030 us (1.80% of Mean)
Skewness = 0.43, Kurtosis = 2.25, MValue = 2
-------------------- Histogram --------------------
[1.620 us ; 1.660 us) | @@@@@@
[1.660 us ; 1.729 us) | @@@@@@@@@
---------------------------------------------------

// * Summary *

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4946/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.304
  [Host]     : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD


| Method         | Mean     | Error     | StdDev    | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|--------------- |---------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| NewtonsoftJson | 4.436 us | 0.0873 us | 0.1253 us |  1.00 |    0.04 | 1.8158 |   7.42 KB |        1.00 |
| SystemTextJson | 1.665 us | 0.0300 us | 0.0281 us |  0.38 |    0.01 | 0.3815 |   1.56 KB |        0.21 |

// * Legends *
  Mean        : Arithmetic mean of all measurements
  Error       : Half of 99.9% confidence interval
  StdDev      : Standard deviation of all measurements
  Ratio       : Mean of the ratio distribution ([Current]/[Baseline])
  RatioSD     : Standard deviation of the ratio distribution ([Current]/[Baseline])
  Gen0        : GC Generation 0 collects per 1000 operations
  Allocated   : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  Alloc Ratio : Allocated memory ratio distribution ([Current]/[Baseline])
  1 us        : 1 Microsecond (0.000001 sec)

// * Diagnostic Output - MemoryDiagnoser *


// ***** BenchmarkRunner: End *****
Run time: 00:00:35 (35.19 sec), executed benchmarks: 2

Global total time: 00:00:39 (39.2 sec), executed benchmarks: 2
// * Artifacts cleanup *
Artifacts cleanup is finished

````
C:\Users\s_irv\source\repos\JsonBenchmark\JsonBenchmark\JsonBenchmark\bin\Release\net9.0\JsonBenchmark.exe (process 2716) exited with code 0 (0x0).
Press any key to close this window . . .
