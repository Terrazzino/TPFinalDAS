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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        // Utilidades para el desarrollo del CRUD

        ControladoraProductos controladora = new ControladoraProductos();
        Producto productoSeleccionado = new Producto();
        ProductoImportado productoImportadoSeleccionado = new ProductoImportado();
        bool importado = false;
        private void FormProductos_Load(object sender, EventArgs e)
        {
            ActualizarGrillas();
            txtPais.Enabled = false;
        }
        private void ActualizarGrillas()
        {
            var productos = controladora.LeerProductos();
            var productosImportados = controladora.LeerProductosImportados();

            var datosProducto = productos.Select(p => new
            {
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                Precio = p.Precio,
                Stock = p.Stock,
                Codigo = p.Codigo,
            }).ToList();

            var datosProductoImportado = productosImportados.Select(p => new
            {
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                Precio = p.Precio,
                Stock = p.Stock,
                Pais = p.Pais,
                Codigo = p.Codigo,
            }).ToList();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = datosProducto;

            dgvProductosImportados.DataSource = null;
            dgvProductosImportados.DataSource = datosProductoImportado;

            cmbCategorias.DataSource = null;
            cmbCategorias.DataSource = controladora.LeerTodaLasCategorias();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productoSeleccionado = controladora.LeerProductos().FirstOrDefault(x => x.Codigo == dgvProductos.Rows[e.RowIndex].Cells[4].Value.ToString());

            txtCodigoProducto.Text = productoSeleccionado.Codigo.ToString();
            txtNombreProducto.Text = productoSeleccionado.Nombre.ToString();
            txtDescripcionProducto.Text = productoSeleccionado.Descripcion.ToString();
            txtPrecioProducto.Text = productoSeleccionado.Precio.ToString();
            txtStockProducto.Text = productoSeleccionado.Stock.ToString();
            checkImportado.Checked = false;
            cmbCategorias.Text = productoSeleccionado.CategoriaDelProducto.Nombre.ToString();

            lblLeyenda.Text = $"A seleccionado el producto {productoSeleccionado.Nombre}";
        }

        private void dgvProductosImportados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productoImportadoSeleccionado = controladora.LeerProductosImportados().FirstOrDefault(x => x.Codigo == dgvProductosImportados.Rows[e.RowIndex].Cells[5].Value.ToString());

            txtCodigoProducto.Text = productoImportadoSeleccionado.Codigo.ToString();
            txtNombreProducto.Text = productoImportadoSeleccionado.Nombre.ToString();
            txtDescripcionProducto.Text = productoImportadoSeleccionado.Descripcion.ToString();
            txtPrecioProducto.Text = productoImportadoSeleccionado.Precio.ToString();
            txtStockProducto.Text = productoImportadoSeleccionado.Stock.ToString();
            checkImportado.Checked = true;
            txtPais.Text = productoImportadoSeleccionado.Pais;
            cmbCategorias.Text = productoImportadoSeleccionado.CategoriaDelProducto.Nombre.ToString();

            lblLeyenda.Text = $"A seleccionado el producto {productoImportadoSeleccionado.Nombre}";
        }

        private Producto ValidarYCrearProducto()
        {
            if (txtCodigoProducto.Text != "" && txtNombreProducto.Text != "" && txtDescripcionProducto.Text != "" && txtPrecioProducto.Text != "" && txtStockProducto.Text != "" && cmbCategorias.Text != "" && txtPais.Enabled==false)
            {
                Producto producto = new Producto()
                {
                    Codigo = txtCodigoProducto.Text,
                    Nombre = txtNombreProducto.Text,
                    Descripcion = txtDescripcionProducto.Text,
                    Precio = decimal.Parse(txtPrecioProducto.Text),
                    Stock = int.Parse(txtStockProducto.Text),
                    CategoriaDelProducto = controladora.BuscarCategoriaDelProducto(cmbCategorias.Text)
                };
                return producto;
            }
            else
            {
                return null;
            }
        }

        private ProductoImportado ValidarYCrearProductoImportado()
        {
            if (txtCodigoProducto.Text != "" && txtNombreProducto.Text != "" && txtDescripcionProducto.Text != "" && txtPrecioProducto.Text != "" && txtStockProducto.Text != "" && cmbCategorias.Text != "" && txtPais.Enabled==true && txtPais.Text!="")
            {
                ProductoImportado productoImportado = new ProductoImportado()
                {
                    Codigo = txtCodigoProducto.Text,
                    Nombre = txtNombreProducto.Text,
                    Descripcion = txtDescripcionProducto.Text,
                    Precio = decimal.Parse(txtPrecioProducto.Text),
                    Stock = int.Parse(txtStockProducto.Text),
                    CategoriaDelProducto = controladora.BuscarCategoriaDelProducto(cmbCategorias.Text),
                    Pais = txtPais.Text,
                };
                return productoImportado;
            }
            else
            {
                return null;
            }
        }

        private void checkImportado_CheckedChanged(object sender, EventArgs e)
        {
            importado = checkImportado.Checked;
            txtPais.Enabled = importado;
        }

        // CRUD

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            if (importado == false)
            {
                var producto = ValidarYCrearProducto();
                if (producto != null)
                {
                    controladora.RegistrarProducto(producto);
                    ActualizarGrillas();
                    lblLeyenda.Text = $"El producto {producto.Nombre} se a registrado";
                }
                else
                {
                    lblLeyenda.Text = $"El producto no pudo ser registrado";
                }
            }
            else
            {
                var productoImportado = ValidarYCrearProductoImportado();
                if (productoImportado != null)
                {
                    controladora.RegistrarProducto(productoImportado);
                    ActualizarGrillas();
                    lblLeyenda.Text = $"El producto importado {productoImportado.Nombre} se a registrado";
                }
                else
                {
                    lblLeyenda.Text = $"El producto importado no pudo ser registrado";
                }
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (!importado)
            {
                if (productoSeleccionado != null)
                {
                    var producto = ValidarYCrearProducto();
                    producto.Codigo = productoSeleccionado.Codigo;
                    controladora.ModificarProducto(producto);
                    ActualizarGrillas();
                    lblLeyenda.Text = $"El producto {productoSeleccionado.Nombre} a sido actualizado";
                }
                else
                {
                    lblLeyenda.Text = "El producto no pudo actualizarse";
                }
            }
            else
            {
                if (productoImportadoSeleccionado != null)
                {
                    var productoImportado = ValidarYCrearProductoImportado();
                    productoImportado.Codigo = productoImportadoSeleccionado.Codigo;
                    productoImportado.Id = productoImportadoSeleccionado.Id;
                    controladora.ModificarProducto(productoImportado);
                    ActualizarGrillas();
                    lblLeyenda.Text = $"El producto importado {productoImportadoSeleccionado.Nombre} a sido actualizado";
                }
                else
                {
                    lblLeyenda.Text = "El producto importado no pudo actualizarse";
                }
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (importado == false)
            {
                if (productoSeleccionado != null)
                {
                    controladora.EliminarProducto(productoSeleccionado);
                    ActualizarGrillas();
                    lblLeyenda.Text = $"El produto {productoSeleccionado.Nombre} a sido eliminado";
                }
                else
                {
                    lblLeyenda.Text = "No se a podido eliminar el producto";
                }
            }
            else
            {
                if (productoImportadoSeleccionado != null)
                {
                    controladora.EliminarProducto(productoImportadoSeleccionado);
                    ActualizarGrillas();
                    lblLeyenda.Text = $"El produto {productoImportadoSeleccionado.Nombre} a sido eliminado";
                }
                else
                {
                    lblLeyenda.Text = "No se a podido eliminar el producto";
                }
            }
        }

    }
}
