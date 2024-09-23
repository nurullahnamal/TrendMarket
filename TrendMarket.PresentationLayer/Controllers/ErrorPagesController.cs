using Microsoft.AspNetCore.Mvc;

namespace TrendMarket.PresentationLayer.Controllers
{
    public class ErrorPagesController : Controller
    {
        public IActionResult ErrorPage404()
        {
            return View();
        }
    }
}
