using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Net;

namespace WindowsFormsApplication1
{
    public class Cliente:Conexion
    {
        public int idCliente { get; set; }
        public string nomCliente { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha { get; set; }
        public int FKidTrabajo { get; set; }


        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Insertar(int idCliente, string nomCliente, string Domicilio, string Telefono, DateTime Fecha, string FKidTrabajo, string Trabajo, string AreaTrabajo, string EstadoTrabajo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarProductos";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@nomCliente", nomCliente);
            comando.Parameters.AddWithValue("@Domicilio", Domicilio);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@Fecha", Fecha);
            comando.Parameters.AddWithValue("@FKidTrabajo", FKidTrabajo);
            comando.Parameters.AddWithValue("@Trabajo", Trabajo);
            comando.Parameters.AddWithValue("@AreaTrabajo", AreaTrabajo);
            comando.Parameters.AddWithValue("@EstadoTrabajo", EstadoTrabajo);
            comando.CommandText = "Insert Into Clientes Values (@idCliente,@nomCliente,@Domicilio,@Telefono,@Fecha)";
            // crear variable resultado
            int resultado;
            // ejecutar la orden o comando
            resultado = comando.ExecuteNonQuery();        
            
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
