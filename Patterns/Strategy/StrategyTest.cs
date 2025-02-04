namespace DesignPatterns.Patterns.Strategy;

public class StrategyTest
{
    public static void Run()
    {
        // Version 1
        StrategySortingContext sortable = new StrategySortingContext();
        sortable.Sort();
        sortable.SetQuickSortStrategy();
        sortable.Sort();

        // Version 2
        StrategySortingContext2 sortable2 = new();
        sortable2.Sort(Behavior.BubbleSortStrategy);
        sortable2.Sort(Behavior.QuickSortStrategy);
    }
}