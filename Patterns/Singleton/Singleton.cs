namespace DesignPatterns.Patterns;

public class Singleton
{
    private static Singleton? instance = null;
    public string message = "";

    protected Singleton()
    {
        message = "Hello Wold!";
    }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
                instance = new Singleton();

            //instance ??= new(); // Compound Assignment

            return instance;
        }
    }
}