using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Models
{
    public class ShopCartModel
    {

        public ShopCartModel()
        { }

        public ShopCartModel(int prodId, string make, string text, decimal price, int storeId, int quan)
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

        //customprops
        public string Make { get; set; }
        public string Text { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<StoreInvenModel> StoreInvenModels { get; set; }
    }//eoc
}//eon
