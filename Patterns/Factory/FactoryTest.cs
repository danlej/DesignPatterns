namespace DesignPatterns.Patterns.Factory;

public class FactoryTest
{
    public static void Run()
    {
        Shape? shape = ShapeFactory.Create(ShapeFactory.SQUARE);
        if (shape != null) Console.WriteLine(shape.GetSides());
    }
}