namespace Reflectonia;

public class ReflectoniaLog : IReflectoniaLog
{
    public void Info(string message)
    {
        var color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("[INFO]\t" + message);
        Console.ForegroundColor = color;
    }

    public void Error(string message)
    {
        var color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[ERROR]\t" + message);
        Console.ForegroundColor = color;
    }
}
