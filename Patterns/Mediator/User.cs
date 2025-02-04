namespace DesignPatterns.Patterns.Mediator;

public class User : IColleague
{
    public User(IMediator mediator) : base(mediator)
    {

    }

    public override void Receive(string message)
    {
        Console.WriteLine($"Un Usuario recibe: {message}");
    }
}