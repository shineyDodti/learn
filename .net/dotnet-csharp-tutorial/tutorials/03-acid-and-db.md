# ACID and basic persistence concepts

This lesson is about saving data safely.

When a program changes data, you want to know:

- did everything finish?
- did nothing get half-saved?
- can I trust the result?

That is what ACID is about.

## ACID in simple words

- **Atomicity**: all of it happens or none of it happens.
- **Consistency**: the data stays valid.
- **Isolation**: one transaction does not break another.
- **Durability**: once saved, the data stays saved.

## A simple picture

Think of sending money:

1. remove money from one account
2. add money to another account

If step 1 happens but step 2 fails, that is bad.

A transaction protects you from that kind of problem.

## What a transaction is

A transaction is a grouped set of changes.

You either:

- commit it, which saves the changes
- rollback it, which cancels the changes

## Full runnable code

```csharp
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
```

## Run it

```powershell
dotnet run --project src\AcidApp
```

## What to notice

- the first transaction saves data
- the second one gets cancelled
- the database only keeps the committed data

## Why this matters

Real databases use transactions so data does not get broken when errors happen.

That is how apps keep money, orders, and important records safe.

For real databases, learn SQL and a provider like SQL Server, PostgreSQL, or SQLite.
