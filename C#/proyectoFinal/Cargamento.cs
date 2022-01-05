using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace proyectoFinal
{
    public partial class Cargamento : Form
    {
        NpgsqlConnection conn2;
        public Cargamento(NpgsqlConnection conn)
        {
            InitializeComponent();
            conn2 = new NpgsqlConnection();
            conn2 = conn;
            mostrar("Select * from cargamento");
        }
        void limpiar()
        {
            fechaEntrada.Clear();
            proveedorEntrada.Clear();
            costoEntrada.Clear();
        }

        private void agregarB_Click(object sender, EventArgs e)
        {
            try
            {
                conn2.Open();
                string dato = "insert into cargamento (fecha,provedor,precio_nomina) " +
                    "values('" + fechaEntrada.Text + "','" + proveedorEntrada.Text + "'," + costoEntrada.Text + ");";
                NpgsqlCommand command = new NpgsqlCommand(dato, conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Cargamento agregado con exito");
                limpiar();
                conn2.Close();
                mostrar("Select * from cargamento;");
            }
            catch(NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn2.Close();
            }
        }

        private void mostrarTodoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mostrar("Select * from cargamento;");
        }

        void mostrar(string linea)
        {
            try
            {
                conn2.Open();
                DataSet datos = new DataSet();
                NpgsqlDataAdapter add = new NpgsqlDataAdapter(linea, conn2);
                add.Fill(datos);
                verTabla.DataSource = datos.Tables[0];
                conn2.Close();
            }
            catch(NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn2.Close();
            }
        }

        private void porFolioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            datoBuscarL.Text = "Folio a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }


        private void aceptBus_Click_1(object sender, EventArgs e)
        {
            if (datoBuscarL.Text == "Fecha a buscar")
                mostrar("Select * from cargamento where fecha='" + datoBusEntrada.Text + "'");
            else if (datoBuscarL.Text == "Folio a buscar")
                mostrar("Select * from cargamento where folio=" + datoBusEntrada.Text);
            else if (datoBuscarL.Text == "Proveedor a buscar")
                mostrar("Select * from cargamento where provedor='" + datoBusEntrada.Text + "'");
            else if (datoBuscarL.Text == "Costo de cargamento a buscar")
                mostrar("Select * from cargamento where precio_nomina=" + datoBusEntrada.Text);
        }

        private void porFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "Fecha a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }
        private void porProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "Proveedor a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void porCostoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "Costo de cargamento a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void verTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = verTabla.CurrentRow;
            DateTime fecha = Convert.ToDateTime(fila.Cells[0].Value);
            fechaEntrada.Text = fecha.ToString("dd/MM/yyyy HH:mm:ss");
            proveedorEntrada.Text = Convert.ToString(fila.Cells[2].Value);
            costoEntrada.Text = Convert.ToString(fila.Cells[3].Value);
        }

        private void LimpiarB_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void eliminarB_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow fila = verTabla.CurrentRow;
            int id = Convert.ToInt32(fila.Cells[1].Value);
            try
            {
                conn2.Open();
                NpgsqlCommand command = new NpgsqlCommand("delete from cargamento where folio =" + id + ";", conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Cargamento eliminado con exito");
                limpiar();
                conn2.Close();
                mostrar("Select * from cargamento;");
            }
            catch(NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn2.Close();
            }
        }

        private void ModificarB_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow fila = verTabla.CurrentRow;
            int folio = Convert.ToInt32(fila.Cells[1].Value);
            try
            {
                conn2.Open();
                string linea = "update cargamento set fecha='" + fechaEntrada.Text + "',provedor='" + proveedorEntrada.Text + "',precio_nomina=" + costoEntrada.Text + " where folio=" + folio + ";";
                NpgsqlCommand command = new NpgsqlCommand(linea, conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Cargamento modificado con exito");
                limpiar();
                conn2.Close();
                mostrar("Select * from cargamento;");
            }
            catch(NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn2.Close();
            }
        }

        private void cerrar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void maximizar_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MostrarContenidoCargB_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            DataGridViewRow fila = verTabla.CurrentRow;
            int folio = Convert.ToInt32(fila.Cells[1].Value);
            ContenidoCargamento cont = new ContenidoCargamento(conn2, folio);
            cont.MdiParent = this.MdiParent;
            cont.Show();
        }
    }
}
