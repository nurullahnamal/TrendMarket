using Microsoft.AspNetCore.Mvc;

namespace TrendMarket.PresentationLayer.ViewComponents.AdminLAyoutViewComponents
{
    public class _MainPanelLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
