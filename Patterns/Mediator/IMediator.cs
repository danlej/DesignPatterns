namespace DesignPatterns.Patterns.Mediator;

public interface IMediator
{
    void Send(string message, IColleague colleague);
}