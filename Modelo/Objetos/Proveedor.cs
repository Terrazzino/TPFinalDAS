using Modelo.Clases_Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Objetos
{
    public class Proveedor:IdentificacionProveedorCliente
    {
        public int Id { get; set; }
        public string Contacto { get; set; }
        public List<Producto> Productos { get; set; } = new List<Producto>();

        public void AgregarProductoAlProveedor(Producto producto)
        {
            var validarDuplicado = Productos.FirstOrDefault(x=>x.Nombre == producto.Nombre);
            if (validarDuplicado == null)
            {
                Productos.Add(producto);
            }
        }
        public void EliminarProductoDelProveedor(Producto producto)
        {
            var validarExistencia = Productos.FirstOrDefault(x=>x.Nombre == producto.Nombre);
            if (validarExistencia != null)
            {
                Productos.Remove(producto);
            }
        }

        public void ModificarProductoDelProveedor(Producto productoActualizado)
        {
            var buscarProductoAnterior = Productos.FirstOrDefault(x=>x.Nombre == productoActualizado.Nombre);
            if (buscarProductoAnterior != null)
            {
                productoActualizado.Id = buscarProductoAnterior.Id;
                Productos.Remove(buscarProductoAnterior);
                Productos.Add(productoActualizado);
            }
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
