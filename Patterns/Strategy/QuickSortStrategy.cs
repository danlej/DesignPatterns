namespace DesignPatterns.Patterns;

public class QuickSortStrategy : ISortable
{
    public void Sort()
    {
        Console.WriteLine("QuickSort Strategy");
    }
}