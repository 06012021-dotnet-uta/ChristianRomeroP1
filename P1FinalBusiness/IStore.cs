using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P1FinalDbContext;
using P1Models;

namespace P1FinalBusiness
{
   public interface IStore
    {

        /*Because this is an interface, we want to put in methods that stores should have:
        Place order for this location
        add new customer favorite location
        search favorite customers
        display all order history for this location
         */

        //Task<bool> NewCustomerAsync(CustomerModel p);
        //Task<List<CustomerModel>> PlayerListAsync();


        bool saveCustomer(P1Models.Customer cm);
        List<StoreInvenModel> ListStoreInven();




        ArrayList ShowStores();
        ArrayList StoreInventory(int favoritechoice);
        List<P1Models.Location> GetLocationsList();
        P1Models.Location GetLocation(int choice);
        List<P1Models.Location> StoreView();
        void SpecialDeals();

        //method to view all stores from DB
        //public static void StoreView()
        //
        //   using (var context = new context.P0DbContext())
        //   {
        //
        //       List<context.Location> storelist = context.Locations.Where(l => l.StoreId >= 0).ToList();
        //
        //       //forreach loop to print out the values (if you just write consolewriteline you get memory address)
        //       foreach (var store in storelist)
        //       {
        //           Console.WriteLine($"{store.StoreId}. {store.City}, {store.State}");
        //       }
        //
        //   }
        //
    }
}
