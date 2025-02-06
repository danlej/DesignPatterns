namespace DesignPatterns.Patterns.Mediator;

public interface IMediator
{
    void Register(IColleague colleague);
    void Send(string message, IColleague colleague);
}