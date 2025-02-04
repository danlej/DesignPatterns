namespace DesignPatterns.Patterns.Mediator;

public abstract class IColleague
{
    private IMediator mediator;

    public IMediator Mediator
    {
        get;
    }

    public IColleague(IMediator _mediator)
    {
        this.mediator = _mediator;
    }

    public void Communicate(string message)
    {
        this.mediator.Send(message, this);
    }

    public abstract void Receive(string message);
}