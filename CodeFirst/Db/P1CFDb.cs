using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Db
{
    class P1CFDb : DbContext
    {
        //here we place the tables we will have - & create corresponding models
        public DbSet<CustomerModel> Customers{ get; set; }
        public DbSet<ProductModel> Products{ get; set; }
        public DbSet<StoreModel> Stores { get; set; }
        public DbSet<InventoryModel> Inventories{ get; set; }

        //create a constructor for instantiating the P1CFDb
        public P1CFDb() { }

        public P1CFDb(DbContextOptions options) : base(options) { }


    }
}
