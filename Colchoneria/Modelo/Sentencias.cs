using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class Sentencias
    {
        Conexion con = new Conexion();



        public OdbcDataAdapter buscarlogin(string tabla, string dato1, string dato2)
        {
            
            string sql = "SELECT usuario, contra FROM " + tabla + " where usuario='" +dato1+ "' and contra='" +dato2+"';" ;
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }





    }
}
