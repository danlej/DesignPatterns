namespace DesignPatterns.Patterns.Proxy;

public class RealSubject : Subject
{
    public override void Action()
    {
        Console.WriteLine("Realizar acción");
    }
}