using Logger.Data.DTO;
using Logger.Logic.Logger;

namespace Logger.Logic.FileLogger
{
    public class ConsoleLogger : ILogger
    {

        public void AddEntry(LogEntry logEntry)
        {
            Console.WriteLine(Helper.Helper.ConvertToString(logEntry));
        }

        public void AddEntries(List<LogEntry> logEntries)
        {
            foreach (LogEntry logEntry in logEntries)
            {
                Console.WriteLine(Helper.Helper.ConvertToString(logEntry));
            }
        }
    }
}
