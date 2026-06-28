# HTTP verbs and APIs

This lesson explains how C# talks to web services.

## What HTTP is

HTTP is the language a browser or app uses to talk to a server.

When your app calls an API, it sends a request.
The API sends back a response.

## Common HTTP verbs

- **GET**: read data
- **POST**: create new data
- **PUT**: replace data
- **PATCH**: change part of data
- **DELETE**: remove data

## What an API is

An API is a way for programs to talk to each other.

Example:

- your app asks for products
- the API sends back JSON
- your app shows the products

## The C# code in this lesson

This app uses `HttpClient` to send one GET request.

That is the basic pattern you will use again and again.

## Full runnable code

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

## Run it

```powershell
dotnet run --project src\HttpDemoApp
```

## What to notice

- the code creates an `HttpClient`
- it sends a GET request
- it reads the response text
- it prints the status code

## Why this matters

This is how apps talk to websites and backend services.

## Small API example

Here is a tiny API server:

```csharp
var builder = WebApplication.CreateBuilder();
var app = builder.Build();
app.MapGet("/hello", () => "Hello world");
app.Run();
```

That means: when someone visits `/hello`, return `Hello world`.

## Try this yourself

- change the URL
- change the printed text
- look up what GET and POST mean
- try writing a tiny API that returns a string
