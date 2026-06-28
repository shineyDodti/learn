# OOP and SOLID (short guide)

OOP basics:
- Class: a blueprint for objects (data + behavior).
- Object/instance: runtime value created from a class.
- Encapsulation, inheritance, polymorphism: core OOP ideas.

Full runnable example (`src/OopApp/Program.cs`):

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

Run locally:
```powershell
dotnet run --project src\OopApp
```
