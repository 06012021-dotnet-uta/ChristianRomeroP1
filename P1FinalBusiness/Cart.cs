using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P1FinalDbContext;
using P1Models;

namespace P1FinalBusiness
{
    public class CartCheckout
    {
        //carts need to have a context because they need to access the db & arraylist of orders
        private readonly P1TestDbContext _context;
        private List<P1Models.Order> _ord;
        // private List<Product> _prod;
        public List<P1Models.Product> Products { get; set; }
        public Customer Customer;

        //static list 

        //constructor
        public CartCheckout(P1TestDbContext context)
        {
            this._context = context;
            Products = new List<P1Models.Product>();
        }

        // AddProductAsync
       /* public async Task<bool> AddProductAsync(Product p)
        {
            Products.Add(p);
            var n = new CartProduct(1, p.ProductId);
            await _context.AddAsync(n);
            await _context.SaveChangesAsync();

            return true;
        }
       */

        //Display an order
        //public async Task<List<CartProduct>> ListOfCartProductsAsync()
        //{
        //    //  ps = _context.Users.ToList();
        //    ps = _context.CartProducts.ToList();

        //    return ps;
        //}

    }
}
