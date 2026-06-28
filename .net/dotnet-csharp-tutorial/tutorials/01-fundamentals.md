# C# Fundamentals

This lesson teaches the first things every beginner needs:

- variables
- data types
- `if` statements
- `for` loops
- lists

## 1. Variables

A variable stores a value.

Think of it like a labeled box.

```csharp
int count = 10;
double price = 3.99;
string name = "Alice";
bool ok = true;
```

What these mean:

- `int` = whole number
- `double` = number with decimals
- `string` = text
- `bool` = true or false

## 2. Conditions

A condition asks a yes/no question.

```csharp
if (count > 5)
{
    Console.WriteLine("many");
}
```

This means:

- if `count` is bigger than 5, print `many`
- otherwise do nothing

## 3. Loops

A loop repeats work.

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

This means:

- start at 0
- stop before 5
- increase by 1 each time

## 4. Lists

A list stores more than one item.

```csharp
var list = new List<string> { "apple", "banana", "cherry" };

foreach (var item in list)
{
    Console.WriteLine(item);
}
```

`foreach` means: go through each item in the list.

## What the runnable app does

The app in `src/FundamentalsApp/Program.cs` shows all of the ideas above together.

It prints:

- the variable values
- one `if` result
- a loop from 0 to 4
- the items in a list

## Full runnable code

```csharp
using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		Console.WriteLine("C# Fundamentals demo\n");

		int count = 10;
		double price = 3.99;
		string name = "Alice";
		bool ok = true;

		Console.WriteLine($"count={count}, price={price}, name={name}, ok={ok}");

		if (count > 5)
		{
			Console.WriteLine("many");
		}

		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine(i);
		}

		var list = new List<string> { "apple", "banana", "cherry" };
		Console.WriteLine("List items:");
		foreach (var item in list)
		{
			Console.WriteLine(" - " + item);
		}
	}
}
```

## Run it

```powershell
dotnet run --project src\FundamentalsApp
```

## Try this yourself

Change the code and run it again:

- change `count` to 2
- change the words in the list
- add one more line inside the loop

That is how you learn: read, change, run, repeat.
