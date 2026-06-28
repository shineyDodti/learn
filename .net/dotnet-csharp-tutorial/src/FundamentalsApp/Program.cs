using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("C# Fundamentals demo\n");

        int count = 10;
        double price = 3.99;
        string name = "Alice";
        bool ok = true;

        Console.WriteLine($"count={count}, price={price}, name={name}, ok={ok}");

        if (count > 5) Console.WriteLine("many");

        for (int i = 0; i < 5; i++) Console.WriteLine(i);

        var list = new List<string> { "apple", "banana", "cherry" };
        Console.WriteLine("List items:");
        foreach (var item in list) Console.WriteLine(" - " + item);
    }
}
