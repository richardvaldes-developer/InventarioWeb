using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModuloAdministrador.Controllers
{
    public class InventaryController : Controller
    {
        // GET: InventaryController
        public ActionResult Index()
        {
            return View();
        }

        // GET: InventaryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InventaryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InventaryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InventaryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InventaryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InventaryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InventaryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
