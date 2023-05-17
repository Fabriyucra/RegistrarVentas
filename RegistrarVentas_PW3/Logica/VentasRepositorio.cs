using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarVentas.Repositorio.Logica
{
    public interface IVentasRepositorio {
        List<Entidades.Venta> ObtenerTodos();
        void Agregar(Entidades.Venta venta);
        void Eliminar(int id);
    }
    public class VentasRepositorio : IVentasRepositorio
    { 
    private static List<Entidades.Venta> _ventas = new List<Entidades.Venta>();
    public List<Entidades.Venta> ObtenerTodos() 
    { 
    return _ventas;
    }
        public void Agregar(Entidades.Venta venta) {
        _ventas.Add(venta);
        }
        public void Eliminar(int id) 
        {
            var venta = _ventas.FirstOrDefault(x => x.Id == id);
            if (venta != null)
            {
                _ventas.Remove(venta);
            }
        }
    }
}
