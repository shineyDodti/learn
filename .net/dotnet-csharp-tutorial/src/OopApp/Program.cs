using DotnetTutorial.Oop.Domain;
using DotnetTutorial.Oop.Infrastructure;
using DotnetTutorial.Oop.Services;

namespace DotnetTutorial.OopApp;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("OOP & SOLID demo\n");

        var logger = new ConsoleLogger();
        var repo = new PersonRepository(logger);

        repo.Add(new Person("Ada", 30));
        repo.Add(new Person("Grace", 35));

        repo.PrintAll();

        Console.WriteLine("\nNotes:\n- S: Single Responsibility\n- O: Open/Closed\n- L: Liskov\n- I: Interface Segregation\n- D: Dependency Inversion");
    }
}
