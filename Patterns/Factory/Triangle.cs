namespace DesignPatterns.Patterns.Factory;

public class Triangle : Shape
{
    private const int SHAPES = 3;

    public override int GetSides()
    {
        return SHAPES;
    }
}