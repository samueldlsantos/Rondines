using Microsoft.AspNetCore.Mvc;

namespace RondinesWeb.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
