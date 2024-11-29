using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModuloAdministrador.Data;
using ModuloAdministrador.Models;

namespace ModuloAdministrador.Controllers
{
    public class UserAccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserAccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Acción para mostrar todos los usuarios
        public async Task<IActionResult> Index()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }

        // Acción para mostrar el formulario de creación de un nuevo usuario
        public IActionResult Create()
        {
            return View();
        }

        // Acción POST para crear un nuevo usuario
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IduserPK, UserName, UserPassword, TypeUser")] Users user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); // Redirige a la lista de usuarios después de crear
            }
            return View(user);
        }

        // Acción para mostrar el formulario de edición de un usuario
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // Acción POST para editar un usuario
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IduserPK, UserName, UserPassword, TypeUser")] Users user)
        {
            if (id != user.IduserPK)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.IduserPK))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index)); // Redirige a la lista de usuarios después de editar
            }
            return View(user);
        }

        // GET: UserAccount/Delete/5 (Formulario para confirmar la eliminación)
        public IActionResult Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: UserAccount/Delete/5 (Elimina un usuario)
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: UserAccount/Details/5 (Ver detalles de un usuario)
        public IActionResult Details(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // Verificar si el usuario existe en la base de datos
        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.IduserPK == id);
        }
    }
}
