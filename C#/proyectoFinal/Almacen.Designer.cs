namespace proyectoFinal
{
    partial class Almacen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Almacen));
            this.listaAlmacen = new System.Windows.Forms.DataGridView();
            this.DatosL = new System.Windows.Forms.Label();
            this.id_tipoEntrada = new System.Windows.Forms.TextBox();
            this.id_tipo_zapato = new System.Windows.Forms.Label();
            this.idL = new System.Windows.Forms.Label();
            this.idEntrada = new System.Windows.Forms.TextBox();
            this.tamañoL = new System.Windows.Forms.Label();
            this.tamañoEntrada = new System.Windows.Forms.TextBox();
            this.folioL = new System.Windows.Forms.Label();
            this.folioEntrada = new System.Windows.Forms.TextBox();
            this.cantidadL = new System.Windows.Forms.Label();
            this.cantidadEntrada = new System.Windows.Forms.TextBox();
            this.PrecioL = new System.Windows.Forms.Label();
            this.precioEntrada = new System.Windows.Forms.TextBox();
            this.aceptarB = new System.Windows.Forms.Button();
            this.datoBuscarL = new System.Windows.Forms.Label();
            this.datoBusEntrada = new System.Windows.Forms.TextBox();
            this.aceptBus = new System.Windows.Forms.Button();
            this.ModificarB = new System.Windows.Forms.Button();
            this.eliminarB = new System.Windows.Forms.Button();
            this.LimpiarB = new System.Windows.Forms.Button();
            this.TituloPanel = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bucarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PorIdZapato = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombre = new System.Windows.Forms.ToolStripMenuItem();
            this.porCargamento = new System.Windows.Forms.ToolStripMenuItem();
            this.porTipo = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.IdtipoZapato = new System.Windows.Forms.ToolStripMenuItem();
            this.porMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.Portamaño = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlmacen)).BeginInit();
            this.TituloPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaAlmacen
            // 
            this.listaAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listaAlmacen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listaAlmacen.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.listaAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaAlmacen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.listaAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaAlmacen.DefaultCellStyle = dataGridViewCellStyle18;
            this.listaAlmacen.Location = new System.Drawing.Point(0, 106);
            this.listaAlmacen.Name = "listaAlmacen";
            this.listaAlmacen.RowHeadersWidth = 51;
            this.listaAlmacen.RowTemplate.Height = 24;
            this.listaAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaAlmacen.Size = new System.Drawing.Size(739, 309);
            this.listaAlmacen.TabIndex = 1;
            this.listaAlmacen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaAlmacen_CellContentClick);
            // 
            // DatosL
            // 
            this.DatosL.AutoSize = true;
            this.DatosL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.DatosL.Location = new System.Drawing.Point(745, 125);
            this.DatosL.Name = "DatosL";
            this.DatosL.Size = new System.Drawing.Size(188, 22);
            this.DatosL.TabIndex = 6;
            this.DatosL.Text = "Datos del producto";
            // 
            // id_tipoEntrada
            // 
            this.id_tipoEntrada.Location = new System.Drawing.Point(745, 237);
            this.id_tipoEntrada.Name = "id_tipoEntrada";
            this.id_tipoEntrada.Size = new System.Drawing.Size(186, 22);
            this.id_tipoEntrada.TabIndex = 7;
            // 
            // id_tipo_zapato
            // 
            this.id_tipo_zapato.AutoSize = true;
            this.id_tipo_zapato.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.id_tipo_zapato.Location = new System.Drawing.Point(745, 209);
            this.id_tipo_zapato.Name = "id_tipo_zapato";
            this.id_tipo_zapato.Size = new System.Drawing.Size(203, 22);
            this.id_tipo_zapato.TabIndex = 8;
            this.id_tipo_zapato.Text = "ID del tipo de zapato";
            // 
            // idL
            // 
            this.idL.AutoSize = true;
            this.idL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.idL.Location = new System.Drawing.Point(745, 153);
            this.idL.Name = "idL";
            this.idL.Size = new System.Drawing.Size(133, 22);
            this.idL.TabIndex = 9;
            this.idL.Text = "ID del zapato";
            // 
            // idEntrada
            // 
            this.idEntrada.Location = new System.Drawing.Point(745, 181);
            this.idEntrada.Name = "idEntrada";
            this.idEntrada.Size = new System.Drawing.Size(186, 22);
            this.idEntrada.TabIndex = 10;
            // 
            // tamañoL
            // 
            this.tamañoL.AutoSize = true;
            this.tamañoL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tamañoL.Location = new System.Drawing.Point(745, 364);
            this.tamañoL.Name = "tamañoL";
            this.tamañoL.Size = new System.Drawing.Size(85, 22);
            this.tamañoL.TabIndex = 11;
            this.tamañoL.Text = "Tamaño";
            // 
            // tamañoEntrada
            // 
            this.tamañoEntrada.Location = new System.Drawing.Point(745, 389);
            this.tamañoEntrada.Name = "tamañoEntrada";
            this.tamañoEntrada.Size = new System.Drawing.Size(186, 22);
            this.tamañoEntrada.TabIndex = 12;
            // 
            // folioL
            // 
            this.folioL.AutoSize = true;
            this.folioL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.folioL.Location = new System.Drawing.Point(745, 264);
            this.folioL.Name = "folioL";
            this.folioL.Size = new System.Drawing.Size(204, 22);
            this.folioL.TabIndex = 13;
            this.folioL.Text = "Folio del cargamento";
            // 
            // folioEntrada
            // 
            this.folioEntrada.Location = new System.Drawing.Point(745, 289);
            this.folioEntrada.Name = "folioEntrada";
            this.folioEntrada.Size = new System.Drawing.Size(186, 22);
            this.folioEntrada.TabIndex = 14;
            // 
            // cantidadL
            // 
            this.cantidadL.AutoSize = true;
            this.cantidadL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cantidadL.Location = new System.Drawing.Point(745, 314);
            this.cantidadL.Name = "cantidadL";
            this.cantidadL.Size = new System.Drawing.Size(99, 22);
            this.cantidadL.TabIndex = 15;
            this.cantidadL.Text = "Cantidad";
            // 
            // cantidadEntrada
            // 
            this.cantidadEntrada.Location = new System.Drawing.Point(745, 339);
            this.cantidadEntrada.Name = "cantidadEntrada";
            this.cantidadEntrada.Size = new System.Drawing.Size(186, 22);
            this.cantidadEntrada.TabIndex = 16;
            // 
            // PrecioL
            // 
            this.PrecioL.AutoSize = true;
            this.PrecioL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.PrecioL.Location = new System.Drawing.Point(745, 418);
            this.PrecioL.Name = "PrecioL";
            this.PrecioL.Size = new System.Drawing.Size(66, 22);
            this.PrecioL.TabIndex = 17;
            this.PrecioL.Text = "Precio";
            // 
            // precioEntrada
            // 
            this.precioEntrada.Location = new System.Drawing.Point(745, 443);
            this.precioEntrada.Name = "precioEntrada";
            this.precioEntrada.Size = new System.Drawing.Size(186, 22);
            this.precioEntrada.TabIndex = 18;
            // 
            // aceptarB
            // 
            this.aceptarB.Location = new System.Drawing.Point(745, 480);
            this.aceptarB.Name = "aceptarB";
            this.aceptarB.Size = new System.Drawing.Size(85, 47);
            this.aceptarB.TabIndex = 19;
            this.aceptarB.Text = "Agregar";
            this.aceptarB.UseVisualStyleBackColor = true;
            this.aceptarB.Click += new System.EventHandler(this.AceptarB_Click);
            // 
            // datoBuscarL
            // 
            this.datoBuscarL.AutoSize = true;
            this.datoBuscarL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.datoBuscarL.Location = new System.Drawing.Point(16, 433);
            this.datoBuscarL.Name = "datoBuscarL";
            this.datoBuscarL.Size = new System.Drawing.Size(149, 22);
            this.datoBuscarL.TabIndex = 20;
            this.datoBuscarL.Text = "Datos a buscar";
            this.datoBuscarL.Visible = false;
            // 
            // datoBusEntrada
            // 
            this.datoBusEntrada.Location = new System.Drawing.Point(16, 461);
            this.datoBusEntrada.Name = "datoBusEntrada";
            this.datoBusEntrada.Size = new System.Drawing.Size(186, 22);
            this.datoBusEntrada.TabIndex = 21;
            this.datoBusEntrada.Visible = false;
            // 
            // aceptBus
            // 
            this.aceptBus.Location = new System.Drawing.Point(16, 489);
            this.aceptBus.Name = "aceptBus";
            this.aceptBus.Size = new System.Drawing.Size(85, 47);
            this.aceptBus.TabIndex = 22;
            this.aceptBus.Text = "Aceptar";
            this.aceptBus.UseVisualStyleBackColor = true;
            this.aceptBus.Visible = false;
            this.aceptBus.Click += new System.EventHandler(this.AceptBus_Click);
            // 
            // ModificarB
            // 
            this.ModificarB.Location = new System.Drawing.Point(961, 309);
            this.ModificarB.Name = "ModificarB";
            this.ModificarB.Size = new System.Drawing.Size(85, 47);
            this.ModificarB.TabIndex = 23;
            this.ModificarB.Text = "Modificar";
            this.ModificarB.UseVisualStyleBackColor = true;
            this.ModificarB.Click += new System.EventHandler(this.ModificarB_Click);
            // 
            // eliminarB
            // 
            this.eliminarB.Location = new System.Drawing.Point(961, 239);
            this.eliminarB.Name = "eliminarB";
            this.eliminarB.Size = new System.Drawing.Size(85, 47);
            this.eliminarB.TabIndex = 24;
            this.eliminarB.Text = "Eliminar";
            this.eliminarB.UseVisualStyleBackColor = true;
            this.eliminarB.Click += new System.EventHandler(this.EliminarB_Click);
            // 
            // LimpiarB
            // 
            this.LimpiarB.Location = new System.Drawing.Point(961, 169);
            this.LimpiarB.Name = "LimpiarB";
            this.LimpiarB.Size = new System.Drawing.Size(85, 47);
            this.LimpiarB.TabIndex = 25;
            this.LimpiarB.Text = "Limpiar";
            this.LimpiarB.UseVisualStyleBackColor = true;
            this.LimpiarB.Click += new System.EventHandler(this.LimpiarB_Click);
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
            this.TituloPanel.TabIndex = 26;
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
            this.cerrar.Click += new System.EventHandler(this.Cerrar_Click);
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
            this.minimizar.Click += new System.EventHandler(this.Minimizar_Click);
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
            this.maximizar.Click += new System.EventHandler(this.Maximizar_Click);
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
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bucarToolStripMenuItem
            // 
            this.bucarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PorIdZapato,
            this.IdtipoZapato,
            this.porCargamento,
            this.porNombre,
            this.porMarca,
            this.porTipo,
            this.Portamaño,
            this.mostrarTodo});
            this.bucarToolStripMenuItem.Name = "bucarToolStripMenuItem";
            this.bucarToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.bucarToolStripMenuItem.Text = "Bucar";
            // 
            // PorIdZapato
            // 
            this.PorIdZapato.Name = "PorIdZapato";
            this.PorIdZapato.Size = new System.Drawing.Size(232, 26);
            this.PorIdZapato.Text = "Por id de zapato";
            this.PorIdZapato.Click += new System.EventHandler(this.PorId_Click);
            // 
            // porNombre
            // 
            this.porNombre.Name = "porNombre";
            this.porNombre.Size = new System.Drawing.Size(232, 26);
            this.porNombre.Text = "Por Nombre";
            this.porNombre.Click += new System.EventHandler(this.PorNombre_Click);
            // 
            // porCargamento
            // 
            this.porCargamento.Name = "porCargamento";
            this.porCargamento.Size = new System.Drawing.Size(232, 26);
            this.porCargamento.Text = "Por cargamento";
            this.porCargamento.Click += new System.EventHandler(this.PorCargamento_Click);
            // 
            // porTipo
            // 
            this.porTipo.Name = "porTipo";
            this.porTipo.Size = new System.Drawing.Size(232, 26);
            this.porTipo.Text = "Por tipo";
            this.porTipo.Click += new System.EventHandler(this.PorTipo_Click);
            // 
            // mostrarTodo
            // 
            this.mostrarTodo.Name = "mostrarTodo";
            this.mostrarTodo.Size = new System.Drawing.Size(232, 26);
            this.mostrarTodo.Text = "Mostrar todo";
            this.mostrarTodo.Click += new System.EventHandler(this.MostrarTodo_Click);
            // 
            // IdtipoZapato
            // 
            this.IdtipoZapato.Name = "IdtipoZapato";
            this.IdtipoZapato.Size = new System.Drawing.Size(232, 26);
            this.IdtipoZapato.Text = "Por id tipo de zapato";
            this.IdtipoZapato.Click += new System.EventHandler(this.PorIdTipo_Click);
            // 
            // porMarca
            // 
            this.porMarca.Name = "porMarca";
            this.porMarca.Size = new System.Drawing.Size(232, 26);
            this.porMarca.Text = "Por Marca";
            this.porMarca.CheckStateChanged += new System.EventHandler(this.PorMarca_Click);
            // 
            // Portamaño
            // 
            this.Portamaño.Name = "Portamaño";
            this.Portamaño.Size = new System.Drawing.Size(232, 26);
            this.Portamaño.Text = "Por tamaño";
            this.Portamaño.Click += new System.EventHandler(this.PorTamaño_Click);
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 558);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TituloPanel);
            this.Controls.Add(this.LimpiarB);
            this.Controls.Add(this.eliminarB);
            this.Controls.Add(this.ModificarB);
            this.Controls.Add(this.aceptBus);
            this.Controls.Add(this.datoBusEntrada);
            this.Controls.Add(this.datoBuscarL);
            this.Controls.Add(this.aceptarB);
            this.Controls.Add(this.precioEntrada);
            this.Controls.Add(this.PrecioL);
            this.Controls.Add(this.cantidadEntrada);
            this.Controls.Add(this.cantidadL);
            this.Controls.Add(this.folioEntrada);
            this.Controls.Add(this.folioL);
            this.Controls.Add(this.tamañoEntrada);
            this.Controls.Add(this.tamañoL);
            this.Controls.Add(this.idEntrada);
            this.Controls.Add(this.idL);
            this.Controls.Add(this.id_tipo_zapato);
            this.Controls.Add(this.id_tipoEntrada);
            this.Controls.Add(this.DatosL);
            this.Controls.Add(this.listaAlmacen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Almacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacen";
            ((System.ComponentModel.ISupportInitialize)(this.listaAlmacen)).EndInit();
            this.TituloPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listaAlmacen;
        private System.Windows.Forms.Label DatosL;
        private System.Windows.Forms.TextBox id_tipoEntrada;
        private System.Windows.Forms.Label id_tipo_zapato;
        private System.Windows.Forms.Label idL;
        private System.Windows.Forms.TextBox idEntrada;
        private System.Windows.Forms.Label tamañoL;
        private System.Windows.Forms.TextBox tamañoEntrada;
        private System.Windows.Forms.Label folioL;
        private System.Windows.Forms.TextBox folioEntrada;
        private System.Windows.Forms.Label cantidadL;
        private System.Windows.Forms.TextBox cantidadEntrada;
        private System.Windows.Forms.Label PrecioL;
        private System.Windows.Forms.TextBox precioEntrada;
        private System.Windows.Forms.Button aceptarB;
        private System.Windows.Forms.Label datoBuscarL;
        private System.Windows.Forms.TextBox datoBusEntrada;
        private System.Windows.Forms.Button aceptBus;
        private System.Windows.Forms.Button ModificarB;
        private System.Windows.Forms.Button eliminarB;
        private System.Windows.Forms.Button LimpiarB;
        private System.Windows.Forms.Panel TituloPanel;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Button maximizar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bucarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PorIdZapato;
        private System.Windows.Forms.ToolStripMenuItem porNombre;
        private System.Windows.Forms.ToolStripMenuItem porCargamento;
        private System.Windows.Forms.ToolStripMenuItem porTipo;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodo;
        private System.Windows.Forms.ToolStripMenuItem IdtipoZapato;
        private System.Windows.Forms.ToolStripMenuItem porMarca;
        private System.Windows.Forms.ToolStripMenuItem Portamaño;
    }
}