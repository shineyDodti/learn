using DotnetTutorial.Oop.Domain;

namespace DotnetTutorial.Oop.Services;

public sealed class PersonRepository
{
    private readonly ILogger _logger;
    private readonly List<Person> _people = new();

    public PersonRepository(ILogger logger)
    {
        _logger = logger;
    }

    public void Add(Person person)
    {
        _people.Add(person);
        _logger.Log($"Added {person.Name}");
    }

    public void PrintAll()
    {
        Console.WriteLine("People:");
        foreach (var person in _people)
        {
            Console.WriteLine($"- {person.Name}, age {person.Age}");
        }
    }
}