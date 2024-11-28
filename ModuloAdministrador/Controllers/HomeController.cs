using Microsoft.AspNetCore.Mvc;
using ModuloAdministrador.Models;
using System.Diagnostics;

namespace ModuloAdministrador.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult AdministradorInicio()
        {
            return View();
        }
    }
}