namespace ConsoleApp.Logger.Concrete
{
    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
