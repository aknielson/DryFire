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
        public  virtual Drill DrillExcercise { get; set; }
        public int DrillGoalParTime { get; set; }
        public TimeSpan DrillTimeSpan { get; set; }
        public int DrillReps { get; set; }
        public virtual LogEntry PreviousLogEntry { get; set; }

        public Platform EquipmentUsed { get; set; }

        public PlatformKind EquipmentKind { get; set; }
    }
}
