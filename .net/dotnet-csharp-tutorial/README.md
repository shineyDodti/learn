NoobTutor — .NET C# learning console app

This workspace contains beginner-friendly C# lessons with one clear starting guide, lesson pages, and a small console app for each topic.

Start here if you are new:

- [00-beginner-guide.md](tutorials/00-beginner-guide.md)

Read that page first. It explains the terms, the order, and how to use the repo.

Lessons:

- [01-fundamentals.md](tutorials/01-fundamentals.md) → [FundamentalsApp](src/FundamentalsApp/FundamentalsApp.csproj)
- [02-oop-and-solid.md](tutorials/02-oop-and-solid.md) → [OopApp](src/OopApp/OopApp.csproj)
- [03-acid-and-db.md](tutorials/03-acid-and-db.md) → [AcidApp](src/AcidApp/AcidApp.csproj)
- [04-http-and-api.md](tutorials/04-http-and-api.md) → [HttpDemoApp](src/HttpDemoApp/HttpDemoApp.csproj)
- [05-exercises.md](tutorials/05-exercises.md) → [ExercisesApp](src/ExercisesApp/ExercisesApp.csproj)

Projects:

- [FundamentalsApp](src/FundamentalsApp/FundamentalsApp.csproj)
- [OopApp](src/OopApp/OopApp.csproj)
- [AcidApp](src/AcidApp/AcidApp.csproj)
- [HttpDemoApp](src/HttpDemoApp/HttpDemoApp.csproj)
- [ExercisesApp](src/ExercisesApp/ExercisesApp.csproj)

Quick start (after you install .NET SDK):

Run a lesson example (replace `FundamentalsApp` with another project name):

```powershell
cd .net/dotnet-csharp-tutorial
dotnet run --project src\FundamentalsApp
```

Each `tutorials/*.md` file includes the full `Program.cs` for the lesson and a `dotnet run --project` command.

Notes:
- Examples target `net10.0`. If you have a different SDK, change the `TargetFramework` in the relevant `*.csproj`.
- Network demos use external sites and may return errors if offline or the remote is unavailable.

Projects and files (local links):

- Projects:
	- [FundamentalsApp.csproj](src/FundamentalsApp/FundamentalsApp.csproj)
	- [OopApp.csproj](src/OopApp/OopApp.csproj)
	- [AcidApp.csproj](src/AcidApp/AcidApp.csproj)
	- [HttpDemoApp.csproj](src/HttpDemoApp/HttpDemoApp.csproj)
	- [ExercisesApp.csproj](src/ExercisesApp/ExercisesApp.csproj)

- Tutorial markdowns:
	- [01-fundamentals.md](tutorials/01-fundamentals.md)
	- [02-oop-and-solid.md](tutorials/02-oop-and-solid.md)
	- [03-acid-and-db.md](tutorials/03-acid-and-db.md)
	- [04-http-and-api.md](tutorials/04-http-and-api.md)
	- [05-exercises.md](tutorials/05-exercises.md)

Run a specific example:

```powershell
dotnet run --project src\FundamentalsApp
```
