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

        private void AsignacionModuloAplicacion_Load(object sender, EventArgs e)
        {
            cn.llenarListAplicaciones(listAplicacionesDB.Tag.ToString(), listAplicacionesDB);
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
            limpiar();
            MessageBox.Show(message);
            //593; 379
            Size = new Size(593, 379);
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
    }
}
