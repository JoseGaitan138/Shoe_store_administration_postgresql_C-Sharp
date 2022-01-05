namespace proyectoFinal
{
    partial class alta_zapato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alta_zapato));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TituloPanel = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.LimpiarB = new System.Windows.Forms.Button();
            this.eliminarB = new System.Windows.Forms.Button();
            this.ModificarB = new System.Windows.Forms.Button();
            this.aceptBus = new System.Windows.Forms.Button();
            this.datoBusEntrada = new System.Windows.Forms.TextBox();
            this.datoBuscarL = new System.Windows.Forms.Label();
            this.aceptarB = new System.Windows.Forms.Button();
            this.idEntrada = new System.Windows.Forms.TextBox();
            this.idL = new System.Windows.Forms.Label();
            this.nombreL = new System.Windows.Forms.Label();
            this.nombreEntrada = new System.Windows.Forms.TextBox();
            this.listaAlmacen = new System.Windows.Forms.DataGridView();
            this.marcaL = new System.Windows.Forms.Label();
            this.marcaEntrada = new System.Windows.Forms.TextBox();
            this.tipoL = new System.Windows.Forms.Label();
            this.tipoEntrada = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bucarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porId = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombre = new System.Windows.Forms.ToolStripMenuItem();
            this.porMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.porTipo = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.TituloPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlmacen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.TituloPanel.Size = new System.Drawing.Size(1100, 48);
            this.TituloPanel.TabIndex = 27;
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.BackColor = System.Drawing.Color.Transparent;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(1053, 0);
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
            this.minimizar.Location = new System.Drawing.Point(959, -1);
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
            this.maximizar.Location = new System.Drawing.Point(1006, 0);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(47, 48);
            this.maximizar.TabIndex = 1;
            this.maximizar.UseVisualStyleBackColor = false;
            this.maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // LimpiarB
            // 
            this.LimpiarB.Location = new System.Drawing.Point(973, 172);
            this.LimpiarB.Name = "LimpiarB";
            this.LimpiarB.Size = new System.Drawing.Size(85, 47);
            this.LimpiarB.TabIndex = 47;
            this.LimpiarB.Text = "Limpiar";
            this.LimpiarB.UseVisualStyleBackColor = true;
            this.LimpiarB.Click += new System.EventHandler(this.LimpiarB_Click);
            // 
            // eliminarB
            // 
            this.eliminarB.Location = new System.Drawing.Point(973, 242);
            this.eliminarB.Name = "eliminarB";
            this.eliminarB.Size = new System.Drawing.Size(85, 47);
            this.eliminarB.TabIndex = 46;
            this.eliminarB.Text = "Eliminar";
            this.eliminarB.UseVisualStyleBackColor = true;
            this.eliminarB.Click += new System.EventHandler(this.EliminarB_Click);
            // 
            // ModificarB
            // 
            this.ModificarB.Location = new System.Drawing.Point(973, 312);
            this.ModificarB.Name = "ModificarB";
            this.ModificarB.Size = new System.Drawing.Size(85, 47);
            this.ModificarB.TabIndex = 45;
            this.ModificarB.Text = "Modificar";
            this.ModificarB.UseVisualStyleBackColor = true;
            this.ModificarB.Click += new System.EventHandler(this.ModificarB_Click);
            // 
            // aceptBus
            // 
            this.aceptBus.Location = new System.Drawing.Point(403, 501);
            this.aceptBus.Name = "aceptBus";
            this.aceptBus.Size = new System.Drawing.Size(85, 47);
            this.aceptBus.TabIndex = 44;
            this.aceptBus.Text = "Aceptar";
            this.aceptBus.UseVisualStyleBackColor = true;
            this.aceptBus.Visible = false;
            this.aceptBus.Click += new System.EventHandler(this.AceptBus_Click);
            // 
            // datoBusEntrada
            // 
            this.datoBusEntrada.Location = new System.Drawing.Point(403, 473);
            this.datoBusEntrada.Name = "datoBusEntrada";
            this.datoBusEntrada.Size = new System.Drawing.Size(186, 22);
            this.datoBusEntrada.TabIndex = 43;
            this.datoBusEntrada.Visible = false;
            // 
            // datoBuscarL
            // 
            this.datoBuscarL.AutoSize = true;
            this.datoBuscarL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.datoBuscarL.Location = new System.Drawing.Point(399, 439);
            this.datoBuscarL.Name = "datoBuscarL";
            this.datoBuscarL.Size = new System.Drawing.Size(149, 22);
            this.datoBuscarL.TabIndex = 42;
            this.datoBuscarL.Text = "Datos a buscar";
            this.datoBuscarL.Visible = false;
            // 
            // aceptarB
            // 
            this.aceptarB.Location = new System.Drawing.Point(757, 401);
            this.aceptarB.Name = "aceptarB";
            this.aceptarB.Size = new System.Drawing.Size(85, 47);
            this.aceptarB.TabIndex = 41;
            this.aceptarB.Text = "Agregar";
            this.aceptarB.UseVisualStyleBackColor = true;
            this.aceptarB.Click += new System.EventHandler(this.AceptarB_Click);
            // 
            // idEntrada
            // 
            this.idEntrada.Location = new System.Drawing.Point(757, 184);
            this.idEntrada.Name = "idEntrada";
            this.idEntrada.Size = new System.Drawing.Size(186, 22);
            this.idEntrada.TabIndex = 32;
            // 
            // idL
            // 
            this.idL.AutoSize = true;
            this.idL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.idL.Location = new System.Drawing.Point(757, 156);
            this.idL.Name = "idL";
            this.idL.Size = new System.Drawing.Size(29, 22);
            this.idL.TabIndex = 31;
            this.idL.Text = "ID";
            // 
            // nombreL
            // 
            this.nombreL.AutoSize = true;
            this.nombreL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.nombreL.Location = new System.Drawing.Point(757, 212);
            this.nombreL.Name = "nombreL";
            this.nombreL.Size = new System.Drawing.Size(84, 22);
            this.nombreL.TabIndex = 30;
            this.nombreL.Text = "Nombre";
            // 
            // nombreEntrada
            // 
            this.nombreEntrada.Location = new System.Drawing.Point(757, 240);
            this.nombreEntrada.Name = "nombreEntrada";
            this.nombreEntrada.Size = new System.Drawing.Size(186, 22);
            this.nombreEntrada.TabIndex = 29;
            // 
            // listaAlmacen
            // 
            this.listaAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listaAlmacen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listaAlmacen.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.listaAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaAlmacen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listaAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaAlmacen.DefaultCellStyle = dataGridViewCellStyle4;
            this.listaAlmacen.Location = new System.Drawing.Point(12, 109);
            this.listaAlmacen.Name = "listaAlmacen";
            this.listaAlmacen.RowHeadersWidth = 51;
            this.listaAlmacen.RowTemplate.Height = 24;
            this.listaAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaAlmacen.Size = new System.Drawing.Size(739, 309);
            this.listaAlmacen.TabIndex = 28;
            this.listaAlmacen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaAlmacen_CellContentClick);
            // 
            // marcaL
            // 
            this.marcaL.AutoSize = true;
            this.marcaL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.marcaL.Location = new System.Drawing.Point(757, 267);
            this.marcaL.Name = "marcaL";
            this.marcaL.Size = new System.Drawing.Size(71, 22);
            this.marcaL.TabIndex = 48;
            this.marcaL.Text = "Marca";
            // 
            // marcaEntrada
            // 
            this.marcaEntrada.Location = new System.Drawing.Point(757, 292);
            this.marcaEntrada.Name = "marcaEntrada";
            this.marcaEntrada.Size = new System.Drawing.Size(186, 22);
            this.marcaEntrada.TabIndex = 49;
            // 
            // tipoL
            // 
            this.tipoL.AutoSize = true;
            this.tipoL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tipoL.Location = new System.Drawing.Point(757, 323);
            this.tipoL.Name = "tipoL";
            this.tipoL.Size = new System.Drawing.Size(46, 22);
            this.tipoL.TabIndex = 50;
            this.tipoL.Text = "Tipo";
            // 
            // tipoEntrada
            // 
            this.tipoEntrada.Location = new System.Drawing.Point(757, 358);
            this.tipoEntrada.Name = "tipoEntrada";
            this.tipoEntrada.Size = new System.Drawing.Size(186, 22);
            this.tipoEntrada.TabIndex = 51;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bucarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 28);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bucarToolStripMenuItem
            // 
            this.bucarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porId,
            this.porNombre,
            this.porMarca,
            this.porTipo,
            this.mostrarTodo});
            this.bucarToolStripMenuItem.Name = "bucarToolStripMenuItem";
            this.bucarToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.bucarToolStripMenuItem.Text = "Bucar";
            // 
            // porId
            // 
            this.porId.Name = "porId";
            this.porId.Size = new System.Drawing.Size(179, 26);
            this.porId.Text = "Por id";
            this.porId.Click += new System.EventHandler(this.PorId_Click);
            // 
            // porNombre
            // 
            this.porNombre.Name = "porNombre";
            this.porNombre.Size = new System.Drawing.Size(179, 26);
            this.porNombre.Text = "Por Nombre";
            this.porNombre.Click += new System.EventHandler(this.PorModelo_Click);
            // 
            // porMarca
            // 
            this.porMarca.Name = "porMarca";
            this.porMarca.Size = new System.Drawing.Size(179, 26);
            this.porMarca.Text = "Por marca";
            this.porMarca.Click += new System.EventHandler(this.PorMarca_Click);
            // 
            // porTipo
            // 
            this.porTipo.Name = "porTipo";
            this.porTipo.Size = new System.Drawing.Size(179, 26);
            this.porTipo.Text = "Por tipo";
            this.porTipo.Click += new System.EventHandler(this.PorTipo_Click);
            // 
            // mostrarTodo
            // 
            this.mostrarTodo.Name = "mostrarTodo";
            this.mostrarTodo.Size = new System.Drawing.Size(179, 26);
            this.mostrarTodo.Text = "Mostrar todo";
            this.mostrarTodo.Click += new System.EventHandler(this.Todo_Click);
            // 
            // alta_zapato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 559);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tipoEntrada);
            this.Controls.Add(this.tipoL);
            this.Controls.Add(this.marcaEntrada);
            this.Controls.Add(this.marcaL);
            this.Controls.Add(this.LimpiarB);
            this.Controls.Add(this.eliminarB);
            this.Controls.Add(this.ModificarB);
            this.Controls.Add(this.aceptBus);
            this.Controls.Add(this.datoBusEntrada);
            this.Controls.Add(this.datoBuscarL);
            this.Controls.Add(this.aceptarB);
            this.Controls.Add(this.idEntrada);
            this.Controls.Add(this.idL);
            this.Controls.Add(this.nombreL);
            this.Controls.Add(this.nombreEntrada);
            this.Controls.Add(this.listaAlmacen);
            this.Controls.Add(this.TituloPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "alta_zapato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "alta_zapato";
            this.TituloPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaAlmacen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TituloPanel;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Button maximizar;
        private System.Windows.Forms.Button LimpiarB;
        private System.Windows.Forms.Button eliminarB;
        private System.Windows.Forms.Button ModificarB;
        private System.Windows.Forms.Button aceptBus;
        private System.Windows.Forms.TextBox datoBusEntrada;
        private System.Windows.Forms.Label datoBuscarL;
        private System.Windows.Forms.Button aceptarB;
        private System.Windows.Forms.TextBox idEntrada;
        private System.Windows.Forms.Label idL;
        private System.Windows.Forms.Label nombreL;
        private System.Windows.Forms.TextBox nombreEntrada;
        private System.Windows.Forms.DataGridView listaAlmacen;
        private System.Windows.Forms.Label marcaL;
        private System.Windows.Forms.TextBox marcaEntrada;
        private System.Windows.Forms.Label tipoL;
        private System.Windows.Forms.TextBox tipoEntrada;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bucarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porId;
        private System.Windows.Forms.ToolStripMenuItem porNombre;
        private System.Windows.Forms.ToolStripMenuItem porMarca;
        private System.Windows.Forms.ToolStripMenuItem porTipo;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodo;
    }
}