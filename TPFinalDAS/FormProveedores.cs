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
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        // Utilidades para el desarrollo del CRUD

        ControladoraProveedores controladora = new ControladoraProveedores();
        Proveedor proveedorSeleccionado = new Proveedor();

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            var proveedores = controladora.LeerProveedores();
            var datosProveedores = proveedores.Select(p => new
            {
                Codigo = p.Codigo,
                Nombre = p.Nombre,
                Direccion = p.Direccion,
                Contacto = p.Contacto,
                Productos = string.Join(" - ", p.Productos.Select(n => n.Nombre)),
            }).ToList();

            dgvProveedor.DataSource = null;
            dgvProveedor.DataSource = datosProveedores;

            checkListProductos.Items.Clear();
            foreach (Producto producto in controladora.LeerProductos())
            {
                checkListProductos.Items.Add(producto.Nombre);
            }
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            proveedorSeleccionado = controladora.LeerProveedores().FirstOrDefault(x => x.Codigo == dgvProveedor.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtCodigoProveedor.Text = proveedorSeleccionado.Codigo;
            txtNombreProveedor.Text = proveedorSeleccionado.Nombre;
            txtDireccionProveedor.Text = proveedorSeleccionado.Direccion;
            txtContactoProveedor.Text = proveedorSeleccionado.Contacto;

            for (int i = 0; i < checkListProductos.Items.Count; i++)
            {
                checkListProductos.SetItemChecked(i, false);
            }

            foreach (Producto prod in proveedorSeleccionado.Productos)
            {
                for (int i = 0; i < checkListProductos.Items.Count; i++)
                {
                    if (checkListProductos.Items[i].ToString() == prod.Nombre)
                    {
                        checkListProductos.SetItemChecked(i, true);
                    }
                }
            }
        }

        private Proveedor ValidarCamposYCrear()
        {
            if (txtCodigoProveedor.Text != "" && txtNombreProveedor.Text != "" && txtDireccionProveedor.Text != "" && txtContactoProveedor.Text != "")
            {
                Proveedor proveedor = new Proveedor()
                {
                    Codigo = txtCodigoProveedor.Text,
                    Nombre = txtNombreProveedor.Text,
                    Direccion = txtDireccionProveedor.Text,
                    Contacto = txtContactoProveedor.Text,
                };
                if (checkListProductos.Items.Count > 0)
                {
                    foreach (var p in checkListProductos.CheckedItems)
                    {
                        var producto = controladora.LeerProductos().FirstOrDefault(x => x.Nombre == p.ToString());
                        if (producto != null)
                        {
                            proveedor.AgregarProductoAlProveedor(producto);
                        }
                    }
                }
                return proveedor;
            }
            else
            {
                return null;
            }
        }

        //CRUD

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            var proveedor = ValidarCamposYCrear();
            if (proveedor != null)
            {
                controladora.RegistrarProveedor(proveedor);
                ActualizarGrilla();
                lblLeyenda.Text = $"El proveedor {proveedor.Nombre} se a registrado";
            }
            else
            {
                lblLeyenda.Text = "El proveedor no pudo ser registrado";
            }
        }

        private void btnModificarModificarCliente_Click(object sender, EventArgs e)
        {
            if (proveedorSeleccionado != null)
            {
                var proveedorActualizado = ValidarCamposYCrear();

                proveedorSeleccionado.Nombre = proveedorActualizado.Nombre;
                proveedorSeleccionado.Direccion = proveedorActualizado.Direccion;
                proveedorSeleccionado.Contacto = proveedorActualizado.Contacto;
                proveedorSeleccionado.Productos = proveedorActualizado.Productos;

                controladora.ModificarProveedor(proveedorSeleccionado);
                ActualizarGrilla();
                lblLeyenda.Text = $"El proveedor {proveedorSeleccionado.Nombre} a sido modificado";
            }
            else
            {
                lblLeyenda.Text = "Algo a fallado al modificar el proveedor";
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (proveedorSeleccionado!=null)
            {
                controladora.EliminarProveedor(proveedorSeleccionado);
                ActualizarGrilla();
                lblLeyenda.Text = $"El provedor {proveedorSeleccionado.Nombre} se a eliminado";
            }
            else
            {
                lblLeyenda.Text = "Algo a fallado al eliminar el proveedor";
            }
        }
    }
}
