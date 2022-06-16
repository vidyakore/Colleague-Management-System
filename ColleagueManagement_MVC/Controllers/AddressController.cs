using ColleagueManagement_MVC.Models;
using ColleagueManagement_MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColleagueManagement_MVC.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddress db;

        public AddressController(IAddress db)
        {
            this.db = db;
        }

        [HttpGet]
        public ActionResult AddNewAddress()
        {
            //var tupleModel = new Tuple<List<Colleague>, List<Address>>();
            ColleagueDbContext db = new ColleagueDbContext();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult AddNewAddress(Address address)
        {
            address.Created = DateTime.Now;

            if (ModelState.IsValid)
            {
                db.Add(address);
                TempData["Message"] = "You have created the Address!";
                return RedirectToAction("GetAddress", new { id = address.AddressId });
            }

            return View();
        }

        // GET: all Addresses
        public ActionResult Index()
        {
            var model = db.GetAll();

            return View(model);
        }

        public ActionResult GetAddress(int id)
        {
            var model = db.Get(id);
            return View(model);
        }
    }
}