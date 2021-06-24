using System;
using System.ComponentModel.DataAnnotations;

namespace P1Models
{
    public class CustomerModel
    {
        [Required] //this annotation makes it required when entering this type of information
        public int CustomerId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Favorite { get; set; }
        public string Member { get; set; }
    }//eoc
}//eon
