using System.Collections;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark;

[CategoriesColumn]
[MemoryDiagnoser]
[SimpleJob(iterationCount: IterationCount)]
public class UseGenericCollections : BenchmarkBase
{
    [Params(100_000)]
    public override int Length { get; set; }
    private List<int> _genericList = [];
    private ArrayList _list = [];

    [GlobalSetup]
    public override void Setup()
    {
        _genericList = new(Length);
        _list = new(Length);
    }

    [Benchmark(Baseline = true)]
    public int GenericList()
    {
        for (var i = 0; i < _genericList.Count; i++)
        {
            _genericList.Add(i);
        }
        return _genericList.Count;
    }

    [Benchmark]
    public int List()
    {
        for (var i = 0; i < _list.Count; i++)
        {
            _list.Add(i);
        }
        return _list.Count;
    }
}
