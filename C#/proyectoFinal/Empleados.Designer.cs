namespace proyectoFinal
{
    partial class Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TituloPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bucarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poriDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrar = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.LimpiarB = new System.Windows.Forms.Button();
            this.eliminarB = new System.Windows.Forms.Button();
            this.ModificarB = new System.Windows.Forms.Button();
            this.aceptBus = new System.Windows.Forms.Button();
            this.datoBusEntrada = new System.Windows.Forms.TextBox();
            this.datoBuscarL = new System.Windows.Forms.Label();
            this.agregarB = new System.Windows.Forms.Button();
            this.Sueldo = new System.Windows.Forms.TextBox();
            this.SueldoL = new System.Windows.Forms.Label();
            this.FechaEntrada = new System.Windows.Forms.TextBox();
            this.IngresoL = new System.Windows.Forms.Label();
            this.iDL = new System.Windows.Forms.Label();
            this.iDEmpleado = new System.Windows.Forms.TextBox();
            this.datosL = new System.Windows.Forms.Label();
            this.verTabla = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.NombreL = new System.Windows.Forms.Label();
            this.TituloPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloPanel
            // 
            this.TituloPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.TituloPanel.Controls.Add(this.menuStrip1);
            this.TituloPanel.Controls.Add(this.cerrar);
            this.TituloPanel.Controls.Add(this.minimizar);
            this.TituloPanel.Controls.Add(this.maximizar);
            this.TituloPanel.Location = new System.Drawing.Point(0, 0);
            this.TituloPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TituloPanel.Name = "TituloPanel";
            this.TituloPanel.Size = new System.Drawing.Size(1056, 48);
            this.TituloPanel.TabIndex = 50;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bucarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(65, 48);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bucarToolStripMenuItem
            // 
            this.bucarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNombreToolStripMenuItem,
            this.porFechaToolStripMenuItem,
            this.poriDToolStripMenuItem,
            this.mostrarTodoToolStripMenuItem});
            this.bucarToolStripMenuItem.Name = "bucarToolStripMenuItem";
            this.bucarToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.bucarToolStripMenuItem.Text = "Bucar";
            // 
            // porNombreToolStripMenuItem
            // 
            this.porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            this.porNombreToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.porNombreToolStripMenuItem.Text = "Por Nombre";
            this.porNombreToolStripMenuItem.Click += new System.EventHandler(this.porFolioToolStripMenuItem_Click);
            // 
            // porFechaToolStripMenuItem
            // 
            this.porFechaToolStripMenuItem.Name = "porFechaToolStripMenuItem";
            this.porFechaToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.porFechaToolStripMenuItem.Text = "Por fecha";
            // 
            // poriDToolStripMenuItem
            // 
            this.poriDToolStripMenuItem.Name = "poriDToolStripMenuItem";
            this.poriDToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.poriDToolStripMenuItem.Text = "Por iD";
            this.poriDToolStripMenuItem.Click += new System.EventHandler(this.poriDToolStripMenuItem_Click);
            // 
            // mostrarTodoToolStripMenuItem
            // 
            this.mostrarTodoToolStripMenuItem.Name = "mostrarTodoToolStripMenuItem";
            this.mostrarTodoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.mostrarTodoToolStripMenuItem.Text = "Mostrar todo";
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.BackColor = System.Drawing.Color.Transparent;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(1009, 0);
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
            this.minimizar.Location = new System.Drawing.Point(915, -1);
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
            this.maximizar.Location = new System.Drawing.Point(961, 0);
            this.maximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(47, 48);
            this.maximizar.TabIndex = 1;
            this.maximizar.UseVisualStyleBackColor = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // LimpiarB
            // 
            this.LimpiarB.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarB.Location = new System.Drawing.Point(961, 126);
            this.LimpiarB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LimpiarB.Name = "LimpiarB";
            this.LimpiarB.Size = new System.Drawing.Size(91, 47);
            this.LimpiarB.TabIndex = 66;
            this.LimpiarB.Text = "Limpiar";
            this.LimpiarB.UseVisualStyleBackColor = true;
            this.LimpiarB.Click += new System.EventHandler(this.LimpiarB_Click);
            // 
            // eliminarB
            // 
            this.eliminarB.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarB.Location = new System.Drawing.Point(961, 196);
            this.eliminarB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eliminarB.Name = "eliminarB";
            this.eliminarB.Size = new System.Drawing.Size(91, 47);
            this.eliminarB.TabIndex = 65;
            this.eliminarB.Text = "Eliminar";
            this.eliminarB.UseVisualStyleBackColor = true;
            this.eliminarB.Click += new System.EventHandler(this.eliminarB_Click);
            // 
            // ModificarB
            // 
            this.ModificarB.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarB.Location = new System.Drawing.Point(961, 266);
            this.ModificarB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModificarB.Name = "ModificarB";
            this.ModificarB.Size = new System.Drawing.Size(91, 42);
            this.ModificarB.TabIndex = 64;
            this.ModificarB.Text = "Modificar";
            this.ModificarB.UseVisualStyleBackColor = true;
            this.ModificarB.Click += new System.EventHandler(this.ModificarB_Click);
            // 
            // aceptBus
            // 
            this.aceptBus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptBus.Location = new System.Drawing.Point(21, 446);
            this.aceptBus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aceptBus.Name = "aceptBus";
            this.aceptBus.Size = new System.Drawing.Size(85, 47);
            this.aceptBus.TabIndex = 63;
            this.aceptBus.Text = "Aceptar";
            this.aceptBus.UseVisualStyleBackColor = true;
            this.aceptBus.Visible = false;
            this.aceptBus.Click += new System.EventHandler(this.aceptBus_Click);
            // 
            // datoBusEntrada
            // 
            this.datoBusEntrada.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datoBusEntrada.Location = new System.Drawing.Point(21, 418);
            this.datoBusEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datoBusEntrada.Name = "datoBusEntrada";
            this.datoBusEntrada.Size = new System.Drawing.Size(185, 24);
            this.datoBusEntrada.TabIndex = 62;
            this.datoBusEntrada.Visible = false;
            // 
            // datoBuscarL
            // 
            this.datoBuscarL.AutoSize = true;
            this.datoBuscarL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.datoBuscarL.Location = new System.Drawing.Point(21, 390);
            this.datoBuscarL.Name = "datoBuscarL";
            this.datoBuscarL.Size = new System.Drawing.Size(149, 22);
            this.datoBuscarL.TabIndex = 61;
            this.datoBuscarL.Text = "Datos a buscar";
            this.datoBuscarL.Visible = false;
            // 
            // agregarB
            // 
            this.agregarB.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarB.Location = new System.Drawing.Point(747, 354);
            this.agregarB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agregarB.Name = "agregarB";
            this.agregarB.Size = new System.Drawing.Size(85, 47);
            this.agregarB.TabIndex = 60;
            this.agregarB.Text = "Agregar";
            this.agregarB.UseVisualStyleBackColor = true;
            this.agregarB.Click += new System.EventHandler(this.agregarB_Click);
            // 
            // Sueldo
            // 
            this.Sueldo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sueldo.Location = new System.Drawing.Point(747, 247);
            this.Sueldo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.Size = new System.Drawing.Size(185, 24);
            this.Sueldo.TabIndex = 59;
            // 
            // SueldoL
            // 
            this.SueldoL.AutoSize = true;
            this.SueldoL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.SueldoL.Location = new System.Drawing.Point(743, 222);
            this.SueldoL.Name = "SueldoL";
            this.SueldoL.Size = new System.Drawing.Size(71, 22);
            this.SueldoL.TabIndex = 58;
            this.SueldoL.Text = "Sueldo";
            // 
            // FechaEntrada
            // 
            this.FechaEntrada.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaEntrada.Location = new System.Drawing.Point(747, 194);
            this.FechaEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaEntrada.Name = "FechaEntrada";
            this.FechaEntrada.Size = new System.Drawing.Size(185, 24);
            this.FechaEntrada.TabIndex = 57;
            // 
            // IngresoL
            // 
            this.IngresoL.AutoSize = true;
            this.IngresoL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.IngresoL.Location = new System.Drawing.Point(747, 167);
            this.IngresoL.Name = "IngresoL";
            this.IngresoL.Size = new System.Drawing.Size(168, 22);
            this.IngresoL.TabIndex = 56;
            this.IngresoL.Text = "Fecha de ingreso";
            // 
            // iDL
            // 
            this.iDL.AutoSize = true;
            this.iDL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.iDL.Location = new System.Drawing.Point(747, 113);
            this.iDL.Name = "iDL";
            this.iDL.Size = new System.Drawing.Size(160, 22);
            this.iDL.TabIndex = 55;
            this.iDL.Text = "iD del empleado";
            // 
            // iDEmpleado
            // 
            this.iDEmpleado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDEmpleado.Location = new System.Drawing.Point(747, 142);
            this.iDEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iDEmpleado.Name = "iDEmpleado";
            this.iDEmpleado.Size = new System.Drawing.Size(185, 24);
            this.iDEmpleado.TabIndex = 54;
            // 
            // datosL
            // 
            this.datosL.AutoSize = true;
            this.datosL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.datosL.Location = new System.Drawing.Point(741, 74);
            this.datosL.Name = "datosL";
            this.datosL.Size = new System.Drawing.Size(194, 22);
            this.datosL.TabIndex = 53;
            this.datosL.Text = "Datos del Empleado";
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.verTabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.verTabla.Location = new System.Drawing.Point(21, 53);
            this.verTabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verTabla.Name = "verTabla";
            this.verTabla.ReadOnly = true;
            this.verTabla.RowHeadersWidth = 51;
            this.verTabla.RowTemplate.Height = 24;
            this.verTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.verTabla.Size = new System.Drawing.Size(720, 309);
            this.verTabla.TabIndex = 52;
            this.verTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.verTabla_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(747, 310);
            this.Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(185, 24);
            this.Nombre.TabIndex = 68;
            // 
            // NombreL
            // 
            this.NombreL.AutoSize = true;
            this.NombreL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.NombreL.Location = new System.Drawing.Point(741, 283);
            this.NombreL.Name = "NombreL";
            this.NombreL.Size = new System.Drawing.Size(84, 22);
            this.NombreL.TabIndex = 69;
            this.NombreL.Text = "Nombre";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1056, 512);
            this.Controls.Add(this.NombreL);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.LimpiarB);
            this.Controls.Add(this.eliminarB);
            this.Controls.Add(this.ModificarB);
            this.Controls.Add(this.aceptBus);
            this.Controls.Add(this.datoBusEntrada);
            this.Controls.Add(this.datoBuscarL);
            this.Controls.Add(this.agregarB);
            this.Controls.Add(this.Sueldo);
            this.Controls.Add(this.SueldoL);
            this.Controls.Add(this.FechaEntrada);
            this.Controls.Add(this.IngresoL);
            this.Controls.Add(this.iDL);
            this.Controls.Add(this.iDEmpleado);
            this.Controls.Add(this.datosL);
            this.Controls.Add(this.verTabla);
            this.Controls.Add(this.TituloPanel);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TituloPanel.ResumeLayout(false);
            this.TituloPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verTabla)).EndInit();
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
        private System.Windows.Forms.Button agregarB;
        private System.Windows.Forms.TextBox Sueldo;
        private System.Windows.Forms.Label SueldoL;
        private System.Windows.Forms.TextBox FechaEntrada;
        private System.Windows.Forms.Label IngresoL;
        private System.Windows.Forms.Label iDL;
        private System.Windows.Forms.TextBox iDEmpleado;
        private System.Windows.Forms.Label datosL;
        private System.Windows.Forms.DataGridView verTabla;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label NombreL;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bucarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poriDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodoToolStripMenuItem;
    }
}