using P1FinalDbContext;
using P1Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1FinalBusiness
{
    public class CusBus : ICustomer
    {
        private readonly P1TestDbContext _context;//similar to Store class
        public P1Models.Customer currentcustomer = null;
        public CusBus(P1TestDbContext context)
        {
            this._context = context;
        }

        public P1Models.Customer saveCustomer(P1Models.Customer cm)
        {
            //map cm to dbcustomer
            P1FinalDbContext.Customer dbcustomer = new P1FinalDbContext.Customer();
            {
                dbcustomer.Fname = cm.Fname;
                dbcustomer.Lname = cm.Lname;
                dbcustomer.Username = cm.Username;
                dbcustomer.Password = cm.Password;
                dbcustomer.Email = cm.Email;
            };
            _context.Add(dbcustomer);
            _context.SaveChanges();
            return cm;
        }

        /// <summary>
        /// This is the login method that maps context type to model type to be output into a view
        /// </summary>
        /// <param name="usn">user's username</param>
        /// <param name="pwd">user's paswword</param>
        /// <returns></returns>
        public P1Models.Customer Login(string usn, string pwd)
        {
            P1FinalDbContext.Customer dbcustomer;
            dbcustomer = _context.Customers.Where(x => x.Username == usn && x.Password == pwd).FirstOrDefault();
            //let's map
            if (dbcustomer == null)
            {
                currentcustomer = null;
                return currentcustomer;
            }
            else
            {
                P1Models.Customer q = new P1Models.Customer()
                {
                    Fname = dbcustomer.Fname,
                    Lname = dbcustomer.Lname,
                    Username = dbcustomer.Username,
                    Email = dbcustomer.Email,
                    Password = dbcustomer.Password,
                };
                currentcustomer = q;
            }
            return currentcustomer;
        }

        /// <summary>
        /// Returns List of Customers matching parameters or list of all customers on empty parameters
        /// </summary>
        /// <param name="fName">First name contains</param>
        /// <param name="lName">Last name contains</param>
        /// <returns>List of Customer Objects that contain input requirements</returns>
        public List<P1FinalDbContext.Customer> GetCustomerList(string fName = "", string lName = "")
        {
            var customerList = _context.Customers.Where(x => x.Fname.Contains(fName) && x.Lname.Contains(lName)).ToList();

            return customerList;
        }


    }
}
