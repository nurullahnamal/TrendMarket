using Microsoft.AspNetCore.Mvc;
using TrendMarket.BusinessLayer.Abstract;

namespace TrendMarket.PresentationLayer.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
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
            return View();

        }

    }
}
