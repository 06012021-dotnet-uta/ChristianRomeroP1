using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Models
{
    class ShopCartModel
    {
        [Required]
        public int CartId { get; set; }
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public ShopCartModel(int userId)
        {
            // this.CartId = cartId;
            this.CustomerId = userId;
        }
    }//eoc
}//eon
