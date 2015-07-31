using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DryFire.DomainClasses
{
    public class LogEntry
    {
        public int LogEntryId { get; set; }
        public DateTime DrillRunDate { get; set; }
        public Drill DrillExcercise { get; set; }
        public TimeSpan DrillGoalParTime { get; set; }
        public TimeSpan DrillTimeSpan { get; set; }
        public int DrillReps { get; set; }
        public LogEntry PreviousLogEntry { get; set; }

        public Equipment EquipmentUsed { get; set; }
    }
}
