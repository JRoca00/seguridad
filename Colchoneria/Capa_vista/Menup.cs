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
    public partial class Menup : Form
    {
        Controlador cn = new Controlador();

        public Menup()
        {
            InitializeComponent();

            Button[] apps = { btnseguridad, btlogistica, btncompras, btnProduccion, btnnominas, btnBancos, btnContabilidad};
            cn.deshabilitarApps(apps);

            cn.getAccesoApp(1000, apps[0]);
            cn.getAccesoApp(2000, apps[1]);
            cn.getAccesoApp(3000, apps[2]);
            cn.getAccesoApp(5000, apps[3]);
            cn.getAccesoApp(6000, apps[4]);
            cn.getAccesoApp(7000, apps[5]);
            cn.getAccesoApp(8000, apps[6]);
           

        }

        public void btnlogout_Click(object sender, EventArgs e)
        {
            MenuSeguridad b = new MenuSeguridad();
            b.Show();
            //this.Close();
        }

        public void btlogistica_Click(object sender, EventArgs e)
        {
            VistaLogistica.Menu b = new VistaLogistica.Menu();
            b.Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Login b = new Login();
            b.Show();
            this.Close();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            /*VistaLogistica.Menu b = new VistaLogistica.Menu();
            b.Show();*/
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            /*VistaLogistica.Menu b = new VistaLogistica.Menu();
           b.Show();*/
        }

        private void btnnominas_Click(object sender, EventArgs e)
        {
            /*VistaLogistica.Menu b = new VistaLogistica.Menu();
           b.Show();*/
        }

        private void btnBancos_Click(object sender, EventArgs e)
        {
            /*VistaLogistica.Menu b = new VistaLogistica.Menu();
           b.Show();*/
        }

        private void btnContabilidad_Click(object sender, EventArgs e)
        {
            /*VistaLogistica.Menu b = new VistaLogistica.Menu();
           b.Show();*/
        }
    }
}
