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
    public partial class Login : Form
    {

        string tab = "usuario";
        string da1 = "usuario";
        string da2 = "contra";
        Controlador cn = new Controlador();

        public Login()
        {
            InitializeComponent();
        }


        public void login()
        {
            if (cn.validarLogin(TBusuario.Text, Controlador.SetHash(TBcontrasena.Text)))
            {
                Controlador.Username = Controlador.SetHash(TBusuario.Text); 
                if (cn.getAccesoModulos(1000))
                {
                    Navegador_seg mdi = new Navegador_seg();
                    mdi.Show();
                    this.Hide();
                    cn.setBtitacora("1000", "login");
                };
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            login();  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                // TBcontraseña.PasswordChar = '*';
                TBcontrasena.PasswordChar = '\0';
            }
            else
                       if (TBcontrasena.Text != "")
            {
                // TBcontraseña.PasswordChar = '\0';
                TBcontrasena.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recuperacion b = new recuperacion();
            b.Show();
        }
    }
}
