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
        P1Models.Customer saveCustomer(P1Models.Customer cm);
        P1Models.Customer Login(string usn, string pwd);
        List<P1FinalDbContext.Customer> GetCustomerList(string fName = "", string lName = "");


        
    }
}
