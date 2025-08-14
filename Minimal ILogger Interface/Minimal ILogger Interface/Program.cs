ILogger NoReferanceObject;
NoReferanceObject = new FileLogger();
NoReferanceObject.Log("log message");
NoReferanceObject = new ConsoleLogger();
NoReferanceObject.Log(" Console message");
public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
       System.Console.WriteLine(message);
    }
}
public class FileLogger : ILogger
{
    public void Log(string message)
    {
       System.IO.File.AppendAllText("log.txt", message + "\n");
    }
}

public interface ILogger
{
    void Log(string message);
}