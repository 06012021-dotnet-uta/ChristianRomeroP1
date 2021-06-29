using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P1FinalBusiness;
using P1Models;
using P1FinalDbContext;

namespace P1Final.Controllers
{
    public class StoreController : Controller
    {
        //private readonly Store st = new Store();
        private readonly P1TestDbContext _context;
        public StoreController(P1TestDbContext context)
        {
            _context = context;
            
        }

        // GET: StoreController
        public ActionResult Index()
        {
            return View();
        }

        //GET: StoreController/LoginStore
        public IActionResult Register2()
        {
            return View();
        }

        //POST: StoreController/LoginStore
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register2(P1FinalDbContext.Customer cm)
        {
            _context.Add(cm);
            _context.SaveChanges();
            if (!ModelState.IsValid)
                {
                    RedirectToAction("Create");
                ViewBag.message = "There was an issue.";
            }
            ViewBag.message = "You have successfully created a new account.";
            return View();
        }

        //GET: StoreController/Login
        public ActionResult Login()
        {
            return View();
        }
        //POST: StoreController/Login
        public ActionResult Login(string usn, string pwd)
        {
            var c= _context.Customers.Where(x => x.Username == usn && x.Password == pwd).ToList();
            //if c is in the customers table, then return login succ view
            if (!ModelState.IsValid)
            {
                RedirectToAction("ErrLogin");
            }
            return View("LoginSuccessful");
        }

        // GET: StoreController/StoreList/
        public ActionResult StoreList()
        {
            List<P1FinalDbContext.Location> l = _context.Locations.ToList();
            return View(l);
        }

        // GET: StoreController/StoreList/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StoreInven(int location)
        {
            List<P1FinalDbContext.Location> l = _context.Locations.ToList();
            return View(l);
        }


        /// <summary>
        /// This is an interface that implements a View of StoreList & allows users to view all stores
        /// </summary>
        /// <returns>Returns a view of all stores</returns>
        public IActionResult Details()
        {
            return View("StoreList");
        }


    }//eoc
}//eon
