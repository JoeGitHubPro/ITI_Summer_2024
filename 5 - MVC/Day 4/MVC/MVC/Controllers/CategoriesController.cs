using Microsoft.AspNetCore.Mvc;
using MVC.Data;
using MVC.Models;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _context = new AppDbContext();


        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = _context.Categories
                .FirstOrDefault(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateConfirmed(CategoryInputViewModel CategoryInputViewModel)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category() { Name = CategoryInputViewModel.Name };
                _context.Add(category);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(CategoryInputViewModel);
        }


        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = _context.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        public IActionResult EditConfirmed(int id, CategoryInputViewModel CategoryInputViewModel)
        {


            if (ModelState.IsValid)
            {
                Category category = new Category() { Id = id, Name = CategoryInputViewModel.Name };

                try
                {
                    _context.Update(category);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (!_context.Categories.Any(e => e.Id == category.Id))
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
            return View(CategoryInputViewModel);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = _context.Categories
                .FirstOrDefault(m => m.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        public IActionResult DeleteConfirmed(int id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
