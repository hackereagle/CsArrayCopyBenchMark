# C# Array Copy Methods Benchmark

Here are the results of the benchmark:

``` shell
// GC:  116 116 116 2048055152 512
// Threading:  0 0 512

// AfterAll
// Benchmark Process 9476 has exited with code 0.

Mean = 1.031 ms, StdErr = 0.004 ms (0.42%), N = 12, StdDev = 0.015 ms
Min = 0.994 ms, Q1 = 1.026 ms, Median = 1.034 ms, Q3 = 1.041 ms, Max = 1.050 ms
IQR = 0.014 ms, LowerFence = 1.005 ms, UpperFence = 1.062 ms
ConfidenceInterval = [1.012 ms; 1.050 ms] (CI 99.9%), Margin = 0.019 ms (1.85% of Mean)
Skewness = -1.09, Kurtosis = 3.57, MValue = 2

// ** Remained 0 (0.0%) benchmark(s) to run. Estimated finish 2024-08-02 17:39 (0h 0m from now) **
Successfully reverted power plan (GUID: 381b4222-f694-41f0-9685-ff5bb260df2e FriendlyName: Balanced)
// ***** BenchmarkRunner: Finish  *****

// * Export *
  BenchmarkDotNet.Artifacts\results\CsArrayCopyMethodsBenchMark.TestArrayCopyClass-report.csv
  BenchmarkDotNet.Artifacts\results\CsArrayCopyMethodsBenchMark.TestArrayCopyClass-report-github.md
  BenchmarkDotNet.Artifacts\results\CsArrayCopyMethodsBenchMark.TestArrayCopyClass-report.html

// * Detailed results *
TestArrayCopyClass.CopyArrayUsingForLoop: DefaultJob
Runtime = .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 1.400 ms, StdErr = 0.008 ms (0.56%), N = 40, StdDev = 0.049 ms
Min = 1.283 ms, Q1 = 1.369 ms, Median = 1.397 ms, Q3 = 1.427 ms, Max = 1.534 ms
IQR = 0.058 ms, LowerFence = 1.282 ms, UpperFence = 1.513 ms
ConfidenceInterval = [1.372 ms; 1.428 ms] (CI 99.9%), Margin = 0.028 ms (1.98% of Mean)
Skewness = 0.29, Kurtosis = 3.3, MValue = 2
-------------------- Histogram --------------------
[1.264 ms ; 1.318 ms) | @
[1.318 ms ; 1.358 ms) | @@@@@
[1.358 ms ; 1.419 ms) | @@@@@@@@@@@@@@@@@@@
[1.419 ms ; 1.457 ms) | @@@@@@@@@@@@
[1.457 ms ; 1.500 ms) | @
[1.500 ms ; 1.538 ms) | @@
---------------------------------------------------

TestArrayCopyClass.CopyArrayUsingArrayCopy: DefaultJob
Runtime = .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 1.117 ms, StdErr = 0.005 ms (0.46%), N = 16, StdDev = 0.020 ms
Min = 1.088 ms, Q1 = 1.102 ms, Median = 1.117 ms, Q3 = 1.128 ms, Max = 1.166 ms
IQR = 0.026 ms, LowerFence = 1.063 ms, UpperFence = 1.166 ms
ConfidenceInterval = [1.096 ms; 1.138 ms] (CI 99.9%), Margin = 0.021 ms (1.85% of Mean)
Skewness = 0.59, Kurtosis = 2.77, MValue = 2
-------------------- Histogram --------------------
[1.086 ms ; 1.110 ms) | @@@@@@
[1.110 ms ; 1.151 ms) | @@@@@@@@@
[1.151 ms ; 1.176 ms) | @
---------------------------------------------------

TestArrayCopyClass.CopyArrayUsingCopyTo: DefaultJob
Runtime = .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 1.049 ms, StdErr = 0.006 ms (0.61%), N = 82, StdDev = 0.058 ms
Min = 0.969 ms, Q1 = 1.012 ms, Median = 1.032 ms, Q3 = 1.075 ms, Max = 1.271 ms
IQR = 0.064 ms, LowerFence = 0.916 ms, UpperFence = 1.171 ms
ConfidenceInterval = [1.027 ms; 1.071 ms] (CI 99.9%), Margin = 0.022 ms (2.09% of Mean)
Skewness = 1.67, Kurtosis = 6.45, MValue = 2.21
-------------------- Histogram --------------------
[0.966 ms ; 1.000 ms) | @@@@@@@@@@@
[1.000 ms ; 1.035 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[1.035 ms ; 1.072 ms) | @@@@@@@@@@@@@@@@
[1.072 ms ; 1.109 ms) | @@@@@@@@@@@@
[1.109 ms ; 1.145 ms) | @@@@
[1.145 ms ; 1.181 ms) | @@
[1.181 ms ; 1.231 ms) | @
[1.231 ms ; 1.289 ms) | @@
---------------------------------------------------

TestArrayCopyClass.CopyArrayUsingLinq: DefaultJob
Runtime = .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 1.048 ms, StdErr = 0.004 ms (0.43%), N = 15, StdDev = 0.017 ms
Min = 1.024 ms, Q1 = 1.036 ms, Median = 1.045 ms, Q3 = 1.060 ms, Max = 1.079 ms
IQR = 0.024 ms, LowerFence = 1.000 ms, UpperFence = 1.096 ms
ConfidenceInterval = [1.029 ms; 1.066 ms] (CI 99.9%), Margin = 0.019 ms (1.77% of Mean)
Skewness = 0.25, Kurtosis = 1.71, MValue = 2
-------------------- Histogram --------------------
[1.022 ms ; 1.064 ms) | @@@@@@@@@@@@@
[1.064 ms ; 1.089 ms) | @@
---------------------------------------------------

TestArrayCopyClass.CopyArrayUsingBuffer: DefaultJob
Runtime = .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 1.031 ms, StdErr = 0.004 ms (0.42%), N = 12, StdDev = 0.015 ms
Min = 0.994 ms, Q1 = 1.026 ms, Median = 1.034 ms, Q3 = 1.041 ms, Max = 1.050 ms
IQR = 0.014 ms, LowerFence = 1.005 ms, UpperFence = 1.062 ms
ConfidenceInterval = [1.012 ms; 1.050 ms] (CI 99.9%), Margin = 0.019 ms (1.85% of Mean)
Skewness = -1.09, Kurtosis = 3.57, MValue = 2
-------------------- Histogram --------------------
[0.985 ms ; 1.009 ms) | @
[1.009 ms ; 1.059 ms) | @@@@@@@@@@@
---------------------------------------------------

// * Summary *

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
12th Gen Intel Core i5-1240P, 1 CPU, 16 logical and 12 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2


| Method                  | Mean     | Error     | StdDev    | Median   | Gen0     | Gen1     | Gen2     | Allocated |
|------------------------ |---------:|----------:|----------:|---------:|---------:|---------:|---------:|----------:|
| CopyArrayUsingForLoop   | 1.400 ms | 0.0277 ms | 0.0492 ms | 1.397 ms | 312.5000 | 312.5000 | 312.5000 |   3.81 MB |
| CopyArrayUsingArrayCopy | 1.117 ms | 0.0207 ms | 0.0203 ms | 1.117 ms | 218.7500 | 218.7500 | 218.7500 |   3.81 MB |
| CopyArrayUsingCopyTo    | 1.049 ms | 0.0219 ms | 0.0582 ms | 1.032 ms | 261.7188 | 261.7188 | 261.7188 |   3.81 MB |
| CopyArrayUsingLinq      | 1.048 ms | 0.0185 ms | 0.0173 ms | 1.045 ms | 242.1875 | 242.1875 | 242.1875 |   3.81 MB |
| CopyArrayUsingBuffer    | 1.031 ms | 0.0190 ms | 0.0149 ms | 1.034 ms | 226.5625 | 226.5625 | 226.5625 |   3.81 MB |

// * Warnings *
Environment
  Summary -> Benchmark was executed with attached debugger

// * Hints *
Outliers
  TestArrayCopyClass.CopyArrayUsingForLoop: Default   -> 6 outliers were removed (1.59 ms..1.96 ms)
  TestArrayCopyClass.CopyArrayUsingArrayCopy: Default -> 1 outlier  was  removed (1.18 ms)
  TestArrayCopyClass.CopyArrayUsingCopyTo: Default    -> 18 outliers were removed (1.30 ms..2.69 ms)
  TestArrayCopyClass.CopyArrayUsingBuffer: Default    -> 3 outliers were removed, 4 outliers were detected (993.93 us, 1.08 ms..1.20 ms)

// * Legends *
  Mean      : Arithmetic mean of all measurements
  Error     : Half of 99.9% confidence interval
  StdDev    : Standard deviation of all measurements
  Median    : Value separating the higher half of all measurements (50th percentile)
  Gen0      : GC Generation 0 collects per 1000 operations
  Gen1      : GC Generation 1 collects per 1000 operations
  Gen2      : GC Generation 2 collects per 1000 operations
  Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  1 ms      : 1 Millisecond (0.001 sec)

// * Diagnostic Output - MemoryDiagnoser *


// ***** BenchmarkRunner: End *****
Run time: 00:02:35 (155.44 sec), executed benchmarks: 5

Global total time: 00:02:55 (175.26 sec), executed benchmarks: 5
// * Artifacts cleanup *
Artifacts cleanup is finished
```