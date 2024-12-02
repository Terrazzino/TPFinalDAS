namespace Vista
{
    partial class FormCategorias
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
            txtCodigoCategoria = new TextBox();
            txtNombreCategoria = new TextBox();
            txtDescripcionCategoria = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRegistrarCategoria = new Button();
            btnModificarCategoria = new Button();
            btnEliminarCategoria = new Button();
            dgvCategorias = new DataGridView();
            lblLeyenda = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // txtCodigoCategoria
            // 
            txtCodigoCategoria.Location = new Point(12, 32);
            txtCodigoCategoria.Name = "txtCodigoCategoria";
            txtCodigoCategoria.Size = new Size(125, 27);
            txtCodigoCategoria.TabIndex = 0;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(12, 85);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(125, 27);
            txtNombreCategoria.TabIndex = 1;
            // 
            // txtDescripcionCategoria
            // 
            txtDescripcionCategoria.Location = new Point(12, 138);
            txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            txtDescripcionCategoria.Size = new Size(125, 27);
            txtDescripcionCategoria.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 4;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 6;
            label3.Text = "Descripcion";
            // 
            // btnRegistrarCategoria
            // 
            btnRegistrarCategoria.Location = new Point(12, 171);
            btnRegistrarCategoria.Name = "btnRegistrarCategoria";
            btnRegistrarCategoria.Size = new Size(125, 29);
            btnRegistrarCategoria.TabIndex = 7;
            btnRegistrarCategoria.Text = "Registrar";
            btnRegistrarCategoria.UseVisualStyleBackColor = true;
            btnRegistrarCategoria.Click += btnRegistrarCategoria_Click;
            // 
            // btnModificarCategoria
            // 
            btnModificarCategoria.Location = new Point(12, 206);
            btnModificarCategoria.Name = "btnModificarCategoria";
            btnModificarCategoria.Size = new Size(125, 29);
            btnModificarCategoria.TabIndex = 8;
            btnModificarCategoria.Text = "Modificar";
            btnModificarCategoria.UseVisualStyleBackColor = true;
            btnModificarCategoria.Click += btnModificarCategoria_Click;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.Location = new Point(12, 241);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(125, 29);
            btnEliminarCategoria.TabIndex = 9;
            btnEliminarCategoria.Text = "Eliminar";
            btnEliminarCategoria.UseVisualStyleBackColor = true;
            btnEliminarCategoria.Click += btnEliminarCategoria_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(143, 32);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(474, 238);
            dgvCategorias.TabIndex = 10;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            // 
            // lblLeyenda
            // 
            lblLeyenda.AutoSize = true;
            lblLeyenda.Location = new Point(12, 287);
            lblLeyenda.Name = "lblLeyenda";
            lblLeyenda.Size = new Size(222, 20);
            lblLeyenda.TabIndex = 11;
            lblLeyenda.Text = "Bienvenido al campo categorias";
            // 
            // FormCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 316);
            Controls.Add(lblLeyenda);
            Controls.Add(dgvCategorias);
            Controls.Add(btnEliminarCategoria);
            Controls.Add(btnModificarCategoria);
            Controls.Add(btnRegistrarCategoria);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescripcionCategoria);
            Controls.Add(txtNombreCategoria);
            Controls.Add(txtCodigoCategoria);
            Name = "FormCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCategorias";
            Load += FormCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigoCategoria;
        private TextBox txtNombreCategoria;
        private TextBox txtDescripcionCategoria;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnRegistrarCategoria;
        private Button btnModificarCategoria;
        private Button btnEliminarCategoria;
        private DataGridView dgvCategorias;
        private Label lblLeyenda;
    }
}