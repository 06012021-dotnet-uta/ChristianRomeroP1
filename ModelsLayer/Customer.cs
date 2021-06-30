using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public Customer()
    {
        Orders = new HashSet<Order>();
    }

    public int CustomerId { get; set; }
    public string Fname { get; set; }
    public string Lname { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
}
}
