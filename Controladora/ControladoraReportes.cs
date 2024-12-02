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
            return _context.Facturas.Include(c=>c.ClienteDeFactura).Include(d=>d.DetallesDeFactura).OrderBy(f=>f.Fecha).ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Producto> LeerProductosMasVendidos()
        {
            return _context.Productos.Include(x=>x.DetalleFactura).ToList().AsReadOnly();//.Where(x=>x.DetallesDeFactura).Include(x=>x.DetallesDeFactura).ThenInclude(p => p.Producto).Sum().OrderByDescending(c => c.Cantidad).ToList().AsReadOnly();
        }
    }
}
