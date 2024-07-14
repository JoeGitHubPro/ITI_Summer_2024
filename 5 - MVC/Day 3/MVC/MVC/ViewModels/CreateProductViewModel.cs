using MVC.Models;

namespace MVC.ViewModels
{
    public class CreateProductViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
