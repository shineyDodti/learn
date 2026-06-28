using System.Text.Json;
using DotnetTutorial.Exercises.Domain;

namespace DotnetTutorial.Exercises.Services;

public sealed class StudentJsonSerializer
{
    public string Serialize(IEnumerable<Student> students)
    {
        return JsonSerializer.Serialize(students, new JsonSerializerOptions
        {
            WriteIndented = true
        });
    }
}