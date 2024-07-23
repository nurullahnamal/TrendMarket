using Microsoft.AspNetCore.Mvc;
using TrendMarket.BusinessLayer.Abstract;

namespace TrendMarket.PresentationLayer.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult CategoryList()
        {
            var values = _categoryService.TGetAll();
            return View(values);
        }
    }
}
