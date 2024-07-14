using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        public IActionResult CreateConfirmed(ProductInputViewModel productInput)
        {
            if (ModelState.IsValid)
            {
                Product product = new Product()
                {
                    Name = productInput.Name,
                    Price = productInput.Price,
                    CategoryId = productInput.CategoryId
                };
                _context.Add(product);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", productInput.CategoryId);
            return View(productInput);
        }


        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            return View(product);
        }


        public IActionResult EditConfirmed(int id, ProductInputViewModel productInput)
        {


            if (ModelState.IsValid)
            {
                Product product = new Product()
                {
                    Id = id,
                    Name = productInput.Name,
                    Price = productInput.Price,
                    CategoryId = productInput.CategoryId
                };

                try
                {
                    _context.Update(product);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (!_context.Products.Any(e => e.Id == product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw ex;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", productInput.CategoryId);
            return View(productInput);
        }


        public IActionResult Delete(int? id)
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

        public IActionResult DeleteConfirmed(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
