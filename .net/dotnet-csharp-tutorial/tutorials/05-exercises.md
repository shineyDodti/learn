# Exercises

This page is for practice.

Do not just read it. Try it.

## Exercise 1: Factorial

Write code that calculates factorial.

Example:

- `5! = 5 x 4 x 3 x 2 x 1 = 120`

Hints:

- use a loop
- start with 1
- multiply as you go

## Exercise 2: Student list

Make a `Student` class.

Give it:

- a name
- an age

Then make a list of students and print them.

Hints:

- use `List<Student>`
- use a `foreach` loop

## Exercise 3: JSON

Take the student list and convert it to JSON.

Hints:

- use `System.Text.Json`
- look for `JsonSerializer.Serialize`

## Exercise 4: Tiny API

Create a tiny API that returns a list of students.

Hints:

- use `WebApplication.CreateBuilder()`
- add a `MapGet` route
- return a list or JSON

## Run the placeholder app

```powershell
dotnet run --project src\ExercisesApp
```

## What success looks like

You should be able to:

- read the code
- change the code
- run it again
- understand the result

That is how beginner learning works.
