
using System.Text.Json;

namespace DesignPatterns.Patterns.ProxyHttp;

public class WebClient : IWebClient
{
    protected string domain;
    protected string path;

    public WebClient(string _domain, string _path)
    {
        domain = _domain;
        path = _path;
    }

    public override async Task<string> GetAsync(int id)
    {
        string url = $"{domain}/{path}/{id}";
        string content = "";

        HttpClient client = new();

        Console.WriteLine("Se va al servicio...");
        var httpResponse = await client.GetAsync(url);

        if (httpResponse.IsSuccessStatusCode)
        {
            content = await httpResponse.Content.ReadAsStringAsync();
        }
        else
        {
            Console.WriteLine($"Error en la solicitud: {httpResponse.StatusCode}");
        }

        httpResponse.Dispose();
        client.Dispose();

        return content;
    }
}