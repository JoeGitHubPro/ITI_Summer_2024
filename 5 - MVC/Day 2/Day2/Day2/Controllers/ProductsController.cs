using Day2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day2.Controllers
{

    public class ProductsController : Controller
    {
        private readonly AppDbContext _context = new AppDbContext();


        // GET: Products
        public IActionResult Index()
        {
            var appDbContext = _context.Products.Include(p => p.Category);
            return View(appDbContext.ToList());
        }

        // GET: Products/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _context.Products
                .Include(p => p.Category)
                .FirstOrDefault(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            TempData["Deleted item id"] = id;
            return View(product);
        }
        public IActionResult Delete()
        {
            int id = (int)TempData["Deleted item id"];
            var item = _context.Products.SingleOrDefault(a => a.Id == id);

            if (item != null)
                _context.Products.Remove(item);

            _context.SaveChanges();


            return Redirect("Index");
        }

    }
}
