using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Modelo;

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




    }
}
