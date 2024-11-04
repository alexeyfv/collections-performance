using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark;

[CategoriesColumn]
[MemoryDiagnoser]
[SimpleJob(iterationCount: IterationCount)]
public class SliceOnlySpans : BenchmarkBase
{
    private int _start;
    private int _end;

    [ParamsSource(nameof(GetLengths))]
    public override int Length { get; set; }

    [GlobalSetup]
    public override void Setup() 
    {
        _start = 25_000;
        _end = 75_000;
        base.Setup();
    }

    [Benchmark(Baseline = true)]
    public int SliceArray()
    {
        var sum = 0;
        var sliced = _transactionsArray[_start.._end];
        foreach (var t in sliced) sum += t.Amount;
        return sum;
    }

    [Benchmark]
    public int SliceSpan()
    {
        var sum = 0;
        var sliced = _transactionsArray.AsSpan()[_start.._end];
        foreach (var t in sliced) sum += t.Amount;
        return sum;
    }
}
