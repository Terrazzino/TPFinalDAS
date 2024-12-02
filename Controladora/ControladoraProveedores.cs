using Microsoft.EntityFrameworkCore;
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
    public class ControladoraProveedores
    {
        Contexto _contexto = new Contexto();

        public ReadOnlyCollection<Proveedor> LeerProveedores()
        {
            return _contexto.Proveedores.Include(p => p.Productos).ToList().AsReadOnly();
        }

        public ReadOnlyCollection<Producto> LeerProductos()
        {
            return _contexto.Productos.ToList().AsReadOnly();
        }

        public void RegistrarProveedor(Proveedor proveedor)
        {
            var validarDuplicado = _contexto.Proveedores.FirstOrDefault(x=>x.Codigo == proveedor.Codigo);
            if (validarDuplicado == null)
            {
                _contexto.Proveedores.Add(proveedor);
                _contexto.SaveChanges();
            }
        }

        public void EliminarProveedor(Proveedor proveedor)
        {
            _contexto.Proveedores.Remove(proveedor);
            _contexto.SaveChanges();
        }

        public void ModificarProveedor(Proveedor proveedorActualizado)
        {
            var proveedorAnterior = _contexto.Proveedores.FirstOrDefault(x => x.Codigo == proveedorActualizado.Codigo);
            if (proveedorAnterior != null)
            {
                proveedorActualizado.Id = proveedorAnterior.Id;
                _contexto.Proveedores.Remove(proveedorAnterior);
                _contexto.Proveedores.Add(proveedorActualizado);
                _contexto.SaveChanges();
            }
        }
    }
}
