namespace Generator;

public static class Log
{
    public static void Info(string message)
    {
        var color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("[INFO]\t" + message);
        Console.ForegroundColor = color;
    }

    public static void Error(string message)
    {
        var color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[ERROR]\t" + message);
        Console.ForegroundColor = color;
    }
}
