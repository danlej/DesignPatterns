namespace DesignPatterns.Patterns.Strategy;

public class StrategySortingContext2
{
    private ISortable sortable;

    public StrategySortingContext2()
    {
        this.sortable = new BubbleSortStrategy();
    }

    public void Sort(Behavior behavior)
    {
        switch (behavior)
        {
            case Behavior.BubbleSortStrategy:
                {
                    this.sortable = new BubbleSortStrategy();
                    break;
                }
            case Behavior.QuickSortStrategy:
                {
                    this.sortable = new QuickSortStrategy();
                    break;
                }
        }

        this.sortable.Sort();
    }
}

public enum Behavior
{
    BubbleSortStrategy, QuickSortStrategy
}
