using LabScheduler2.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabScheduler2.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            SetupQualifications.Execute();
            LabManager.DAL.LabContext db = new LabManager.DAL.LabContext();

            List<Qualification> qualifications = db.Qualifications.ToList();


            foreach (Qualification q in db.Qualifications.ToList())
            {
                Console.WriteLine(q.employee.FirstName);
                Console.WriteLine(q.bench.Description);
                //Console.ReadLine();
            }


            DateTime dtStart = new DateTime(2016, 1, 1, 0, 0, 0);
            int intHourCounter = 1;

           while(dtStart.DayOfYear < 3)
            {
                Hour hour = new Hour();
                
                List<BenchStatus> benchStatuses = new List<BenchStatus>();

                foreach(Bench bench in db.Benches.ToList())
                {
                    BenchStatus status = new BenchStatus { StatusCode = 1 };
                    benchStatuses.Add(status);
                   
                }
                
                db.Hours.Add(hour);


                dtStart = dtStart.AddHours(1);
                Console.WriteLine(dtStart.Date.ToLongDateString());

                intHourCounter += 1;
               
            }
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
