using Microsoft.AspNetCore.Mvc;
using P1FinalDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1Final.Controllers
{
    public class CustomerController : Controller
    {
        private readonly P1TestDbContext _context;

        public CustomerController(P1TestDbContext context)
        {
            _context = context;
        }

        //GET: Customer/PrintAllCustomers
        public IActionResult PrintAllCustomers()
        {
            List<Customer> c = _context.Customers.ToList();
            return View(c);
        }

        //use a GET method to dynamically change customerid
        //GET: Customer/PrintCustomerOrder
        public IActionResult PrintCustomerOrder(int customerid)
        {
            List<Order> o = _context.Orders.Where(x => x.CustomerId == customerid).ToList();
            return View(o);
        }

    }//eoc
}//eon
