using Microsoft.AspNetCore.Mvc;
using RegistrarVentas.Repositorio.Entidades;
using RegistrarVentas.Repositorio.Logica;

namespace RegistrarVentas.Web.Controllers
{
    public class RegistrarVentasController : Controller
    {
        IVentasRepositorio _ventasRepositorio;

        public RegistrarVentasController(IVentasRepositorio ventasRepositorio)
        {
            _ventasRepositorio = ventasRepositorio;
        }

        public IActionResult Index()
        {
            var ventas = _ventasRepositorio.ObtenerTodos();
            return View(ventas);
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Venta venta)
        {
            try
            {
                _ventasRepositorio.Agregar(venta);
            }
            catch (ArgumentException ex)
            {
                ViewBag.Mensaje = $"El nombre de poder {venta.Cliente} ya existe";
                return View(venta);
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
                return View(venta);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            _ventasRepositorio.Eliminar(id);
            return RedirectToAction("Index");
        }
    }
}
