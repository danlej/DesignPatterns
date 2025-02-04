namespace DesignPatterns.Patterns;

public class Square : Shape
{
    private const int SHAPES = 4;

    public override int GetSides()
    {
        return SHAPES;
    }
}