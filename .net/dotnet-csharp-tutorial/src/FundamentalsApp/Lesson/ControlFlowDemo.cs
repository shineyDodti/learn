namespace DotnetTutorial.Fundamentals.Demos;

public sealed class ControlFlowDemo
{
    public void Show()
    {
        Console.WriteLine("Control flow:");

        int count = 10;
        if (count > 5)
        {
            Console.WriteLine("count is bigger than 5");
        }

        Console.WriteLine("for loop:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"i = {i}");
        }
    }
}