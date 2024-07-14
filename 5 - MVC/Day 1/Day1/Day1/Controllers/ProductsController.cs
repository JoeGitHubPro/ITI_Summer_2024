using Day1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    public class ProductsController : Controller
    {


        private readonly List<Product> products = new List<Product> {

                new Product { Id = 1, Name = "Wireless Mouse", Price = 29.99m },
                new Product { Id = 2, Name = "Mechanical Keyboard", Price = 99.99m },
                new Product { Id = 3, Name = "USB-C Hub", Price = 49.99m },
                new Product { Id = 4, Name = "External Hard Drive", Price = 89.99m },
                new Product { Id = 5, Name = "Bluetooth Speaker", Price = 59.99m },
                new Product { Id = 6, Name = "Noise Cancelling Headphones", Price = 199.99m },
                new Product { Id = 7, Name = "Smartphone Stand", Price = 14.99m },
                new Product { Id = 8, Name = "Laptop Sleeve", Price = 25.99m },
                new Product { Id = 9, Name = "Wireless Charger", Price = 39.99m },
                new Product { Id = 10, Name = "Portable Power Bank", Price = 49.99m }
        };




        // GET: Products
        public IActionResult Index()
        {
            return View(products.ToList());
        }

        // GET: Products/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = products.FirstOrDefault(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }


    }
}
