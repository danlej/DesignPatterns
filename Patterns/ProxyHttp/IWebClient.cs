namespace DesignPatterns.Patterns.ProxyHttp;

public abstract class IWebClient
{
    public abstract Task<string> GetAsync(int id);
}