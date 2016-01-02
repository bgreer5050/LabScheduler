using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabScheduler2.Domain
{
    public class ScheduleBlock
    {
        public virtual HourlyEmployee Employee { get; set; }
        public virtual Bench Bench { get; set; }

        public virtual Hour Hour { get; set; }
    }
}
