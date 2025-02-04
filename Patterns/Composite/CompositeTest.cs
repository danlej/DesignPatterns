namespace DesignPatterns.Patterns.Composite;

public class CompositeTest
{
    public static void Run()
    {
        Ingredient ingredient1 = new("Flour", 5, 200, "Oz");
        Ingredient ingredient2 = new("Milk", 3, 1, "Litre");
        Ingredient ingredient3 = new("Eggs", 2, 1, "Pound");

        CompositePie lemonPie = new("Lemon Pie");
        lemonPie.Add(ingredient1);
        lemonPie.Add(ingredient2);
        lemonPie.Add(ingredient3);

        Console.WriteLine($"Cost of Lemon Pie: {lemonPie.TotalCost}");

        Ingredient ingredient4 = new("Chocolate", 7, 1, "Oz");
        CompositePie chocolatePie = new("Chocolate Pie");

        chocolatePie.Add(ingredient4);
        chocolatePie.Add(lemonPie);

        Console.WriteLine($"Cost of Chocolate Pie: {chocolatePie.TotalCost}");
    }
}