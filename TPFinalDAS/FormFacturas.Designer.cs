namespace Vista
{
    partial class FormFacturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvFactura = new DataGridView();
            btnEliminarFactura = new Button();
            btnModificarFactura = new Button();
            btnRegistrarFactura = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNumeroFactura = new TextBox();
            dateFactura = new DateTimePicker();
            cmbClientes = new ComboBox();
            btnEliminarDetalle = new Button();
            btnRegistrarDetalle = new Button();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblDetalles = new Label();
            numCantidad = new NumericUpDown();
            lblLeyenda = new Label();
            cmbProductos = new ComboBox();
            dgvDetalles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // dgvFactura
            // 
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Location = new Point(168, 32);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowHeadersWidth = 51;
            dgvFactura.Size = new Size(474, 133);
            dgvFactura.TabIndex = 50;
            dgvFactura.CellClick += dgvFactura_CellClick;
            // 
            // btnEliminarFactura
            // 
            btnEliminarFactura.Location = new Point(509, 171);
            btnEliminarFactura.Name = "btnEliminarFactura";
            btnEliminarFactura.Size = new Size(133, 33);
            btnEliminarFactura.TabIndex = 49;
            btnEliminarFactura.Text = "Eliminar Factura";
            btnEliminarFactura.UseVisualStyleBackColor = true;
            btnEliminarFactura.Click += btnEliminarFactura_Click;
            // 
            // btnModificarFactura
            // 
            btnModificarFactura.Location = new Point(338, 171);
            btnModificarFactura.Name = "btnModificarFactura";
            btnModificarFactura.Size = new Size(133, 33);
            btnModificarFactura.TabIndex = 48;
            btnModificarFactura.Text = "Modificar Factura";
            btnModificarFactura.UseVisualStyleBackColor = true;
            btnModificarFactura.Click += btnModificarFactura_Click;
            // 
            // btnRegistrarFactura
            // 
            btnRegistrarFactura.Location = new Point(168, 171);
            btnRegistrarFactura.Name = "btnRegistrarFactura";
            btnRegistrarFactura.Size = new Size(133, 33);
            btnRegistrarFactura.TabIndex = 47;
            btnRegistrarFactura.Text = "Registrar Factura";
            btnRegistrarFactura.UseVisualStyleBackColor = true;
            btnRegistrarFactura.Click += btnRegistrarFactura_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 46;
            label3.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 45;
            label2.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 44;
            label1.Text = "Numero";
            // 
            // txtNumeroFactura
            // 
            txtNumeroFactura.Location = new Point(12, 32);
            txtNumeroFactura.Name = "txtNumeroFactura";
            txtNumeroFactura.Size = new Size(150, 27);
            txtNumeroFactura.TabIndex = 41;
            // 
            // dateFactura
            // 
            dateFactura.Location = new Point(12, 85);
            dateFactura.Name = "dateFactura";
            dateFactura.Size = new Size(150, 27);
            dateFactura.TabIndex = 51;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(12, 138);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(150, 28);
            cmbClientes.TabIndex = 52;
            // 
            // btnEliminarDetalle
            // 
            btnEliminarDetalle.Location = new Point(509, 403);
            btnEliminarDetalle.Name = "btnEliminarDetalle";
            btnEliminarDetalle.Size = new Size(133, 33);
            btnEliminarDetalle.TabIndex = 59;
            btnEliminarDetalle.Text = "Eliminar Detalle";
            btnEliminarDetalle.UseVisualStyleBackColor = true;
            btnEliminarDetalle.Click += btnEliminarDetalle_Click;
            // 
            // btnRegistrarDetalle
            // 
            btnRegistrarDetalle.Location = new Point(168, 403);
            btnRegistrarDetalle.Name = "btnRegistrarDetalle";
            btnRegistrarDetalle.Size = new Size(133, 33);
            btnRegistrarDetalle.TabIndex = 57;
            btnRegistrarDetalle.Text = "Registrar Detalle";
            btnRegistrarDetalle.UseVisualStyleBackColor = true;
            btnRegistrarDetalle.Click += btnRegistrarDetalle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 295);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 56;
            label4.Text = "Cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 241);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 54;
            label6.Text = "Producto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 207);
            label7.Name = "label7";
            label7.Size = new Size(663, 20);
            label7.TabIndex = 63;
            label7.Text = "_____________________________________________________________________________________________________________";
            // 
            // lblDetalles
            // 
            lblDetalles.AutoSize = true;
            lblDetalles.Location = new Point(168, 241);
            lblDetalles.Name = "lblDetalles";
            lblDetalles.Size = new Size(147, 20);
            lblDetalles.TabIndex = 64;
            lblDetalles.Text = "Detalle de la factura:";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(12, 318);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(150, 27);
            numCantidad.TabIndex = 65;
            // 
            // lblLeyenda
            // 
            lblLeyenda.AutoSize = true;
            lblLeyenda.Location = new Point(12, 447);
            lblLeyenda.Name = "lblLeyenda";
            lblLeyenda.Size = new Size(262, 20);
            lblLeyenda.TabIndex = 66;
            lblLeyenda.Text = "Bienvenido al campo de facturaciones";
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(12, 264);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(150, 28);
            cmbProductos.TabIndex = 67;
            // 
            // dgvDetalles
            // 
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Location = new Point(168, 263);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.RowHeadersWidth = 51;
            dgvDetalles.Size = new Size(474, 134);
            dgvDetalles.TabIndex = 68;
            dgvDetalles.CellClick += dgvDetalles_CellClick;
            // 
            // FormFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 476);
            Controls.Add(dgvDetalles);
            Controls.Add(cmbProductos);
            Controls.Add(lblLeyenda);
            Controls.Add(numCantidad);
            Controls.Add(lblDetalles);
            Controls.Add(label7);
            Controls.Add(btnEliminarDetalle);
            Controls.Add(btnRegistrarDetalle);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(cmbClientes);
            Controls.Add(dateFactura);
            Controls.Add(dgvFactura);
            Controls.Add(btnEliminarFactura);
            Controls.Add(btnModificarFactura);
            Controls.Add(btnRegistrarFactura);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumeroFactura);
            Name = "FormFacturas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormFacturas";
            Load += FormFacturas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkListProductos;
        private CheckedListBox checkedListBox1;
        private Label label5;
        private Label label4;
        private TextBox txtContactoProveedor;
        private Label lblLeyenda;
        private DataGridView dgvFactura;
        private Button btnEliminarFactura;
        private Button btnModificarFactura;
        private Button btnRegistrarFactura;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNumeroFactura;
        private Label label6;
        private DateTimePicker dateFactura;
        private ComboBox cmbClientes;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgvDetalles;
        private Button btnEliminarDetalle;
        private Button btnRegistrarDetalle;
        private TextBox textBox1;
        private Label label7;
        private Label lblDetalles;
        private NumericUpDown numCantidad;
        private ComboBox cmbProductos;
    }
}