using Microsoft.AspNetCore.Mvc;

namespace TrendMarket.PresentationLayer.ViewComponents.AdminLAyoutViewComponents
{
	public class _FooterLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
