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
    public partial class Almacen : Form
    {
        NpgsqlConnection conn2;
        public Almacen(NpgsqlConnection conn)
        {
            InitializeComponent();
            conn2 = new NpgsqlConnection();
            conn2 = conn;
        }

        void limpiar()
        {
            idEntrada.Clear();
            id_tipoEntrada.Clear();
            tamañoEntrada.Clear();
            folioEntrada.Clear();
            cantidadEntrada.Clear();
            precioEntrada.Clear();
        }

        private void AceptarB_Click(object sender, EventArgs e)
        {
            try
            {
                conn2.Open();
                string dato = "insert into zapato values('" + idEntrada.Text + "','" + id_tipoEntrada.Text + "'," + folioEntrada.Text + "," + cantidadEntrada.Text + "," + tamañoEntrada.Text + "," + precioEntrada.Text + ");";
                NpgsqlCommand command = new NpgsqlCommand(dato, conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Producto agredado con exito");
                conn2.Close();
                mostrarPor();
                limpiar();
            }
            catch(NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn2.Close();
            }
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
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn2.Close();
            }
        }

        private void ListaAlmacen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = listaAlmacen.CurrentRow;
            idEntrada.Text = Convert.ToString(fila.Cells[0].Value);
            id_tipoEntrada.Text = Convert.ToString(fila.Cells[1].Value);      
            folioEntrada.Text = Convert.ToString(fila.Cells[5].Value);
            cantidadEntrada.Text = Convert.ToString(fila.Cells[6].Value);
            tamañoEntrada.Text = Convert.ToString(fila.Cells[7].Value);
            precioEntrada.Text = Convert.ToString(fila.Cells[8].Value);
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
                NpgsqlCommand command = new NpgsqlCommand("delete from zapato where id_zapato ='"+ fila.Cells[0].Value + "';", conn2);
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
                string linea = "update zapato set id_tipo_zapato='" + id_tipoEntrada.Text + "',tamaño=" + tamañoEntrada.Text + ",folio_cargamento=" + folioEntrada.Text + ",cantidad=" + cantidadEntrada.Text + ",precio=" + precioEntrada.Text + " where id_zapato='" + fila.Cells[0].Value + "';";
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

        private void PorId_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "ID de zapato a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void PorIdTipo_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "ID tipo de zapato a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void PorCargamento_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "Folio del cargamento a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void PorNombre_Click(object sender, EventArgs e)
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

        private void PorTamaño_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "Tamaño a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void MostrarTodo_Click(object sender, EventArgs e)
        {
            mostrar("select C.id_zapato,O.id_tipo_zapato,O.nombre,O.marca,O.tipo,C.folio_cargamento,C.cantidad,C.tamaño,C.precio from Alta_zapato O,zapato C where (C.id_tipo_zapato=O.id_tipo_zapato);");
        }

        private void AceptBus_Click(object sender, EventArgs e)
        {
            mostrarPor();
        }

        private void mostrarPor()
        {
            if (datoBuscarL.Text == "ID de zapato a buscar")
                mostrar("select C.id_zapato,O.id_tipo_zapato,O.nombre,O.marca,O.tipo,C.folio_cargamento,C.cantidad,C.tamaño,C.precio from Alta_zapato O,zapato C where (C.id_tipo_zapato=O.id_tipo_zapato and C.id_zapato='" + datoBusEntrada.Text + "');");
            else if (datoBuscarL.Text == "ID tipo de zapato a buscar")
                mostrar("select C.id_zapato,O.id_tipo_zapato,O.nombre,O.marca,O.tipo,C.folio_cargamento,C.cantidad,C.tamaño,C.precio from Alta_zapato O,zapato C where (C.id_tipo_zapato=O.id_tipo_zapato and C.id_tipo_zapato='" + datoBusEntrada.Text + "');");
            else if (datoBuscarL.Text == "Folio del cargamento a buscar")
                mostrar("select C.id_zapato,O.id_tipo_zapato,O.nombre,O.marca,O.tipo,C.folio_cargamento,C.cantidad,C.tamaño,C.precio from Alta_zapato O,zapato C where (C.id_tipo_zapato=O.id_tipo_zapato and C.folio_cargamento=" + datoBusEntrada.Text + ");");
            else if (datoBuscarL.Text == "Nombre a buscar")
                mostrar("select C.id_zapato,O.id_tipo_zapato,O.nombre,O.marca,O.tipo,C.folio_cargamento,C.cantidad,C.tamaño,C.precio from Alta_zapato O,zapato C where (C.id_tipo_zapato=O.id_tipo_zapato and  O.nombre='" + datoBusEntrada.Text + "');");
            else if (datoBuscarL.Text == "Marca a buscar")
                mostrar("select C.id_zapato,O.id_tipo_zapato,O.nombre,O.marca,O.tipo,C.folio_cargamento,C.cantidad,C.tamaño,C.precio from Alta_zapato O,zapato C where (C.id_tipo_zapato=O.id_tipo_zapato and  O.marca='" + datoBusEntrada.Text + "');");
            else if (datoBuscarL.Text == "Tipo a buscar")
                mostrar("select C.id_zapato,O.id_tipo_zapato,O.nombre,O.marca,O.tipo,C.folio_cargamento,C.cantidad,C.tamaño,C.precio from Alta_zapato O,zapato C where (C.id_tipo_zapato=O.id_tipo_zapato and  O.tipo='" + datoBusEntrada.Text + "');");
            else if (datoBuscarL.Text == "Tamaño a buscar")
                mostrar("select C.id_zapato,O.id_tipo_zapato,O.nombre,O.marca,O.tipo,C.folio_cargamento,C.cantidad,C.tamaño,C.precio from Alta_zapato O,zapato C where (C.id_tipo_zapato=O.id_tipo_zapato and  C.tamaño=" + datoBusEntrada.Text + ");");
            else
                mostrar("select C.id_zapato,O.id_tipo_zapato,O.nombre,O.marca,O.tipo,C.folio_cargamento,C.cantidad,C.tamaño,C.precio from Alta_zapato O,zapato C where (C.id_tipo_zapato=O.id_tipo_zapato);");
        }
    }
}
   