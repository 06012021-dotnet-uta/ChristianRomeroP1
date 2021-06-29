using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P1Models;
using P1FinalDbContext;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace P1FinalBusiness
{
   public class Store //: IStore
    {
        private readonly P1TestDbContext _context;//all stores access DBcontext
        public P1FinalDbContext.Customer currentcustomer { get; set; }//any given store has a customer shopping at it
		public P1FinalDbContext.Location storechoice;

		//constructors
		public Store() { }
        public Store(P1TestDbContext context)//Store takes in context as a parameter
        {
            this._context = context;
        }

		public Store(P1FinalDbContext.Customer currentcustomer)
        {
			this.currentcustomer = currentcustomer;
        }

		public Store(P1TestDbContext context, P1FinalDbContext.Customer customer)
		{
			this._context = context;
			this.currentcustomer = customer;
		}


		///<summary>
		///This is the register method
		/// </summary>
		///
		public async Task<bool> RegisterAsync(string fname, string lname, string usn, string pwd, string email)
		{
			
				P1FinalDbContext.Customer c = new P1FinalDbContext.Customer();

				c.Fname = fname;
				c.Lname = lname;
				c.Username= usn;
				c.Password=pwd;
				c.Email = email;

			await _context.Customers.AddAsync(c);

			if (_context.SaveChanges() == 1)
			{ return true; }
            else { return false; }
		}



		/// <summary>
		/// This is the method to login correctly.
		/// </summary>
		/// <param name="usn">This is a customer's username</param>
		/// <param name="pwd">This is a customer's password</param>
		/// <returns></returns>
		public bool Login(string usn, string pwd)
		{
			P1FinalDbContext.Customer cm;
			
			using (P1TestDbContext context = new P1TestDbContext())
			{
				cm = context.Customers.Where(x => x.Username == usn && x.Password == pwd).FirstOrDefault();
			}

			if (cm == null)
			{
				return false;
			}
			else
			{
				currentcustomer = cm;
				return true;
			}
		}
		

		/// <summary>
		/// Registers customer to Db and implements exception handling
		/// </summary>
		/// <param name="p">This is a CustomerModel type from the Customer view</param>
		/// <returns>Returns a boolean value of whether the customer was successfully added to Db</returns>
		/*
		 * public async Task<bool> NewCustomerAsync(P1Models.CustomerModel cm)
	{
		//create a try/catch to save the player
		await _context.Customers.AddAsync(cm);
		try
		{
			await _context.SaveChangesAsync();
		}
		catch (DbUpdateConcurrencyException ex)
		{
			Console.WriteLine($"There was a problem updating the Db => {ex.InnerException}");
			return false;
		}
		/*catch (DbUpdateException ex)
		{       //change this to logging
			Console.WriteLine($"There was a problem updating the Db => {ex.InnerException}");
			return false;
		}*/




		///<summary>
		///This is a method to view all store locations (from the Db)
		///</summary>
		
		public ArrayList ShowStores()
		{
			//retrieve favorite choice value
			ArrayList arr = new ArrayList();

			var locs = _context.Locations.Where(x => x.StoreId >= 0).ToList();
			foreach (var l in locs)
            {
				StoreModel sm = new StoreModel();
				sm.StoreId = l.StoreId;
				sm.State = l.State;
				sm.City = l.City;
				sm.Address = l.Address;
				sm.Phone = l.Phone;

				arr.Add(sm);
			}
			return arr;
		}

			///<summary>
			///This is a method to output all the inventory for a specific store location, using the inventory data for that location.
			///</summary>
			///<param name="favoritechoice"> This parameter is chosen from a view where the customer selects a favorite store</param>

			public ArrayList StoreInventory(int favoritechoice)
		{
			//retrieve favorite choice value
			ArrayList arr = new ArrayList();

			var stores = _context.Inventories.Where(x => x.StoreId == favoritechoice).ToList();

			foreach (var s in stores)
			{
				
			}

			return arr;
		}


		///<summary>
		///This method adds an arraylist to viewbag so that it can be called from a view
		/// </summary>


		///<summary>
		/// A method to view all stores from DB 
		/// </summary>
		///<parameter>
		///
		///</parameter>
		///
		public List<Location> GetLocationsList()
		{
			List<Location> locList = _context.Locations.ToList();
			return locList;
			//user clicks button corresponding to a location 
		}


		/// <summary>
		/// This is the method that runs when a users chooses a location to shop at.
		/// </summary>
		/// <returns></returns>
		///         
		public Location GetLocation(int choice)
        {
            storechoice = _context.Locations.Where(x => x.StoreId == choice).FirstOrDefault();
            return storechoice;
        }

	//This is the original method that was created but limitation was that the scope prohibited from storing the info into a view
	//I ended up using an arraylist of <Location> type to store the entities representing the stores so that a view could output that object
		public List<Location> StoreView()
		{
			var choices = _context.Locations.Where(x => x.StoreId >= 0).ToList();
			return choices;
		}
		/*using (var context = new P1TestDbContext())
		{

			List<P1FinalDbContext.Location> storelist = context.Locations.Where(x => x.StoreId >= 0).ToList();

			//forreach loop to print out the values (if you just write consolewriteline you get memory address)
			foreach (var store in storelist)
			{
				Console.WriteLine($"{store.StoreId}. {store.City}, {store.State}");
			}

		}
		*/




	///<summary>
	///This is a method to create an order 
	/// </summary>
	///



	///<summary>
	///This is a method to display order details
	/// </summary>
	/// 

	///<summary>
	///This method shows the inventory for a specific store
	/// </summary>
	/// 

	///<summary>
	///This method decrements the inventory for a specific store based off the order
	/// </summary>
	/// 




}//eoc
}//eon
