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
        // prueba pr = new prueba();
        prueba b = new prueba();

        public Login()
        {
            InitializeComponent();
        }

        



        public void login()
        {
            if (cn.validarLogin(TBusuario.Text, Controlador.SetHash(TBcontrasena.Text)))
            {
                Controlador.Username = Controlador.SetHash(TBusuario.Text);

                // Navegador_seg b = new Navegador_seg();
                Menu b = new Menu();
                b.Show();

                if (cn.getAccesoModulos(1000))
                {
                    //Navegador_seg b = new Navegador_seg();
                    b.Show();

                   b.btlogistica.Enabled = true;
                    //b.btndosmil.Enabled = true;
                    this.Hide();
                    cn.setBtitacora("1000", "login");
                };
                 if (cn.getAccesoModulos(2000))
                {
                   // prueba b = new prueba();
                  //  b.Show();

                    b.btnbancos.Enabled = true;

                    this.Hide();
                    cn.setBtitacora("2000", "login");
                };
                if (cn.getAccesoModulos(3000))
                {
                    // prueba b = new prueba();
                    //  b.Show();

                    b.btncompras.Enabled = true;

                    this.Hide();
                    cn.setBtitacora("3000", "login");
                };
                if (cn.getAccesoModulos(4000))
                {
                    // prueba b = new prueba();
                    //  b.Show();

                    b.btncontabilidad.Enabled = true;

                    this.Hide();
                    cn.setBtitacora("4000", "login");
                };
                if (cn.getAccesoModulos(5000))
                {
                    // prueba b = new prueba();
                    //  b.Show();

                    b.btnnominas.Enabled = true;

                    this.Hide();
                    cn.setBtitacora("5000", "login");
                };
                if (cn.getAccesoModulos(6000))
                {
                    // prueba b = new prueba();
                    //  b.Show();

                    b.btnproduccion.Enabled = true;

                    this.Hide();
                    cn.setBtitacora("6000", "login");
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
