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
    public class ControladoraFacturaciones
    {
        Contexto _contexto = new Contexto();
        public ReadOnlyCollection<Factura> LeerFacturas()
        {
            return _contexto.Facturas.Include(c => c.ClienteDeFactura).Include(d=>d.DetallesDeFactura).ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Cliente> LeerClientes()
        {
            return _contexto.Clientes.ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Producto> LeerProductos()
        {
            return _contexto.Productos.Include(c=>c.CategoriaDelProducto).ToList().AsReadOnly();
        }
        public ReadOnlyCollection<DetalleFactura> LeerDetalles()
        {
            return _contexto.DetallesFacturas.Include(p=>p.ProductoDelDetalle).ToList().AsReadOnly();
        }
        public ReadOnlyCollection<DetalleFactura> LeerDetallesDeFactura(Factura factura)
        {
            List<DetalleFactura> detallesDeFactura = new List<DetalleFactura>();
            foreach (DetalleFactura d in _contexto.DetallesFacturas)
            {
                if (d.FacturaDelDetalle.Numero == factura.Numero)
                {
                    detallesDeFactura.Add(d);
                }
            }
            return detallesDeFactura.ToList().AsReadOnly();
        }

        public void RegistrarFactura(Factura factura)
        {
            var validarDuplicado = _contexto.Facturas.Include(d=>d.DetallesDeFactura).FirstOrDefault(x=>x.Numero==factura.Numero);
            if (validarDuplicado == null)
            {
                _contexto.Facturas.Add(factura);
                _contexto.SaveChanges();
            }
        }
        public void RegistrarDetalle(Factura factura, DetalleFactura detalle)
        {
            var buscarProductoDelDetalle = _contexto.Productos.FirstOrDefault(x=>x.Codigo == detalle.ProductoDelDetalle.Codigo);
            var validarExistenciaDeFactura = _contexto.Facturas.Include(d => d.DetallesDeFactura).FirstOrDefault(x => x.Numero == factura.Numero);
            if (validarExistenciaDeFactura != null)
            {
                var validarDetalleDuplicado = validarExistenciaDeFactura.DetallesDeFactura.FirstOrDefault(x=>x.ProductoDelDetalle.Nombre==detalle.ProductoDelDetalle.Nombre);
                if (validarDetalleDuplicado == null)
                {
                    validarExistenciaDeFactura.AgregarDetalleDeLaFactura(detalle);
                    _contexto.DetallesFacturas.Add(detalle);
                    _contexto.Facturas.Update(factura);
                }
                else
                {
                    detalle.Id = validarDetalleDuplicado.Id;
                    validarExistenciaDeFactura.AgregarDetalleDeLaFactura(detalle);
                    _contexto.DetallesFacturas.Update(validarDetalleDuplicado);
                    _contexto.Facturas.Update(factura);
                }
                buscarProductoDelDetalle.AjustarStock(detalle.Cantidad);
                _contexto.Productos.Update(buscarProductoDelDetalle);
                _contexto.SaveChanges();
            }   
        }

        public void EliminarFactura(Factura factura)
        {
            var validarExistenciaDeFactura = _contexto.Facturas.Include(d => d.DetallesDeFactura).FirstOrDefault(x => x.Numero == factura.Numero);
            if (validarExistenciaDeFactura!=null)
            {
                factura.EliminarTodosLosDetalles();
                _contexto.Facturas.Update(factura);
                _contexto.Facturas.Remove(factura);
                _contexto.SaveChanges();
            }
        }

        public void EliminarDetalleDeFactura(DetalleFactura detalle)
        {
            var validarExistenciaDeDetalle = _contexto.DetallesFacturas.FirstOrDefault(x => x.ProductoDelDetalle == detalle.ProductoDelDetalle);
            if (validarExistenciaDeDetalle!=null)
            {
                validarExistenciaDeDetalle.FacturaDelDetalle.EliminarDetalle(validarExistenciaDeDetalle);
                _contexto.DetallesFacturas.Remove(validarExistenciaDeDetalle);
                _contexto.Facturas.Update(validarExistenciaDeDetalle.FacturaDelDetalle);
                _contexto.SaveChanges();
            }
        }

        public void ModificarFactura(Factura facturaActualizada)
        {
            var facturaAnterior = _contexto.Facturas.Include(d=>d.DetallesDeFactura).FirstOrDefault(x=>x.Numero == facturaActualizada.Numero);
            if (facturaActualizada!=null)
            {
                facturaActualizada.Id = facturaAnterior.Id;
                foreach (DetalleFactura d in facturaAnterior.DetallesDeFactura)
                {
                    facturaActualizada.AgregarDetalleDeLaFactura(d);
                }
                _contexto.Facturas.Remove(facturaAnterior);
                _contexto.Facturas.Add(facturaActualizada);
                _contexto.SaveChanges();
            }
        }
    }
}
