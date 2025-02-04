using Microsoft.Win32.SafeHandles;

namespace DesignPatterns.Patterns;

public class Mediator : IMediator
{
    private List<IColleague> colleagues;

    public Mediator()
    {
        colleagues = new List<IColleague>();
    }

    public void Add(IColleague colleague)
    {
        this.colleagues.Add(colleague);
    }

    public void Send(string message, IColleague colleague)
    {
        foreach (var c in this.colleagues)
        {
            if (colleague != c)
            {
                c.Receive(message);
            }
        }
    }
}