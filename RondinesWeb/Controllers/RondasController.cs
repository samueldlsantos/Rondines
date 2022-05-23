using Microsoft.AspNetCore.Mvc;

namespace RondinesWeb.Controllers
{
    public class RondasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
