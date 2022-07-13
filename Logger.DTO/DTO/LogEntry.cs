using Logger.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Data.DTO
{
    /// <summary>
    /// The log entry DTO.
    /// </summary>
    public class LogEntry
    {
        [Required]
        [MaxLength(100)]
        public string ApplicationID { get; set; }

        [Required]
        [MaxLength(50)]
        public string TraceID { get; set; }

        [Required]
        public Severity Severity { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }

        [MaxLength(255)]
        public string Message { get; set; }

        [MaxLength(50)]
        public string? ComponentName { get; set; }

        [MaxLength(50)]
        public string? RequestID { get; set; }
    }
}
