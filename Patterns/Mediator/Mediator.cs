namespace DesignPatterns.Patterns.Mediator;

public class Mediator : IMediator
{
    private List<IColleague> colleagues;

    public Mediator()
    {
        colleagues = [];
    }

    public void Add(IColleague colleague)
    {
        colleagues.Add(colleague);
    }

    public void Send(string message, IColleague colleague)
    {
        foreach (var c in colleagues)
        {
            if (colleague != c)
            {
                c.Receive(message);
            }
        }
    }
}