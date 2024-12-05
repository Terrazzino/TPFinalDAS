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
    public class ControladoraReportes
    {
        Contexto _context = new Contexto();

        public ReadOnlyCollection<Factura> LeerFacturas()
        {
            return _context.Facturas.Include(c => c.Cliente).Include(d => d.DetallesDeFactura).OrderBy(f => f.Fecha).ToList().AsReadOnly();
        }
        public ReadOnlyCollection<ProductoReporte> LeerProductosMasVendidos()
        {
            var lista = _context.Productos.Include(x => x.DetalleFactura).AsNoTracking();
            var result = lista.GroupBy(l => l.DetalleFactura.Producto)
                              .Select(cl => new ProductoReporte
                              {
                                  Id = cl.Key.Id,
                                  Nombre = cl.Key.Nombre,
                                  Codigo = cl.Key.Codigo,
                                  Descripcion = cl.Key.Descripcion,
                                  CantidadVendida = cl.Sum(c => c.DetalleFactura.Cantidad)
                                  
                              }).OrderByDescending(p => p.CantidadVendida).ToList().AsReadOnly();
            return result;
        }
    }
}
