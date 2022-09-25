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
    public partial class AsignacionAplicacionesPerfiles : Form
    {
        string table = "tbl_permisosaplicacionperfil";

        Controlador cn = new Controlador();

        public AsignacionAplicacionesPerfiles()
        {
            InitializeComponent();
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
            txtIdPerfil.Text = "";
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

        public void getId()
        {
            try
            {
                string dato;
                dato = ListaPerfil.CurrentCell.Value.ToString();
                txtIdPerfil.Text = dato;
            }
            catch (Exception ex)
            {

            }
        }

        public void actualizardatagriew()
        {
            string id = txtIdPerfil.Text;
            cn.llenarListApliUsuariosstring(listAplicacionPerfil.Tag.ToString(), listAplicacionPerfil, id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            checks();
            char[] delimiterChars = { ',' };
            string text = txtCadenas.Text;
            string[] words = text.Split(delimiterChars);

            foreach (var word in words)
            {
                txtIdAplicacion.Text = word;
                TextBox[] textbox = { txtIdPerfil, txtIdAplicacion, txtGuardar, txtEliminar, txtModificar, txtBuscar, txtImprimir };
                cn.ingresar(textbox, table);
            }
            string message = "Registro Guardado";
            actualizardatagriew();
            limpiar();
            MessageBox.Show(message);
            Size = new Size(623, 455);
        }

        private void AsignacionAplicacionesPerfiles_Load(object sender, EventArgs e)
        {
            cn.llenarListAplicaciones(listAplicacionesDB.Tag.ToString(), listAplicacionesDB);
            cn.llenarListPerfiles(ListaPerfil.Tag.ToString(), ListaPerfil);
            Size = new Size(623, 455);
            desabilitar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            chBoxGuardar.Checked = true;
            chBoxModificar.Checked = true;
            chBoxEliminar.Checked = true;
            chBoxBuscar.Checked = true;
            chBoxImprimir.Checked = true;
        }

        private void listAplicacionesDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getIds();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaPerfil.Visible = false;
            /*994; 455*/
            if (listAplicacionesDB.Visible == false)
            {
                listAplicacionesDB.Visible = true;
                Size = new Size(994, 455);
            }
            else
            {
                //623; 455
                listAplicacionesDB.Visible = false;
                Size = new Size(623, 455);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listAplicacionesDB.Visible = false;
            /*994; 455*/
            if (ListaPerfil.Visible == false)
            {
                ListaPerfil.Visible = true;
                Size = new Size(994, 455);
            }
            else
            {
                //623; 455
                ListaPerfil.Visible = false;
                Size = new Size(623, 455);
            }
        }

        private void ListaPerfil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getId();
        }

    }
}
