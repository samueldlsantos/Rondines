using Microsoft.AspNetCore.Mvc;

namespace RondinesWeb.Controllers
{
    public class IncidentesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
