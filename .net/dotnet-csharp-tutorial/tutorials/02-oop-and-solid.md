# OOP and SOLID

OOP means object-oriented programming.

That is a fancy way of saying:

- put related data and behavior together
- build small pieces that work together

## OOP basics

- **Class**: a blueprint for objects.
- **Object**: something created from a class.
- **Encapsulation**: keep related things together.
- **Inheritance**: one class can build on another.
- **Polymorphism**: different objects can act through the same interface.

## What this lesson shows

This example uses:

- a `Person` class
- an `ILogger` interface
- a `PersonRepository` class

The goal is to show how small pieces fit together.

## Why interfaces matter

An interface is a promise.

If a class says it implements `ILogger`, it must provide `Log`.

That helps you change code later without rewriting everything.

## The SOLID idea

SOLID is a group of five design ideas.

- **S**: one class should do one job.
- **O**: open for extension, closed for modification.
- **L**: derived classes should still behave correctly.
- **I**: keep interfaces small.
- **D**: depend on abstractions, not concrete types.

Do not memorize the letters first. Learn the idea first.

## Full runnable code

```csharp
using System;
using System.Collections.Generic;

interface ILogger { void Log(string message); }
class ConsoleLogger : ILogger { public void Log(string message) => Console.WriteLine("[LOG] " + message); }

class Person
{
	public string Name { get; }
	public int Age { get; }
	public Person(string name, int age) { Name = name; Age = age; }
}

class PersonRepository
{
	private readonly ILogger _logger;
	private readonly List<Person> _people = new List<Person>();
	public PersonRepository(ILogger logger) { _logger = logger; }
	public void Add(Person p) { _people.Add(p); _logger.Log($"Added {p.Name}"); }
	public void PrintAll() { foreach (var p in _people) Console.WriteLine($"Person: {p.Name}, age {p.Age}"); }
}

class Program
{
	static void Main()
	{
		Console.WriteLine("OOP & SOLID demo\n");
		ILogger logger = new ConsoleLogger();
		var repo = new PersonRepository(logger);
		var person = new Person("Ada", 30);
		repo.Add(person);
		repo.PrintAll();

		Console.WriteLine("\nNotes:\n- S: Single Responsibility\n- O: Open/Closed\n- L: Liskov\n- I: Interface Segregation\n- D: Dependency Inversion");
	}
}
```

## Run it

```powershell
dotnet run --project src\OopApp
```

## What to notice

- `Program` starts the app.
- `Person` stores data.
- `PersonRepository` keeps a list of people.
- `ILogger` lets the repository use logging without knowing the exact logger type.

## Try this yourself

- change the name `Ada` to your name
- add another `Person`
- change the message inside `Log`
- remove the log line and see what changes

The point is to see how objects talk to each other.
