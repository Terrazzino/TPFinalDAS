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
        public ReadOnlyCollection<DetalleFactura> LeerProductosMasVendidos()
        {
            return _context.DetallesFacturas.Include(p => p.ProductoDelDetalle).OrderBy(c => c.Cantidad).ToList().AsReadOnly();
        }
    }
}
