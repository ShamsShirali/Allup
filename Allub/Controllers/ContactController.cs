using Microsoft.AspNetCore.Mvc;

namespace Allub.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
