using System.Collections.Generic;

namespace DotnetTutorial.Fundamentals.Demos;

public sealed class CollectionDemo
{
    public void Show()
    {
        var list = new List<string> { "apple", "banana", "cherry" };

        Console.WriteLine("Collections:");
        foreach (var item in list)
        {
            Console.WriteLine($"- {item}");
        }
    }
}