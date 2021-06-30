using System;
using System.Collections.Generic;

#nullable disable

namespace P1Models
{
    public partial class Favorite
    {
        public Favorite()
        {
            Customers = new HashSet<Customer>();
        }

        public int FavoriteId { get; set; }
        public int Store { get; set; }

        public virtual Location StoreNavigation { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
