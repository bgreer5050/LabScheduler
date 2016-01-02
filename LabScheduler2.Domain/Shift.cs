using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabScheduler2.Domain
{
    public class Shift
    {
        public int Id { get; set; }
        public long StartTime { get; set; }
        public long EndTime { get; set; }
    }
}
