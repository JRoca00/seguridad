using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_controlador;

namespace Capa_vista
{
    public partial class Usuario : Form
    {
        string table = "Usuarios2";

        Controlador cn = new Controlador();

        public Usuario()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtUsuario.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtContrasenia.Text = "";
            txtBusqueda.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Navegador_seg b = new Navegador_seg();
            b.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { txtNombre, txtApellido, txtContrasenia };
            cn.ingresar(textbox, table);
            string message = "Registro Guardado";
            limpiar();
            MessageBox.Show(message);
            //actualizardatagriew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { txtUsuario, txtNombre, txtApellido, txtContrasenia };
            int valor1 = int.Parse(txtBusqueda.Text);
            string campo = "idUsuario = ";
            //string num = txtBusqueda.Tag.ToString();
            cn.buscar(textbox,table, valor1,campo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { txtUsuario, txtNombre, txtApellido, txtContrasenia };
            int valor1 = int.Parse(txtBusqueda.Text);
            string campo = "idUsuario = ";
            cn.actualizar(textbox,table,campo, valor1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            txtUsuario.Enabled = false;
        }
    }
}
