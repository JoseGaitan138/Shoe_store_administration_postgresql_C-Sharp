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
    public partial class MenuPrincipal : Form
    {
        NpgsqlConnection conn2;
        public MenuPrincipal(NpgsqlConnection conn)
        {
            
            InitializeComponent();
            conn2 = new NpgsqlConnection();
            conn2 = conn;
        }

   
        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ProductoBotton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            alta_zapato productos = new alta_zapato(conn2);
            productos.MdiParent = this;
            productos.Show();
        }

        private void ProductoBotton_MouseEnter(object sender, EventArgs e)
        {
            productoBotton.BackColor = Color.AliceBlue;
        }

        private void ProductoBotton_MouseLeave(object sender, EventArgs e)
        {
            productoBotton.BackColor = Color.RoyalBlue;
        }

        private void AlmacenBotton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            Almacen almacen = new Almacen(conn2);
            almacen.MdiParent = this;
            almacen.Show();
        }

        private void AlmacenBotton_MouseEnter(object sender, EventArgs e)
        {
            almacenBotton.BackColor = Color.AliceBlue;
        }

        private void AlmacenBotton_MouseLeave(object sender, EventArgs e)
        {
            almacenBotton.BackColor = Color.RoyalBlue;
        }

        private void CargamentoButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            Cargamento carg = new Cargamento(conn2);
            carg.MdiParent = this;
            carg.Show();
        }

        private void CargamentoButton_MouseEnter(object sender, EventArgs e)
        {
            CargamentoButton.BackColor = Color.AliceBlue;
        }

        private void CargamentoButton_MouseLeave(object sender, EventArgs e)
        {
            CargamentoButton.BackColor = Color.RoyalBlue;
        }

        private void VentasButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            Ventas ventas = new Ventas(conn2);
            ventas.MdiParent = this;
            ventas.Show();
        }

        private void VentasButton_MouseEnter(object sender, EventArgs e)
        {
            VentasButton.BackColor = Color.AliceBlue;
        }

        private void VentasButton_MouseLeave(object sender, EventArgs e)
        {
            VentasButton.BackColor = Color.RoyalBlue;
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            Empleados E = new Empleados(conn2);
            E.MdiParent = this;
            E.Show();
            
        }

        private void buttonEmpleados_MouseEnter(object sender, EventArgs e)
        {
            buttonEmpleados.BackColor = Color.AliceBlue;
        }

        private void buttonEmpleados_MouseLeave(object sender, EventArgs e)
        {
            buttonEmpleados.BackColor = Color.RoyalBlue;
        }
    }
        
}
