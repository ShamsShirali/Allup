using Microsoft.AspNetCore.Mvc;

namespace Allub.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
