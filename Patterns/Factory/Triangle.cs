namespace DesignPatterns.Patterns.Factory;

public class Triangle : Shape
{
    private const string NAME = "TRIANGLE";
    private const int SHAPES = 3;

    public override string GetName()
    {
        return NAME;
    }
    public override int GetSides()
    {
        return SHAPES;
    }
}