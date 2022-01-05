namespace proyectoFinal
{
    partial class CantidadVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CantidadVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.costo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bucarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porIDDeZapatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFolioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porCantidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TituloPanel = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.LimpiarB = new System.Windows.Forms.Button();
            this.EliminarB = new System.Windows.Forms.Button();
            this.ModificarB = new System.Windows.Forms.Button();
            this.aceptBus = new System.Windows.Forms.Button();
            this.datoBusEntrada = new System.Windows.Forms.TextBox();
            this.datoBuscarL = new System.Windows.Forms.Label();
            this.AgregarB = new System.Windows.Forms.Button();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.costoL = new System.Windows.Forms.Label();
            this.folioVenta = new System.Windows.Forms.TextBox();
            this.folioCargamentoL = new System.Windows.Forms.Label();
            this.idZapatoL = new System.Windows.Forms.Label();
            this.IdZapato = new System.Windows.Forms.TextBox();
            this.datosL = new System.Windows.Forms.Label();
            this.verTabla = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.TituloPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // costo
            // 
            this.costo.Location = new System.Drawing.Point(741, 363);
            this.costo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(185, 22);
            this.costo.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(737, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 87;
            this.label1.Text = "Precio";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bucarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 86;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bucarToolStripMenuItem
            // 
            this.bucarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porIDDeZapatoToolStripMenuItem,
            this.porFolioToolStripMenuItem1,
            this.porCantidadToolStripMenuItem,
            this.mostrarTodoToolStripMenuItem});
            this.bucarToolStripMenuItem.Name = "bucarToolStripMenuItem";
            this.bucarToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.bucarToolStripMenuItem.Text = "Bucar";
            // 
            // porIDDeZapatoToolStripMenuItem
            // 
            this.porIDDeZapatoToolStripMenuItem.Name = "porIDDeZapatoToolStripMenuItem";
            this.porIDDeZapatoToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.porIDDeZapatoToolStripMenuItem.Text = "Por ID de Zapato";
            this.porIDDeZapatoToolStripMenuItem.Click += new System.EventHandler(this.porIDDeZapatoToolStripMenuItem_Click);
            // 
            // porFolioToolStripMenuItem1
            // 
            this.porFolioToolStripMenuItem1.Name = "porFolioToolStripMenuItem1";
            this.porFolioToolStripMenuItem1.Size = new System.Drawing.Size(205, 26);
            this.porFolioToolStripMenuItem1.Text = "Por folio";
            this.porFolioToolStripMenuItem1.Click += new System.EventHandler(this.porFolioToolStripMenuItem1_Click);
            // 
            // porCantidadToolStripMenuItem
            // 
            this.porCantidadToolStripMenuItem.Name = "porCantidadToolStripMenuItem";
            this.porCantidadToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.porCantidadToolStripMenuItem.Text = "Por cantidad";
            this.porCantidadToolStripMenuItem.Click += new System.EventHandler(this.porCantidadToolStripMenuItem_Click);
            // 
            // mostrarTodoToolStripMenuItem
            // 
            this.mostrarTodoToolStripMenuItem.Name = "mostrarTodoToolStripMenuItem";
            this.mostrarTodoToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.mostrarTodoToolStripMenuItem.Text = "Mostrar todo";
            this.mostrarTodoToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodoToolStripMenuItem_Click);
            // 
            // TituloPanel
            // 
            this.TituloPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.TituloPanel.Controls.Add(this.cerrar);
            this.TituloPanel.Controls.Add(this.minimizar);
            this.TituloPanel.Controls.Add(this.maximizar);
            this.TituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TituloPanel.Location = new System.Drawing.Point(0, 0);
            this.TituloPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TituloPanel.Name = "TituloPanel";
            this.TituloPanel.Size = new System.Drawing.Size(1067, 48);
            this.TituloPanel.TabIndex = 85;
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.BackColor = System.Drawing.Color.Transparent;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(1020, 0);
            this.cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(47, 48);
            this.cerrar.TabIndex = 0;
            this.cerrar.UseVisualStyleBackColor = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.BackColor = System.Drawing.Color.Transparent;
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(925, -1);
            this.minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(47, 48);
            this.minimizar.TabIndex = 2;
            this.minimizar.UseVisualStyleBackColor = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackColor = System.Drawing.Color.Transparent;
            this.maximizar.FlatAppearance.BorderSize = 0;
            this.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(972, 0);
            this.maximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(47, 48);
            this.maximizar.TabIndex = 1;
            this.maximizar.UseVisualStyleBackColor = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // LimpiarB
            // 
            this.LimpiarB.Location = new System.Drawing.Point(961, 187);
            this.LimpiarB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LimpiarB.Name = "LimpiarB";
            this.LimpiarB.Size = new System.Drawing.Size(85, 47);
            this.LimpiarB.TabIndex = 84;
            this.LimpiarB.Text = "Limpiar";
            this.LimpiarB.UseVisualStyleBackColor = true;
            this.LimpiarB.Click += new System.EventHandler(this.LimpiarB_Click);
            // 
            // EliminarB
            // 
            this.EliminarB.Location = new System.Drawing.Point(961, 257);
            this.EliminarB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EliminarB.Name = "EliminarB";
            this.EliminarB.Size = new System.Drawing.Size(85, 47);
            this.EliminarB.TabIndex = 83;
            this.EliminarB.Text = "Eliminar";
            this.EliminarB.UseVisualStyleBackColor = true;
            this.EliminarB.Click += new System.EventHandler(this.EliminarB_Click);
            // 
            // ModificarB
            // 
            this.ModificarB.Location = new System.Drawing.Point(961, 327);
            this.ModificarB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModificarB.Name = "ModificarB";
            this.ModificarB.Size = new System.Drawing.Size(85, 47);
            this.ModificarB.TabIndex = 82;
            this.ModificarB.Text = "Modificar";
            this.ModificarB.UseVisualStyleBackColor = true;
            this.ModificarB.Click += new System.EventHandler(this.ModificarB_Click);
            // 
            // aceptBus
            // 
            this.aceptBus.Location = new System.Drawing.Point(16, 507);
            this.aceptBus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aceptBus.Name = "aceptBus";
            this.aceptBus.Size = new System.Drawing.Size(85, 47);
            this.aceptBus.TabIndex = 81;
            this.aceptBus.Text = "Aceptar";
            this.aceptBus.UseVisualStyleBackColor = true;
            this.aceptBus.Visible = false;
            this.aceptBus.Click += new System.EventHandler(this.aceptBus_Click);
            // 
            // datoBusEntrada
            // 
            this.datoBusEntrada.Location = new System.Drawing.Point(16, 479);
            this.datoBusEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datoBusEntrada.Name = "datoBusEntrada";
            this.datoBusEntrada.Size = new System.Drawing.Size(185, 22);
            this.datoBusEntrada.TabIndex = 80;
            this.datoBusEntrada.Visible = false;
            // 
            // datoBuscarL
            // 
            this.datoBuscarL.AutoSize = true;
            this.datoBuscarL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.datoBuscarL.Location = new System.Drawing.Point(16, 452);
            this.datoBuscarL.Name = "datoBuscarL";
            this.datoBuscarL.Size = new System.Drawing.Size(149, 22);
            this.datoBuscarL.TabIndex = 79;
            this.datoBuscarL.Text = "Datos a buscar";
            this.datoBuscarL.Visible = false;
            // 
            // AgregarB
            // 
            this.AgregarB.Location = new System.Drawing.Point(745, 391);
            this.AgregarB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgregarB.Name = "AgregarB";
            this.AgregarB.Size = new System.Drawing.Size(85, 47);
            this.AgregarB.TabIndex = 78;
            this.AgregarB.Text = "Agregar";
            this.AgregarB.UseVisualStyleBackColor = true;
            this.AgregarB.Click += new System.EventHandler(this.AgregarB_Click);
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(741, 308);
            this.cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(185, 22);
            this.cantidad.TabIndex = 77;
            // 
            // costoL
            // 
            this.costoL.AutoSize = true;
            this.costoL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.costoL.Location = new System.Drawing.Point(737, 283);
            this.costoL.Name = "costoL";
            this.costoL.Size = new System.Drawing.Size(185, 22);
            this.costoL.TabIndex = 76;
            this.costoL.Text = "Cantidad de pares";
            // 
            // folioVenta
            // 
            this.folioVenta.Location = new System.Drawing.Point(741, 256);
            this.folioVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.folioVenta.Name = "folioVenta";
            this.folioVenta.Size = new System.Drawing.Size(185, 22);
            this.folioVenta.TabIndex = 75;
            // 
            // folioCargamentoL
            // 
            this.folioCargamentoL.AutoSize = true;
            this.folioCargamentoL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.folioCargamentoL.Location = new System.Drawing.Point(741, 228);
            this.folioCargamentoL.Name = "folioCargamentoL";
            this.folioCargamentoL.Size = new System.Drawing.Size(157, 22);
            this.folioCargamentoL.TabIndex = 74;
            this.folioCargamentoL.Text = "Folio de compra";
            // 
            // idZapatoL
            // 
            this.idZapatoL.AutoSize = true;
            this.idZapatoL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.idZapatoL.Location = new System.Drawing.Point(741, 175);
            this.idZapatoL.Name = "idZapatoL";
            this.idZapatoL.Size = new System.Drawing.Size(101, 22);
            this.idZapatoL.TabIndex = 73;
            this.idZapatoL.Text = "ID Zapato";
            // 
            // IdZapato
            // 
            this.IdZapato.Location = new System.Drawing.Point(741, 203);
            this.IdZapato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdZapato.Name = "IdZapato";
            this.IdZapato.Size = new System.Drawing.Size(185, 22);
            this.IdZapato.TabIndex = 72;
            // 
            // datosL
            // 
            this.datosL.AutoSize = true;
            this.datosL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.datosL.Location = new System.Drawing.Point(737, 143);
            this.datosL.Name = "datosL";
            this.datosL.Size = new System.Drawing.Size(275, 22);
            this.datosL.TabIndex = 71;
            this.datosL.Text = "Datos de compra del zapato";
            // 
            // verTabla
            // 
            this.verTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.verTabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.verTabla.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.verTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.verTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.verTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.verTabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.verTabla.Location = new System.Drawing.Point(0, 124);
            this.verTabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verTabla.Name = "verTabla";
            this.verTabla.ReadOnly = true;
            this.verTabla.RowHeadersWidth = 51;
            this.verTabla.RowTemplate.Height = 24;
            this.verTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.verTabla.Size = new System.Drawing.Size(739, 309);
            this.verTabla.TabIndex = 70;
            this.verTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.verTabla_CellContentClick);
            // 
            // CantidadVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.costo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TituloPanel);
            this.Controls.Add(this.LimpiarB);
            this.Controls.Add(this.EliminarB);
            this.Controls.Add(this.ModificarB);
            this.Controls.Add(this.aceptBus);
            this.Controls.Add(this.datoBusEntrada);
            this.Controls.Add(this.datoBuscarL);
            this.Controls.Add(this.AgregarB);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.costoL);
            this.Controls.Add(this.folioVenta);
            this.Controls.Add(this.folioCargamentoL);
            this.Controls.Add(this.idZapatoL);
            this.Controls.Add(this.IdZapato);
            this.Controls.Add(this.datosL);
            this.Controls.Add(this.verTabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CantidadVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CantidadVenta";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TituloPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.verTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox costo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bucarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porIDDeZapatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFolioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porCantidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodoToolStripMenuItem;
        private System.Windows.Forms.Panel TituloPanel;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Button maximizar;
        private System.Windows.Forms.Button LimpiarB;
        private System.Windows.Forms.Button EliminarB;
        private System.Windows.Forms.Button ModificarB;
        private System.Windows.Forms.Button aceptBus;
        private System.Windows.Forms.TextBox datoBusEntrada;
        private System.Windows.Forms.Label datoBuscarL;
        private System.Windows.Forms.Button AgregarB;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label costoL;
        private System.Windows.Forms.TextBox folioVenta;
        private System.Windows.Forms.Label folioCargamentoL;
        private System.Windows.Forms.Label idZapatoL;
        private System.Windows.Forms.TextBox IdZapato;
        private System.Windows.Forms.Label datosL;
        private System.Windows.Forms.DataGridView verTabla;
    }
}