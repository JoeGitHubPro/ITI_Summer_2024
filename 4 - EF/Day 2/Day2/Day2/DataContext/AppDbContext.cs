using Day2.Configuration;
using Day2.Models;
using Microsoft.EntityFrameworkCore;

namespace Day2.DataContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-T4OMHBE\\SQLEXPRESS;Database=youssef;Encrypt=false;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new OrderProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

            // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        }
    }
}
