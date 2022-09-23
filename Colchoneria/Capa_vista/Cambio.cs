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
    public partial class Cambio : Form
    {
        public Cambio()
        {
            InitializeComponent();
        }
        string table = "tbl_usuarios";
        Controlador cn = new Controlador();

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                TextBox[] textbox = { txtcontraseña };
                txtcontraseña.Text = Capa_controlador.Controlador.SetHash(txtcontraseña.Text);
                int valor1 = int.Parse(txtBusqueda.Text);
                string campo = "pk_id_usuario = ";
                cn.actualizarcontra(textbox, table, campo, valor1);
            
        }
    }
}
