using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db
{
    class P1CFDb : DbContext
    {
        //here we place the tables we will have - & create corresponding models


        //create a constructor for instantiating the P1CFDb
        public P1CFDb() { }

        public P1CFDb(DbContextOptions options) : base(options) { }


    }
}
