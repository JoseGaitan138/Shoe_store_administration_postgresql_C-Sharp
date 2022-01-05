﻿namespace proyectoFinal
{
    partial class ContenidoCargamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContenidoCargamento));
            this.mostrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bucarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porIDDeZapatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFolioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porCantidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCostopzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porMontoTotalDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TituloPanel = new System.Windows.Forms.Panel();
            this.LimpiarB = new System.Windows.Forms.Button();
            this.EliminarB = new System.Windows.Forms.Button();
            this.ModificarB = new System.Windows.Forms.Button();
            this.aceptBus = new System.Windows.Forms.Button();
            this.datoBusEntrada = new System.Windows.Forms.TextBox();
            this.datoBuscarL = new System.Windows.Forms.Label();
            this.AgregarB = new System.Windows.Forms.Button();
            this.cantidadEntrada = new System.Windows.Forms.TextBox();
            this.costoL = new System.Windows.Forms.Label();
            this.folioEntrada = new System.Windows.Forms.TextBox();
            this.folioCargamentoL = new System.Windows.Forms.Label();
            this.idZapatoL = new System.Windows.Forms.Label();
            this.IdZapatoEntrada = new System.Windows.Forms.TextBox();
            this.datosL = new System.Windows.Forms.Label();
            this.verTabla = new System.Windows.Forms.DataGridView();
            this.costoPzaEntrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cerrar = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.TituloPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrarTodoToolStripMenuItem
            // 
            this.mostrarTodoToolStripMenuItem.Name = "mostrarTodoToolStripMenuItem";
            this.mostrarTodoToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.mostrarTodoToolStripMenuItem.Text = "Mostrar todo";
            this.mostrarTodoToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodoToolStripMenuItem_Click);
            // 
            // bucarToolStripMenuItem
            // 
            this.bucarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porIDDeZapatoToolStripMenuItem,
            this.porFolioToolStripMenuItem1,
            this.porCantidadToolStripMenuItem,
            this.porCostopzaToolStripMenuItem,
            this.porMontoTotalDePedidoToolStripMenuItem,
            this.mostrarTodoToolStripMenuItem});
            this.bucarToolStripMenuItem.Name = "bucarToolStripMenuItem";
            this.bucarToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.bucarToolStripMenuItem.Text = "Bucar";
            // 
            // porIDDeZapatoToolStripMenuItem
            // 
            this.porIDDeZapatoToolStripMenuItem.Name = "porIDDeZapatoToolStripMenuItem";
            this.porIDDeZapatoToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.porIDDeZapatoToolStripMenuItem.Text = "Por ID de Zapato";
            this.porIDDeZapatoToolStripMenuItem.Click += new System.EventHandler(this.porIDDeZapatoToolStripMenuItem_Click);
            // 
            // porFolioToolStripMenuItem1
            // 
            this.porFolioToolStripMenuItem1.Name = "porFolioToolStripMenuItem1";
            this.porFolioToolStripMenuItem1.Size = new System.Drawing.Size(269, 26);
            this.porFolioToolStripMenuItem1.Text = "Por folio";
            this.porFolioToolStripMenuItem1.Click += new System.EventHandler(this.porFolioToolStripMenuItem1_Click);
            // 
            // porCantidadToolStripMenuItem
            // 
            this.porCantidadToolStripMenuItem.Name = "porCantidadToolStripMenuItem";
            this.porCantidadToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.porCantidadToolStripMenuItem.Text = "Por cantidad";
            this.porCantidadToolStripMenuItem.Click += new System.EventHandler(this.porCantidadToolStripMenuItem_Click);
            // 
            // porCostopzaToolStripMenuItem
            // 
            this.porCostopzaToolStripMenuItem.Name = "porCostopzaToolStripMenuItem";
            this.porCostopzaToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.porCostopzaToolStripMenuItem.Text = "Por costo/pza";
            this.porCostopzaToolStripMenuItem.Click += new System.EventHandler(this.porCostopzaToolStripMenuItem_Click);
            // 
            // porMontoTotalDePedidoToolStripMenuItem
            // 
            this.porMontoTotalDePedidoToolStripMenuItem.Name = "porMontoTotalDePedidoToolStripMenuItem";
            this.porMontoTotalDePedidoToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.porMontoTotalDePedidoToolStripMenuItem.Text = "Por monto total de pedido";
            this.porMontoTotalDePedidoToolStripMenuItem.Click += new System.EventHandler(this.porMontoTotalDePedidoToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bucarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 28);
            this.menuStrip1.TabIndex = 67;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TituloPanel
            // 
            this.TituloPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.TituloPanel.Controls.Add(this.cerrar);
            this.TituloPanel.Controls.Add(this.minimizar);
            this.TituloPanel.Controls.Add(this.maximizar);
            this.TituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TituloPanel.Location = new System.Drawing.Point(0, 0);
            this.TituloPanel.Name = "TituloPanel";
            this.TituloPanel.Size = new System.Drawing.Size(1116, 48);
            this.TituloPanel.TabIndex = 66;
            // 
            // LimpiarB
            // 
            this.LimpiarB.Location = new System.Drawing.Point(961, 186);
            this.LimpiarB.Name = "LimpiarB";
            this.LimpiarB.Size = new System.Drawing.Size(85, 47);
            this.LimpiarB.TabIndex = 65;
            this.LimpiarB.Text = "Limpiar";
            this.LimpiarB.UseVisualStyleBackColor = true;
            this.LimpiarB.Click += new System.EventHandler(this.LimpiarB_Click);
            // 
            // EliminarB
            // 
            this.EliminarB.Location = new System.Drawing.Point(961, 256);
            this.EliminarB.Name = "EliminarB";
            this.EliminarB.Size = new System.Drawing.Size(85, 47);
            this.EliminarB.TabIndex = 64;
            this.EliminarB.Text = "Eliminar";
            this.EliminarB.UseVisualStyleBackColor = true;
            this.EliminarB.Click += new System.EventHandler(this.EliminarB_Click);
            // 
            // ModificarB
            // 
            this.ModificarB.Location = new System.Drawing.Point(961, 326);
            this.ModificarB.Name = "ModificarB";
            this.ModificarB.Size = new System.Drawing.Size(85, 47);
            this.ModificarB.TabIndex = 63;
            this.ModificarB.Text = "Modificar";
            this.ModificarB.UseVisualStyleBackColor = true;
            this.ModificarB.Click += new System.EventHandler(this.ModificarB_Click);
            // 
            // aceptBus
            // 
            this.aceptBus.Location = new System.Drawing.Point(16, 506);
            this.aceptBus.Name = "aceptBus";
            this.aceptBus.Size = new System.Drawing.Size(85, 47);
            this.aceptBus.TabIndex = 62;
            this.aceptBus.Text = "Aceptar";
            this.aceptBus.UseVisualStyleBackColor = true;
            this.aceptBus.Visible = false;
            this.aceptBus.Click += new System.EventHandler(this.aceptBus_Click);
            // 
            // datoBusEntrada
            // 
            this.datoBusEntrada.Location = new System.Drawing.Point(16, 478);
            this.datoBusEntrada.Name = "datoBusEntrada";
            this.datoBusEntrada.Size = new System.Drawing.Size(186, 22);
            this.datoBusEntrada.TabIndex = 61;
            this.datoBusEntrada.Visible = false;
            // 
            // datoBuscarL
            // 
            this.datoBuscarL.AutoSize = true;
            this.datoBuscarL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.datoBuscarL.Location = new System.Drawing.Point(16, 450);
            this.datoBuscarL.Name = "datoBuscarL";
            this.datoBuscarL.Size = new System.Drawing.Size(149, 22);
            this.datoBuscarL.TabIndex = 60;
            this.datoBuscarL.Text = "Datos a buscar";
            this.datoBuscarL.Visible = false;
            // 
            // AgregarB
            // 
            this.AgregarB.Location = new System.Drawing.Point(745, 390);
            this.AgregarB.Name = "AgregarB";
            this.AgregarB.Size = new System.Drawing.Size(85, 47);
            this.AgregarB.TabIndex = 59;
            this.AgregarB.Text = "Agregar";
            this.AgregarB.UseVisualStyleBackColor = true;
            this.AgregarB.Click += new System.EventHandler(this.AgregarB_Click);
            // 
            // cantidadEntrada
            // 
            this.cantidadEntrada.Location = new System.Drawing.Point(741, 307);
            this.cantidadEntrada.Name = "cantidadEntrada";
            this.cantidadEntrada.Size = new System.Drawing.Size(186, 22);
            this.cantidadEntrada.TabIndex = 58;
            // 
            // costoL
            // 
            this.costoL.AutoSize = true;
            this.costoL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.costoL.Location = new System.Drawing.Point(737, 282);
            this.costoL.Name = "costoL";
            this.costoL.Size = new System.Drawing.Size(185, 22);
            this.costoL.TabIndex = 57;
            this.costoL.Text = "Cantidad de pares";
            // 
            // folioEntrada
            // 
            this.folioEntrada.Location = new System.Drawing.Point(741, 255);
            this.folioEntrada.Name = "folioEntrada";
            this.folioEntrada.Size = new System.Drawing.Size(186, 22);
            this.folioEntrada.TabIndex = 56;
            // 
            // folioCargamentoL
            // 
            this.folioCargamentoL.AutoSize = true;
            this.folioCargamentoL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.folioCargamentoL.Location = new System.Drawing.Point(741, 227);
            this.folioCargamentoL.Name = "folioCargamentoL";
            this.folioCargamentoL.Size = new System.Drawing.Size(201, 22);
            this.folioCargamentoL.TabIndex = 55;
            this.folioCargamentoL.Text = "Folio de cargamento";
            // 
            // idZapatoL
            // 
            this.idZapatoL.AutoSize = true;
            this.idZapatoL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.idZapatoL.Location = new System.Drawing.Point(741, 174);
            this.idZapatoL.Name = "idZapatoL";
            this.idZapatoL.Size = new System.Drawing.Size(101, 22);
            this.idZapatoL.TabIndex = 54;
            this.idZapatoL.Text = "ID Zapato";
            // 
            // IdZapatoEntrada
            // 
            this.IdZapatoEntrada.Location = new System.Drawing.Point(741, 202);
            this.IdZapatoEntrada.Name = "IdZapatoEntrada";
            this.IdZapatoEntrada.Size = new System.Drawing.Size(186, 22);
            this.IdZapatoEntrada.TabIndex = 53;
            // 
            // datosL
            // 
            this.datosL.AutoSize = true;
            this.datosL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.datosL.Location = new System.Drawing.Point(737, 142);
            this.datosL.Name = "datosL";
            this.datosL.Size = new System.Drawing.Size(268, 22);
            this.datosL.TabIndex = 52;
            this.datosL.Text = "Datos de pedido del zapato";
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
            this.verTabla.Location = new System.Drawing.Point(0, 123);
            this.verTabla.Name = "verTabla";
            this.verTabla.ReadOnly = true;
            this.verTabla.RowHeadersWidth = 51;
            this.verTabla.RowTemplate.Height = 24;
            this.verTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.verTabla.Size = new System.Drawing.Size(739, 309);
            this.verTabla.TabIndex = 51;
            this.verTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.verTabla_CellContentClick);
            // 
            // costoPzaEntrada
            // 
            this.costoPzaEntrada.Location = new System.Drawing.Point(741, 362);
            this.costoPzaEntrada.Name = "costoPzaEntrada";
            this.costoPzaEntrada.Size = new System.Drawing.Size(186, 22);
            this.costoPzaEntrada.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(737, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 22);
            this.label1.TabIndex = 68;
            this.label1.Text = "Costo/Pza. de fabrica";
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.BackColor = System.Drawing.Color.Transparent;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(1069, 0);
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
            this.minimizar.Location = new System.Drawing.Point(975, -1);
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
            this.maximizar.Location = new System.Drawing.Point(1022, 0);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(47, 48);
            this.maximizar.TabIndex = 1;
            this.maximizar.UseVisualStyleBackColor = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // ContenidoCargamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 558);
            this.Controls.Add(this.costoPzaEntrada);
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
            this.Controls.Add(this.cantidadEntrada);
            this.Controls.Add(this.costoL);
            this.Controls.Add(this.folioEntrada);
            this.Controls.Add(this.folioCargamentoL);
            this.Controls.Add(this.idZapatoL);
            this.Controls.Add(this.IdZapatoEntrada);
            this.Controls.Add(this.datosL);
            this.Controls.Add(this.verTabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContenidoCargamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContenidoCargamento";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TituloPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.verTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mostrarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bucarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Button maximizar;
        private System.Windows.Forms.Panel TituloPanel;
        private System.Windows.Forms.Button LimpiarB;
        private System.Windows.Forms.Button EliminarB;
        private System.Windows.Forms.Button ModificarB;
        private System.Windows.Forms.Button aceptBus;
        private System.Windows.Forms.TextBox datoBusEntrada;
        private System.Windows.Forms.Label datoBuscarL;
        private System.Windows.Forms.Button AgregarB;
        private System.Windows.Forms.TextBox cantidadEntrada;
        private System.Windows.Forms.Label costoL;
        private System.Windows.Forms.TextBox folioEntrada;
        private System.Windows.Forms.Label folioCargamentoL;
        private System.Windows.Forms.Label idZapatoL;
        private System.Windows.Forms.TextBox IdZapatoEntrada;
        private System.Windows.Forms.Label datosL;
        private System.Windows.Forms.DataGridView verTabla;
        private System.Windows.Forms.ToolStripMenuItem porIDDeZapatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFolioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porCantidadToolStripMenuItem;
        private System.Windows.Forms.TextBox costoPzaEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem porCostopzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porMontoTotalDePedidoToolStripMenuItem;
    }
}