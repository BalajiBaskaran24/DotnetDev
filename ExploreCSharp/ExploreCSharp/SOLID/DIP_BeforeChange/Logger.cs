namespace ExploreCSharp.SOLID.DIP_BeforeChange;

public class Logger
{
    public void Log(string message)
    {
        Console.WriteLine($"Write to Console: {message}");
    }
}
