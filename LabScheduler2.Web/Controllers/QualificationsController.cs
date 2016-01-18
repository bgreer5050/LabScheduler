using LabScheduler2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabScheduler2.Web.Controllers
{
    public class QualificationsController : Controller
    {
        // GET: Qualifications
        public ActionResult Index()
        {
            LabManager.DAL.LabContext db = new LabManager.DAL.LabContext();
            LabScheduler2.BLL.LabRepository repo = new BLL.LabRepository(db);
            List<LabScheduler2.Web.Models.QualificationsListViewModel> vm = new List<Models.QualificationsListViewModel>();

            foreach(Bench _bench in repo.GetAllBenches())
            {
                vm.Add(new Models.QualificationsListViewModel { bench = _bench, qualifications = _bench.Qualifications });
            }

            return View(vm);
        }

        // GET: Qualifications/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Qualifications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Qualifications/Create
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

        // GET: Qualifications/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Qualifications/Edit/5
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

        // GET: Qualifications/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Qualifications/Delete/5
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
