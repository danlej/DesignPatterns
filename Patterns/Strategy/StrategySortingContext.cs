namespace DesignPatterns.Patterns;

public class StrategySortingContext
{
    private ISortable sortable;

    public StrategySortingContext()
    {
        this.sortable = new BubbleSortStrategy();
    }

    public void SetBubbleSortStrategy()
    {
        this.sortable = new BubbleSortStrategy();
    }

    public void SetQuickSortStrategy()
    {
        this.sortable = new QuickSortStrategy();
    }

    public void Sort()
    {
        this.sortable.Sort();
    }
}