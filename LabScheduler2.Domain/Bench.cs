using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabScheduler2.Domain
{
    public class Bench
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public virtual List<Qualification> Qualifications { get; set; }

        public string Description2 { get; set; }
        public string Description5 { get; set; }



    }
}
