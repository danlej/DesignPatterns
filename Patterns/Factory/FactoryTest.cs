namespace DesignPatterns.Patterns.Factory;

public class FactoryTest
{
    public static void Run()
    {
        Shape? shape = ShapeFactory.Create(ShapeFactory.TRIANGLE);
        Print(shape);
        shape = ShapeFactory.Create(ShapeFactory.SQUARE);
        Print(shape);
    }

    private static void Print(Shape? shape)
    {
        if (shape != null) Console.WriteLine($"{shape.GetName()}: {shape.GetSides()} sides");
    }
}
