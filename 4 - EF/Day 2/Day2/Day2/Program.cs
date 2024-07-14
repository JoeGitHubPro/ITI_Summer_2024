using Day2.DataContext;
using Day2.Models;
using Microsoft.EntityFrameworkCore;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new AppDbContext();


            db.Database.EnsureCreated();



            var category = new Category { Name = "Electronics" };
            var product = new Product { Name = "Phone", Price = 3000, Category = category };
            var order = new Order { OrderDate = DateTime.Now, OrderPrice = 2700 };

            var orderProduct = new OrderProduct { Order = order, Product = product };

            db.Categories.Add(category);
            db.Products.Add(product);
            db.Orders.Add(order);
            db.OrderProducts.Add(orderProduct);

            db.SaveChanges();



            var orders = db.Orders.Include(o => o.OrderProducts).ThenInclude(op => op.Product).ToList();
            foreach (var o in orders)
            {
                Console.WriteLine($"Order {o.Id}: {o.OrderDate}, {o.OrderPrice}");
                foreach (var op in o.OrderProducts)
                {
                    Console.WriteLine($" - {op.Product.Name}: {op.Product.Price}");
                }
            }


        }
    }
}
