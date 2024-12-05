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
    public partial class FormFacturas : Form
    {
        public FormFacturas()
        {
            InitializeComponent();
        }

        // Utilidades para el desarrollo del CRUD

        ControladoraFacturaciones controladora = new ControladoraFacturaciones();
        Factura facturaSeleccionada = new Factura();
        DetalleFactura detalleSeleccionado = new DetalleFactura();

        private void FormFacturas_Load(object sender, EventArgs e)
        {
            ActualizarGrillaFacturasYCmbs();
        }

        private void ActualizarGrillaFacturasYCmbs()
        {
            var facturas = controladora.LeerFacturas();
            var datosFacturas = facturas.Select(f => new
            {
                Numero = f.Numero,
                Fecha = f.Fecha,
                Cliente = f.Cliente.Nombre,
               // Total = f.CalcularTotal().ToString(),
            }).ToList();

            dgvFactura.DataSource = null;
            dgvFactura.DataSource = datosFacturas;

            cmbClientes.DataSource = null;
            cmbClientes.DataSource = controladora.LeerClientes();

            cmbProductos.DataSource = null;
            cmbProductos.DataSource = controladora.LeerProductos();
        }

        private void ActualizaGrillaDetalles()
        {
            if (facturaSeleccionada!=null)
            {
                var detalles = facturaSeleccionada.DetallesDeFactura.Select(d => new
                {
                    Nombre = d.Producto.Nombre,
                    Cantidad = d.Cantidad,
                    PrecioUnitario = d.PrecioUnitario,
                    SubTotal = d.Subtotal,
                    //NroFactura = d.Factura.Numero,
                }).ToList();

                dgvDetalles.DataSource = null;
                dgvDetalles.DataSource = detalles;
            }
        }

        private void dgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            facturaSeleccionada = controladora.LeerFacturas().FirstOrDefault(x => x.Numero == int.Parse(dgvFactura.Rows[e.RowIndex].Cells[0].Value.ToString()));

            txtNumeroFactura.Text = facturaSeleccionada.Numero.ToString();
            dateFactura.Value = DateTime.Parse(facturaSeleccionada.Fecha.ToString());
            cmbClientes.Text = facturaSeleccionada.Cliente.Codigo;

            var detalles = facturaSeleccionada.DetallesDeFactura.Select(d => new
            {
                Nombre = d.Producto.Nombre,
                Cantidad = d.Cantidad,
                PrecioUnitario = d.PrecioUnitario,
                SubTotal = d.Subtotal,
            //    NroFactura = d.FacturaDelDetalle.Numero,
            }).ToList();

            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = detalles;
            lblDetalles.Text = $"Detalle de la factura: {facturaSeleccionada.Numero}";
        }
        private void dgvDetalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       //     detalleSeleccionado = controladora.LeerDetalles().FirstOrDefault(x => x.ProductoDelDetalle.Nombre == dgvDetalles.Rows[e.RowIndex].Cells[0].Value.ToString());

        }


        private Factura ValidarYCrearCamposFactura()
        {
            if (txtNumeroFactura.Text != "" && dateFactura.Text != "" && cmbClientes.Text != "")
            {
                Factura factura = new Factura()
                {
                    Numero = int.Parse(txtNumeroFactura.Text),
                    Fecha = dateFactura.Value,
                    Cliente = controladora.LeerClientes().FirstOrDefault(c => c.Codigo == cmbClientes.Text)
                };
                return factura;
            }
            else
            {
                return null;
            }
        }

        private DetalleFactura ValidarYCrearCamposDetalle()
        {
            if (cmbProductos.Text != "" && int.Parse(numCantidad.Value.ToString()) > 0)
            {
                var buscarProducto = controladora.LeerProductos().FirstOrDefault(x => x.Nombre == cmbProductos.Text);
                if (buscarProducto.Stock > int.Parse(numCantidad.Value.ToString()))
                {
                    DetalleFactura detalle = new DetalleFactura()
                    {
                        Cantidad = int.Parse(numCantidad.Value.ToString()),
                        Producto = buscarProducto,
                        PrecioUnitario = buscarProducto.Precio,
                    };
                    return detalle;
                }
                else
                {
                    return null;
                }

            }
            else
            {
                return null;
            }
        }

        //CRUD

        private void btnRegistrarFactura_Click(object sender, EventArgs e)
        {
            var factura = ValidarYCrearCamposFactura();
            if (factura != null)
            {
                controladora.RegistrarFactura(factura);
                ActualizarGrillaFacturasYCmbs();
                lblLeyenda.Text = $"La factura {factura.Numero} a sido registrada";
            }
            else
            {
                lblLeyenda.Text = "A ocurrido un error al registrar la factura";
            }
        }

        private void btnModificarFactura_Click(object sender, EventArgs e)
        {
            if (facturaSeleccionada != null)
            {
                var facturaActualizada = ValidarYCrearCamposFactura();
                facturaActualizada.Numero = facturaSeleccionada.Numero;
                controladora.ModificarFactura(facturaActualizada);
                ActualizarGrillaFacturasYCmbs();
                lblLeyenda.Text = $"La factura {facturaSeleccionada.Numero} a sido actualizada";
            }
            else
            {
                lblLeyenda.Text = "A ocurrido un error al actualizar la factura";
            }
        }

        private void btnEliminarFactura_Click(object sender, EventArgs e)
        {
            if (facturaSeleccionada != null)
            {
                controladora.EliminarFactura(facturaSeleccionada);
                ActualizarGrillaFacturasYCmbs();
                lblLeyenda.Text = $"La factura {facturaSeleccionada.Numero} a sido eliminada";
            }
            else
            {
                lblLeyenda.Text = "A ocurrido un error al eliminar la facturas";
            }
        }

        private void btnRegistrarDetalle_Click(object sender, EventArgs e)
        {
            if (facturaSeleccionada != null)
            {
                var detalle = ValidarYCrearCamposDetalle();
                if (detalle != null)
                {
             //       detalle.FacturaDelDetalle = facturaSeleccionada;
              //      controladora.RegistrarDetalle(facturaSeleccionada, detalle);
                    ActualizarGrillaFacturasYCmbs();
                    ActualizaGrillaDetalles();
             //       lblLeyenda.Text = $"El detalle de {detalle.ProductoDelDetalle.Nombre} a sido registrado";
                }
                else
                {
                    lblLeyenda.Text = "A ocurrido un error al registrar el detalle";
                }
            }
            else
            {
                lblLeyenda.Text = "Debe seleccionar una factura";
            }
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            if (detalleSeleccionado!=null)
            {
                controladora.EliminarDetalleDeFactura(detalleSeleccionado);
                ActualizarGrillaFacturasYCmbs();
                ActualizaGrillaDetalles();
                lblDetalles.Text = $"El detalle a sido eliminado";
            }
            else
            {
                lblLeyenda.Text = "A ocurrido un error al eliminar el detalle";
            }
        }
    }
}
