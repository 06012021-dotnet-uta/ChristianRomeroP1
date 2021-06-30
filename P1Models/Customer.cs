using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace P1Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        [Required] //this annotation makes it required when entering this type of information
        [Key]
        public int CustomerId { get; set; }

        protected string _fname; // this states a property

        [Required(ErrorMessage = "This property is required")] //these annotations state constraints that would normally exist in SQL
        [MaxLength(30)]
        [Display(Name = "First Name")]
        public string Fname
        {
            get { return _fname; }
            set
            {
                if (value.Length >= 1 && value.Length <= 30)
                {
                    _fname = value;//we can adjust the setter method for a property according to the DB constraints we would have/want
                }//will be using this template for the next sections
            }
        }


        protected string _lname; // this states a property

        [Required(ErrorMessage = "This property is required")] //these annotations state constraints that would normally exist in SQL
        [MaxLength(30)]
        [Display(Name = "Last Name")]
        public string Lname
        {
            get { return _fname; }
            set
            {
                if (value.Length >= 1 && value.Length <= 30)
                {
                    _lname = value;
                }
            }
        }


        protected string _username; // this states a property
        [Required(ErrorMessage = "Username must be no greater than 30 characters")] //these annotations state constraints that would normally exist in SQL
        [MaxLength(30)]
        [Display(Name = "Username")]
        public string Username
        {
            get { return _username; }
            set
            {
                if (value.Length >= 1 && value.Length <= 30)
                {
                    _username = value;
                }
            }
        }



        protected string _password;

        [Required(ErrorMessage = "Password must be length less than 100 characters")]
        [MaxLength(100)]
        [Display(Name = "Password")]
        public string Password
        {
            get { return _password; }
            set
            {
                if (value.Length <= 100)
                {
                    _password = value;
                }
            }
        }

        protected string _email;

        [Required(ErrorMessage = "Password must have length greater than 10 and less than 50.")]
        [MaxLength(64)]
        [Display(Name = "Email")]
        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Length <= 64)
                {
                    _email = value;
                }
            }
        }



        //this override constructor will be called with you instantiate the class instance and provide
        // the fname and lname at the same time.
        public Customer(string fname, string lname)
        {
            this.Fname = fname;
            this.Lname = lname;
        }



        public virtual ICollection<Order> Orders { get; set; }
    }
}
