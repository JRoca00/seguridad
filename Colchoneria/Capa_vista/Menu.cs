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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void btlogistica_Click(object sender, EventArgs e)
        {
            vistalogis.MenuLogistica b = new vistalogis.MenuLogistica();
            b.Show();
            this.Hide();
        }

        public void btncontabilidad_Click(object sender, EventArgs e)
        {
            Navegador_seg b = new Navegador_seg();
            
            b.Show();
        }

        public void btnnominas_Click(object sender, EventArgs e)
        {

        }

        public void btnbancos_Click(object sender, EventArgs e)
        {

        }

        public void btncompras_Click(object sender, EventArgs e)
        {

        }

        public void btnproduccion_Click(object sender, EventArgs e)
        {

        }
    }
}
