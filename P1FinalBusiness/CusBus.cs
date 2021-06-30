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
        public CusBus(P1TestDbContext context)
        {
            this._context = context;
        }

        public bool saveCustomer(P1Models.Customer cm)
        {
            bool b = false;
            _context.Add(cm);
            _context.SaveChanges();
            if (_context.SaveChanges() == 0)
            {
                return b;
            }
            else { b = true; }
            return b;
        }

        /// <summary>
        /// This is the login method that maps context type to model type to be output into a view
        /// </summary>
        /// <param name="usn">user's username</param>
        /// <param name="pwd">user's paswword</param>
        /// <returns></returns>
        public bool Login(string usn, string pwd)
        {
            P1FinalDbContext.Customer dbcustomer;
            dbcustomer = _context.Customers.Where(x => x.Username == usn && x.Password == pwd).FirstOrDefault();
            //let's map
            if (dbcustomer == null)
            {
                return false;
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
            }
            return true;
        }

        public Task<bool> NewCustomerAsync(CustomerModel p)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterAsync(string fname, string lname, string usn, string pwd, string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterCustomerAsync(P1FinalDbContext.Customer p)
        {
            throw new NotImplementedException();
        }
    }
}
