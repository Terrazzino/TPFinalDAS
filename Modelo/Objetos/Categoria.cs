using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Objetos
{
    public class Categoria:IdentificacionProductoCategoria
    {
        public int Id { get; set; }
        public List<Producto> Productos { get; set; }

        public Categoria()
        {
            Productos = new List<Producto>();
        }

        public void AgregarProductosACategoria(Producto producto)
        {
            var validarDuplicado = Productos.FirstOrDefault(x=>x.Codigo==producto.Codigo);
            if (validarDuplicado == null)
            {
                Productos.Add(producto);
            }
        }

        public void EliminarProductoDeCategoria(Producto producto)
        {
            var validarExistencia = Productos.FirstOrDefault(x=>x.Codigo==producto.Codigo);
            if (validarExistencia != null)
            {
                Productos.Remove(producto);
            }
        }

        public void ModificarProductoDeCliente(Producto productoActualizado)
        {
            var buscarProductoAnterior = Productos.FirstOrDefault(x=>x.Codigo == productoActualizado.Codigo);
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
