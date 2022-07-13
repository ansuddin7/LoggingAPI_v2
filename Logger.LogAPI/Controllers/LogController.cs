using Logger.Data.DTO;
using Logger.Logic.LogHandler;
using Microsoft.AspNetCore.Mvc;

namespace Logger.API.Controllers
{
    /// <summary>
    /// Logging API that supports bulk logging and single entry logging.
    /// </summary>
    [Route("api/log")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly ILogHandler _logHandler;
        
        public LogController(ILogHandler logHandler)
        {
            _logHandler = logHandler;
        }

        /// <summary>
        /// Add a single log entry
        /// </summary>
        /// <param name="logEntry"></param>
        /// <response code="204">The request was successful</response>
        [HttpPost]
        public ActionResult AddLogEntry(LogEntry logEntry)
        {
            _logHandler.AddEntry(logEntry);
            return NoContent();
        }

        /// <summary>
        /// Log multiple entries
        /// </summary>
        /// <param name="logEntries"></param>
        /// <response code="204">The request was successful</response>
        [HttpPost("bulk")]
        public ActionResult AddLogEntries(List<LogEntry> logEntries)
        {
            _logHandler.AddEntries(logEntries);
            return NoContent();
        }
    }
}
