using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabScheduler2.Domain
{
    public class Hour
    {
        public int Id { get; set; }
        //public long Start { get; set; }
       //BenchStatus//public long End { get; set; }
        public DateTime Time { get; set; }
        public int HourNo { get; set; }
        public int Year { get; set; }
        public List<BenchStatus> BenchStatuses { get; set; }

    }
}
