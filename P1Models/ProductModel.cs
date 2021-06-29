using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Models
{
    class ProductModel
    {
        [Required] //this annotation makes it required when entering this type of information
        [Key]
        public int ProductId { get; set; }

        protected string _make; 

        [Required(ErrorMessage = "This property is required")] 
        [MaxLength(40)]
        [Display(Name = "Make")]
        public string Make
        {
            get { return _make; }
            set
            {
                if (value.Length >= 1 && value.Length <= 30)
                {
                    _make = value;
                }
            }
        }


        protected string _text; 

        [Required(ErrorMessage = "This property is required")] 
        [MaxLength(250)]
        [Display(Name = "Description")]
        public string Text
        {
            get { return _text; }
            set
            {
                if (value.Length <= 250)
                {
                    _text = value;
                }
            }
        }


        protected int _price;
        [Required(ErrorMessage = "This property is required")] 
        [Display(Name = "Price")]

        public int Price
        {
            get { return _price; }
            set
            {
                if(value > 00.00)
                {
                    _price = value;
                }
            }
        }


    }//eoc
}//eon
