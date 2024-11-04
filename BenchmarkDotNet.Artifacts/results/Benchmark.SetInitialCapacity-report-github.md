```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-NVFKNO : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=25  

```
| Method                 | Length | Mean     | Error    | StdDev   | Ratio    | RatioSD | Gen0    | Gen1    | Gen2    | Allocated | Alloc Ratio |
|----------------------- |------- |---------:|---------:|---------:|---------:|--------:|--------:|--------:|--------:|----------:|------------:|
| DefaultInitialCapacity | 100000 | 573.0 μs | 17.31 μs | 23.11 μs | baseline |         | 86.9141 | 25.3906 | 25.3906 | 1024.5 KB |             |
| GivenInitialCapacity   | 100000 | 368.3 μs |  4.96 μs |  6.62 μs |     -36% |    4.4% | 12.2070 | 12.2070 | 12.2070 | 390.77 KB |        -62% |
