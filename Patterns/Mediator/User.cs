namespace DesignPatterns.Patterns.Mediator;

public class User(IMediator mediator, string _name) : IColleague(mediator, _name)
{
    public override void Receive(string message)
    {
        Console.WriteLine($"Un Usuario ({name}) recibe: {message}");
    }
}