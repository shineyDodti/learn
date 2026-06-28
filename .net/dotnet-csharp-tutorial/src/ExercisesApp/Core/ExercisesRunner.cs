using DotnetTutorial.Exercises.Domain;
using DotnetTutorial.Exercises.Services;

namespace DotnetTutorial.Exercises.Core;

public sealed class ExercisesRunner
{
    public void ShowMenu()
    {
        var factorial = new FactorialCalculator();
        var students = new StudentRoster();
        var serializer = new StudentJsonSerializer();

        Console.WriteLine("Exercises demo\n");
        Console.WriteLine($"Factorial 5 = {factorial.Calculate(5)}");

        students.Add(new Student("Alice", 20));
        students.Add(new Student("Bob", 22));

        Console.WriteLine("Students:");
        foreach (var student in students.GetAll())
        {
            Console.WriteLine($"- {student.Name}, age {student.Age}");
        }

        Console.WriteLine("\nStudents as JSON:");
        Console.WriteLine(serializer.Serialize(students.GetAll()));
    }
}