namespace DotnetTutorial.Acid.Database;

public sealed class FakeDatabase
{
    private readonly List<string> _data = new();
    private List<string>? _pending;

    public void BeginTransaction()
    {
        _pending = new List<string>();
        Console.WriteLine("Transaction started");
    }

    public void Insert(string value)
    {
        if (_pending is null)
        {
            throw new InvalidOperationException("No transaction");
        }

        _pending.Add(value);
        Console.WriteLine($"Queued insert: {value}");
    }

    public void Commit()
    {
        if (_pending is null)
        {
            throw new InvalidOperationException("No transaction");
        }

        _data.AddRange(_pending);
        _pending = null;
        Console.WriteLine("Transaction committed");
    }

    public void Rollback()
    {
        _pending = null;
        Console.WriteLine("Transaction rolled back");
    }

    public void PrintAll()
    {
        Console.WriteLine("Data in database:");
        foreach (var value in _data)
        {
            Console.WriteLine($"- {value}");
        }
    }
}