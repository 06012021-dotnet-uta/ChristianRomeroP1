using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1FinalBusiness
{
    public class Customer
    {
        ////blic static void SortCustomersFirst()
        ////
        ////  
        ////
        ////  using (context)
        ////  {
        ////      //create an ordered list of context type Customer via lambda
        ////      List<context.Customer> namedList = context.Customers.OrderBy(b => b.Fname).ToList();
        ////      Console.WriteLine("All customers and basic information, ordered by first name.");
        ////      foreach (var cust in namedList)//output basic information
        ////      {
        ////          Console.WriteLine($"Name: {cust.Fname} {cust.Lname}  ID: {cust.CustomerId}   -  Email: {cust.Email}  - " +
        ////              $"Address: {cust.Mailing} {cust.State},{cust.State} {cust.Zip}");
        ////      }
        ////  }
        ////
        ////
        ////blic static void SortCustomersMemberStatus()
        ////
        ////  context.P0DbContext context = new context.P0DbContext();
        ////  using (context)
        ////  {
        ////      //create an ordered list of context type Customer via lambda
        ////      List<context.Customer> memberList = context.Customers.OrderBy(b => b.Member).ToList();
        ////      Console.WriteLine("All customers and basic information, with non-members first.");
        ////      foreach (var cust in memberList)//output basic information
        ////      {
        ////          Console.WriteLine($"Name: {cust.Fname} {cust.Lname}  - Member:{cust.Member}   Email: {cust.Email}  - " +
        ////              $"Address: {cust.Mailing} {cust.State},{cust.State} {cust.Zip}");
        ////      }
        ////  }
        ////
        ////method to show all order history of a customer
        ///public static void CustomerOrderHistory(int customerId)
        ///{
        ////  context.P0DbContext context = new context.P0DbContext();
        ////  using (context)
        ////  {
        ////      //select star
        ////      List<context.Order> history = context.Orders.OrderBy(b => b.CustomerId == customerId).ToList();
        ////      Console.WriteLine("Order History for a customer");
        ////      int count = 0;
        ////      foreach (var order in history.Where(c => c.CustomerId == customerId))
        ////      {
        ////          Console.WriteLine($"The order history for {order.CustomerId}: {count++}. {order.QuanOrder} " +
        ////              $"{order.Product} ordered on {order.DateOrder}");
        ////      }
        ////  }
        ///}
        ///blic static void AllOrderHistory(int customerId)
        ///
        ///  context.P0DbContext context = new context.P0DbContext();
        ///  using (context)
        ///  {
        ///      //select star
        ///      List<context.Order> history = context.Orders.OrderBy(b => b.CustomerId == customerId).ToList();
        ///      Console.WriteLine("Order History for all customers");
        ///      int count = 0;
        ///      foreach (var order in history)
        ///      {
        ///          Console.WriteLine($"The order history for {order.CustomerId}: {count++}. {order.QuanOrder} " +
        ///              $"{order.Product} ordered on {order.DateOrder}");
        ///      }
        ///  }
        ///
        //

    }//eoc
}//eon
