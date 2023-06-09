using Microsoft.AspNetCore.Mvc;

namespace Allub.Areas.Hr.Controllers
{
    public class DashboardController : Controller
    {
        [Area("hr")]
        public IActionResult Index()
        {
            return Content("Welcome to HR");
        }
    }
}
