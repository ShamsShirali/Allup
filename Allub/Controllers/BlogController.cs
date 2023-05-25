using Microsoft.AspNetCore.Mvc;

namespace Allub.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
