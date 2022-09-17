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
    public partial class AsignacionPerfiles : Form
    {
        string table = "AsignacionesPerfilsUsuario";

        Controlador cn = new Controlador();

        public AsignacionPerfiles()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtIdPerfil.Text = "";
            txtIdUsuario.Text = "";
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Navegador_seg b = new Navegador_seg();
            b.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { txtIdPerfil, txtIdUsuario};
            cn.ingresar(textbox, table);
            string message = "Registro Guardado";
            limpiar();
            MessageBox.Show(message);
        }

        private void AsignacionPerfiles_Load(object sender, EventArgs e)
        {
            cn.llenartablaa(listPerfilUsuario.Tag.ToString(), listPerfilUsuario);
        }
    }
}
