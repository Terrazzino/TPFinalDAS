using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Objetos
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        
        public decimal Subtotal { get; set; }

        public Producto Producto { get; set; }

        public void CalcularSubtotal()
        {
            Subtotal = Cantidad * PrecioUnitario;
        }
        public decimal CalcularSubtotalParaLoad()
        {
            return Cantidad * PrecioUnitario;
        }
    }
}
