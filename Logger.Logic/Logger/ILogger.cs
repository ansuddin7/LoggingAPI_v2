using Logger.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Logic.Logger
{
    public interface ILogger
    {
        void AddEntry(LogEntry logEntry);

        void AddEntries(List<LogEntry> logEntries);
    }
}
