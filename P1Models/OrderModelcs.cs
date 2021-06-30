using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Models
{
   public class OrderModelcs  //add foreignkeys
    {
        private ArrayList orderGoods = new ArrayList();

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public int CustomerId { get; set; }
        public int QuanOrder { get; set; }
        public DateTime DateOrder { get; set; }



        //constructor



        /// <summary>
        /// Retrieves items in the order
        /// </summary>
        /// <returns>Items in order</returns>
       /* public ArrayList getOrder()
        {
            return products;
        }
       */

        /// <summary>
        /// Gets the total of all the items in the inventory
        /// </summary>
        /// <returns>Total cost</returns>
                /*
                 public double getTotal()
                 {
                     double all = 0;
                     foreach (Inventory i in products)
                     {
                         all += (i.price * i.quantity);
                     }
                     return all;
                 }
                */

        }//eoc
}//eon
