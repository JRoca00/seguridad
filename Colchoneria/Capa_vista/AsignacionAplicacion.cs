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
    public partial class AsignacionAplicacion : Form
    {
        string table = "PermisosAplicacionesUsuario";

        Controlador cn = new Controlador();

        public AsignacionAplicacion()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Navegador_seg b = new Navegador_seg();
            b.Show();
            this.Hide();
        }

        public void checks()
        {
            if (chBoxGuardar.Checked){txtGuardar.Text = "1";}else{txtGuardar.Text = "0";}
            if (chBoxEliminar.Checked) { txtEliminar.Text = "1"; } else { txtEliminar.Text = "0"; }
            if (chBoxModificar.Checked) { txtModificar.Text = "1"; } else { txtModificar.Text = "0"; }
            if (chBoxBuscar.Checked) { txtBuscar.Text = "1"; } else { txtBuscar.Text = "0"; }
            if (chBoxImprimir.Checked) { txtImprimir.Text = "1"; } else { txtImprimir.Text = "0"; }
        }

        public void limpiar()
        {
            chBoxGuardar.Checked = false;
            chBoxModificar.Checked = false;
            chBoxEliminar.Checked = false;
            chBoxBuscar.Checked = false;
            chBoxImprimir.Checked = false;
            txtBuscar.Text = "";
            txtEliminar.Text = "";
            txtGuardar.Text = "";
            txtIdAplicacion.Text = "";
            txtIdUsuario.Text = "";
            txtImprimir.Text = "";
            txtModificar.Text = "";
        }

        public void desabilitar()
        {
            txtBuscar.Visible = false;
            txtEliminar.Visible = false;
            txtGuardar.Visible = false;
            txtImprimir.Visible = false;
            txtModificar.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checks();
            TextBox[] textbox = { txtIdUsuario,txtIdAplicacion,txtGuardar,txtEliminar,txtModificar,txtBuscar,txtImprimir };
            cn.ingresar(textbox, table);
            string message = "Registro Guardado";
            limpiar();
            MessageBox.Show(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chBoxGuardar.Checked = true;
            chBoxModificar.Checked = true;
            chBoxEliminar.Checked = true;
            chBoxBuscar.Checked = true;
            chBoxImprimir.Checked = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AsignacionAplicacion_Load(object sender, EventArgs e)
        {
            cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);
            desabilitar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
