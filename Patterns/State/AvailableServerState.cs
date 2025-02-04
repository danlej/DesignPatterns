namespace DesignPatterns.Patterns;

public class AvailableServerState : ServerState
{
    public override void Response()
    {
        Console.WriteLine("Response 200");
    }
}