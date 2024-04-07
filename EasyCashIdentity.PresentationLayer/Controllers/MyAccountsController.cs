using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentity.PresentationLayer.Controllers
{
    public class MyAccountsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
