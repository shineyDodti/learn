namespace DotnetTutorial.Exercises.Domain;

public sealed class Student
{
    public string Name { get; }
    public int Age { get; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}