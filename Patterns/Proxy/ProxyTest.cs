namespace DesignPatterns.Patterns.Proxy;

public class ProxyTest
{
    public static void Run()
    {
        RealSubject realSubject = new();
        // Some(realSubject);

        Proxy proxy = new(realSubject);
        proxy.Login("user", "123456");
        Some(proxy);
    }

    public static void Some(Subject subject)
    {
        subject.Action();
    }
}