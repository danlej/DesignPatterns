namespace DesignPatterns.Patterns.Proxy;

public class Proxy : Subject
{
    private RealSubject realSubject;
    private bool authorized;

    public Proxy(RealSubject _realSubject)
    {
        realSubject = _realSubject;
        authorized = false;
    }

    public override void Action()
    {
        if (authorized)
        {
            Console.WriteLine("Proxy: Acceso permitido");
            realSubject.Action();
        }
        else
        {
            Console.WriteLine("Proxy: Acceso no permitido");
        }
    }

    public void Login(string user, string password)
    {
        if (user == "user" && password == "123456")
            authorized = true;
    }
}