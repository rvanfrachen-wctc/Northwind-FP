using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Northwind.Models
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public void AddCustomer(Customer customer)
        {
            this.Add(customer);
            this.SaveChanges();
        }
        public void EditCustomer(Customer customer)
        {
            var customerToUpdate = Customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);
            if (customerToUpdate != null)
            {
                customerToUpdate.Address = customer.Address;
                customerToUpdate.City = customer.City;
                customerToUpdate.Region = customer.Region;
                customerToUpdate.PostalCode = customer.PostalCode;
                customerToUpdate.Country = customer.Country;
                customerToUpdate.Phone = customer.Phone;
                customerToUpdate.Fax = customer.Fax;
            }

            SaveChanges();
        }
        public CartItem AddToCart(CartItemJSON cartItemJson)
        {
            var CustomerId = Customers.FirstOrDefault(c => c.Email == cartItemJson.email)!.CustomerId;
            int ProductId = cartItemJson.id;
            // check for duplicate cart item
            var cartItem = CartItems.FirstOrDefault(ci => ci.ProductId == ProductId && ci.CustomerId == CustomerId);
            if (cartItem == null)
            {
                // this is a new cart item
                cartItem = new CartItem()
                {
                    CustomerId = CustomerId,
                    ProductId = cartItemJson.id,
                    Quantity = cartItemJson.qty
                };
                CartItems.Add(cartItem);
            }
            else
            {
                // for duplicate cart item, simply update the quantity
                cartItem.Quantity += cartItemJson.qty;
            }

            SaveChanges();
            cartItem.Product = Products.Find(cartItem.ProductId);
            return cartItem;
        }
    }
}