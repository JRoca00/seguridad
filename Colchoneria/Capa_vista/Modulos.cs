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
    public partial class Modulos : Form
    {
        string table = "tbl_modulos";

        Controlador cn = new Controlador();

        public Modulos()
        {
            InitializeComponent();
        }
        
        public void Limpiar()
        {
            txtBuscar.Text = "";
            txtDescripcion.Text = "";
            txtIdModulo.Text = "";
            txtNombre.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Navegador_seg b = new Navegador_seg();
            b.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { txtDescripcion, txtNombre };
            cn.ingresar(textbox, table);
            string message = "Registro Guardado";
            Limpiar();
            MessageBox.Show(message);
            //actualizardatagriew();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { txtBuscar, txtDescripcion, txtIdModulo, txtNombre };
            int valor1 = int.Parse(txtBuscar.Text);
            string campo = "idModulo = ";
            //string num = txtBusqueda.Tag.ToString();
            cn.buscar(textbox, table, valor1, campo);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { txtBuscar, txtDescripcion, txtNombre };
            int valor1 = int.Parse(txtBuscar.Text);
            string campo = "idModulo = ";
            cn.actualizar(textbox, table, campo, valor1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int campo = int.Parse(txtBuscar.Text);
                string condicion = "idModulo = ";
                cn.eliminar(table, condicion, campo);
                //this.Close();
            }
            else
            {
                Limpiar();
                //this.Close();
            }
        }
    }
}
