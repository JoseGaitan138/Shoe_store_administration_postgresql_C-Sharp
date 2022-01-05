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
    public partial class CantidadVenta : Form
    {
        NpgsqlConnection conn2;
        int folio_venta;
        public CantidadVenta(NpgsqlConnection conn, int folio)
        {
            InitializeComponent();
            conn2 = new NpgsqlConnection();
            conn2 = conn;
            folio_venta = folio;
            folioVenta.Text = folio_venta.ToString();
            mostrar("Select * from cantidad_venta where folio_venta=" + folio_venta);
        }

        public void limpiar()
        {
            IdZapato.Clear();
            folioVenta.Text = folio_venta.ToString();
            cantidad.Clear();
            costo.Clear();
        }
        private void LimpiarB_Click(object sender, EventArgs e)
        {
            limpiar();
            folioVenta.Text = folio_venta.ToString();

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

        private void EliminarB_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = verTabla.CurrentRow;
            string id = Convert.ToString(fila.Cells[1].Value);
            try
            {
                conn2.Open();
                NpgsqlCommand command = new NpgsqlCommand("delete from cantidad_venta where id_zapato ='" + id + "' and folio_venta="+ folioVenta.Text +";" +
                    "update ventas set total = (select sum(e.total) from cantidad_venta as e where e.folio_venta =" + folioVenta.Text + ") where folio =" + folioVenta.Text + ";", conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Venta eliminada de la base de datos con exito");
                limpiar();
                conn2.Close();
                mostrar("Select * from cantidad_venta where folio_venta=" + folio_venta.ToString());
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
            string id = Convert.ToString(fila.Cells[1].Value);
            try
            {
                conn2.Open();
                string linea = "update cantidad_venta set " +
                    "folio_venta=" + folioVenta.Text + ",id_zapato = '" + IdZapato.Text + "',cantidad=" + cantidad.Text + ",monto=" + costo.Text +
                    ",total=cantidad*monto" + " where id_zapato='" + id + "' and folio_venta=" + folioVenta.Text + ";" +
                    "update ventas set total = (select sum(e.total) from cantidad_venta as e where e.folio_venta =" + folioVenta.Text + ") where folio =" + folioVenta.Text + ";";
                NpgsqlCommand command = new NpgsqlCommand(linea, conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Pedido del cargamento modificado con exito");
                limpiar();
                conn2.Close();
                mostrar("Select * from cantidad_venta where folio_venta=" + folio_venta.ToString());
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn2.Close();
            }
        }

        private void AgregarB_Click(object sender, EventArgs e)
        {
            float cant = float.Parse(cantidad.Text);
            float ccosto = float.Parse(costo.Text);
            try
            {
                conn2.Open();
                string dato = "insert into cantidad_venta values('" + folioVenta.Text + "'," + IdZapato.Text + "," +
                    cantidad.Text + "," + ccosto + "," + cant * ccosto + ");" +
                    "update ventas set total = (select sum(e.total) from cantidad_venta as e where e.folio_venta =" + folioVenta.Text + ") where folio =" + folioVenta.Text + ";";
                NpgsqlCommand command = new NpgsqlCommand(dato, conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Venta agregada con exito");
                limpiar();
                conn2.Close();
                mostrar("Select * from cantidad_venta where folio_venta=" + folio_venta.ToString());
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn2.Close();
            }
        }


        private void verTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = verTabla.CurrentRow;
            IdZapato.Text = Convert.ToString(fila.Cells[1].Value);
            folioVenta.Text = Convert.ToString(fila.Cells[0].Value);
            cantidad.Text = Convert.ToString(fila.Cells[2].Value);
            costo.Text = Convert.ToString(fila.Cells[3].Value);
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

        private void porIDDeZapatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "ID Zapato a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void porFolioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "Folio de venta a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void porCantidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "Cantidad de venta a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void mostrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar("Select * from cantidad_venta");
        }

        private void aceptBus_Click(object sender, EventArgs e)
        {
            if (datoBuscarL.Text == "ID Zapato a buscar")
                mostrar("Select * from cantidad_venta where id_zapato='" + datoBusEntrada.Text + "'");
            else if (datoBuscarL.Text == "Folio de venta a buscar")
                mostrar("Select * from cantidad_venta where folio_venta=" + datoBusEntrada.Text);
            else if (datoBuscarL.Text == "Cantidad de venta a buscar")
                mostrar("Select * from cantidad_venta where cantidad='" + datoBusEntrada.Text + "'");
        }
    }
}
