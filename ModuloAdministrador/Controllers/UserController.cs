using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ModuloAdministrador.Data;
using System.Linq;
using ModuloAdministrador.Models;

namespace ModuloAdministrador.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VerificarUsuario(string username, string password)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(u => u.UserName == username && u.UserPassword == password);

                if (user != null)
                {
                    TempData["Message"] = "Inicio de sesión exitoso.";
                    return RedirectToAction("AdministradorInicio", "Home");
                }

                TempData["Error"] = "Usuario o contraseña incorrectos.";
                return RedirectToAction("UserOrPasswordIncorrect");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error de conexión a la base de datos: {ex.Message}");
                TempData["ErrorMessage"] = "No se pudo conectar a la base de datos. Por favor, inténtelo más tarde.";
                return RedirectToAction("ErrorPage");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
                TempData["ErrorMessage"] = "Error inesperado: {ex.Message};
                return RedirectToAction("ErrorPage");
            }
        }
        public IActionResult UserOrPasswordIncorrect()
        {
            ViewBag.ErrorMessage = TempData["ErrorMessage"];
            return View();
        }

        public IActionResult ErrorPage()
        {
            ViewBag.ErrorMessage = TempData["ErrorMessage"];
            return View();
        }

    }
}
