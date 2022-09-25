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
    public partial class AsignacionModuloAplicacion : Form
    {
        Controlador cn = new Controlador();
        string table = "tbl_asignacionmoduloaplicacion";
        public AsignacionModuloAplicacion()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtCadenas.Text = "";
            txtIdAplicacion.Text = "";
            txtIdPerfil.Text = "";
        }

        public void ocultar()
        {
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
                dato = ListModulo.CurrentCell.Value.ToString();
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

        private void AsignacionModuloAplicacion_Load(object sender, EventArgs e)
        {
            cn.llenarListAplicaciones(listAplicacionesDB.Tag.ToString(), listAplicacionesDB);
            cn.llenarListModulo(ListModulo.Tag.ToString(), ListModulo);
            Size = new Size(593, 379);
            ocultar();
        }

        private void listAplicacionesDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getIds();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = { ',' };
            string text = txtCadenas.Text;
            string[] words = text.Split(delimiterChars);

            foreach (var word in words)
            {
                txtIdAplicacion.Text = word;
                TextBox[] textbox = { txtIdPerfil, txtIdAplicacion };
                cn.ingresar(textbox, table);
            }
            string message = "Registro Guardado";
            actualizardatagriew();
            limpiar();
            MessageBox.Show(message);
            //593; 379
            Size = new Size(593, 379);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListModulo.Visible = false;
            /*958; 379*/
            if (listAplicacionesDB.Visible == false)
            {
                listAplicacionesDB.Visible = true;
                Size = new Size(958, 379);
            }
            else
            {
                //623; 455
                listAplicacionesDB.Visible = false;
                Size = new Size(593, 379);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listAplicacionesDB.Visible = false;
            /*958; 379*/
            if (ListModulo.Visible == false)
            {
                ListModulo.Visible = true;
                Size = new Size(958, 379);
            }
            else
            {
                //623; 455
                ListModulo.Visible = false;
                Size = new Size(593, 379);
            }
        }

        private void ListModulo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getId();
        }
    }
}
