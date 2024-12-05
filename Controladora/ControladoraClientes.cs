using Modelo;
using Modelo.Objetos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraClientes
    {
        Contexto _contexto = new Contexto();

        public ReadOnlyCollection<Cliente> LeerClientes()
        {
            return _contexto.Clientes.ToList().AsReadOnly();
        }
        public void RegistrarCliente(Cliente cliente)
        {
            var validarDuplicado = _contexto.Clientes.FirstOrDefault(x => x.Codigo == cliente.Codigo);
            if (validarDuplicado == null)
            {
                _contexto.Clientes.Add(cliente);
                _contexto.SaveChanges();
            }
        }
        public void EliminarCliente(Cliente cliente)
        {
            _contexto.Clientes.Remove(cliente);
            _contexto.SaveChanges();
        }

        public void ModificarCliente(Cliente clienteActualizado)
        {
            _contexto.Clientes.Update(clienteActualizado);
            _contexto.SaveChanges();
        }
    }
}
