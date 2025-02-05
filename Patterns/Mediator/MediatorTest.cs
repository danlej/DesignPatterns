namespace DesignPatterns.Patterns.Mediator;

public class MediatorTest
{
    public static void Run()
    {
        Mediator mediator = new();
        IColleague oPepe = new User(mediator, "Pepe");
        IColleague oAdmin = new UserAdmin(mediator, "Franco");
        IColleague oAdmin2 = new UserAdmin(mediator, "Juan");
        mediator.Add(oPepe);
        mediator.Add(oAdmin);
        mediator.Add(oAdmin2);

        oPepe.Communicate("Oye admin tengo un problema!");
        oAdmin.Communicate("¿Qué problema tienes?");
    }
}