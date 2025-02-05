namespace DesignPatterns.Patterns.Mediator;

public class UserAdmin(IMediator _mediator, string _name) : IColleague(_mediator, _name)
{
    public override void Receive(string message)
    {
        Console.WriteLine($"Un Administrador ({name}) recibe: {message}");
    }
}