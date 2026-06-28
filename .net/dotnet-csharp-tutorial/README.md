NoobTutor — .NET C# learning console app

This workspace contains beginner-friendly C# console apps (one per lesson) and markdown tutorials with runnable code examples.

- `src/FundamentalsApp` — fundamentals examples
- `src/OopApp` — OOP & SOLID example
- `src/AcidApp` — ACID transaction simulation
- `src/HttpDemoApp` — HTTP client demo
- `src/ExercisesApp` — exercises and placeholders
- `tutorials/` — markdown lessons with full example code and GitHub-friendly snippets

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
