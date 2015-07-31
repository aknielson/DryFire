using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DryFire.DomainClasses
{
    public class Drill
    {
        public int DrillId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public byte[] Diagram { get; set; }

        //pistol, shotgun, rifle
        public Equipment Equipment { get; set; }

        public DrillType DrillType { get; set; }

        public TimeSpan SuggestedTimeSpan { get; set; }
        public UInt16 SuggestedReps { get; set; }
    }

   
}
