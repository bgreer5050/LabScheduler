using LabManager.DAL;
using LabScheduler2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabScheduler2.BLL
{
    public  class LabRepository
    {
        private LabContext _context;

        public LabRepository(LabContext context)
        {
            _context = context;
        }

        public IEnumerable<Bench> GetAllBenches()
        {
            return _context.Benches.ToList();
        }

        public IEnumerable<Bench> GetAllBenchesWiithStatuses()
        {
            return _context.Benches.Include("Status").ToList();
        }

        public IEnumerable<Employee> GetAllHourlyEmployees()
        {
            return _context.HourlyEmployees.ToList();
        }

        public IEnumerable<Qualification> GetAllQualifications()
        {
            return _context.Qualifications.ToList();
        }

        //public IEnumerable<ScheduleBlock> GetAllScheduleBlocks()
        //{
        //    return _context.ScheduleBlocks.ToList();
        //}

        public IEnumerable<Shift> GetAllShifts()
        {
            return _context.Shifts.ToList();
        }
    }
}
