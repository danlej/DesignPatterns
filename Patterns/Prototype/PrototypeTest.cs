namespace DesignPatterns.Patterns.Prototype;

public class PrototypeTest
{
    public static void Run()
    {
        Prototype oveja = new()
        {
            Nombre = "Dolly",
            Patas = 4,
            Rasgos = new() { Color = "Blanca", Raza = "Oveja" }
        };

        Prototype? perro = oveja.Clone() as Prototype;
        if (perro != null && perro.Rasgos != null)
        {
            perro.Rasgos.Color = "Negro";
            perro.Rasgos.Raza = "Perro";
            perro.Nombre = "Tommy";
        }

        Console.WriteLine($"La {oveja.Rasgos.Raza} {oveja.Nombre} es de color {oveja.Rasgos.Color}");
        Console.WriteLine($"El {perro?.Rasgos?.Raza} {perro?.Nombre} es de color {perro?.Rasgos?.Color}");
    }
}