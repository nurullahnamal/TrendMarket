using Microsoft.AspNetCore.Mvc;

namespace TrendMarket.PresentationLayer.ViewComponents.AdminLAyoutViewComponents
{
	public class _CustomTemplateLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
