using System.Data.Entity;
namespace Inventory2.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("Inventory2")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}