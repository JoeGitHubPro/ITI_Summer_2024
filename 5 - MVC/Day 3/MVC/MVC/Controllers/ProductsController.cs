using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Data;
using MVC.Models;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context = new AppDbContext();


        public IActionResult Index()
        {
            var appDbContext = _context.Products.Include(p => p.Category);
            return View(appDbContext.ToList());
        }

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

            return View(product);
        }


        public IActionResult Create()
        {

            CreateProductViewModel model = new CreateProductViewModel()
            {

                Categories = _context.Categories.ToList()

            };
            return View(model);
        }

        public ActionResult CreateSumbit(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }



        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EditProductViewModel model = new EditProductViewModel()
            {
                Product = _context.Products.SingleOrDefault(a => a.Id == id),
                Categories = _context.Categories.ToList()
            };

            return View(model);
        }


        public IActionResult EditSumbit(int Id, Product product)
        {
            if (Id != product.Id)
            {
                return NotFound();
            }

            try
            {
                _context.Update(product);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }

            return RedirectToAction(nameof(Index));

        }


    }
}
