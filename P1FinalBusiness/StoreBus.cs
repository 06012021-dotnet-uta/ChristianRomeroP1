using P1FinalDbContext;
using P1Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1FinalBusiness
{
    public class StoreBus : IStore
    {
        private readonly P1TestDbContext _context = new P1TestDbContext();//all stores access DBcontext
        public Customer currentcustomer { get; set; }//any given store has a customer shopping at it
        public P1FinalDbContext.Location storechoice;//to store the current store
        public ArrayList arr;

        /// <summary>
        /// This is a method that saves a Customer type to the DB
        /// </summary>
        /// <param name="cm"></param>
        /// <returns></returns>
        public bool saveCustomer(P1Models.Customer cm)
        {
            bool b = false;

            P1FinalDbContext.Customer c = new P1FinalDbContext.Customer()
            {
                //CustomerId = cm.CustomerId,
                Fname = cm.Fname,
                Lname = cm.Lname,
                Username = cm.Username,
                Password = cm.Password,
                Email = cm.Email,

                //finish mapping
            };
            _context.Add(c);
            _context.SaveChanges();
            if (_context.SaveChanges() == 0)
            {
                return b;
            }
            else { b = true; }
            return b;
        }

        /// <summary>
        /// This lists the entire inventory for a store based on the storeid.
        /// </summary>
        /// <param name="storeid"></param>
        /// <returns>Returns a list of a custom model type StoreInvenModel that is passed into the Shop action method.</returns>
        public List<StoreInvenModel> ListStoreInven()
        {
            List<StoreInvenModel> prodinv = new List<StoreInvenModel>();//create new list
                                                        //use join query to join on the storeId (column shared between Products & Store)
            var join = _context.Inventories.Join(_context.Products,
                inv => inv.ProductId,//this determines on what column we are joining the tables
                prod => prod.ProductId,
                (inv, prod) => new StoreInvenModel(//this is the custom type to pass into view 
                    prod.ProductId,
                    prod.Make,
                    prod.Text,
                    prod.Price,
                    inv.StoreId,
                    inv.QuanStore)
            ).AsEnumerable();

            prodinv = join.ToList();//we will just use storeid == 1 to test it out

            return prodinv;
        }

            //using (_context) DOESN'T WORK HOW I WANT
            //{
            //    var joined =
            //        from p in _context.Products
            //        join i in _context.Inventories on p.ProductId equals i.ProductId
            //        select new
            //        {
            //            ProductId = p.ProductId,
            //            Make = p.Make,
            //            Text = p.Text,
            //            Price = p.Price,
            //            StoreId = i.StoreId,
            //            QuanStore = i.QuanStore,
            //        };

            //}
        
        //    //var prodList = context.Products.ToList();


        //    var joinResults = context.Inventories.Join(
        //        context.Products,
        //        invent => invent.ProductId,
        //        prod => prod.ProductId,
        //        (invent, prod) => new InventoryProduct(
        //            prod.ProductId,
        //            prod.ProductName,
        //            prod.Price,
        //            prod.Description,
        //            prod.Category,
        //            invent.LocationId,
        //            invent.NumberProducts)
        //    ).AsEnumerable();

        //    List<InventoryProduct> productList = joinResults.Where(x => x.LocationId == locationId).ToList();

        //    return productList;
        //}








        public P1Models.Location GetLocation(int choice)
        {
            throw new NotImplementedException();
        }

        public List<P1Models.Location> GetLocationsList()
        {
            throw new NotImplementedException();
        }

        public ArrayList ShowStores()
        {
            throw new NotImplementedException();
        }

        public void SpecialDeals()
        {
            throw new NotImplementedException();
        }

        public ArrayList StoreInventory(int favoritechoice)
        {
            throw new NotImplementedException();
        }

        public List<P1Models.Location> StoreView()
        {
            throw new NotImplementedException();
        }
    }
}
