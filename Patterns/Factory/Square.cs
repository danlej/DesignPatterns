namespace DesignPatterns.Patterns.Factory;

public class Square : Shape
{
    private const string NAME = "SQUARE";
    private const int SHAPES = 4;

    public override string GetName()
    {
        return NAME;
    }

    public override int GetSides()
    {
        return SHAPES;
    }
}