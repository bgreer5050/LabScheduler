using LabScheduler2.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.DAL
{
   public class LabContext : DbContext
    {


        public LabContext():base()
        {
           
            //Debug.WriteLine(this.Database.Connection.ConnectionString.ToString());

        }

        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<HourlyEmployee> HourlyEmployees { get; set; }
        public DbSet<Bench> Benches { get; set; }
        //public DbSet<BenchStatus> BenchStatuses { get; set; }

        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<ScheduleBlock> ScheduleBlocks { get; set; }
        //public DbSet<Hour> Hours { get; set; }
    }
}
