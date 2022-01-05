namespace proyectoFinal
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.TituloPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cerrar = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonEmpleados = new System.Windows.Forms.Button();
            this.VentasButton = new System.Windows.Forms.Button();
            this.CargamentoButton = new System.Windows.Forms.Button();
            this.almacenBotton = new System.Windows.Forms.Button();
            this.productoBotton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TituloPanel.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloPanel
            // 
            this.TituloPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.TituloPanel.Controls.Add(this.label1);
            this.TituloPanel.Controls.Add(this.cerrar);
            this.TituloPanel.Controls.Add(this.minimizar);
            this.TituloPanel.Controls.Add(this.maximizar);
            this.TituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TituloPanel.Location = new System.Drawing.Point(0, 0);
            this.TituloPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TituloPanel.Name = "TituloPanel";
            this.TituloPanel.Size = new System.Drawing.Size(1373, 47);
            this.TituloPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "ZAPATERIA EL XOLOSCUNCLE";
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.BackColor = System.Drawing.Color.Transparent;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(1325, 0);
            this.cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(47, 48);
            this.cerrar.TabIndex = 0;
            this.cerrar.UseVisualStyleBackColor = false;
            this.cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.BackColor = System.Drawing.Color.Transparent;
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(1232, -1);
            this.minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(47, 48);
            this.minimizar.TabIndex = 2;
            this.minimizar.UseVisualStyleBackColor = false;
            this.minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackColor = System.Drawing.Color.Transparent;
            this.maximizar.FlatAppearance.BorderSize = 0;
            this.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(1279, 0);
            this.maximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(47, 48);
            this.maximizar.TabIndex = 1;
            this.maximizar.UseVisualStyleBackColor = false;
            this.maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenu.Controls.Add(this.buttonEmpleados);
            this.panelMenu.Controls.Add(this.VentasButton);
            this.panelMenu.Controls.Add(this.CargamentoButton);
            this.panelMenu.Controls.Add(this.almacenBotton);
            this.panelMenu.Controls.Add(this.productoBotton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 47);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(223, 636);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonEmpleados
            // 
            this.buttonEmpleados.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmpleados.Image")));
            this.buttonEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmpleados.Location = new System.Drawing.Point(0, 228);
            this.buttonEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEmpleados.Name = "buttonEmpleados";
            this.buttonEmpleados.Size = new System.Drawing.Size(223, 57);
            this.buttonEmpleados.TabIndex = 4;
            this.buttonEmpleados.Text = "Empleados";
            this.buttonEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEmpleados.UseVisualStyleBackColor = false;
            this.buttonEmpleados.Click += new System.EventHandler(this.buttonEmpleados_Click);
            this.buttonEmpleados.MouseEnter += new System.EventHandler(this.buttonEmpleados_MouseEnter);
            this.buttonEmpleados.MouseLeave += new System.EventHandler(this.buttonEmpleados_MouseLeave);
            // 
            // VentasButton
            // 
            this.VentasButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.VentasButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.VentasButton.Image = ((System.Drawing.Image)(resources.GetObject("VentasButton.Image")));
            this.VentasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VentasButton.Location = new System.Drawing.Point(0, 171);
            this.VentasButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VentasButton.Name = "VentasButton";
            this.VentasButton.Size = new System.Drawing.Size(223, 57);
            this.VentasButton.TabIndex = 3;
            this.VentasButton.Text = "Ventas";
            this.VentasButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VentasButton.UseVisualStyleBackColor = false;
            this.VentasButton.Click += new System.EventHandler(this.VentasButton_Click);
            this.VentasButton.MouseEnter += new System.EventHandler(this.VentasButton_MouseEnter);
            this.VentasButton.MouseLeave += new System.EventHandler(this.VentasButton_MouseLeave);
            // 
            // CargamentoButton
            // 
            this.CargamentoButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CargamentoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CargamentoButton.Image = ((System.Drawing.Image)(resources.GetObject("CargamentoButton.Image")));
            this.CargamentoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CargamentoButton.Location = new System.Drawing.Point(0, 114);
            this.CargamentoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CargamentoButton.Name = "CargamentoButton";
            this.CargamentoButton.Size = new System.Drawing.Size(223, 57);
            this.CargamentoButton.TabIndex = 2;
            this.CargamentoButton.Text = "Cargamento";
            this.CargamentoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CargamentoButton.UseVisualStyleBackColor = false;
            this.CargamentoButton.Click += new System.EventHandler(this.CargamentoButton_Click);
            this.CargamentoButton.MouseEnter += new System.EventHandler(this.CargamentoButton_MouseEnter);
            this.CargamentoButton.MouseLeave += new System.EventHandler(this.CargamentoButton_MouseLeave);
            // 
            // almacenBotton
            // 
            this.almacenBotton.BackColor = System.Drawing.Color.RoyalBlue;
            this.almacenBotton.Dock = System.Windows.Forms.DockStyle.Top;
            this.almacenBotton.Image = ((System.Drawing.Image)(resources.GetObject("almacenBotton.Image")));
            this.almacenBotton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.almacenBotton.Location = new System.Drawing.Point(0, 57);
            this.almacenBotton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.almacenBotton.Name = "almacenBotton";
            this.almacenBotton.Size = new System.Drawing.Size(223, 57);
            this.almacenBotton.TabIndex = 1;
            this.almacenBotton.Text = "Almacen";
            this.almacenBotton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.almacenBotton.UseVisualStyleBackColor = false;
            this.almacenBotton.Click += new System.EventHandler(this.AlmacenBotton_Click);
            this.almacenBotton.MouseEnter += new System.EventHandler(this.AlmacenBotton_MouseEnter);
            this.almacenBotton.MouseLeave += new System.EventHandler(this.AlmacenBotton_MouseLeave);
            // 
            // productoBotton
            // 
            this.productoBotton.BackColor = System.Drawing.Color.RoyalBlue;
            this.productoBotton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productoBotton.Image = ((System.Drawing.Image)(resources.GetObject("productoBotton.Image")));
            this.productoBotton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productoBotton.Location = new System.Drawing.Point(0, 0);
            this.productoBotton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productoBotton.Name = "productoBotton";
            this.productoBotton.Size = new System.Drawing.Size(223, 57);
            this.productoBotton.TabIndex = 0;
            this.productoBotton.Text = "Productos";
            this.productoBotton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.productoBotton.UseVisualStyleBackColor = false;
            this.productoBotton.Click += new System.EventHandler(this.ProductoBotton_Click);
            this.productoBotton.MouseEnter += new System.EventHandler(this.ProductoBotton_MouseEnter);
            this.productoBotton.MouseLeave += new System.EventHandler(this.ProductoBotton_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(229, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1127, 614);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1373, 683);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.TituloPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TituloPanel.ResumeLayout(false);
            this.TituloPanel.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TituloPanel;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button maximizar;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button productoBotton;
        private System.Windows.Forms.Button VentasButton;
        private System.Windows.Forms.Button CargamentoButton;
        private System.Windows.Forms.Button almacenBotton;
        private System.Windows.Forms.Button buttonEmpleados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}