using Logger.Data.DTO;
using Logger.Logic.Logger;
using Microsoft.Extensions.Configuration;

namespace Logger.Logic.FileLogger
{

    public class FileLogger : ILogger
    {
        private readonly string _filePath;
        public FileLogger(IConfiguration configuration)
        {
            _filePath = configuration["filePath"];
        }

        public void AddEntry(LogEntry logEntry)
        {
            using (StreamWriter writer = File.AppendText(_filePath))
            {
                writer.WriteLine(Helper.Helper.ConvertToString(logEntry));
            }
        }

        public void AddEntries(List<LogEntry> logEntries)
        {
            using (StreamWriter writer = File.AppendText(_filePath))
            {
                foreach (var logEntry in logEntries)
                {
                    writer.WriteLine(Helper.Helper.ConvertToString(logEntry));
                }
            }
        }
    }
}
