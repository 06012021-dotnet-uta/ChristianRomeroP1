using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Models
{
   public class AccountModel //this model represents existing account data for a customer
    {
        //methods to query data for each form

         void VerifyUser()
        {
            //use db context

            //query the data
            
            //
        }


        [Required]
        protected string _username; // this states a property
        [Required(ErrorMessage = "This property is required")] //these annotations state constraints that would normally exist in SQL
        [MaxLength(50)]
        [Display(Name = "Username")]
        public string Username
        {
            get { return _username; }
            set
            {
                if (value.Length >= 1 && value.Length <= 50)
                {
                    _username = value;//we can adjust the setter method for a property according to the DB constraints we would have/want
                }//will be using this template for the next sections
            }
        }


        //public string Member { get; set; } Will probably need separate view for credit card info

        //insert refined customer methods from P0



        protected string _password;

        [Required(ErrorMessage = "Password must have length greater than 10 and less than 50.")]
        [MaxLength(100)]
        [MinLength(10)]
        [Display(Name = "Password")]
        public string Password
        {
            get { return _password; }
            set
            {
                if ( value.Length <= 100)
                {
                    _password = value;
                }
            }
        }



    }//eoc
}//eon
