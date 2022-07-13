using Logger.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Logic.Helper
{
    public class Helper
    {
        public static string ConvertToString(LogEntry logEntry)
        {
            return $"ApplicationID: {logEntry.ApplicationID}, TraceID: {logEntry.TraceID}" +
                $"Severity: {logEntry.Severity.ToString()}, Timestamp: {logEntry.TimeStamp}," +
                $"Message: {logEntry.Message}, ComponentName: {logEntry.ComponentName}, RequestID: {logEntry.RequestID}";
        }
    }
}
