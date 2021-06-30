using Microsoft.AspNetCore.Mvc;
using P1FinalDbContext;
using P1FinalBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1Final.Controllers
{
    public class CustomerController : Controller
    {
        private readonly P1TestDbContext _context;
        private readonly ICustomer c;
        public CustomerController(P1TestDbContext context, ICustomer c)
        {
            _context = context;
            this.c = c;
        }

        //GET: Customer/Login
        [HttpGet]
        public IActionResult LoginCustomer()//make sure controller input == business layer input
        {
            return View();
        }

        //POST: Customer/Login
        [HttpPost]
        public IActionResult LoginCustomer(P1Models.Customer cm)//make sure controller input == business layer input
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("LoginCustomer");
                ViewBag.message = "There was an issue.";
            }
            string usn = cm.Username;
            string pwd = cm.Password;
            c.Login(usn, pwd);
            return View("LoginSucc");
        }

        //POST: Customer/Login
        public IActionResult LoginSucc(P1Models.Customer cm)//make sure controller input == business layer input
        {
            string usn = cm.Username;
            string pwd = cm.Password;
            c.Login(usn, pwd);
            return View("LoginSucc");
        }

        //GET: Customer/PrintAllCustomers
        public IActionResult PrintAllCustomers()
        {
            List<P1FinalDbContext.Customer> c = _context.Customers.ToList();
            return View(c);
        }


        //use a GET method to dynamically change customerid
        //GET: Customer/PrintCustomerOrder
        public IActionResult OrderHistoryCustomer( )//parameter of int customerid
        {
            List<Order> o = _context.Orders.Where(x => x.CustomerId >=0 ).ToList();//throwing exception because no orders exist
            return View(o);
        }

        public IActionResult OrderHistoryStore()//parameter of int storeid - create the view
        {
            List<Order> o = _context.Orders.Where(x => x.StoreId >= 0).ToList();//throwing exception because no orders exist
            return View(o);
        }

    }//eoc
}//eon
