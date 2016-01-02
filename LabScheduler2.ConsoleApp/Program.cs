using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabScheduler2.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            LabManager.DAL.LabContext db = new LabManager.DAL.LabContext();


            foreach (Domain.Supervisor sup in db.Supervisors.ToList())
            {
                Console.WriteLine(sup.FirstName);
            }

            LabScheduler2.Domain.Supervisor super = new Domain.Supervisor();
            super.FirstName = "Mindy";
            super.LastName = "Greer";
            super.IsActive = "Y";



            db.Supervisors.Add(super);
            db.SaveChanges();
            int x = db.SaveChanges();
            Console.WriteLine(x.ToString());
            Console.ReadLine();
        }
    }
}
