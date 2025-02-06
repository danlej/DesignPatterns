namespace DesignPatterns.Patterns.Mediator;

public abstract class IColleague
{
    protected IMediator mediator;
    public string Name { get; private set; }

    protected IColleague(IMediator _mediator, string _name)
    {
        mediator = _mediator;
        Name = _name;
    }

    public IMediator? Mediator
    {
        get;
    }

    public void Communicate(string message)
    {
        this.mediator.Send(message, this);
    }

    public abstract void Receive(string message);
}

