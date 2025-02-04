namespace DesignPatterns.Patterns;

public class UnavailableServerState : ServerState
{
    public override void Response()
    {
        Thread.Sleep(1000);
        Console.WriteLine("Response 503");
    }
}