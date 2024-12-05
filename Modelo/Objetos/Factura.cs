using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Objetos
{
    public class Factura
    {
        public int Id { get; set; }
        public int Numero {  get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total {  get; set; }
        public Cliente Cliente { get; set; }
        public List<DetalleFactura> DetallesDeFactura { get; set;} = new List<DetalleFactura>();
  
        public void AgregarDetalleDeLaFactura(DetalleFactura detalle)
        {
            var validarDuplicado = DetallesDeFactura.FirstOrDefault(x=>x.Producto.Nombre == detalle.Producto.Nombre);
            if (validarDuplicado == null)
            {
                detalle.CalcularSubtotal();
                DetallesDeFactura.Add(detalle);
            }
            else
            {
                validarDuplicado.Cantidad += detalle.Cantidad;
                validarDuplicado.CalcularSubtotal();
            }
            CalcularTotalDeFactura();
        }

        public void EliminarDetalle(DetalleFactura detalle)
        {
            var validarExistencia = DetallesDeFactura.FirstOrDefault(x=>x.Producto.Nombre == detalle.Producto.Nombre);
            if (validarExistencia != null)
            {
                validarExistencia.Cantidad -= detalle.Cantidad;
                validarExistencia.CalcularSubtotal();
                DetallesDeFactura.Remove(detalle);
            }
            CalcularTotalDeFactura();
        }
       

        public void CalcularTotalDeFactura()
        {
            Total = 0;
            foreach (DetalleFactura d in DetallesDeFactura)
            {
                Total += d.Subtotal;
            }
        }



        public override string ToString()
        {
            return Numero.ToString();
        }
    }
}
