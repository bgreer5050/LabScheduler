using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabScheduler2.Web.Controllers
{
    public class ScheduleController : Controller
    {
        // GET: Schedule
        public ActionResult Index()
        {
            LabManager.DAL.LabContext db = new LabManager.DAL.LabContext();

            List<Domain.ScheduleBlock> Blocks = db.ScheduleBlocks.Take(1500).ToList();
            foreach(Domain.ScheduleBlock block in Blocks)
            {
                
            }

            return View(Blocks);
        }

        public ActionResult Today()
        {
            LabManager.DAL.LabContext db = new LabManager.DAL.LabContext();
            int intMonth = DateTime.Today.Month;
            int intDay = DateTime.Today.Day;
            int intYear = DateTime.Today.Year;

            List<Domain.ScheduleBlock> Blocks = db.ScheduleBlocks.Where(c=>c.Hour.Day== intDay && c.Hour.Month == intMonth && c.Hour.Year == intYear).ToList();
            foreach (Domain.ScheduleBlock block in Blocks)
            {

            }

            return View("Index",Blocks);
        }



        public void ScheduleTony()
        {

        }

        // GET: Schedule/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Schedule/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Schedule/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Schedule/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Schedule/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Schedule/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Schedule/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
