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
    public partial class Bitacora : Form
    {
        string emp = "tbl_bitacoradeeventos";
        Controlador cn = new Controlador();

        public Bitacora()
        {
            InitializeComponent();
        }

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(emp);
            datag.DataSource = dt;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
