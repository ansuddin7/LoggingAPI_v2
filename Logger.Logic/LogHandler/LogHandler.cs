using Logger.Data.DTO;
using Logger.Logic.Delegates;

namespace Logger.Logic.LogHandler
{
    public class LogHandler : ILogHandler
    {
        private readonly LogEntryDelegate _logEntryDelegate;
        private readonly LogEntriesDelegate _logEntriesDelegate;


        public LogHandler(LogEntryDelegate logEntryDelegate, LogEntriesDelegate logEntriesDelegate)
        {
            _logEntryDelegate = logEntryDelegate;
            _logEntriesDelegate = logEntriesDelegate;
        }

        public void AddEntry(LogEntry logEntry)
        {
            _logEntryDelegate(logEntry);
        }

        public void AddEntries(List<LogEntry> logEntries)
        {
            _logEntriesDelegate(logEntries);
        }
    }
}
