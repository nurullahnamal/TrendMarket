using Microsoft.AspNetCore.Mvc;

namespace TrendMarket.PresentationLayer.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
