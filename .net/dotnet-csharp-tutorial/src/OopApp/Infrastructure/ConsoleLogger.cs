using DotnetTutorial.Oop.Domain;

namespace DotnetTutorial.Oop.Infrastructure;

public sealed class ConsoleLogger : ILogger
{
    public void Log(string message) => Console.WriteLine("[LOG] " + message);
}