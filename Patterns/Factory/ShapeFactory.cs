namespace DesignPatterns.Patterns.Factory;

public class ShapeFactory
{
    public const int TRIANGLE = 1;
    public const int SQUARE = 2;

    public static Shape? Create(int tipo)
    {
        switch (tipo)
        {
            case TRIANGLE:
                return new Triangle();
            case SQUARE:
                return new Square();
            default: return null;
        }
    }
}