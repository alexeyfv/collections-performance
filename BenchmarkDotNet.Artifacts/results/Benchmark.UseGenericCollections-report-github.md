```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-NVFKNO : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=25  

```
| Method      | Length | Mean      | Error     | StdDev    | Ratio    | RatioSD | Allocated | Alloc Ratio |
|------------ |------- |----------:|----------:|----------:|---------:|--------:|----------:|------------:|
| GenericList | 100000 | 0.7633 ns | 0.0675 ns | 0.0854 ns | baseline |         |         - |          NA |
| List        | 100000 | 1.8633 ns | 0.0947 ns | 0.1264 ns |    +147% |   13.5% |         - |          NA |
