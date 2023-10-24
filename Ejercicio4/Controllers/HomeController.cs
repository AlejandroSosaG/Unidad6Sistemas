using Ejercicio4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio4.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}