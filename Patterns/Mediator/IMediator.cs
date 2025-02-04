namespace DesignPatterns.Patterns;

public interface IMediator
{
    void Send(string message, IColleague colleague);
}