namespace DesignPatterns.Patterns.State;

public class StateTest
{
    public static void Run()
    {
        // ServerContext server = new()
        // {
        //     State = new AvailableServerState()
        // };

        HttpServer server = new();

        server.AttendRequest();

        server.State = new OverflowServerState();
        server.AttendRequest();
        server.AttendRequest();

        server.State = new UnavailableServerState();
        server.AttendRequest();
        server.AttendRequest();
    }
}