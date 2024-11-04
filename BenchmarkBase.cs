namespace Benchmark;

public abstract class BenchmarkBase
{
    public const int IterationCount = 25;

    public abstract int Length { get; set; }

    protected Transaction[] _transactionsArray = default!;
    protected List<Transaction> _transactionsList = default!;
    protected IEnumerable<Transaction> _transactionsIEnumerable = default!;

    public virtual void Setup()
    {
        _transactionsArray = InitializeTransaction(Length).ToArray();
        _transactionsList = InitializeTransaction(Length).ToList();
        _transactionsIEnumerable = InitializeTransaction(Length);
    }

    public static IEnumerable<Transaction> InitializeTransaction(int length) =>
        Enumerable
            .Range(0, length)
            .Select(x => new Transaction(
                Guid.NewGuid(),
                Random.Shared.Next(0, 100),
                $"{Guid.NewGuid()}"));

    public static IEnumerable<int> GetLengths()
    {
        for (var i = 10; i < 100; i += 25) yield return i;
        for (var i = 100; i < 1000; i += 250) yield return i;
        for (var i = 1000; i < 10_000; i += 2500) yield return i;
        for (var i = 10_000; i < 100_000; i += 25_000) yield return i;
        for (var i = 100_000; i < 1_000_000; i += 250_000) yield return i;
        yield return 1_000_000;
    }

    public record class Transaction(Guid Id, int Amount, string Description);
}
