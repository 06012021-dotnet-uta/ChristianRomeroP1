using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace P1FinalDbContext
{
    public partial class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? StoreId { get; set; }
        public int? CustomerId { get; set; }
        public int? QuanOrder { get; set; }
        public DateTime DateOrder { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual Location Store { get; set; }
    }
}
