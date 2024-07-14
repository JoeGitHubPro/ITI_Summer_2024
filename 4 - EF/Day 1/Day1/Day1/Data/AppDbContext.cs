using Day1.Models;
using Microsoft.EntityFrameworkCore;

namespace Day1.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-T4OMHBE\\SQLEXPRESS;Database=youssef_0;Encrypt=false;Trusted_Connection=True;");
        }
    }
}
