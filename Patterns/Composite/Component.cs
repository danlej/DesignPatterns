namespace DesignPatterns.Patterns.Composite;

public abstract class Component
{
    public string? Name { get; set; }

    public decimal Cost { get; set; }

    public Component(string _name, decimal _cost)
    {
        Name = _name;
        Cost = _cost;
    }
}