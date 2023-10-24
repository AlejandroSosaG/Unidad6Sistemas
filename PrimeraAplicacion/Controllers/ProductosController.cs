using Microsoft.AspNetCore.Mvc;

namespace PrimeraAplicacion.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult ListadoProductos()
        {
            return View();
        }
    }
}
