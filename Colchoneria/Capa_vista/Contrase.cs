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
    public partial class Contrase : Form
    {
        public Contrase()
        {
            InitializeComponent();
        }

        Controlador cn = new Controlador();


        public void autenticar()
        {
            if (cn.validarLogin(TBusuario.Text, Controlador.SetHash(TBcontrasena.Text)))
            {
                Controlador.Username = Controlador.SetHash(TBusuario.Text);
                //cn.setBtitacora("0001", "login");
                Cambio b = new Cambio();
                b.MdiParent = this;
                b.Show();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            autenticar();
            groupBox1.Visible = false;

        }
    }
}
