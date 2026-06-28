# HTTP verbs and APIs (overview)

Common HTTP verbs:
- GET — retrieve a resource
- POST — create a resource
- PUT — replace a resource
- PATCH — modify part of a resource
- DELETE — remove a resource

Full runnable example (`src/HttpDemoApp/Program.cs`):

```csharp
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
```

Run locally:
```powershell
dotnet run --project src\HttpDemoApp
```

Minimal API (server-side) example (copy into a new project):

```csharp
var builder = WebApplication.CreateBuilder();
var app = builder.Build();
app.MapGet("/hello", () => "Hello world");
app.Run();
```

Notes:
- APIs often use JSON. Use `System.Text.Json` or `Newtonsoft.Json` for (de)serialization.
- Practice by building small endpoints and calling them with `curl` or `HttpClient`.
