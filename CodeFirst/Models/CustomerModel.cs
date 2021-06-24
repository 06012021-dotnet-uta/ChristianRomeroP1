using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CustomerModel
    {
        //key for DB
        [Key]
        public int CustomerId { get; set; }

        protected string _fname; // this states a property

        [Required(ErrorMessage = "This property is required")] //these annotations state constraints that would normally exist in SQL
        [MaxLength(50)]
        [Display(Name = "First Name")]
        public string Fname
        {
            get { return _fname; }
            set 
            { 
                if(value.Length >=1 && value.Length <=50)
                {
                    _fname = value;//we can adjust the setter method for a property according to the DB constraints we would have/want
                }//will be using this template for the next sections
            } 
        }

        protected string _lastname;
        
        [Required(ErrorMessage = "This property is required")] 
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public string Lname
        {
            get { return _lastname; }
            set
            {
                if (value.Length >= 1 && value.Length <= 50)
                {
                    _lastname = value;
                }
            }
        }

        protected string _member;

        [Required]
        [Display(Name = "Member")]
        public string Member
        {
            get { return _member; }
            set
                {
                _member = value;
                }
        }

        protected string _username;

        [Required(ErrorMessage = "Username must have length greater than 10 and less than 50.")]
        [MaxLength(50)]
        [MinLength(10)]
        [Display(Name = "Username")]
        public string Username
        {
            get { return _username; }
            set
            {
                if (value.Length >= 10 && value.Length <= 50)
                {
                    _username = value;
                }
            }
        }

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
                if (value.Length >= 10 && value.Length <= 100)
                {
                    _password = value;
                }
            }
        }


        public CustomerModel()
        {
            Fname = "defaultFname";
            Lname = "defaultLname";
        }

        public CustomerModel(string fname, string lname)
        {
            this.Fname = fname;
            this.Lname = lname;
        }

    }//eoc
}//eon
