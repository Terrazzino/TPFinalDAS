using Vista;

namespace TPFinalDAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategorias form = new FormCategorias();
            form.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductos form = new FormProductos();
            form.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();
            form.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProveedores form = new FormProveedores();
            form.Show();
        }

        private void realizarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFacturas form = new FormFacturas();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReportes form = new FormReportes();
            form.Show();
        }
    }
}
