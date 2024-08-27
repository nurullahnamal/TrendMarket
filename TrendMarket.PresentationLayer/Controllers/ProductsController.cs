using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrendMarket.BusinessLayer.Abstract;
using TrendMarket.EntityLayer.Concrete;

namespace TrendMarket.PresentationLayer.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult ProductList()
        {
            var values = _productService.TGetAll();

            return View(values);
        }
        public IActionResult ProductListWithCategory() 
        {
            var values =_productService.TProductListWithCategory();
            return View(values);
        }

        public IActionResult DeleteProduct(int id) { 
            _productService.TGetById(id);
            return RedirectToAction("ProductListWithCategory");

        }

        [HttpGet]

        public IActionResult CreateProduct()
        {
            var values = _categoryService.TGetAll();
            ViewBag.categories = new SelectList(values, "CategoryId", "CategoryName");
            return View();

        }
        [HttpPost]
        public IActionResult CreateProduct( Product product ) {
            

            _productService.TInsert(product);
            return RedirectToAction("ProductListWithCategory");
        
        }

    }
}
