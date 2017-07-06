namespace ConsoleApp.Logger.Concrete
{
    class ComboLogger : ILogger
    {
        public void Log(string message)
        {
            new ConsoleLogger().Log(message);
            new FileLogger().Log(message);
        }
    }
}
