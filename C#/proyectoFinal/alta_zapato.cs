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
    public partial class alta_zapato : Form
    {
        NpgsqlConnection conn2;
        public alta_zapato(NpgsqlConnection conn)
        {
            InitializeComponent();
            conn2 = new NpgsqlConnection();
            conn2 = conn;
        }

        void limpiar()
        {
            idEntrada.Clear();
            nombreEntrada.Clear();
            marcaEntrada.Clear();
            tipoEntrada.Clear();
        }

        void mostrar(string linea)
        {
            try
            {
                conn2.Open();
                DataSet datos = new DataSet();
                NpgsqlDataAdapter add = new NpgsqlDataAdapter(linea, conn2);
                add.Fill(datos);
                listaAlmacen.DataSource = datos.Tables[0];
                conn2.Close();
            }
            catch
            {
                MessageBox.Show("Error al hacer la busqueda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AceptarB_Click(object sender, EventArgs e)
        {
            try
            {
                conn2.Open();
                string dato = "insert into Alta_zapato values('" + idEntrada.Text + "','" + nombreEntrada.Text + "','" + marcaEntrada.Text + "','" + tipoEntrada.Text + "');";
                NpgsqlCommand command = new NpgsqlCommand(dato, conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Producto agredado con exito");
                conn2.Close();
                mostrarPor();
                limpiar();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn2.Close();
            }
        }

        private void PorId_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "ID a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void PorModelo_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "Nombre a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void PorMarca_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "Marca a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;

        }

        private void PorTipo_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "Tipo a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void Todo_Click(object sender, EventArgs e)
        {
            mostrar("Select * from Alta_zapato;");
        }

        private void AceptBus_Click(object sender, EventArgs e)
        {
            mostrarPor();
        }

        private void mostrarPor()
        {
            if (datoBuscarL.Text == "ID a buscar")
                mostrar("Select * from Alta_zapato where id_tipo_zapato='" + datoBusEntrada.Text + "'");
            else if (datoBuscarL.Text == "Nombre a buscar")
                mostrar("Select * from Alta_zapato where nombre='" + datoBusEntrada.Text + "'");
            else if (datoBuscarL.Text == "Marca a buscar")
                mostrar("Select * from Alta_zapato where marca='" + datoBusEntrada.Text + "'");
            else if (datoBuscarL.Text == "Tipo a buscar")
                mostrar("Select * from Alta_zapato where tipo=" + "'" + datoBusEntrada.Text + "'");
            else
                mostrar("Select * from Alta_zapato;");
        }

            private void ListaAlmacen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = listaAlmacen.CurrentRow;
            idEntrada.Text = Convert.ToString(fila.Cells[0].Value);
            nombreEntrada.Text = Convert.ToString(fila.Cells[1].Value);
            marcaEntrada.Text = Convert.ToString(fila.Cells[2].Value);
            tipoEntrada.Text = Convert.ToString(fila.Cells[3].Value);
        }

        private void LimpiarB_Click(object sender, EventArgs e)
        {
            limpiar();
            datoBusEntrada.Clear();
        }

        private void EliminarB_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = listaAlmacen.CurrentRow;
            try
            {
                conn2.Open();
                NpgsqlCommand command = new NpgsqlCommand("delete from Alta_zapato where id_tipo_zapato ='" + fila.Cells[0].Value + "';", conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Producto eliminado con exito");
                conn2.Close();
                mostrarPor();
                limpiar();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn2.Close();
            }
        }

        private void ModificarB_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = listaAlmacen.CurrentRow;
            try
            {
                conn2.Open();
                string linea = "update Alta_zapato set nombre='" + nombreEntrada.Text + "',marca='" +marcaEntrada.Text + "',tipo='" + tipoEntrada.Text + "' where id_tipo_zapato='" + fila.Cells[0].Value + "';";
                NpgsqlCommand command = new NpgsqlCommand(linea, conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Producto modificado con exito");
                conn2.Close();
                mostrarPor();
                limpiar();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn2.Close();
            }
        }

       
    }
}
