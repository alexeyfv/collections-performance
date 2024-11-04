using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark;

[CategoriesColumn]
[MemoryDiagnoser]
[SimpleJob(iterationCount: IterationCount)]
public class SetInitialCapacity : BenchmarkBase
{
    [Params(100_000)]
    public override int Length { get; set; }

    [GlobalSetup]
    public override void Setup() => base.Setup();

    [Benchmark(Baseline = true)]
    public int DefaultInitialCapacity()
    {
        var list = new List<int>();
        for (var i = 0; i < Length; i++)
        {
            list.Add(i);
        }
        return list.Count;
    }

    [Benchmark]
    public int GivenInitialCapacity()
    {
        var list = new List<int>(Length);
        for (var i = 0; i < Length; i++)
        {
            list.Add(i);
        }
        return list.Count;
    }
}
