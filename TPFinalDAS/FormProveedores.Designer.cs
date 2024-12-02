namespace Vista
{
    partial class FormProveedores
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
            label4 = new Label();
            txtContactoProveedor = new TextBox();
            lblLeyenda = new Label();
            dgvProveedor = new DataGridView();
            btnEliminarCliente = new Button();
            btnModificarModificarCliente = new Button();
            btnRegistrarCliente = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDireccionProveedor = new TextBox();
            txtNombreProveedor = new TextBox();
            txtCodigoProveedor = new TextBox();
            label5 = new Label();
            checkListProductos = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 37;
            label4.Text = "Contacto";
            // 
            // txtContactoProveedor
            // 
            txtContactoProveedor.Location = new Point(12, 191);
            txtContactoProveedor.Name = "txtContactoProveedor";
            txtContactoProveedor.Size = new Size(150, 27);
            txtContactoProveedor.TabIndex = 36;
            // 
            // lblLeyenda
            // 
            lblLeyenda.AutoSize = true;
            lblLeyenda.Location = new Point(12, 383);
            lblLeyenda.Name = "lblLeyenda";
            lblLeyenda.Size = new Size(203, 20);
            lblLeyenda.TabIndex = 35;
            lblLeyenda.Text = "Bienvenido al campo clientes";
            // 
            // dgvProveedor
            // 
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Location = new Point(168, 32);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.RowHeadersWidth = 51;
            dgvProveedor.Size = new Size(474, 291);
            dgvProveedor.TabIndex = 34;
            dgvProveedor.CellClick += dgvProveedor_CellClick;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(523, 329);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(119, 33);
            btnEliminarCliente.TabIndex = 33;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnModificarModificarCliente
            // 
            btnModificarModificarCliente.Location = new Point(347, 329);
            btnModificarModificarCliente.Name = "btnModificarModificarCliente";
            btnModificarModificarCliente.Size = new Size(119, 33);
            btnModificarModificarCliente.TabIndex = 32;
            btnModificarModificarCliente.Text = "Modificar";
            btnModificarModificarCliente.UseVisualStyleBackColor = true;
            btnModificarModificarCliente.Click += btnModificarModificarCliente_Click;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Location = new Point(168, 329);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(119, 33);
            btnRegistrarCliente.TabIndex = 31;
            btnRegistrarCliente.Text = "Registrar";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 30;
            label3.Text = "Dirección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 29;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 28;
            label1.Text = "Codigo";
            // 
            // txtDireccionProveedor
            // 
            txtDireccionProveedor.Location = new Point(12, 138);
            txtDireccionProveedor.Name = "txtDireccionProveedor";
            txtDireccionProveedor.Size = new Size(150, 27);
            txtDireccionProveedor.TabIndex = 27;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(12, 85);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(150, 27);
            txtNombreProveedor.TabIndex = 26;
            // 
            // txtCodigoProveedor
            // 
            txtCodigoProveedor.Location = new Point(12, 32);
            txtCodigoProveedor.Name = "txtCodigoProveedor";
            txtCodigoProveedor.Size = new Size(150, 27);
            txtCodigoProveedor.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 221);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 39;
            label5.Text = "Productos";
            // 
            // checkListProductos
            // 
            checkListProductos.FormattingEnabled = true;
            checkListProductos.Location = new Point(12, 244);
            checkListProductos.Name = "checkListProductos";
            checkListProductos.Size = new Size(150, 114);
            checkListProductos.TabIndex = 40;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 412);
            Controls.Add(checkListProductos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtContactoProveedor);
            Controls.Add(lblLeyenda);
            Controls.Add(dgvProveedor);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnModificarModificarCliente);
            Controls.Add(btnRegistrarCliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDireccionProveedor);
            Controls.Add(txtNombreProveedor);
            Controls.Add(txtCodigoProveedor);
            Name = "FormProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProveedores";
            Load += FormProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtContactoProveedor;
        private Label lblLeyenda;
        private DataGridView dgvProveedor;
        private Button btnEliminarCliente;
        private Button btnModificarModificarCliente;
        private Button btnRegistrarCliente;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDireccionProveedor;
        private TextBox txtNombreProveedor;
        private TextBox txtCodigoProveedor;
        private Label label5;
        private CheckedListBox checkListProductos;
    }
}