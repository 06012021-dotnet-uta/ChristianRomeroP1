using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P1Models;
using P1FinalDbContext;
using Xunit;

namespace P1FinalTests
{
    public class UnitTest1
    {

        //create the in-memory Db //  installed EF Core
       /* DbContextOptions<P1TestDbContext> options = new DbContextOptionsBuilder<P1TestDbContext>()
            .UseInMemoryDatabase(databaseName: "TestingDb")
            .Options;
       */

        [Fact]


        public void LoginTest()
        {
            Console.WriteLine("This is the body of the login test");
        }
    }//eoc
}//eon
