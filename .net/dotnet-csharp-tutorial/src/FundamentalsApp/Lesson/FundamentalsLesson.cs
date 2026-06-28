using DotnetTutorial.Fundamentals.Demos;

namespace DotnetTutorial.Fundamentals;

public sealed class FundamentalsLesson
{
    public void Run()
    {
        var variables = new VariablesDemo();
        var controlFlow = new ControlFlowDemo();
        var collections = new CollectionDemo();

        variables.Show();
        Console.WriteLine();

        controlFlow.Show();
        Console.WriteLine();

        collections.Show();
    }
}