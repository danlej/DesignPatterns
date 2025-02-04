namespace DesignPatterns.Patterns;

public class OverflowServerState : ServerState
{
    public override void Response()
    {
        Thread.Sleep(500);
        Console.WriteLine("Response 200");
    }
}