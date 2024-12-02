
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Objetos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Contacto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Factura> FacturasDeCliente { get; set; } = new List<Factura>();

        public void AgregarFacturaAlCliente(Factura factura)
        {
            var validarDuplicado = FacturasDeCliente.FirstOrDefault(x=>x.Numero == factura.Numero);
            if (validarDuplicado == null)
            {
                FacturasDeCliente.Add(factura);
            }
        }

        public void EliminarFacturaDelCliente(Factura factura)
        {
            var validarExistencia = FacturasDeCliente.FirstOrDefault(x=>x.Numero == factura.Numero);
            if (validarExistencia != null)
            {
                FacturasDeCliente.Remove(factura);
            }
        }

    }
}
