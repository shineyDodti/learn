# C# Beginner Guide

Start here if you are new to C#.

This page is the map. It explains the words, the order, and how to use the lessons.

## What this repo contains

- [README.md](../README.md) tells you where everything is.
- `tutorials/` has the learning pages.
- `src/` has small console apps you can run to test each lesson.

## What C# is

C# is a programming language. You use it to tell the computer what to do.

People use C# to build:

- console apps
- websites and APIs
- desktop apps
- games
- tools and services

This repo starts with console apps because they are the easiest way to see C# working.

## What a console app is

A console app is a program that runs in a terminal window.

It can:

- print text
- ask for input
- make decisions
- repeat steps

Example:

```csharp
using System;

Console.WriteLine("Hello");
```

That prints text to the screen.

## The most important beginner ideas

- **Project**: a folder that contains code and a `.csproj` file.
- **Program.cs**: the file where the app starts.
- **Variable**: a box that stores a value.
- **Type**: what kind of value the variable holds.
- **Method**: a function inside a class.
- **Class**: a blueprint for data and behavior.
- **Object**: something created from a class.
- **Loop**: repeat work.
- **Condition**: choose between paths.

## How to use this repo

Read the pages in this order:

1. [Fundamentals](01-fundamentals.md)
2. [OOP and SOLID](02-oop-and-solid.md)
3. [ACID and basic persistence](03-acid-and-db.md)
4. [HTTP verbs and APIs](04-http-and-api.md)
5. [Exercises](05-exercises.md)

Each page has:

- a plain-English explanation
- a small code example
- a runnable console app
- a short practice section

## How to run a lesson

Example:

```powershell
dotnet run --project src\FundamentalsApp
```

Replace `FundamentalsApp` with the lesson you want.

## What to do first

1. Read this page.
2. Open [Fundamentals](01-fundamentals.md).
3. Run [FundamentalsApp](../src/FundamentalsApp/FundamentalsApp.csproj).
4. Compare the text and the code.

If a word is still confusing, come back to this page and reread the definitions above.
