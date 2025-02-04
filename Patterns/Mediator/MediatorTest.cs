namespace DesignPatterns.Patterns.Mediator;

public class MediatorTest
{
    public static void Run()
    {
        Mediator mediator = new();
        IColleague oPepe = new User(mediator);
        IColleague oAdmin = new UserAdmin(mediator);
        mediator.Add(oPepe);
        mediator.Add(oAdmin);
        oPepe.Communicate("Oye admin tengo un problema!");
    }
}