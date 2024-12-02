namespace Vista
{
    partial class FormClientes
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
            lblLeyenda = new Label();
            dgvClientes = new DataGridView();
            btnEliminarCliente = new Button();
            btnModificarModificarCliente = new Button();
            btnRegistrarCliente = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDireccionCliente = new TextBox();
            txtNombreCliente = new TextBox();
            txtCodigoCliente = new TextBox();
            label4 = new Label();
            txtContactoCliente = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblLeyenda
            // 
            lblLeyenda.AutoSize = true;
            lblLeyenda.Location = new Point(12, 328);
            lblLeyenda.Name = "lblLeyenda";
            lblLeyenda.Size = new Size(203, 20);
            lblLeyenda.TabIndex = 22;
            lblLeyenda.Text = "Bienvenido al campo clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(143, 32);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(474, 291);
            dgvClientes.TabIndex = 21;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(12, 294);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(125, 29);
            btnEliminarCliente.TabIndex = 20;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnModificarModificarCliente
            // 
            btnModificarModificarCliente.Location = new Point(12, 259);
            btnModificarModificarCliente.Name = "btnModificarModificarCliente";
            btnModificarModificarCliente.Size = new Size(125, 29);
            btnModificarModificarCliente.TabIndex = 19;
            btnModificarModificarCliente.Text = "Modificar";
            btnModificarModificarCliente.UseVisualStyleBackColor = true;
            btnModificarModificarCliente.Click += btnModificarModificarCliente_Click;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Location = new Point(12, 224);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(125, 29);
            btnRegistrarCliente.TabIndex = 18;
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
            label3.TabIndex = 17;
            label3.Text = "Dirección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 16;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 15;
            label1.Text = "Codigo";
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.Location = new Point(12, 138);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(125, 27);
            txtDireccionCliente.TabIndex = 14;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(12, 85);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(125, 27);
            txtNombreCliente.TabIndex = 13;
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(12, 32);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.Size = new Size(125, 27);
            txtCodigoCliente.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 24;
            label4.Text = "Contacto";
            // 
            // txtContactoCliente
            // 
            txtContactoCliente.Location = new Point(12, 191);
            txtContactoCliente.Name = "txtContactoCliente";
            txtContactoCliente.Size = new Size(125, 27);
            txtContactoCliente.TabIndex = 23;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 357);
            Controls.Add(label4);
            Controls.Add(txtContactoCliente);
            Controls.Add(lblLeyenda);
            Controls.Add(dgvClientes);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnModificarModificarCliente);
            Controls.Add(btnRegistrarCliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDireccionCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(txtCodigoCliente);
            Name = "FormClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormClientes";
            Load += FormClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLeyenda;
        private DataGridView dgvClientes;
        private Button btnEliminarCliente;
        private Button btnModificarModificarCliente;
        private Button btnRegistrarCliente;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDireccionCliente;
        private TextBox txtNombreCliente;
        private TextBox txtCodigoCliente;
        private Label label4;
        private TextBox txtContactoCliente;
    }
}