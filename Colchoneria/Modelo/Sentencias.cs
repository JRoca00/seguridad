﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo
{
    public class Sentencias
    {
        Conexion con = new Conexion();

        public string[] queryLogin(string user)
        {

            string[] Campos = new string[300];
            string[] auto = new string[300];
            int i = 0;
            string sql = "SELECT pk_id_usuario, username_usuario, password_usuario FROM Usuarios where username_usuario='" + user + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString();
                    Campos[(i + 1)] = reader.GetValue(1).ToString();
                    Campos[(i + 2)] = reader.GetValue(2).ToString();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en query hacia la tabla de usuarios"); }
            return Campos;
        }


        public OdbcDataAdapter buscarlogin(string tabla, string dato1, string dato2)
        {
            
            string sql = "SELECT usuario, contra FROM " + tabla + " where usuario='" +dato1+ "' and contra='" +dato2+"';" ;
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public void insertar(string dato, string tipo, string tabla)
        {
            string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            cmd.ExecuteNonQuery();
        }

        public void busqueda(TextBox[] textbox, string tabla,int num, string condicion)
        {
            string sql = "Select *from " + tabla + " where "+ condicion +" " + num+ ";" ;
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            cmd.ExecuteNonQuery();

            OdbcDataReader leer = cmd.ExecuteReader();
            if (leer.Read()  == true)
            {
                //MessageBox.Show("Ingreso");
                //
                /*string dato1 = leer[txtCamps[0].ToString()].ToString();
                string dato2 = leer[txtCamps[1].ToString()].ToString();
                string dato3 = leer[txtCamps[2].ToString()].ToString();
                string dato4 = leer[txtCamps[3].ToString()].ToString();*/
                MessageBox.Show("Encontrado ");
            }
            else
            {
                MessageBox.Show("No encontrado");
            }
        }

        public void actualizar(string dato, string condicion, string tabla,int num)
        {

            string sql = "Update " + tabla + " " + dato + " where " + condicion + " " + num+ "; ";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            cmd.ExecuteNonQuery();

        }


        public void eliminar(string tabla,string condicion,int campo)
        {
            string sql = "delete from " + tabla + " where " + condicion + " " + campo + " ;";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            cmd.ExecuteNonQuery();
        }

        public OdbcDataAdapter llenartabla(string tabla)
        {
            string sql = "select * from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

    }
}
