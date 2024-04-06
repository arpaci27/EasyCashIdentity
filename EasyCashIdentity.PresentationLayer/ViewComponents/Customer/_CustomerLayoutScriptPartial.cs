using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentity.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
