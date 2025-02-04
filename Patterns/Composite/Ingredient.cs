namespace DesignPatterns.Patterns;

public class Ingredient : Component
{
    public int Quantity { get; set; }

    public string? Unit { get; set; }

    public Ingredient(string _name, decimal _cost, int _quantity, string _unit)
        : base(_name, _cost)
    {
        Quantity = _quantity;
        Unit = _unit;
    }
}