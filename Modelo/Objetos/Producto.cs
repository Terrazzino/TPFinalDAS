using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Objetos
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public decimal Precio {  get; set; }
        public string Descripcion { get; set; }
        public int Stock {  get; set; }
        public int CategoriaId { get; set; }
        public Categoria CategoriaDelProducto { get; set; }

        public DetalleFactura DetalleFactura { get; set; }
        public void AjustarStock(int cantidad)
        {
            Stock -= cantidad;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
