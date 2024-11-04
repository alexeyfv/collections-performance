```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-AGPUFB : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=25  

```
| Method                 | Length | Mean     | Error     | StdDev    | Ratio    | RatioSD | Gen0     | Gen1     | Gen2     | Allocated | Alloc Ratio |
|----------------------- |------- |---------:|----------:|----------:|---------:|--------:|---------:|---------:|---------:|----------:|------------:|
| DefaultInitialCapacity | 100000 | 5.984 ms | 0.6660 ms | 0.8891 ms | baseline |         | 242.1875 | 179.6875 | 179.6875 |      8 MB |             |
| GivenInitialCapacity   | 100000 | 3.232 ms | 0.0661 ms | 0.0882 ms |     -45% |   14.7% |  82.0313 |  82.0313 |  82.0313 |   3.05 MB |        -62% |
