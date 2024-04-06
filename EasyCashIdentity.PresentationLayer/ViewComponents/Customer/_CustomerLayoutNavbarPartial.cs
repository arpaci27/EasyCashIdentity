using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentity.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutNavbarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
