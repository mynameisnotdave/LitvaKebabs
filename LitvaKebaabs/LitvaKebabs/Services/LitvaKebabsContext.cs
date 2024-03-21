using LitvaKebabs.Models;
using Microsoft.EntityFrameworkCore;

namespace LitvaKebabs.Services
{
    public class LitvaKebabsContext(DbContextOptions<LitvaKebabsContext> options) : DbContext(options)
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProduct { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<RestaurantReview> RestaurantReview { get; set; }
        public DbSet<ProductReview> ProductReview { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}
