using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark;

[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
[CategoriesColumn]
[MemoryDiagnoser]
[SimpleJob(iterationCount: IterationCount)]
public class AvoidLinq_Sort : BenchmarkBase
{
    [ParamsSource(nameof(GetLengths))]
    public override int Length { get; set; }

    [GlobalSetup]
    public override void Setup() => base.Setup();

    [Benchmark]
    public int InitializeTransactionArrayBenchmark() =>
        InitializeTransaction(Length).ToArray().Length;

    [Benchmark]
    public Transaction[] TransactionsArraySort()
    {
        var collection = InitializeTransaction(Length).ToArray();
        Array.Sort(collection, (a, b) => a.Amount - b.Amount);
        return collection;
    }

    [Benchmark]
    public List<Transaction> TransactionsListSort()
    {
        var collection = InitializeTransaction(Length).ToList();
        collection.Sort((a, b) => a.Amount - b.Amount);
        return collection;
    }

    [Benchmark]
    public Transaction[] TransactionIEnumerableLinqOrderBy() =>
        [.. InitializeTransaction(Length).OrderBy(x => x.Amount)];

    [Benchmark]
    public Transaction[] TransactionsListLinqOrderBy() =>
        [.. InitializeTransaction(Length).ToList().OrderBy(x => x.Amount)];

    [Benchmark]
    public Transaction[] TransactionsArrayLinqOrderBy() =>
        [.. InitializeTransaction(Length).ToArray().OrderBy(x => x.Amount)];
}