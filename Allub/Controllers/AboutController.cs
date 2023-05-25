using Microsoft.AspNetCore.Mvc;

namespace Allub.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
