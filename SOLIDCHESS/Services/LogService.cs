public class LogService() : ILogService
{
    public void WriteLog(string message)
    {
        Console.WriteLine(message);
    }
}
