using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DryFire.DomainClasses;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DryFire.DataLayer
{
    public class DryFireContext : DbContext
    {
        public DryFireContext() : base("DryFireContext")
        {
        }

        public DbSet<Drill> Drills { get; set; }
        public DbSet<LogEntry> LogEntries { get; set; }
    }
}
