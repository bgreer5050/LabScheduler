using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabScheduler2.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }

        public string IsActive { get; set; }
    }

    public class Supervisor : Employee
    {
        public ICollection<HourlyEmployee> HourlyEmployees { get; set; }
    }

    public class HourlyEmployee :Employee
    {
        public decimal HoursPerWeek { get; set; }

        
    }

}
