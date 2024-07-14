using Day2.Models;
using Microsoft.EntityFrameworkCore;

namespace Day2.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-T4OMHBE\\SQLEXPRESS;Database=youssef;Encrypt=false;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasMany(c => c.Products)
                    .WithOne(p => p.Category)
                    .HasForeignKey(p => p.CategoryId);


            base.OnModelCreating(modelBuilder);
        }


    }
}
