using ColleagueManagement_MVC.Models;
using ColleagueManagement_MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColleagueManagement_MVC.Controllers
{
    public class ColleagueController : Controller
    {
        private readonly IColleague db;
        public ColleagueController(IColleague db)       //need to use autofac for dependecy
        {
            this.db = db;
        }
        

        [HttpGet]
        public ActionResult AddNewColleague()
        {
            ColleagueDbContext obj = new ColleagueDbContext();
            List<Address> _addresses = (from s in obj.Addresses
                                        select s).ToList();
            ViewBag.AddressId = new SelectList(_addresses, "AddressId", "AddressId");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult AddNewColleague(Colleague colleague)
        {
            
            colleague.created = DateTime.Now;

            if(ModelState.IsValid)
            {
                db.Add(colleague);
                TempData["Message"] = "You have created the Colleague!";
                return RedirectToAction("GetColleague", new { id = colleague.ColleagueId });
            }
            
            return View();
        }

        //Get All colleagues
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        //Get Colleague by id
        public ActionResult GetColleague(int id)
        {
            var model = db.Get(id);
            return View(model);
        }

        //edit colleague
        [HttpGet]
        public ActionResult EditColleague(int id)
        {
            
            var model = db.Get(id);
            model.created = DateTime.Now;
            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditColleague(Colleague colleague)
        {
            if(ModelState.IsValid)
            {
                db.editCol(colleague);
                TempData["Message"] = "You have edited the Colleague!";
                return RedirectToAction("Index", new { id = colleague.ColleagueId });
            }
            return View(colleague);
        }

        
        [HttpGet]
        public ActionResult DeleteColleague(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteColleague(int id, FormCollection form)
        {
            db.DeleteCol(id);
            return RedirectToAction("Index");
        }


    }
}