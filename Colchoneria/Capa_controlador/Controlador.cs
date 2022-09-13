using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Modelo;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Capa_controlador
{
    public class Controlador
    {

        Sentencias sn = new Sentencias();

        public static string Username { get; set; }
        public static string idUser { get; set; }

        public static string SetHash(string inputString)
        {
            string hash = "x2";
            byte[] bytes = UTF8Encoding.UTF8.GetBytes(inputString);
            MD5 mD5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();
            tripleDES.Key = mD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripleDES.Mode = CipherMode.ECB;
            ICryptoTransform transform = tripleDES.CreateEncryptor();
            byte[] output = transform.TransformFinalBlock(bytes, 0, bytes.Length);
            return Convert.ToBase64String(output);
        }
        public static string GetHash(string inputString)
        {
            string hash = "x2";
            byte[] bytes = Convert.FromBase64String(inputString);
            MD5 mD5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();
            tripleDES.Key = mD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripleDES.Mode = CipherMode.ECB;
            ICryptoTransform transform = tripleDES.CreateDecryptor();
            byte[] output = transform.TransformFinalBlock(bytes, 0, bytes.Length);
            return UTF8Encoding.UTF8.GetString(output);
        }


        public Boolean validarLogin(string username, string password)
        {
            string[] datos = sn.queryLogin(username);
            for (int i = 0; i < datos.Length; i=i+3)
            {
                if (datos[i+1] == username)
                {
                    if(datos[i+2] == password)
                    {
                        idUser = SetHash(datos[i]);
                        return true;
                    }
                }
            }
            return false;
        }
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
