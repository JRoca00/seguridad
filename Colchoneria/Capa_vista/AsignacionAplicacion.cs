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
        string table = "tbl_permisosaplicacionesusuario";

        Controlador cn = new Controlador();

        public AsignacionAplicacion()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        public void checks()
        {
            if (chBoxGuardar.Checked) { txtGuardar.Text = "1"; } else { txtGuardar.Text = "0"; }
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
            txtCadenas.Text = "";
        }

        public void desabilitar()
        {
            txtBuscar.Visible = false;
            txtEliminar.Visible = false;
            txtGuardar.Visible = false;
            txtImprimir.Visible = false;
            txtModificar.Visible = false;
            txtIdAplicacion.Visible = false;
        }
        public void actualizardatagriew()
        {
            string cadena = txtIdUsuario.Text;
            DataTable dt = cn.SelectList("tbl_permisosaplicacionperfil", cadena);
            dataGridView1.DataSource = dt;
        }

        public void getIds()
        {
            try
            {
                string dato;
                dato = listAplicacionesDB.CurrentCell.Value.ToString();
                if (txtCadenas.Text == "")
                {
                    txtCadenas.Text = dato;
                }
                else
                {
                    string valor = txtCadenas.Text;
                    txtCadenas.Text = valor + "," + dato;
                }

            }
            catch (Exception ex)
            {

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            checks();
            char[] delimiterChars = { ',' };
            string text = txtCadenas.Text;
            string[] words = text.Split(delimiterChars);

            foreach (var word in words)
            {
                txtIdAplicacion.Text = word;
                TextBox[] textbox = { txtIdUsuario, txtIdAplicacion, txtGuardar, txtEliminar, txtModificar, txtBuscar, txtImprimir };
                cn.ingresar(textbox, table);
            }
            string message = "Registro Guardado";
            //limpiar();
            actualizardatagriew();
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


        private void AsignacionAplicacion_Load(object sender, EventArgs e)
        {
            cn.llenarListAplicaciones(listAplicacionesDB.Tag.ToString(), listAplicacionesDB);
            listAplicacionesDB.Visible = false;
            Size = new Size(672,466);
            desabilitar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            /*1062; 466*/
            if (listAplicacionesDB.Visible == false)
            {
                listAplicacionesDB.Visible = true;
                Size = new Size(1062, 466);
            }
            else
            {
                listAplicacionesDB.Visible = false;
                Size = new Size(672, 466);
            }
            
        }

        private void listAplicacionesDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getIds();
        }

    }
}
