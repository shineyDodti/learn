using System;
using System.Collections.Generic;

class FakeDatabase
{
    private List<string> _data = new List<string>();
    private List<string>? _pending;
    public void BeginTransaction() { _pending = new List<string>(); Console.WriteLine("Transaction started"); }
    public void Insert(string value)
    {
        if (_pending is null) throw new InvalidOperationException("No transaction");
        _pending.Add(value);
        Console.WriteLine($"Queued insert: {value}");
    }
    public void Commit()
    {
        if (_pending is null) throw new InvalidOperationException("No transaction");
        _data.AddRange(_pending);
        _pending = null;
        Console.WriteLine("Transaction committed");
    }
    public void Rollback()
    {
        _pending = null;
        Console.WriteLine("Transaction rolled back");
    }
    public void PrintAll() { foreach (var v in _data) Console.WriteLine(" - " + v); }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("ACID simulation demo\n");
        var db = new FakeDatabase();

        Console.WriteLine("--- Successful transaction ---");
        db.BeginTransaction();
        db.Insert("first");
        db.Insert("second");
        db.Commit();
        db.PrintAll();

        Console.WriteLine("\n--- Transaction with error (rolled back) ---");
        db.BeginTransaction();
        db.Insert("third");
        Console.WriteLine("Simulating error...");
        db.Rollback();
        db.PrintAll();
    }
}
