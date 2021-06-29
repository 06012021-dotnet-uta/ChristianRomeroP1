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
        Task<bool> RegisterCustomerAsync(CustomerModel cm);
        Task<bool> LoginAsync(CustomerModel cm);
        Task<List<CustomerModel>> AllCustomerListAsync();
    }
}
