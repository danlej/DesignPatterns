namespace DesignPatterns.Patterns.Mediator;

public abstract class IColleague(IMediator _mediator, string _name)
{
    private readonly IMediator mediator = _mediator;

    protected readonly string name = _name;

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

