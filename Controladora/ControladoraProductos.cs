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
    public class ControladoraProductos
    {
        Contexto _contexto = new Contexto();

        public ReadOnlyCollection<Producto> LeerProductos()
        {
            List<Producto> productos = new List<Producto>();
            foreach (Producto prod in _contexto.Productos)
            {
                if (prod is not ProductoImportado)
                {
                    productos.Add(prod);
                }
            }
            return productos.AsReadOnly();
        }
 
        public ReadOnlyCollection<ProductoImportado> LeerProductosImportados()
        {
            return _contexto.ProductosImportados.ToList().AsReadOnly();
        }

        public void RegistrarProducto(Producto producto)
        {
            var validarDuplicado = _contexto.Productos.FirstOrDefault(x=>x.Codigo == producto.Codigo);
            if (validarDuplicado == null)
            {
                _contexto.Productos.Add(producto);
                _contexto.SaveChanges();
            }
        }

        public void RegistrarProducto(ProductoImportado producto)
        {
            var validarDuplicado = _contexto.Productos.FirstOrDefault(x => x.Codigo == producto.Codigo);
            if (validarDuplicado == null)
            {
                _contexto.ProductosImportados.Add(producto);
                _contexto.SaveChanges();
            }
        }

        public void EliminarProducto(Producto producto)
        {
            _contexto.Productos.Remove(producto);
            _contexto.SaveChanges();
        }
        public void EliminarProducto(ProductoImportado producto)
        {
            _contexto.ProductosImportados.Remove(producto);
            _contexto.SaveChanges();
        }

        public void ModificarProducto(Producto productoActualizado)
        {
            _contexto.Productos.Update(productoActualizado);
            _contexto.SaveChanges();
        }
        public void ModificarProducto(ProductoImportado productoImportadoActualizado)
        {
            _contexto.ProductosImportados.Update(productoImportadoActualizado);
            _contexto.SaveChanges();
        }

        

        public ReadOnlyCollection<Categoria> LeerTodaLasCategorias()
        {
            return _contexto.Categorias.ToList().AsReadOnly();
        }
    }
}
