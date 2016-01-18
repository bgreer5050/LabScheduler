using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabScheduler2.Domain
{
    public class ScheduleBlock
    {
        public int Id { get; set; }

        public virtual HourlyEmployee Employee { get; set; }
        public virtual Bench Bench { get; set; }

        public virtual DateTime Hour { get; set; }

        public virtual BenchStatus BenchStatus { get; set; }
    }
}
