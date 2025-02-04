namespace DesignPatterns.Patterns.Strategy;

public class QuickSortStrategy : ISortable
{
    public void Sort()
    {
        Console.WriteLine("QuickSort Strategy");
    }
}