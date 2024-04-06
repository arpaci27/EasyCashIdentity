using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentity.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutFooterPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
