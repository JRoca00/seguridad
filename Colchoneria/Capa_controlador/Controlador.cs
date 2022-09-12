using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Modelo;
using System.Windows.Forms;

namespace Capa_controlador
{
    public class Controlador
    {

        Sentencias sn = new Sentencias();


        public DataTable buscarlogin(string tabla, string dato1, string dato2)
        {
            OdbcDataAdapter dt = sn.buscarlogin(tabla,dato1,dato2);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void ingresar(TextBox[] textbox, string tabla)//Crea cadenas de datos para la insercion
        {
            string dato = " ";
            string tipo = " ";

            for (int x = 0; x < textbox.Length; x++)
            {

                if (x == textbox.Length - 1)
                {
                    dato += "'" + textbox[x].Text + "'";
                    tipo += textbox[x].Tag.ToString();
                }
                else
                {
                    dato += "'" + textbox[x].Text + "',";
                    tipo += textbox[x].Tag.ToString() + ",";
                }

            }
            sn.insertar(dato, tipo, tabla);
        }

        public void buscar(TextBox[] textbox, string tabla,int num,string condicion)
        {
            //string message = "Registro de text Nombre " + tabla + " id " +  num + " ";
            //MessageBox.Show(message);
            string campo = condicion;
            sn.busqueda(textbox,tabla, num, campo);
        }

        public void actualizar(TextBox[] textbox, string tabla,string campo, int num)
        {
            string dato = " ";
            //string condicion = "(" + textbox[0].Tag.ToString() + " = '" + textbox[0].Text + "')";
            string condicion = campo;

            for (int x = 1; x < textbox.Length; x++)
            {

                if (x == textbox.Length - 1)
                {
                    dato += " " + textbox[x].Tag.ToString() + " = '" + textbox[x].Text + "' ";

                }
                else if (x == 1)
                {
                    dato += "SET " + textbox[x].Tag.ToString() + " = '" + textbox[x].Text + "', ";

                }
                else
                {
                    dato += " " + textbox[x].Tag.ToString() + " = '" + textbox[x].Text + "', ";

                }

            }

            sn.actualizar(dato, condicion, tabla,num);
            MessageBox.Show("Dato actualizado");
        }


        public void eliminar(string tabla, string condicion,int campo)
        {
            sn.eliminar(tabla,condicion,campo);
            //MessageBox.Show("Regristro Eliminado");
        }



    }
}
