
using DesignPatterns.Patterns.Proxy;
using DesignPatterns.Patterns.ProxyHttp;

class Program
{
    static async Task Main(string[] args)
    {
        // Aquí llamas al método Run() del patrón que quieras probar.
        // Ejemplo: SingletonTest.Run();

        //SingletonTest.Run();
        //PrototypeTest.Run();
        // FactoryTest.Run();
        // StrategyTest.Run();
        // MediatorTest.Run();
        // StateTest.Run();
        // CompositeTest.Run();
        // ProxyTest.Run();
        await ProxyHttpTest.RunAsync();
    }
}