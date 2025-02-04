namespace DesignPatterns.Patterns.Singleton;

public class SingletonTest
{
    public static void Run()
    {
        Console.WriteLine(Singleton.Instance.message);
        Singleton.Instance.message = "Hello Mars!";
        Console.WriteLine(Singleton.Instance.message);
    }
}