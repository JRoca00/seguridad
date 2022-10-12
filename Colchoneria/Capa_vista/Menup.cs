using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_vista
{
    public partial class Menup : Form
    {
        public Menup()
        {
            InitializeComponent();
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
    }
}
