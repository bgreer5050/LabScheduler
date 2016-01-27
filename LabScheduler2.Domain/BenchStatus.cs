using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabScheduler2.Domain
{
   
   public class BenchStatus
    {
        public int Id { get; set; }
        public Employee employee { get; set; }
        public int StatusCode { get; set; }
    }

   
}
