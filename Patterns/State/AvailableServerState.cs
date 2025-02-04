namespace DesignPatterns.Patterns.State;

public class AvailableServerState : ServerState
{
    public override void Response()
    {
        Console.WriteLine("Response 200");
    }
}