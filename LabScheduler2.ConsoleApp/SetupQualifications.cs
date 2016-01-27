using LabManager.DAL;
using LabScheduler2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabScheduler2.ConsoleApp
{
    public static class SetupQualifications
    {

        public static void Execute()
        {
            LabContext db = new LabContext();

            List<Qualification> qualifications = db.Qualifications.ToList();
            db.Qualifications.RemoveRange(qualifications);
            db.SaveChanges();

            foreach (Bench _bench in db.Benches.ToList())
            {

                Console.WriteLine(_bench.Description);

                if (_bench.Description.Contains("Sysmex") == true)
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

                if (_bench.Description == "IFOB")
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

                if (_bench.Description == "VIT D")
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
            db.Dispose();
        }
    }
}
