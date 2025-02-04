namespace DesignPatterns.Patterns.Strategy;

public class BubbleSortStrategy : ISortable
{
    public void Sort()
    {
        Console.WriteLine("BubbleSort Strategy");
    }
}