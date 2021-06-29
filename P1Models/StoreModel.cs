using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Models
{
    public class StoreModel
    {

        [Required] //this annotation makes it required when entering this type of information
        [Key]
        public int StoreId { get; set; }

        protected string _city; 

        [Required(ErrorMessage = "City must be no greater than 30 characters")] 
        [MaxLength(30)]
        [Display(Name = "City")]
        public string City
        {
            get { return _city; }
            set
            {
                if (value.Length <= 30)
                {
                    _city = value;
                }
            }
        }


        protected string _state; 

        [Required(ErrorMessage = "State must be no greater than 20 characters")] 
        [MaxLength(20)]
        [Display(Name = "State")]
        public string State
        {
            get { return _state; }
            set
            {
                if (value.Length <= 20)
                {
                    _state = value;
                }
            }
        }


        protected string _address; 
        [Required(ErrorMessage = "Address must be no greater than 100 characters")] 
        [MaxLength(100)]
        [Display(Name = "Address")]
        public string Address
        {
            get { return _address; }
            set
            {
                if (value.Length <= 100)
                {
                    _address = value;
                }
            }
        }


        protected string _phone;

        [Required(ErrorMessage = "Phone length should be exactly 10 characters")]
        [MaxLength(10)]
        [Display(Name = "Phone")]
        public string Phone
        {
            get { return _phone; }
            set
            {
                if (value.Length == 10)
                {
                    _phone = value;
                }
            }
        }


        public StoreModel() { }



        public StoreModel(string city, string state, string address, string phone)
        {
            this._city = city;
            this._state = state;
            this._address = address;
            this._phone = phone;
        }

        //Stores have a list of 
    }//eoc
}//eon
