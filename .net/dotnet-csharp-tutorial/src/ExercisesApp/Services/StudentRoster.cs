using DotnetTutorial.Exercises.Domain;

namespace DotnetTutorial.Exercises.Services;

public sealed class StudentRoster
{
    private readonly List<Student> _students = new();

    public void Add(Student student)
    {
        _students.Add(student);
    }

    public IReadOnlyList<Student> GetAll()
    {
        return _students;
    }
}