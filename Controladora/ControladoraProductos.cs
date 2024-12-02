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
                producto.CategoriaDelProducto.AgregarProductosACategoria(producto);
                _contexto.Categorias.Update(producto.CategoriaDelProducto);
                _contexto.Productos.Add(producto);
                _contexto.SaveChanges();
            }
        }

        public void RegistrarProducto(ProductoImportado producto)
        {
            var validarDuplicado = _contexto.Productos.FirstOrDefault(x => x.Codigo == producto.Codigo);
            if (validarDuplicado == null)
            {
                producto.CategoriaDelProducto.AgregarProductosACategoria(producto);
                _contexto.Categorias.Update(producto.CategoriaDelProducto);
                _contexto.ProductosImportados.Add(producto);
                _contexto.SaveChanges();
            }
        }

        public void EliminarProducto(Producto producto)
        {
            producto.CategoriaDelProducto.EliminarProductoDeCategoria(producto);
            _contexto.Categorias.Update(producto.CategoriaDelProducto);
            _contexto.Productos.Remove(producto);
            _contexto.SaveChanges();
        }
        public void EliminarProducto(ProductoImportado producto)
        {
            producto.CategoriaDelProducto.EliminarProductoDeCategoria(producto);
            _contexto.Categorias.Update(producto.CategoriaDelProducto);
            _contexto.ProductosImportados.Remove(producto);
            _contexto.SaveChanges();
        }

        public void ModificarProducto(Producto productoActualizado)
        {
            var productoAnterior = _contexto.Productos.FirstOrDefault(x=>x.Codigo==productoActualizado.Codigo);
            if (productoAnterior != null)
            {
                productoActualizado.Id = productoAnterior.Id;
                productoActualizado.CategoriaDelProducto.ModificarProductoDeCliente(productoActualizado);
                _contexto.Categorias.Update(productoActualizado.CategoriaDelProducto);
                _contexto.Productos.Remove(productoAnterior);
                _contexto.Productos.Add(productoActualizado);
                _contexto.SaveChanges();
            }
        }
        public void ModificarProducto(ProductoImportado productoImportadoActualizado)
        {
            var productoImportadoAnterior = _contexto.ProductosImportados.FirstOrDefault(x => x.Codigo == productoImportadoActualizado.Codigo);
            if (productoImportadoAnterior != null)
            {
                productoImportadoActualizado.Id = productoImportadoAnterior.Id;
                productoImportadoActualizado.CategoriaDelProducto.ModificarProductoDeCliente(productoImportadoActualizado);
                _contexto.Categorias.Update(productoImportadoActualizado.CategoriaDelProducto);
                _contexto.ProductosImportados.Remove(productoImportadoAnterior);
                _contexto.ProductosImportados.Add(productoImportadoActualizado);
                _contexto.SaveChanges();
            }
        }

        public Categoria BuscarCategoriaDelProducto(string nombre)
        {
            return _contexto.Categorias.Include(p=>p.Productos).FirstOrDefault(x => x.Nombre == nombre);
        }

        public ReadOnlyCollection<Categoria> LeerTodaLasCategorias()
        {
            return _contexto.Categorias.ToList().AsReadOnly();
        }
    }
}
