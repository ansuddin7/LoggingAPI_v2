using Logger.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Logic.Delegates
{
    public delegate void LogEntriesDelegate(List<LogEntry> logEntry);
}
