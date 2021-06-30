using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P1FinalBusiness;
using P1FinalDbContext;

namespace P1Final.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStore s;
        

        public StoreController(IStore store)
        {
            this.s = store;
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

        public IActionResult Register()
        {
            return View();
        }


        //POST: StoreController/RegisterNewCustomer
        public IActionResult RegisterNewCustomer(P1Models.Customer cm)
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("RegisterNewCustomer");
                ViewBag.message = "There was an issue.";
            }
           
            //s.RegisterCustomerAsync();

            // mapp the values unputted by thre user to teh custoemr model from EF/


            //1. create a method in your business layer that will do the below action
            //check
            s.saveCustomer(cm);

            // 2. get some type of confirmation back.. like T/F
            //check

            // 3. render the start page for creating an order.
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
            //if c is in the customers table, then return login succ view
            if (!ModelState.IsValid)
            {
                RedirectToAction("ErrLogin");
            }
            return View("StoreList");
        }

        //GET: StoreController/StoreList()
        public IActionResult StoreList()
        {
            P1TestDbContext _context = new P1TestDbContext();
            List<Location> locs = _context.Locations.ToList<Location>();
            return View(locs);
        }

        //GET: StoreController/StoreList()
        public IActionResult StoreOrderHistory()
        {
            P1TestDbContext _context = new P1TestDbContext();
            List<Order> locord = _context.Orders.ToList();//.Where(x => x.StoreId >= 1)
            return View(locord);
        }


        public IActionResult Shop(P1Models.StoreInvenModel sim)
        {
            //P1TestDbContext _context = new P1TestDbContext();
            //List<Product> l = _context.Products.Where(x => x.ProductId <= 1089).ToList();
            s.ListStoreInven();
            return View();
        }

        public IActionResult Checkout(P1Models.Cart cart)//takes in an object type of cart
        {
            return View(cart);
        }


















        public IActionResult PrintStoresArray()
        {
            s.ShowStores();
            //ViewBag.ArrayStore = s.arr;
            return View();
        }

        public IActionResult PrintAllStores()
        {
            //List<Location> l = _context.Locations.ToList();
            return View();
        }

        public IActionResult PrintAllStoresModel()
        {
            //List<Location> l = _context.Locations.ToList();
            return View();
        }

        // GET: StoreController/StoreList/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StoreInven(int location)
        {
            //List<P1FinalDbContext.Location> l = _context.Locations.ToList();
            return View();
        }

        //GET: StoreController/ViewCart
        public ActionResult test()
        {
            //List<P1FinalDbContext.Location> l = _context.Locations.ToList();
            return View();
        }

        /// <summary>
        /// This is an interface that implements a View of StoreList & allows users to view all stores
        /// </summary>
        /// <returns>Returns a view of all stores</returns>
        public IActionResult Details()
        {
            return View();
        }


        /// <summary>
        /// This is an action method to buy items and add to a cart.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /*public ActionResult Buy(string id)
        {
            ProductModel productModel = new ProductModel();
            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Product = productModel.find(id), Quantity = 1 });
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Product = productModel.find(id), Quantity = 1 });
                }
                Session["cart"] = cart;
            }
            return RedirectToAction("Index");
        }
        */
    }
}
