using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P1Models;

namespace P1FinalBusiness
{
    public interface ICustomer//Customer interface will contain 
    {
        bool saveCustomer(P1Models.Customer cm);
        Task<bool> RegisterAsync(string fname, string lname, string usn, string pwd, string email);
        Task<bool> NewCustomerAsync(CustomerModel p);
        Task<bool> RegisterCustomerAsync(P1FinalDbContext.Customer p);
        bool Login(string usn, string pwd);
    }
}
