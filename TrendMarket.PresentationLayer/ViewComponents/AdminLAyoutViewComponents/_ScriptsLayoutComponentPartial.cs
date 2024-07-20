using Microsoft.AspNetCore.Mvc;

namespace TrendMarket.PresentationLayer.ViewComponents.AdminLAyoutViewComponents
{
	public class _ScriptsLayoutComponentPartial:ViewComponent
	{
		public  IViewComponentResult Invoke()
		{

		return View(); }	
	
	}
}
