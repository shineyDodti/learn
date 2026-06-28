using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("HTTP demo: simple GET using HttpClient\n");
        try
        {
            using var client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(10);
            var resp = await client.GetAsync("https://httpbin.org/get");
            Console.WriteLine($"Status: {(int)resp.StatusCode} {resp.ReasonPhrase}");
            var body = await resp.Content.ReadAsStringAsync();
            Console.WriteLine("Response body (truncated):\n" + (body.Length > 400 ? body.Substring(0, 400) + "..." : body));
        }
        catch (Exception ex)
        {
            Console.WriteLine("HTTP request failed: " + ex.Message);
        }
    }
}
