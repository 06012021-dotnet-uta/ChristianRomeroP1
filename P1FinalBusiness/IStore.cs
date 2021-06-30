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
        P1FinalDbContext.Location GetLocation(int storeId);
        List<P1FinalDbContext.Order> AllLocationOrders(int storeId);
        int GetLocationNumber(int storeId);
        List<StoreInvenModel> ListStoreInven();
        List<StoreInvenModel> ListStoreInven(int locnum);

        Cart CreateCart(int locnum, string usn);
        P1FinalDbContext.Order AddOrder();
        //void AddCart();


        //ArrayList ShowStores();
        //ArrayList StoreInventory(int favoritechoice);
        //List<P1Models.Location> GetLocationsList();
        ////P1Models.Location GetLocation(int choice);
        //List<P1Models.Location> StoreView();
        //void SpecialDeals();


    }
}
