using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P1FinalBusiness;
using P1Models;
using Xunit;

namespace P1FinalTests
{
    [TestClass]
    public class UnitTest1
    {

        //create the in-memory Db //  installed EF Core
       /* DbContextOptions<P1TestDbContext> options = new DbContextOptionsBuilder<P1TestDbContext>()
            .UseInMemoryDatabase(databaseName: "TestingDb")
            .Options;
       */

        //These are tests of the Store class in the Business layer



        [TestMethod]
        public void LoginTest()
        {
            //Arrange
            //Act
            //Assert

            Console.WriteLine("This is the body of the login test");
        }

        [TestMethod]
        public void ShowStoresTest()
        {
            //Arrange
            //Act
            //Assert

            Console.WriteLine("This is the body of the login test");
        }

        [TestMethod]
        public void ShowInvenTest()
        {
            //Arrange
            //Act
            //Assert

            Console.WriteLine("This is the body of the login test");
        }

        [TestMethod]
        public void CreateCartTest()
        {
            //Arrange
            //Act
            //Assert

            Console.WriteLine("This is the body of the login test");
        }
        //These are tests of the Customer class in the Business Layer
    }//eoc
}//eon
