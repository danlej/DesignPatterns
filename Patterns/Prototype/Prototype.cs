namespace DesignPatterns.Patterns.Prototype;

public class Prototype : ICloneable
{
    public int Patas { get; set; }
    public string? Nombre { get; set; }
    public PrototypeDetails? Rasgos { get; set; }

    public object Clone()
    {
        Prototype? clone = MemberwiseClone() as Prototype;
        if (clone != null)
            clone.Rasgos = new()
            {
                Color = Rasgos?.Color,
                Raza = Rasgos?.Raza
            };
        return clone ?? new Object();
    }
}

public class PrototypeDetails
{
    public string? Color { get; set; }
    public string? Raza { get; set; }
}