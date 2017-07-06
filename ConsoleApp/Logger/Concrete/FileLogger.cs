using System;
using System.IO;

namespace ConsoleApp.Logger.Concrete
{
    class FileLogger : ILogger
    {
        public void Log(string message)
        {
            using (StreamWriter sw = File.AppendText("Log.txt"))
            {
                sw.WriteLine($"[{DateTime.Now}]: - {message}");               
            }
        }
    }
}
