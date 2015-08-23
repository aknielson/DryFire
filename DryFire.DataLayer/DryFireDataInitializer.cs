using DryFire.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryFire.DataLayer
{
    public class DryFireDataInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<DryFireContext>
    {

        protected override void Seed(DryFireContext context)
        {
            var DrillList = new List<Drill> {
                 new Drill
            {
                Name = "Sight Picture Confirmation",
                StartPosition = "Standing in box A, hands naturally at sides",
                Procedure = "Draw and establish an acceptable sight picture on a blank wall (no target).  Finger should end on Trigger.  Do not pull the trigger",
                DrillType = DrillType.DryFire,
                EquipmentKind = PlatformKind.ActualEquipment,
                Equipment = Platform.Pistol,
                SuggestedTimeSpan = new TimeSpan(0, 3, 0)
            },
                 new Drill
            {
                     Name = "10-Yard Index",
                StartPosition = "Standing in box A, hands naturally at sides",
                Procedure = "Draw and establish an acceptable sight picture on the lower A zone of T1.  Do not pull the trigger.",
                DrillType = DrillType.DryFire,
                EquipmentKind = PlatformKind.ActualEquipment,
                Equipment = Platform.Pistol,
                SuggestedTimeSpan = new TimeSpan(0, 3, 0)
            },
                 new Drill
            {
                     Name = "10-Yard Surrender Index",
                StartPosition = "Standing in box A, hands above shoulders",
                Procedure = "Draw and establish an acceptable sight picgture on the lower A-zone of T1.  Do not pull the trigger.",
                DrillType = DrillType.DryFire,
                EquipmentKind = PlatformKind.ActualEquipment,
                Equipment = Platform.Pistol,
                SuggestedTimeSpan = new TimeSpan(0, 3, 0)
            },
                 new Drill
            {
                     Name = "Turn and Draw",
                StartPosition = "Standing in box A, facing up rage away from the target the hands above shoulders",
                Procedure = "Trun, then draw and establish an acceptablde sight picgture on the lower A-zone of T1.  Do not pull the trigger.",
                DrillType = DrillType.DryFire,
                EquipmentKind = PlatformKind.ActualEquipment,
                Equipment = Platform.Pistol,
                SuggestedTimeSpan = new TimeSpan(0, 3, 0)
            },
                 new Drill
            {
                     Name = "Strong Hand Index",                    
                StartPosition = "Standing in box A, hands naturally at sides",
                Procedure = "Draw and establish an acceptable sight picture on the lower A-Zone of T1 with the strong hand only.  Do not pull the trigger.",
                DrillType = DrillType.DryFire,
                EquipmentKind = PlatformKind.ActualEquipment,
                Equipment = Platform.Pistol,
                SuggestedTimeSpan = new TimeSpan(0, 3, 0)
            },
                 new Drill
            {
                     Name ="Weak Hand Index",
                StartPosition = "Standing in box A, hands naturally at sides",
                Procedure = "Draw, transfer gun to weak hand and establish an acceptable sight picture on the lower A-zone of T1 with the weak hand only.  Do not pull the trigger.",
                DrillType = DrillType.DryFire,
                EquipmentKind = PlatformKind.ActualEquipment,
                Equipment = Platform.Pistol,
                SuggestedTimeSpan = new TimeSpan(0, 3, 0)
            },
                 new Drill
            {
                     Name = "Burkett Reloads",
                StartPosition = "Gun on targe in a freestyle position",
                Procedure = "Hit the mag button while bringing a new mag just to the edge of the magwell",
                DrillType = DrillType.DryFire,
                EquipmentKind = PlatformKind.ActualEquipment,
                Equipment = Platform.Pistol,
                SuggestedTimeSpan = new TimeSpan(0, 3, 0)
            },
                 new Drill
            {
                     Name = "6 Reload 6",
                StartPosition = "Standing in box A, hands naturally at sides",
                Procedure = "Engage T1-T3 with two shots only, perform a reload, and then engate T1-T3 with two shots only",
                DrillType = DrillType.DryFire,
                EquipmentKind = PlatformKind.Laser,
                Equipment = Platform.Pistol,
                SuggestedTimeSpan = new TimeSpan(0, 3, 0)
            },
                 new Drill
            {
                     Name = "Surrender 6, Reload 6",
                StartPosition = "Standing in box A, hands naturally at sides",
                Procedure = "Engage T1-T3 with two shots only, perform a reload, and then engate T1-T3 with two shots only",
                DrillType = DrillType.DryFire,
                EquipmentKind = PlatformKind.Laser,
                Equipment = Platform.Pistol,
                SuggestedTimeSpan = new TimeSpan(0, 3, 0)
            },
                 new Drill
            {
                     Name = "El Prez",
                StartPosition = "Facing uprange away from the targets, hands above shoulders.",
                Procedure = "Turn, then draw and engage T1 - T3 with two shots only, perform a reload and engage T1 - T3 with two shots only.",
                DrillType = DrillType.DryFire,
                EquipmentKind = PlatformKind.ActualEquipment,
                Equipment = Platform.Pistol,
                     SuggestedTimeSpan = new TimeSpan(0, 3, 0)
            },
                 new Drill
            {
                     Name = "6 Reload Strong",
                StartPosition = "Standing in box A, hands relaxed at sides.",
                Procedure = "Engage T1 - T3 with two shots only freestyle, perform a relad the engage T1 - T3 with two shots only with just the strong hand.",
                DrillType = DrillType.DryFire,
                EquipmentKind = PlatformKind.ActualEquipment,
                Equipment = Platform.Pistol,
                     SuggestedTimeSpan = new TimeSpan(0, 3, 0)
            },
                 new Drill
            {
                     Name = "6 Reload Weak",
                StartPosition = "Standing in box A, hands relaxed at sides.",
                Procedure = "Engage T1 - T3 with two shots only, perform a reload then engage T1 - T3 with just two shots with the weak hand only.",
                DrillType = DrillType.DryFire,
                EquipmentKind = PlatformKind.ActualEquipment,
                Equipment = Platform.Pistol,
                     SuggestedTimeSpan = new TimeSpan(0, 3, 0)
            },
            };

            foreach (var drill in DrillList)
            {
                context.Drills.Add(drill);
            }
            
            context.SaveChanges();

        }
    }
}
