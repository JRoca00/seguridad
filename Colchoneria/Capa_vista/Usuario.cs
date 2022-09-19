using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_controlador;

namespace Capa_vista
{
    public partial class Usuario : Form
    {
        string table = "usuarios";
        Controlador cn = new Controlador();

        public Usuario()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtBusqueda.Text = "";
            txtusername.Text = "";
            txtcontraseña.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtemail.Text = "";
            txtestado.Text = "";
        }

        public void checkbox()
        {
            if (checkBox1.Checked)
            {
                txtestado.Text = "1";
            }
            else
            {
                txtestado.Text = "0";
            }
        }

        private void button5_Click(object sender, EventArgs e)// boton salir
        {
            Navegador_seg b = new Navegador_seg();
            b.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)//boton guardar
        {
            checkbox();
            TextBox[] textbox = { txtnombre, txtapellido, txtcontraseña, txtusername, txtemail, txtestado };
            txtcontraseña.Text = Capa_controlador.Controlador.SetHash(txtcontraseña.Text);
            cn.ingresar(textbox, table);
            string message = "Registro Guardado";
            limpiar();
            MessageBox.Show(message);
        }

        private void button1_Click(object sender, EventArgs e) //Boton Buscar
        {
            TextBox[] textbox = { txtnombre, txtapellido, txtcontraseña, txtusername, txtemail, txtestado };
            int valor1 = int.Parse(txtBusqueda.Text);
            string campo = "pk_id_usuario = ";
            cn.buscar(textbox,table, valor1,campo);
        }

        private void button4_Click(object sender, EventArgs e) //boton modificar
        {
            TextBox[] textbox = { txtnombre, txtapellido, txtcontraseña, txtusername, txtemail, txtestado };
            int valor1 = int.Parse(txtBusqueda.Text);
            string campo = "pk_id_usuario = ";
            cn.actualizar(textbox,table,campo, valor1);
        }

        private void button2_Click(object sender, EventArgs e)// boton nuevo
        {
            limpiar();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            txtestado.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)// boton eliminar
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int campo = int.Parse(txtBusqueda.Text);
                string condicion = "pk_id_usuario = ";
                cn.eliminar(table, condicion, campo);
                string message1 = "Registro eliminado";
                limpiar();
                MessageBox.Show(message1);
            }
            else
            {
                limpiar();
            }
        }
    }
}
