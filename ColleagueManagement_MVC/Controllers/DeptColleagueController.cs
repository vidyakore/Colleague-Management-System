using ColleagueManagement_MVC.Models;
using ColleagueManagement_MVC.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColleagueManagement_MVC.Controllers
{
    public class DeptColleagueController : Controller
    {
        private IDeptColleague db;
        


        // GET: DeptColleague
        public DeptColleagueController(IDeptColleague db)
        {
            this.db = db;
        }

        [HttpGet]
        public ActionResult AddDeptColleague()
        {
            //ColleagueDbContext db = new ColleagueDbContext();
            //return View();

            //changed
            ColleagueDbContext db = new ColleagueDbContext();
            List<Colleague> _colleagues = (from s in db.Colleagues
                                           select s).ToList();
            List<Department> _departments = (from s in db.Departments
                                           select s).ToList();
            ViewBag.ColleagueId = new SelectList(_colleagues, "ColleagueId", "ColleagueName");
            ViewBag.DepartmentId = new SelectList(_departments, "DepartmentId", "DepartmentName");
            var model = new DeptColleague();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult AddDeptColleague(DeptColleague dept )
        {
            
            if (ModelState.IsValid)
            {
                db.Add(dept);
                TempData["Message"] = "You have created the relation for colleague and department!";
                return RedirectToAction("Index","Colleague");
            }

            return View();
        }
    }
}