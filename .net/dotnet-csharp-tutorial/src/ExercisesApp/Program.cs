using DotnetTutorial.Exercises.Core;

namespace DotnetTutorial.ExercisesApp;

internal static class Program
{
    private static void Main()
    {
        var runner = new ExercisesRunner();
        runner.ShowMenu();
    }
}
