using RegistrarVentas.Repositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarVentas.Repositorio.Logica
{
    public interface IClienteRepositorio
    {
        List<Entidades.Cliente> ObtenerTodos();
        void Agregar(Entidades.Cliente cliente);
        void Eliminar(int id);

    }
    public class ClienteRepositorio : IClienteRepositorio
    {
        private static List<Entidades.Cliente> _clientes = new List<Entidades.Cliente>();

        public ClienteRepositorio() {
            Inicializar();
        }
        private void Inicializar()
        {
            _clientes.Clear();
            _clientes.Add(new Entidades.Cliente() { Id = 1, Nombre = "Clientela S.A" });
            _clientes.Add(new Entidades.Cliente() { Id = 2, Nombre = "Producteando SRL" });
            _clientes.Add(new Entidades.Cliente() { Id = 3, Nombre = "Tecleando S.A" });
        }
        private int ObtenerProxId() {
            return _clientes.Count() + 1;

        }
        public void Agregar(Entidades.Cliente cliente)
        {
            cliente.Nombre = cliente.Nombre.Trim();

            if (_clientes.Any(tp => tp.Nombre.Equals(cliente.Nombre, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException();
            }

            cliente.Id = ObtenerProxId();

            _clientes.Add(cliente);
        }      

        public List<Entidades.Cliente> ObtenerTodos()
        {
           return _clientes;
        }
        public void Eliminar(int id)
        {
            var tipoPoder = _clientes.FirstOrDefault(x => x.Id == id);
            if (tipoPoder != null)
            {
                _clientes.Remove(tipoPoder);
            }
        }
    }
}
