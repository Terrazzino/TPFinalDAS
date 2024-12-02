namespace Vista
{
    partial class FormProductos
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
            dgvProductos = new DataGridView();
            btnEliminarProducto = new Button();
            btnModificarProducto = new Button();
            btnRegistrarProducto = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDescripcionProducto = new TextBox();
            txtNombreProducto = new TextBox();
            txtCodigoProducto = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtStockProducto = new TextBox();
            txtPrecioProducto = new TextBox();
            cmbCategorias = new ComboBox();
            dgvProductosImportados = new DataGridView();
            checkImportado = new CheckBox();
            label7 = new Label();
            txtPais = new TextBox();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosImportados).BeginInit();
            SuspendLayout();
            // 
            // lblLeyenda
            // 
            lblLeyenda.AutoSize = true;
            lblLeyenda.Location = new Point(12, 340);
            lblLeyenda.Name = "lblLeyenda";
            lblLeyenda.Size = new Size(220, 20);
            lblLeyenda.TabIndex = 22;
            lblLeyenda.Text = "Bienvenido al campo productos";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(306, 32);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(474, 133);
            dgvProductos.TabIndex = 21;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(155, 246);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(125, 50);
            btnEliminarProducto.TabIndex = 20;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(155, 191);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(125, 52);
            btnModificarProducto.TabIndex = 19;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnRegistrarProducto
            // 
            btnRegistrarProducto.Location = new Point(155, 136);
            btnRegistrarProducto.Name = "btnRegistrarProducto";
            btnRegistrarProducto.Size = new Size(125, 52);
            btnRegistrarProducto.TabIndex = 18;
            btnRegistrarProducto.Text = "Registrar";
            btnRegistrarProducto.UseVisualStyleBackColor = true;
            btnRegistrarProducto.Click += btnRegistrarProducto_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 17;
            label3.Text = "Descripcion";
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
            // txtDescripcionProducto
            // 
            txtDescripcionProducto.Location = new Point(12, 138);
            txtDescripcionProducto.Name = "txtDescripcionProducto";
            txtDescripcionProducto.Size = new Size(125, 27);
            txtDescripcionProducto.TabIndex = 14;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(12, 85);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(125, 27);
            txtNombreProducto.TabIndex = 13;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(12, 32);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(125, 27);
            txtCodigoProducto.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 274);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 28;
            label4.Text = "Categorias";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 221);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 27;
            label5.Text = "Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 168);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 26;
            label6.Text = "Precio";
            // 
            // txtStockProducto
            // 
            txtStockProducto.Location = new Point(12, 244);
            txtStockProducto.Name = "txtStockProducto";
            txtStockProducto.Size = new Size(125, 27);
            txtStockProducto.TabIndex = 24;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(12, 191);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(125, 27);
            txtPrecioProducto.TabIndex = 23;
            // 
            // cmbCategorias
            // 
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(12, 297);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(125, 28);
            cmbCategorias.TabIndex = 29;
            // 
            // dgvProductosImportados
            // 
            dgvProductosImportados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosImportados.Location = new Point(306, 191);
            dgvProductosImportados.Name = "dgvProductosImportados";
            dgvProductosImportados.RowHeadersWidth = 51;
            dgvProductosImportados.Size = new Size(474, 134);
            dgvProductosImportados.TabIndex = 30;
            dgvProductosImportados.CellClick += dgvProductosImportados_CellClick;
            // 
            // checkImportado
            // 
            checkImportado.AutoSize = true;
            checkImportado.Location = new Point(155, 32);
            checkImportado.Name = "checkImportado";
            checkImportado.Size = new Size(102, 24);
            checkImportado.TabIndex = 31;
            checkImportado.Text = "Importado";
            checkImportado.UseVisualStyleBackColor = true;
            checkImportado.CheckedChanged += checkImportado_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(155, 62);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 33;
            label7.Text = "Pais";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(155, 85);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(125, 27);
            txtPais.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(306, 9);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 34;
            label8.Text = "Productos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(306, 168);
            label9.Name = "label9";
            label9.Size = new Size(156, 20);
            label9.TabIndex = 35;
            label9.Text = "Productos Importados";
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 365);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtPais);
            Controls.Add(checkImportado);
            Controls.Add(dgvProductosImportados);
            Controls.Add(cmbCategorias);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtStockProducto);
            Controls.Add(txtPrecioProducto);
            Controls.Add(lblLeyenda);
            Controls.Add(dgvProductos);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnModificarProducto);
            Controls.Add(btnRegistrarProducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescripcionProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtCodigoProducto);
            Name = "FormProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProductos";
            Load += FormProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosImportados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLeyenda;
        private DataGridView dgvProductos;
        private Button btnEliminarProducto;
        private Button btnModificarProducto;
        private Button btnRegistrarProducto;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDescripcionProducto;
        private TextBox txtNombreProducto;
        private TextBox txtCodigoProducto;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtStockProducto;
        private TextBox txtPrecioProducto;
        private ComboBox cmbCategorias;
        private DataGridView dgvProductosImportados;
        private CheckBox checkImportado;
        private Label label7;
        private TextBox txtPais;
        private Label label8;
        private Label label9;
    }
}