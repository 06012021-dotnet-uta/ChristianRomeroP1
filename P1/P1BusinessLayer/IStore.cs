using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P1DbContext;

namespace P1BusinessLayer
{
    public interface IStore
    {
        public bool Login(string inputUsername, string inputPassword);

        public bool Register(Customer newUser);
        public Customer GetCurrentUser();
        public Location GetLocation(int locationId);

        public List<Location> GetLocationsList();

        public List<string> GetCategoryList(int locationId);

        public List<Order> GetOrderList();

        public List<Order> GetOrderList(int locationId);

        

        public List<Order> GetCustomerOrderList(int customerId);

        public List<Customer> GetCustomerList(string fName, string lName);


        public Order GetOrderDetails(int selectedOrderId);

        public Dictionary<int, int> AddToCart(Dictionary<int, int> userCart, int productId, int numAdded);

        public Dictionary<Product, int> ConvertDict(Dictionary<int, int> userCart);

        public decimal GetCartTotal(Dictionary<Product, int> cart);

        public Order Checkout(Dictionary<Product, int> cart, int customerId, int locationId);
    }
}
