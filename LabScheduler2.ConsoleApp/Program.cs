using LabScheduler2.Domain;
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
            LabScheduler2.BLL.LabRepository repo = new BLL.LabRepository(db);

            List<Qualification> qualifications = new List<Qualification>();
            

            

            foreach(Bench _bench in db.Benches.ToList())
            {

                Console.WriteLine(_bench.Description);

                if (_bench.Description.Contains("Sysmex")==true)
                {
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Imelda").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Maribeth").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Marita").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Violeta").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Wilberto").FirstOrDefault(), Status = QualificationStatus.Qualified });


                    db.SaveChanges();
                }

                if (_bench.Description == "Diffs")
                {
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Imelda").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Jan").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Maribeth").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Marita").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Violeta").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Wilberto").FirstOrDefault(), Status = QualificationStatus.Qualified });

                }

                if (_bench.Description == "Variant")
                {

                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Evelyn").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Jan").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Maribeth").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Marita").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Michelle").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Nirali").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Violeta").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Wilberto").FirstOrDefault(), Status = QualificationStatus.Qualified });


                }
                if (_bench.Description == "Coag")
                {
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Imelda").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Jan").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Maribeth").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Marita").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Michelle").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Nirali").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Violeta").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Wilberto").FirstOrDefault(), Status = QualificationStatus.Qualified });

                }

                if (_bench.Description == "ESR")
                {
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Evelyn").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Imelda").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Jan").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Maribeth").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Marita").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Michelle").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Nirali").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Violeta").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Wilberto").FirstOrDefault(), Status = QualificationStatus.Qualified });

                }

                if (_bench.Description == "Centaur")
                {
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Imelda").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Jan").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Marita").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Nirali").FirstOrDefault(), Status = QualificationStatus.Qualified });

                }

                if (_bench.Description == "UA")
                {
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Evelyn").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Imelda").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Marita").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Violeta").FirstOrDefault(), Status = QualificationStatus.Qualified });

                }

                if (_bench.Description == "Sypigg")
                {
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Maribeth").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Marita").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Michelle").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Nirali").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Wilberto").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Violeta").FirstOrDefault(), Status = QualificationStatus.Qualified });

                }

                if (_bench.Description == "Ifobb")
                {
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Imelda").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Marita").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Michelle").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Violeta").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Wilberto").FirstOrDefault(), Status = QualificationStatus.Qualified });

                }

                if (_bench.Description == "Vista")
                {
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Jerry").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Marita").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Tony").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Violeta").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Wilberto").FirstOrDefault(), Status = QualificationStatus.Qualified });


                }

                if (_bench.Description == "Vit D")
                {
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Evelyn").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Imelda").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Jan").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Maribeth").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Marita").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Michelle").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Nirali").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Violeta").FirstOrDefault(), Status = QualificationStatus.Qualified });
                    _bench.Qualifications.Add(new Qualification { bench = _bench, employee = db.HourlyEmployees.Where(c => c.FirstName == "Wilberto").FirstOrDefault(), Status = QualificationStatus.Qualified });


                }


            }


            db.SaveChanges();

            throw new NotImplementedException();

            List<ScheduleBlock> blocks =  repo.GetAllScheduleBlocks().ToList();

            foreach(ScheduleBlock b in blocks)
            {
                Console.WriteLine(b.Bench.Description);
                Console.WriteLine(b.Hour.ToLongDateString());
                Console.ReadLine();
            }

            Console.ReadLine();

            //int counter = db.ScheduleBlocks.Where(c => c.Hour.Year != 2016).Count();

            //for (int i = 0; i < 100; i++)
            //{
            //    foreach (ScheduleBlock block in db.ScheduleBlocks.Where(c => c.Hour.Year != 2016).Take(5000))
            //    {

            //        if (block.Hour.Year != 2016)
            //        {
            //            int adj = block.Hour.Year - 2016;
            //            adj = adj * -1;
            //            block.Hour = block.Hour.AddYears(adj);
            //            Console.WriteLine(counter);
            //            counter -= 1;
            //        }

            //    }
            //    db.SaveChanges(); 
            //}



            //Console.WriteLine("DONE");
            //Console.ReadLine();



            //throw new NotImplementedException();

            //DateTime dt = new DateTime(2016, 1, 1,0,0,0);

            //Console.WriteLine(dt.TimeOfDay.ToString());
            //foreach (Bench bench in db.Benches.Where(c=>c.Id > 44).OrderBy(c=>c.Id).ToList())
            //{
            //    for (var v = 1; v < 8761; v++)
            //    {

            //        Console.WriteLine(dt.Day.ToString());
            //        Console.WriteLine(dt.Month.ToString());
            //        Console.WriteLine(dt.Year.ToString());
            //        Console.WriteLine(dt.Hour.ToString());
            //        // Console.WriteLine(dt.Date.Date.ToLongTimeString());
            //        Console.WriteLine(bench.Description);

            //        ScheduleBlock block = new ScheduleBlock();
            //        block.Bench = bench;
            //        block.Hour = dt;

            //        db.ScheduleBlocks.Add(block);

            //        dt = dt.AddHours(1.0);
            //    }
            //    Console.WriteLine(db.SaveChanges().ToString());
            //}
            //Console.WriteLine("DONE");
            //Console.ReadLine();


            // Console.WriteLine(dt.Date.Date.ToString());

            //foreach (Bench bench in db.Benches.ToList())
            //{
            //    for (var i = 0; i < 366; i++)
            //    {
            //        for (var y = 1; y < 25; y++)
            //        {
            //            ScheduleBlock block = new ScheduleBlock();
            //           // block.Hour.Start = dt.
            //        }
            //    }
            //}


            //int x = db.SaveChanges();
            //Console.WriteLine(x.ToString());
            //Console.ReadLine();
        }
    }
}
