using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Net;

namespace WindowsFormsApplication1
{
    class Trabajo:Trabajo_2
    {
        private int idTr;
        private string trab;
        private string ArTr;
        private DateTime fch;
        private string EsTr;
        private string nomEmp;
        private string nomCl;
       

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




        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=MGsoft;Integrated Security=True";

        public override int idTrabajo { get { return this.idTr; } set { this.idTr = value; } }
        public override string trabajo { get { return this.trab; } set { this.trab = value; } }
        public override string AreaTrabajo { get { return this.ArTr; } set { this.ArTr = value; } }
        public override string EstadoTrabajo { get { return this.EsTr; } set { this.EsTr = value; } }
        public override DateTime Fecha { get { return this.fch; } set { this.fch = value; } }
        public override string Cliente { get { return this.nomCl; } set { this.nomCl = value; } }
        public override string Empleado { get { return this.nomEmp; } set { this.nomEmp = value; } }
       
        public override bool Guardar()
        {
            // Usar 'using' para asegurar que la conexión se cierre correctamente
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear un nuevo comando y asignar la conexión
                using (SqlCommand comando = connection.CreateCommand())
                {
                    try
                    {
                        // Abre la conexión
                        connection.Open();

                        // Configurar el comando como un stored procedure
                        comando.CommandText = "InsertarTrabajo";
                        comando.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetros para el stored procedure

                        comando.Parameters.AddWithValue("@idTr", this.idTr);
                        comando.Parameters.AddWithValue("@trab", this.trab);
                        comando.Parameters.AddWithValue("@ArTr", this.ArTr);
                        comando.Parameters.AddWithValue("@fch", this.fch);
                        comando.Parameters.AddWithValue("@EsTr", this.EsTr);
                        comando.Parameters.AddWithValue("@nomEmp", this.nomEmp);
                        comando.Parameters.AddWithValue("@nomCl", this.nomCl);
                        


                        // Ejecutar el comando y obtener el número de filas afectadas
                        int resultado = comando.ExecuteNonQuery();

                        // Si se insertó al menos una fila, devolver verdadero
                        if (resultado > 0)
                            return true;
                        else
                            return false;
                    }
                    catch (SqlException ex)
                    {
                        // Manejar cualquier excepción de SQL
                        Console.WriteLine("Error SQL: " + ex.Message);
                        return false;
                    }
                    finally
                    {
                        // Limpiar parámetros y cerrar la conexión
                        comando.Parameters.Clear();
                        connection.Close();
                    }
                }
            }
        }

        public override bool Actualizar()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = connection.CreateCommand())
                {
                    try
                    {

                        connection.Open();

                        // Configurar el comando como un UPDATE en lugar de INSERT
                        comando.CommandText = "UPDATE Trabajo SET trabajo = @trab, AreaTrabajo = @ArTr, Fecha=@fch, EstadoTrabajo = @EsTr, Cliente=@nomCl, Empleado=@nomEmp WHERE idTrabajo = @idTr";
                     
                        comando.Parameters.AddWithValue("@idTr", this.idTr);
                        comando.Parameters.AddWithValue("@trab", this.trab);
                        comando.Parameters.AddWithValue("@ArTr", this.ArTr);
                        comando.Parameters.AddWithValue("@fch", this.fch);
                        comando.Parameters.AddWithValue("@EsTr", this.EsTr);
                        comando.Parameters.AddWithValue("@nomCl", this.nomCl);
                        comando.Parameters.AddWithValue("@nomEmp", this.nomEmp);
                        // Ejecutar el comando y obtener el número de filas afectadas
                        int resultado = comando.ExecuteNonQuery();

                        // Si se actualizó al menos una fila, devolver verdadero
                        if (resultado > 0)
                            return true;
                        else
                            return false;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error SQL: " + ex.Message);
                        return false;
                    }
                    finally
                    {
                        comando.Parameters.Clear();
                        connection.Close();
                    }
                }
            }
        }

        public override DataTable reporte()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();

                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = connection;
                    comando.CommandText = "SELECT Trabajo.idTrabajo, Trabajo.trabajo, Trabajo.AreaTrabajo, Trabajo.Fecha, Trabajo.EstadoTrabajo, Trabajo.Cliente, Trabajo.Empleado " +
                                          "FROM Trabajo " /*+
                                          "INNER JOIN Clientes ON Trabajo.FKidCliente = Trabajo.idCliente"*/;

                    using (SqlDataAdapter da = new SqlDataAdapter(comando))
                    {
                        da.Fill(dt);
                    }
                }

                return dt;
            }
        }
    }
}
