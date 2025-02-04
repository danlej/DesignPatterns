namespace DesignPatterns.Patterns;

public class ServerContext
{
    private ServerState state;

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