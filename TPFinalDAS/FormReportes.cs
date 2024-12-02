using Controladora;
using Modelo.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }
        ControladoraReportes controladora = new ControladoraReportes();

        private void FormReportes_Load(object sender, EventArgs e)
        {
            ActualizarGrillas();
            ActualizarGrillaProductosMasVendidos();
        }

        private void ActualizarGrillas()
        {
            var facturas = controladora.LeerFacturas().Select(f => new
            {
                Nro_Factura = f.Numero,
                Fecha = f.Fecha,
                Cliente = f.ClienteDeFactura.Nombre,
                Total = f.Total,

            }).ToList();

            dgvFacturas.DataSource = null;
            dgvFacturas.DataSource = facturas;
        }

        private void ActualizarGrillaProductosMasVendidos()
        {
            List<Producto> productos = new List<Producto>();
            //foreach (DetalleFactura de in controladora.LeerProductosMasVendidos())
            //{
            //    productos.Add(de.ProductoDelDetalle);
            //}
            //var datosProductos = controladora.LeerProductosMasVendidos().Select(p => new
            //{
            //    Nombre = p.ProductoDelDetalle.Nombre,
            //    Stock = p.ProductoDelDetalle.Stock,
            //    Cantidad = p.Cantidad,
            //    Total = p.Subtotal,
            //}).ToList();
            dgvProductosMasVendidos.DataSource = null;
            dgvProductosMasVendidos.DataSource = productos;
        }
    }
}
