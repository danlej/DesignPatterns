namespace DesignPatterns.Patterns.Mediator;

public class MediatorTest
{
    public static void Run()
    {
        Mediator mediator = new();
        IColleague oPepe = new User(mediator, "Pepe");
        IColleague oAdmin = new UserAdmin(mediator, "Franco");
        IColleague oAdmin2 = new UserAdmin(mediator, "Juan");
        mediator.Register(oPepe);
        mediator.Register(oAdmin);
        mediator.Register(oAdmin2);

        oPepe.Communicate("Oye admin tengo un problema!");
        oAdmin.Communicate("¿Qué problema tienes?");
    }
}