using Microsoft.AspNetCore.Mvc;

namespace RondinesWeb.Controllers
{
    public class StatusIncidentesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
