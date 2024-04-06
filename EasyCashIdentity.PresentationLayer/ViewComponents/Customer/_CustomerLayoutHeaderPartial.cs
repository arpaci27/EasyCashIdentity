using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentity.PresentationLayer.ViewComponents.Customer
{
	public class _CustomerLayoutHeaderPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
