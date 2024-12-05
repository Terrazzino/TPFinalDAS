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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        // Utilidades para el desarrollo del CRUD

        ControladoraClientes controladora = new ControladoraClientes();
        Cliente clienteSeleccionado = new Cliente();

        private void FormClientes_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            var clientes = controladora.LeerClientes();
            var datosCliente = clientes.Select(c => new
            {
                Codigo = c.Codigo,
                Nombre = c.Nombre,
                Direccion = c.Direccion,
                Contacto = c.Contacto,
            }).ToList();

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = datosCliente;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clienteSeleccionado = controladora.LeerClientes().FirstOrDefault(x => x.Codigo == dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (clienteSeleccionado != null)
            {
                txtCodigoCliente.Text = clienteSeleccionado.Codigo.ToString();
                txtNombreCliente.Text = clienteSeleccionado.Nombre.ToString();
                txtDireccionCliente.Text = clienteSeleccionado.Direccion.ToString();
                txtContactoCliente.Text = clienteSeleccionado.Contacto.ToString();

                lblLeyenda.Text = $"El cliente {clienteSeleccionado.Nombre} a sido seleccinado";
            }
        }

        private Cliente ValidarCamposYCrear()
        {
            if (txtCodigoCliente.Text != "" && txtNombreCliente.Text != "" && txtDireccionCliente.Text != "" && txtContactoCliente.Text != "")
            {
                Cliente cliente = new Cliente()
                {
                    Codigo = txtCodigoCliente.Text,
                    Nombre = txtNombreCliente.Text,
                    Direccion = txtDireccionCliente.Text,
                    Contacto = txtContactoCliente.Text,
                };
                return cliente;
            }
            else
            {
                return null;
            }
        }

        // CRUD
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            var cliente = ValidarCamposYCrear();
            if (cliente != null)
            {
                controladora.RegistrarCliente(cliente);
                ActualizarGrilla();
                lblLeyenda.Text = $"El cliente {cliente.Nombre} se a registrado";
            }
            else
            {
                lblLeyenda.Text = "No se a podido registrar el cliente";
            }
        }

        private void btnModificarModificarCliente_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado != null)
            {
                var clienteActualizado = ValidarCamposYCrear();

                clienteSeleccionado.Nombre = clienteActualizado.Nombre;
                clienteSeleccionado.Direccion = clienteActualizado.Direccion;
                clienteSeleccionado.Contacto = clienteActualizado.Contacto;


                controladora.ModificarCliente(clienteSeleccionado);
                ActualizarGrilla();
                lblLeyenda.Text = $"El cliente {clienteSeleccionado.Nombre} se a modificado";
            }
            else
            {
                lblLeyenda.Text = "No se a podido modificar el cliente";
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado!=null)
            {
                controladora.EliminarCliente(clienteSeleccionado);
                ActualizarGrilla();
                lblLeyenda.Text = $"El cliente {clienteSeleccionado.Nombre} se a eliminado";
            }
            else
            {
                lblLeyenda.Text = "No se a podido eliminar el cliente";
            }
        }
    }
}
