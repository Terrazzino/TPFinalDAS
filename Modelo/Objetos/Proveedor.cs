
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Objetos
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Contacto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
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

      

        public override string ToString()
        {
            return Nombre;
        }
    }
}
