using Day1.Models;
using Microsoft.EntityFrameworkCore;

namespace Day1.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-T4OMHBE\\SQLEXPRESS;Database=youssef;Encrypt=false;Trusted_Connection=True;");
        //}



    }
}
