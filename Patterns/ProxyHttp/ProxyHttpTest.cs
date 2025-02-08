
namespace DesignPatterns.Patterns.ProxyHttp;

public class ProxyHttpTest
{
    public static async Task RunAsync()
    {
        WebClient webClient = new("https://jsonplaceholder.typicode.com", "posts");

        // Console.WriteLine(await webClient.GetAsync(1));
        // Console.WriteLine(await webClient.GetAsync(1));

        CacheWebClient cacheWebClient = new(webClient);
        Console.WriteLine(await cacheWebClient.GetAsync(1));
        Console.WriteLine(await cacheWebClient.GetAsync(1));
        Console.WriteLine(await cacheWebClient.GetAsync(2));
        Console.WriteLine(await cacheWebClient.GetAsync(1));
        Console.WriteLine(await cacheWebClient.GetAsync(2));

    }
}