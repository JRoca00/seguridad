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
    public partial class Aplicacion : Form
    {
        string table = "Aplicacion2";
        Controlador cn = new Controlador();

        public Aplicacion()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtIdAplicacion.Text = "";
            txtNombre.Text = "";
            txtIdModulo.Text = "";
            txtDescripcion.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Navegador_seg b = new Navegador_seg();
            b.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { txtNombre, txtIdModulo, txtDescripcion };
            cn.ingresar(textbox, table);
            string message = "Registro Guardado";
            limpiar();
            MessageBox.Show(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { txtNombre, txtIdModulo, txtDescripcion };
            int valor1 = int.Parse(txtBusacar.Text);
            string campo = "idAplicacion = ";
            //string num = txtBusacar.Tag.ToString();
            cn.buscar(textbox, table, valor1, campo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { txtIdAplicacion , txtNombre, txtIdModulo, txtDescripcion };
            int valor1 = int.Parse(txtBusacar.Text);
            string campo = "idAplicacion = ";
            cn.actualizar(textbox, table, campo, valor1);
        }

        private void Aplicacion_Load(object sender, EventArgs e)
        {
            txtIdAplicacion.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int campo = int.Parse(txtBusacar.Text);
                string condicion = "idAplicacion = ";
                cn.eliminar(table, condicion, campo);
                //this.Close();
            }
            else
            {
                limpiar();
                //this.Close();
            }

            
        }
    }
}
