using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Models
{
    public class Item
    {
        [Required(ErrorMessage ="This field is required")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Make { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Quantity { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public decimal Price { get; set; }
        
    }
}
