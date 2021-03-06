﻿using LabScheduler2.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabScheduler2.Data
{
    public  class LabContext : DbContext
    {
        public LabContext()
        {

        }

        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<HourlyEmployee> HourlyEmployees { get; set; }
        public DbSet<Bench> Benches { get; set; }
        //public DbSet<BenchStatus> BenchStatuses { get; set; }

        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Hour> Hours { get; set; }

        public DbSet<ScheduleBlock> ScheduleBlocks { get; set; }
        
    }

    
}
