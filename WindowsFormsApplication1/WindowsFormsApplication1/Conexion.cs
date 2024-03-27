using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Net;

namespace WindowsFormsApplication1
{
    public class Conexion
    {


        /*SqlCommand cmd;
         SqlConnection sqlCon;
        SqlDataAdapter da;
        DataTable dt;
         public void Open()
        {
            string localhost=Dns.GetHostName();

            sqlCon = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=MGsoft;Integrated Security=True");
            sqlCon.Open();
            
        } 
        public void Close()
        {
            sqlCon.Close();
        }*/

        public class CD_Conexion
        {
            string localhost = Dns.GetHostName();
            private SqlConnection Conexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=MGsoft;Integrated Security=True");
            public SqlConnection AbrirConexion()
            {
                if (Conexion.State == ConnectionState.Closed)
                    Conexion.Open();
                return Conexion;
            }
            public SqlConnection CerrarConexion()
            {
                if (Conexion.State == ConnectionState.Open)
                    Conexion.Close();
                return Conexion;
            }
        }
        
    }
}
