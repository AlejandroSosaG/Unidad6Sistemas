using Microsoft.AspNetCore.Mvc;

namespace PrimeraAplicacion.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public String Apellidos()
        {
            return "Sosa García";
        }
        public IActionResult Saludo()
        {
            return View();
        }
    }
}
