using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Models
{
    public class Cart
    {
        public Cart()
        {

        }

        public Cart(int ProductId, string make, decimal Price, string Description, int LocationId, int NumberProducts)
        {
            this.ProductId = ProductId;
            this.Make = Make;
            this.Price = Price;

        }

        public int ProductId { get; set; }
        public string Make { get; set; }
        public string Text { get; set; }
        public decimal Price { get; set; }


    }//eoc
}//eon
