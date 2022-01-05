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
    public partial class Empleados : Form
    {
        NpgsqlConnection conn2;
        public Empleados(NpgsqlConnection conn)
        {
            InitializeComponent();
            conn2 = new NpgsqlConnection();
            conn2 = conn;
            mostrar("Select * from empleado");
        }

        private void agregarB_Click(object sender, EventArgs e)
        {
            try
            {
                
                conn2.Open();
                string dato = "insert into empleado values('" + iDEmpleado.Text + "','" +FechaEntrada.Text+ "',"+Sueldo.Text+",0,"+Sueldo.Text+",'" + Nombre.Text +"');";
                NpgsqlCommand command = new NpgsqlCommand(dato, conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Empleado agregado con exito");
                limpiar();
                conn2.Close();
                mostrar("Select * from empleado;");
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn2.Close();
            }
        }

        void limpiar()
        {
            iDEmpleado.Clear();
            FechaEntrada.Clear();
            Sueldo.Clear();
            Nombre.Clear();
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

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void porFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "Fecha de ingreso de empleado a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void mostrarTodoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mostrar("Select * from empleado;");
        }

     
        private void porFolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "Nombre a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }
        private void poriDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "iD a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void aceptBus_Click(object sender, EventArgs e)
        {
            if (datoBuscarL.Text == "iD a buscar")
                mostrar("Select * from empleado where id_empleado='" + datoBusEntrada.Text + "'");
            else if (datoBuscarL.Text == "Fecha de ingreso de empleado a buscar")
                mostrar("Select * from empleado where fecha_ingreso='" + datoBusEntrada.Text + "'");
            else if (datoBuscarL.Text == "Nombre a buscar")
                mostrar("Select * from empleado where nombre='" + datoBusEntrada.Text + "'");
            
        }

        private void eliminarB_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = verTabla.CurrentRow;
            string id = Convert.ToString(fila.Cells[0].Value);
            
            try
            {
                conn2.Open();
                NpgsqlCommand command = new NpgsqlCommand("delete from empleado where id_empleado ='" + id + "';", conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Empleado eliminado con exito");
                limpiar();
                conn2.Close();
                mostrar("Select * from empleado;");
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
                string linea = "update empleado set id_empleado='" + iDEmpleado.Text + "',sueldo_base=" + Sueldo.Text + ",fecha_ingreso='" + FechaEntrada.Text + "',nombre='" +Nombre.Text+  "' where id_empleado=" + id + ";";
                NpgsqlCommand command = new NpgsqlCommand(linea, conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Empleado modificado con exito");
                limpiar();
                conn2.Close();
                mostrar("Select * from Empleado;");
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
        }

        private void verTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = verTabla.CurrentRow;
            iDEmpleado.Text = Convert.ToString(fila.Cells[0].Value);
            FechaEntrada.Text = Convert.ToString(fila.Cells[1].Value);
            Sueldo.Text = Convert.ToString(fila.Cells[2].Value);
            Nombre.Text = Convert.ToString(fila.Cells[5].Value);
        }
    }
}

