using FlowerApp.Auth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FlowerApp.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories
        {
            get;
            set;
        }

        public DbSet<Flower> Flowers
        {
            get;
            set;
        }

        public DbSet<ShoppingCartItem> ShoppingCartItems
        {
            get;
            set;
        }

        public DbSet<Order> Orders
        {
            get;
            set;
        }

        public DbSet<OrderDetail> OrderDetails
        {
            get;
            set;
        }
    }
}
