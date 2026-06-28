namespace DotnetTutorial.Fundamentals.Demos;

public sealed class VariablesDemo
{
    public void Show()
    {
        int count = 10;
        double price = 3.99;
        string name = "Alice";
        bool ok = true;

        Console.WriteLine("Variables:");
        Console.WriteLine($"count={count}, price={price}, name={name}, ok={ok}");
        Console.WriteLine("int = whole number, double = decimal, string = text, bool = true/false");
    }
}