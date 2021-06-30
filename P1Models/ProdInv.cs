using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Models
{
    public class ProdInv
    {
        public ProdInv()
        { }

        public ProdInv(int prodId, string make, string text, decimal price, int storeId, int quan)
        {
            this.StoreId = storeId;
            this.ProductId = prodId;
            this.Make = make;
            this.Text = text;
            this.Price = price;
            this.QuanStore = quan;
        }



        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int QuanStore { get; set; }
        public string Make { get; set; }
        public string Text { get; set; }
        public decimal Price { get; set; }
    }
}
