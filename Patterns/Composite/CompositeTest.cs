namespace DesignPatterns.Patterns.Composite;

public class CompositeTest
{
    public static void Run()
    {
        Leaf ingredient1 = new("Flour", 5, 200, "Oz");
        Leaf ingredient2 = new("Milk", 3, 1, "Litre");
        Leaf ingredient3 = new("Eggs", 2, 1, "Pound");

        Composite lemonPie = new("Lemon Pie");
        lemonPie.Add(ingredient1);
        lemonPie.Add(ingredient2);
        lemonPie.Add(ingredient3);

        Console.WriteLine($"Cost of Lemon Pie: {lemonPie.TotalCost}");

        Leaf ingredient4 = new("Chocolate", 7, 1, "Oz");
        Composite chocolatePie = new("Chocolate Pie");

        chocolatePie.Add(ingredient4);
        chocolatePie.Add(lemonPie);

        Console.WriteLine($"Cost of Chocolate Pie: {chocolatePie.TotalCost}");
    }
}