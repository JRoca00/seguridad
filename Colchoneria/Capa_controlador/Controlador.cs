﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Modelo;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;


namespace Capa_controlador
{
    public class Controlador
    {

        Sentencias sn = new Sentencias();

        public static string Username;

        public static string idUser;

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

        public void setBtitacora(string aplicacion, string accion)
        {
            string fechaActual = DateTime.Now.ToString("yyyy/MM/dd");
            string horaActual = DateTime.Now.ToString("HH:mm:ss");
            string nombreHost = System.Net.Dns.GetHostName().ToUpper();
            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addr = ipEntry.AddressList;
            string direccionIP = addr[1].ToString();
            string datos = "" + GetHash(idUser) + "," + aplicacion + ",'" + fechaActual + "','" + horaActual + "','" + nombreHost + "','" + direccionIP + "','" + accion + "'";
            sn.insertBitacora(datos);
        }

        public string getNombreAplicacion(string codigoApp)
        {
            return sn.queryNombreApp(codigoApp);
        }

        public Boolean getAccesoModulos(int moduloSolicitado)
        {
            string idUsuario = GetHash(idUser);
            Boolean respuestAcceso= false;
            int[] perfiles = sn.getPerfilesUsuario(idUsuario);
            for (int i = 0; i < perfiles.Length; i++)
            {
                if (perfiles[i] != 0 && perfiles[i] != null)
                {
                    int[] aplicaciones = sn.getPerfilAplicacion(perfiles[i]);
                    for (int j = 0; j < aplicaciones.Length; j++)
                    {
                        if (aplicaciones[j] != 0 && aplicaciones != null)
                        {
                            int idModulo = sn.getModuloAplicacion(aplicaciones[j]);
                            if (idModulo == 1000 && moduloSolicitado == 1000)
                            {
                                respuestAcceso = true;
                            }
                            if (idModulo == 2000 && moduloSolicitado == 2000)
                            {
                                respuestAcceso = true;
                            }
                            if (idModulo == 3000 && moduloSolicitado == 3000)
                            {
                                respuestAcceso = true;
                            }
                            if (idModulo == 4000 && moduloSolicitado == 4000)
                            {
                                respuestAcceso = true;
                            }
                            if (idModulo == 5000 && moduloSolicitado == 5000)
                            {
                                respuestAcceso = true;
                            }
                            if (idModulo == 6000 && moduloSolicitado == 6000)
                            {
                                respuestAcceso = true;
                            }
                            if (idModulo == 7000 && moduloSolicitado == 7000)
                            {
                                respuestAcceso = true;
                            }
                            if (idModulo == 8000 && moduloSolicitado == 8000)
                            {
                                respuestAcceso = true;
                            }
                        }
                    }
                }
            }


            return respuestAcceso;
        }

        public int[] getPermisosAplicaion(string App)
        {
            int[] result = new int[5];
            int[] permisos = new int[5];
            string idUsuario = GetHash(idUser);
            int[] perfiles = sn.getPerfilesUsuario(idUsuario);
            for (int i = 0; i < perfiles.Length; i++)
            {
                if (perfiles[i] != 0 && perfiles[i] != null)
                {
                    result = sn.getPermisos(perfiles[i], int.Parse(App));
                    if (result[0] == 1)
                    {
                        permisos[0] = result[0];
                        Console.WriteLine("Guardar");
                    }
                    if (result[1] == 1)
                    {
                        permisos[1] = result[1];
                        Console.WriteLine("Modificar");
                    }
                    if (result[2] == 1)
                    {
                        permisos[2] = result[2];
                        Console.WriteLine("Eliminar");
                    }
                    if (result[3] == 1)
                    {
                        permisos[3] = result[3];
                        Console.WriteLine("Buscar");
                    }
                    if (result[4] == 1)
                    {
                        permisos[4] = result[4];
                        Console.WriteLine("Imprimir");
                    }
                }
            }
            return permisos;
        }

        public Boolean validarLogin(string username, string password)
        {
            string[] datos = sn.queryLogin(username);
            for (int i = 0; i < datos.Length; i = i + 3)
            {
                if (datos[i + 1] == username)
                {
                    if (datos[i + 2] == password)
                    {
                        idUser = SetHash(datos[i]);
                        return true;
                    }
                }
            }
            return false;
        }

        public Boolean validarRecuperacion(string username, string respuesta)
        {
            string[] datos = sn.queryRecuperacion(username);
            for (int i = 0; i < datos.Length; i = i + 3)
            {
                if (datos[i + 1] == username)
                {
                    if (datos[i + 2] == respuesta)
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
            OdbcDataAdapter dt = sn.buscarlogin(tabla, dato1, dato2);
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

        public void actualizarcontra(TextBox[] textbox, string tabla, string campo, int num)
        {
            string dato = " ";

            string condicion = campo;


            dato += "set  " + textbox[0].Tag.ToString() + " = '" + textbox[0].Text + "' ";



            sn.actualizarcontra(dato, condicion, tabla, num);
            MessageBox.Show("Dato actualizado");
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

        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        


        public void eliminar(string tabla, string condicion,int campo)
        {
            sn.eliminar(tabla,condicion,campo);
            //MessageBox.Show("Regristro Eliminado");
        }

        public void llenartablaa(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.llenartabla(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public DataTable SelectList(string tabla,string campo)
        {
            OdbcDataAdapter dt = sn.selectList(tabla, campo);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void llenarListAplicaciones(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.llenarListaAplicaciones(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }


    }
}
