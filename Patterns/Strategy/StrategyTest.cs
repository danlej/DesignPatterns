namespace DesignPatterns.Patterns.Strategy;

public class StrategyTest
{
    public static void Run()
    {
        // Version 1
        Console.WriteLine("Versión 1:");
        StrategySortingContext sortable = new StrategySortingContext();
        sortable.Sort();
        sortable.SetQuickSortStrategy();
        sortable.Sort();

        // Version 2
        Console.WriteLine("Versión 2:");
        StrategySortingContext2 sortable2 = new();
        sortable2.Sort(Behavior.BubbleSortStrategy);
        sortable2.Sort(Behavior.QuickSortStrategy);
    }
}