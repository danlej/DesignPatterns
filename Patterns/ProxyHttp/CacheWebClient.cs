
namespace DesignPatterns.Patterns.ProxyHttp;

public class CacheWebClient : IWebClient
{
    protected WebClient webClient;
    private Dictionary<int, string> cache = [];

    public CacheWebClient(WebClient _webClient)
    {
        webClient = _webClient;
    }

    public override async Task<string> GetAsync(int id)
    {
        if (cache.ContainsKey(id))
        {
            Console.WriteLine($"Proxy: Obtenemos la información de {id} del caché.");
            return cache[id];
        }

        Console.WriteLine($"Proxy: Se realiza la solicitud de {id}");
        var data = await webClient.GetAsync(id);
        cache[id] = data;
        return data;

    }
}