using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RegistrarVentas.Controllers
{
    public class BienvenidosController : Controller
    {
        // GET: BienvenidosController
        public ActionResult Bienvenidos()
        {
            return View();
        }

        // GET: BienvenidosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BienvenidosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BienvenidosController/Create
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

        // GET: BienvenidosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BienvenidosController/Edit/5
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

        // GET: BienvenidosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BienvenidosController/Delete/5
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
