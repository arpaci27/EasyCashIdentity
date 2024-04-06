using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentity.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutSidebarPartial: ViewComponent
    {
        public IViewComponentResult Invoke() {

            return View();
        }
        
    }
}
