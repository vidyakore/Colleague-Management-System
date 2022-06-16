using ColleagueManagement_MVC.Models;
using ColleagueManagement_MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColleagueManagement_MVC.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartment db;

        public DepartmentController(IDepartment db)
        {
            this.db = db;
        }
        // GET: Department
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult AddNewDepartment()
        {
            //var tupleModel = new Tuple<List<Colleague>, List<Address>>();
            ColleagueDbContext db = new ColleagueDbContext();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult AddNewDepartment(Department department)
        {
            department.Created = DateTime.Now;

            if (ModelState.IsValid)
            {
                db.Add(department);
                TempData["Message"] = "You have created the Department!";
                return RedirectToAction("GetDepartment", new { id = department.DepartmentId });
            }

            return View();
        }

        public ActionResult GetDepartment(int id)
        {
            var model = db.Get(id);
            return View(model);
        }
    }
}