using DotnetTutorial.Http.Clients;

namespace DotnetTutorial.HttpDemoApp;

internal static class Program
{
    private static async Task Main()
    {
        var lesson = new HttpLesson();
        await lesson.RunAsync();
    }
}
