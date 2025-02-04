namespace DesignPatterns.Patterns;

public class UserAdmin : IColleague
{
    public UserAdmin(IMediator mediator) : base(mediator)
    {

    }

    public override void Receive(string message)
    {
        Console.WriteLine($"Un Administrador recibe: {message}");
    }
}