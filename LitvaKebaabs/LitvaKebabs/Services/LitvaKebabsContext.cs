using LitvaKebabs.Models;
using Microsoft.EntityFrameworkCore;

namespace LitvaKebabs.Services
{
    public class LitvaKebabsContext : DbContext
    {
        protected readonly IConfiguration _configuration;
        public LitvaKebabsContext(DbContextOptions<LitvaKebabsContext> options, IConfiguration configuration) : base(options)
        {
          _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProduct { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<RestaurantReview> RestaurantReview { get; set; }
        public DbSet<ProductReview> ProductReview { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
    }
}
