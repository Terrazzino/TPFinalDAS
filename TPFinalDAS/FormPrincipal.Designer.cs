namespace TPFinalDAS
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menúToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            proveedorToolStripMenuItem = new ToolStripMenuItem();
            facturarProductosToolStripMenuItem = new ToolStripMenuItem();
            realizarCompraToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menúToolStripMenuItem, facturarProductosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(644, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            menúToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriasToolStripMenuItem, productosToolStripMenuItem, clientesToolStripMenuItem, proveedorToolStripMenuItem });
            menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            menúToolStripMenuItem.Size = new Size(60, 24);
            menúToolStripMenuItem.Text = "Menú";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(163, 26);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(163, 26);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(163, 26);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // proveedorToolStripMenuItem
            // 
            proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            proveedorToolStripMenuItem.Size = new Size(163, 26);
            proveedorToolStripMenuItem.Text = "Proveedor";
            proveedorToolStripMenuItem.Click += proveedorToolStripMenuItem_Click;
            // 
            // facturarProductosToolStripMenuItem
            // 
            facturarProductosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { realizarCompraToolStripMenuItem });
            facturarProductosToolStripMenuItem.Name = "facturarProductosToolStripMenuItem";
            facturarProductosToolStripMenuItem.Size = new Size(145, 24);
            facturarProductosToolStripMenuItem.Text = "Facturar Productos";
            // 
            // realizarCompraToolStripMenuItem
            // 
            realizarCompraToolStripMenuItem.Name = "realizarCompraToolStripMenuItem";
            realizarCompraToolStripMenuItem.Size = new Size(202, 26);
            realizarCompraToolStripMenuItem.Text = "Realizar Compra";
            realizarCompraToolStripMenuItem.Click += realizarCompraToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 53);
            label1.Name = "label1";
            label1.Size = new Size(232, 159);
            label1.TabIndex = 1;
            label1.Text = "👉🏼";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(196, 18);
            label2.TabIndex = 2;
            label2.Text = "Aquí Reporte de Ventas";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(255, 76);
            button1.Name = "button1";
            button1.Size = new Size(140, 136);
            button1.TabIndex = 3;
            button1.Text = "REPORTE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(401, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 224);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Instrucciones de Uso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(166, 20);
            label3.TabIndex = 0;
            label3.Text = "1- Registre la Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 45);
            label4.Name = "label4";
            label4.Size = new Size(161, 20);
            label4.TabIndex = 1;
            label4.Text = "2- Registre el Producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 65);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 2;
            label5.Text = "3- Registr el Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 85);
            label6.Name = "label6";
            label6.Size = new Size(169, 20);
            label6.TabIndex = 3;
            label6.Text = "4- Registre el Proveedor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 105);
            label7.Name = "label7";
            label7.Size = new Size(158, 20);
            label7.TabIndex = 4;
            label7.Text = "5- Realice una compra";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 125);
            label8.Name = "label8";
            label8.Size = new Size(154, 20);
            label8.TabIndex = 5;
            label8.Text = "en la sección Facturar ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 145);
            label9.Name = "label9";
            label9.Size = new Size(142, 20);
            label9.TabIndex = 6;
            label9.Text = "6- Revise el Reporte";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 254);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menúToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem proveedorToolStripMenuItem;
        private ToolStripMenuItem facturarProductosToolStripMenuItem;
        private ToolStripMenuItem realizarCompraToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Button button1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
