namespace DesignPatterns.Patterns.State;

public class HttpServer
{
    private ServerState state = new AvailableServerState();

    public ServerState State
    {
        get { return state; }

        set { state = value; }
    }

    public void AttendRequest()
    {
        state.Response();
    }
}