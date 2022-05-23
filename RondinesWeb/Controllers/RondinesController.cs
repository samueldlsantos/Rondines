using Microsoft.AspNetCore.Mvc;

namespace RondinesWeb.Controllers
{
    public class RondinesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VistaVacia()
        {
            return View("Views/Rondines/VistaVacia.cshtml");
        }
    }
}
