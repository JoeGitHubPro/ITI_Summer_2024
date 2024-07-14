using Microsoft.AspNetCore.Mvc;
using MVC.Data;
using MVC.Models;

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


        public IActionResult CreateSubmit(Category category)
        {

            _context.Add(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));


        }


        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = _context.Categories.SingleOrDefault(a => a.Id == id);

            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }


        public IActionResult EditSubmit(int Id, Category category)
        {
            if (Id != category.Id)
            {
                return NotFound();
            }


            try
            {
                _context.Update(category);
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
