namespace Vista
{
    partial class FormReportes
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
            dgvFacturas = new DataGridView();
            label1 = new Label();
            dgvProductosMasVendidos = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosMasVendidos).BeginInit();
            SuspendLayout();
            // 
            // dgvFacturas
            // 
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Location = new Point(12, 41);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.RowHeadersWidth = 51;
            dgvFacturas.Size = new Size(550, 225);
            dgvFacturas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "FACTURAS";
            // 
            // dgvProductosMasVendidos
            // 
            dgvProductosMasVendidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosMasVendidos.Location = new Point(12, 309);
            dgvProductosMasVendidos.Name = "dgvProductosMasVendidos";
            dgvProductosMasVendidos.RowHeadersWidth = 51;
            dgvProductosMasVendidos.Size = new Size(550, 188);
            dgvProductosMasVendidos.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 286);
            label2.Name = "label2";
            label2.Size = new Size(205, 20);
            label2.TabIndex = 3;
            label2.Text = "PRODUCTOS MÁS VENDIDOS";
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 512);
            Controls.Add(label2);
            Controls.Add(dgvProductosMasVendidos);
            Controls.Add(label1);
            Controls.Add(dgvFacturas);
            Name = "FormReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReportes";
            Load += FormReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosMasVendidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFacturas;
        private Label label1;
        private DataGridView dgvProductosMasVendidos;
        private Label label2;
    }
}