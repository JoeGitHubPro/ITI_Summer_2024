using MVC.Models;

namespace MVC.ViewModels
{
    public class EditProductViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
