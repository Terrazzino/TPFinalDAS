using Modelo.Clases_Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Objetos
{
    public class Cliente:IdentificacionProveedorCliente
    {
        public int Id { get; set; }
        public string Contacto { get; set; }
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

        public void ModificarFacturaDelCliente(Factura facturaActualizada)
        {
            var buscarFacturaAnterior = FacturasDeCliente.FirstOrDefault(x=> x.Numero == facturaActualizada.Numero);
            if (buscarFacturaAnterior != null)
            {
                facturaActualizada.Id = buscarFacturaAnterior.Id;
                FacturasDeCliente.Remove(buscarFacturaAnterior);
                FacturasDeCliente.Add(facturaActualizada);
            }
        }

        public override string ToString()
        {
            return Codigo.ToString();
        }
    }
}
