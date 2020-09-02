using Microsoft.EntityFrameworkCore;
using System;
using OnlineShoppingCart;

namespace OnlineShoppingCartDAL
{
    public class OSCDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFCoreOnlineShoppingCart;Trusted_Connection=True;");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
