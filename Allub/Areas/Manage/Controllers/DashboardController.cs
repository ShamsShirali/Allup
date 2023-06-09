using Microsoft.AspNetCore.Mvc;

namespace Allub.Areas.Manage.Controllers
{
    [Area("manage")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return Content("Welcome to Manage");
        }
    }
}
