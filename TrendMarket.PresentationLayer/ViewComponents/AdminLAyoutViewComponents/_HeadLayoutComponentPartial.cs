using Microsoft.AspNetCore.Mvc;

namespace TrendMarket.PresentationLayer.ViewComponents.AdminLAyoutViewComponents
{
	public class _HeadLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
