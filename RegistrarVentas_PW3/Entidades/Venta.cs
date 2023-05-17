using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarVentas.Repositorio.Entidades
{
    public class Venta
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public int CantVendida { get; set; }
        public double PrecioUnitario { get; set; }
    }
}
