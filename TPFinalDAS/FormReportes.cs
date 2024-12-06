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
                Cliente = f.Cliente.Nombre,
                Total = f.Total,

            }).ToList();

            dgvFacturas.DataSource = null;
            dgvFacturas.DataSource = facturas;
        }

        private void ActualizarGrillaProductosMasVendidos()
        {
            var facturas = controladora.LeerFacturasConProductos();
            List<DetalleFactura> detalles = new List<DetalleFactura>();
            foreach ( var f in facturas)
            {
                foreach(var d in f.DetallesDeFactura)
                {
                    var validarDuplicado = detalles.FirstOrDefault(x=>x.Producto.Nombre == d.Producto.Nombre);
                    if (validarDuplicado != null)
                    {
                        validarDuplicado.Cantidad += d.Cantidad;
                        validarDuplicado.Subtotal = d.Subtotal;
                    }
                    else
                    {
                        detalles.Add(d);
                    }
                    
                }
            }
            var detallForm = detalles.Select(d => new
            {
                Producto = d.Producto.Nombre,
                Cantidad = d.Cantidad,
                Subtotal = d.CalcularSubtotalParaLoad(),

            }).ToList();

            dgvProductosMasVendidos.DataSource = null;
            dgvProductosMasVendidos.DataSource = detallForm.OrderByDescending(x=>x.Cantidad).ToList();
        }
    }
}
