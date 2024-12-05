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
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
        }

        // Utilidades para el desarrollo del CRUD

        ControladoraCategorias controladora = new ControladoraCategorias();
        Categoria categoriaSeleccionada = new Categoria();
        private void FormCategorias_Load(object sender, EventArgs e)
        {
            ActualizarGrillaCategorias();
        }
        private void ActualizarGrillaCategorias()
        {
            var categorias = controladora.LeerCategorias();
            var categoriasConProductos = categorias.Select(c => new
            {
                Categoria = c.Nombre,
                Codigo = c.Codigo,
            ///    Productos = string.Join(" - ", c.Productos.Select(n => n.Nombre))
            }).ToList();

            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = categoriasConProductos;
        }
        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            categoriaSeleccionada = controladora.LeerCategorias().FirstOrDefault(x => x.Codigo == dgvCategorias.Rows[e.RowIndex].Cells[1].Value.ToString());
            
            txtCodigoCategoria.Text = categoriaSeleccionada.Codigo.ToString();
            txtNombreCategoria.Text = categoriaSeleccionada.Nombre.ToString();
            txtDescripcionCategoria.Text = categoriaSeleccionada.Descripcion.ToString();

            lblLeyenda.Text = $"A seleccionado la categoria {categoriaSeleccionada.Nombre}";
        }

        private Categoria ValidarCamposYCrear()
        {
            if (txtCodigoCategoria.Text != "" && txtNombreCategoria.Text != "" && txtDescripcionCategoria.Text != "")
            {
                Categoria categoria = new Categoria()
                {
                    Codigo = txtCodigoCategoria.Text,
                    Nombre = txtNombreCategoria.Text,
                    Descripcion = txtDescripcionCategoria.Text,
                };
                return categoria;
            }
            else
            {
                return null;
            }
        }

        // CRUD

        private void btnRegistrarCategoria_Click(object sender, EventArgs e)
        {
            var categoria = ValidarCamposYCrear();
            if (categoria != null)
            {
                controladora.RegistrarCategoria(categoria);
                ActualizarGrillaCategorias();
                lblLeyenda.Text = $"La categoria {categoria.Nombre} se a registrado";
            }
            else
            {
                lblLeyenda.Text = "Algo a fallado al cargar la categoria";
            }
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            if (categoriaSeleccionada != null)
            {
                var categoriaActualizada = ValidarCamposYCrear();

                categoriaSeleccionada.Nombre = categoriaActualizada.Nombre;
                categoriaSeleccionada.Descripcion = categoriaActualizada.Descripcion;
                controladora.ModificarCategoria(categoriaSeleccionada);
                ActualizarGrillaCategorias();
                lblLeyenda.Text = $"La categoria {categoriaSeleccionada.Nombre} se a modificado";
            }
            else
            {
                lblLeyenda.Text = $"Algo a fallado al modificar la categoria";
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (categoriaSeleccionada != null)
            {
                controladora.EliminarCategoria(categoriaSeleccionada);
                ActualizarGrillaCategorias();
                lblLeyenda.Text = $"La categoria {categoriaSeleccionada.Nombre} se a eliminado";
            }
            else
            {
                lblLeyenda.Text = "Algo a fallado al eliminar la categoria";
            }
        }
    }
}
