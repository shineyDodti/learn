namespace DotnetTutorial.Oop.Domain;

public sealed class Person
{
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}