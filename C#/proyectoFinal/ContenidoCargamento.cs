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
    public partial class ContenidoCargamento : Form
    {
        NpgsqlConnection conn2;
        int folio_carg;
        public ContenidoCargamento(NpgsqlConnection conn, int folio)
        {
            InitializeComponent();
            conn2 = new NpgsqlConnection();
            conn2 = conn;
            folio_carg = folio;
            folioEntrada.Text = folio_carg.ToString();
            mostrar("Select * from Contenido_cargamento where folio_de_cargamento=" + folio_carg.ToString());
        }
        void limpiar()
        {
            IdZapatoEntrada.Clear();
            folioEntrada.Text = folio_carg.ToString();
            cantidadEntrada.Clear();
            costoPzaEntrada.Clear();
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
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn2.Close();
            }
        }
        private void LimpiarB_Click(object sender, EventArgs e)
        {
            limpiar();
            folioEntrada.Text = folio_carg.ToString();
        }

        private void EliminarB_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = verTabla.CurrentRow;
            string id = Convert.ToString(fila.Cells[0].Value);
            try
            {
                conn2.Open();
                NpgsqlCommand command = new NpgsqlCommand("delete from Contenido_cargamento where id_zapato ='" + id + "' and folio_de_cargamento=" + folioEntrada.Text + ";" +
                    "update cargamento set precio_nomina = (select sum(e.monto_cargamento) from Contenido_cargamento as e where e.folio_de_cargamento =" + folioEntrada.Text + ") where folio =" + folioEntrada.Text + ";", conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Pedido eliminado del cargamento con exito");
                limpiar();
                conn2.Close();
                mostrar("Select * from Contenido_cargamento where folio_de_cargamento=" + folio_carg.ToString());
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn2.Close();
            }
        }

        private void ModificarB_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = verTabla.CurrentRow;
            string id = Convert.ToString(fila.Cells[0].Value);
            try
            {
                conn2.Open();
                string linea = "update Contenido_cargamento set " +
                    "id_zapato='" + IdZapatoEntrada.Text + "',folio_de_cargamento=" + folioEntrada.Text + ",cantidad=" + cantidadEntrada.Text + ",costo_pza=" + costoPzaEntrada.Text +
                    ",monto_cargamento=cantidad*costo_pza" + " where id_zapato='" + id + "' and folio_de_cargamento=" + folioEntrada.Text + ";" +
                    "update cargamento set precio_nomina = (select sum(e.monto_cargamento) from Contenido_cargamento as e where e.folio_de_cargamento =" + folioEntrada.Text + ") where folio =" + folioEntrada.Text + ";";
                NpgsqlCommand command = new NpgsqlCommand(linea, conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Pedido del cargamento modificado con exito");
                limpiar();
                conn2.Close();
                mostrar("Select * from Contenido_cargamento where folio_de_cargamento=" + folio_carg.ToString());
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn2.Close();
            }
        }

        private void AgregarB_Click(object sender, EventArgs e)
        {
            float cant = float.Parse(cantidadEntrada.Text);
            float costo = float.Parse(costoPzaEntrada.Text);
            try
            {
                conn2.Open();
                string dato = "insert into Contenido_cargamento values('" + IdZapatoEntrada.Text + "'," + folioEntrada.Text + "," +
                    cantidadEntrada.Text + "," + costo + "," + cant * costo + ");" +
                    "update cargamento set precio_nomina = (select sum(e.monto_cargamento) from Contenido_cargamento as e where e.folio_de_cargamento =" + folioEntrada.Text + ") where folio =" + folioEntrada.Text + ";";
                NpgsqlCommand command = new NpgsqlCommand(dato, conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Pedido agregado al cargamento con exito");
                limpiar();
                conn2.Close();
                mostrar("Select * from Contenido_cargamento where folio_de_cargamento=" + folio_carg.ToString());
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn2.Close();
            }
        }

        private void aceptBus_Click(object sender, EventArgs e)
        {
            if (datoBuscarL.Text == "ID Zapato a buscar")
                mostrar("Select * from Contenido_cargamento where id_zapato='" + datoBusEntrada.Text + "'");
            else if (datoBuscarL.Text == "Folio de cargamento a buscar")
                mostrar("Select * from Contenido_cargamento where folio_de_cargamento=" + datoBusEntrada.Text);
            else if (datoBuscarL.Text == "Cantidad a buscar")
                mostrar("Select * from Contenido_cargamento where cantidad='" + datoBusEntrada.Text + "'");
            else if (datoBuscarL.Text == "Costo/Pza. a buscar")
                mostrar("Select * from Contenido_cargamento where costo_pza=" + datoBusEntrada.Text);
            else if (datoBuscarL.Text == "Monto total de pedido a buscar")
                mostrar("Select * from Contenido_cargamento where monto_cargamento=" + datoBusEntrada.Text);
        }

        private void porIDDeZapatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "ID Zapato a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void porFolioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "Folio de cargamento a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void porCantidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "Cantidad a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void porCostopzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "Costo/Pza. a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void porMontoTotalDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "Monto total de pedido a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void mostrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar("Select * from Contenido_cargamento");
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void verTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = verTabla.CurrentRow;
            IdZapatoEntrada.Text = Convert.ToString(fila.Cells[0].Value);
            folioEntrada.Text = Convert.ToString(fila.Cells[1].Value);
            cantidadEntrada.Text = Convert.ToString(fila.Cells[2].Value);
            costoPzaEntrada.Text = Convert.ToString(fila.Cells[3].Value);
        }
    }
}
