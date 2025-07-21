using Newtonsoft.Json;

namespace LoggingComponent;

public static class Logger
{
    public static void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }

    public static void Log(object obj)
    {
        string json = JsonConvert.SerializeObject(obj);
        Log(json);
    }
}
