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
            return _contexto.Facturas.Include(c => c.Cliente).Include(d=>d.DetallesDeFactura).ThenInclude(x=>x.Producto).ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Cliente> LeerClientes()
        {
            return _contexto.Clientes.ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Producto> LeerProductos()
        {
            return _contexto.Productos.Include(c=>c.Categoria).ToList().AsReadOnly();
        }
       

        public void RegistrarFactura(Factura factura)
        {
            var validarDuplicado = _contexto.Facturas.Include(x=>x.Cliente).Include(d=>d.DetallesDeFactura).ThenInclude(d=>d.Producto).FirstOrDefault(x=>x.Numero==factura.Numero);
            if (validarDuplicado == null)
            {
                _contexto.Facturas.Add(factura);
                _contexto.SaveChanges();
            }
        }
        public void RegistrarDetalle(Factura factura, DetalleFactura detalle)
        {
            factura.AgregarDetalleDeLaFactura(detalle);
            _contexto.Facturas.Update(factura);
            _contexto.SaveChanges();           
        }

        public void EliminarFactura(Factura factura)
        {
            _contexto.Facturas.Remove(factura);
            _contexto.SaveChanges();
        }

        public void EliminarDetalleDeFactura(Factura factura, DetalleFactura detalle)
        {
            factura.EliminarDetalle(detalle);
            _contexto.Facturas.Update(factura);
            _contexto.SaveChanges();
        }

        public void ModificarFactura(Factura facturaActualizada)
        {
            _contexto.Facturas.Update(facturaActualizada);
            _contexto.SaveChanges();
        }
    }
}
