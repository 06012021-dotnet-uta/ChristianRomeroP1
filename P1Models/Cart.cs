using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Models
{
    public class Cart
    {
        public List<Item> Items;
        public int CustomerId { get; set; }
        public DateTime DateOrder { get; set; }
        public Cart( List<Item> items)
        {
            this.Items = items;
        }

        public Cart(List<Item> items, int custid, DateTime dt )
        {

        }

        public Cart()
        {

        }
    }//eoc
}//eon
