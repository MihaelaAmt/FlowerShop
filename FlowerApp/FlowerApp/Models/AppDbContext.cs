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

        //categories
        //can be used to query and save instance of category
        public DbSet<Category> Categories
        {
            get;
            set;
        }
        //flowers
        //can be used to query and save instance of flowers
        public DbSet<Flower> Flowers
        {
            get;
            set;
        }
        //shopping Cart Item
        //can be used to query and save instance of ShoppingCartItems
        public DbSet<ShoppingCartItem> ShoppingCartItems
        {
            get;
            set;
        }
        //orders 
        //can be used to query and save instance of Orders
        public DbSet<Order> Orders
        {
            get;
            set;
        }
        //order details
        //can be used to query and save instance of OrderDetailss
        public DbSet<OrderDetail> OrderDetails
        {
            get;
            set;
        }
    }
}
