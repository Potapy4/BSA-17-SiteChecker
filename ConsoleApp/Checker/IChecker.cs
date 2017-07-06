namespace ConsoleApp.Checker
{
    public interface IChecker
    {
        string Url { get; }
        string Check();
    }
}
