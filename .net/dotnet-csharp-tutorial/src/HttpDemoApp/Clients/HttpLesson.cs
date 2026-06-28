using System.Net.Http;

namespace DotnetTutorial.Http.Clients;

public sealed class HttpLesson
{
    public async Task RunAsync()
    {
        Console.WriteLine("HTTP demo: simple GET using HttpClient\n");

        try
        {
            using var client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(10);

            var resp = await client.GetAsync("https://httpbin.org/get");
            Console.WriteLine($"Status: {(int)resp.StatusCode} {resp.ReasonPhrase}");

            var body = await resp.Content.ReadAsStringAsync();
            var preview = body.Length > 400 ? body[..400] + "..." : body;

            Console.WriteLine("Response body (truncated):\n" + preview);
        }
        catch (Exception ex)
        {
            Console.WriteLine("HTTP request failed: " + ex.Message);
        }
    }
}