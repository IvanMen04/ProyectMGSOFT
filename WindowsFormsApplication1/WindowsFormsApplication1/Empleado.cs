using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Net;

namespace WindowsFormsApplication1
{
    class Empleado:Emplea2
    {
        private int idem;
        private string ne; 
        private string dmc;
        private string tel; 
        private string cor;
        private string Esem;
        //private string lbarea; 


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

       
        public override int idEmpleado { get { return this.idem; } set { this.idem = value; } }
        public override string nomEmpleado { get { return this.ne; } set { this.ne = value; } }
        public override string Domicilio { get { return this.dmc; } set { this.dmc = value; } }
        public override string Telefono { get { return this.tel; } set { this.tel = value; } }
        public override string Correo { get { return this.cor; } set { this.cor = value; } }
        public override string EstadoEmpleado { get { return this.Esem; } set { this.Esem = value; } }
       // public override string  lbarea { get { return this.lba; } set { this.lba = value; } }

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
                        comando.CommandText = "InsertarEmpleados";
                        comando.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetros para el stored procedure
                        comando.Parameters.AddWithValue("@idem", this.idem);
                        comando.Parameters.AddWithValue("@ne", this.ne);
                        comando.Parameters.AddWithValue("@dmc", this.dmc);
                        comando.Parameters.AddWithValue("@tel", this.tel);
                        comando.Parameters.AddWithValue("@cor", this.cor);
                        comando.Parameters.AddWithValue("@Esem", this.Esem);
                        //comando.Parameters.AddWithValue("@lba", this.lba);


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
                        comando.CommandText = "UPDATE Empleado SET nomEmpleado = @ne, Domicilio = @dmc, Telefono = @tel, Correo = @cor, EstadoEmpleado = @Esem WHERE idEmpleado = @idem";
                        comando.Parameters.AddWithValue("@idem", this.idem);
                        comando.Parameters.AddWithValue("@ne", this.ne);
                        comando.Parameters.AddWithValue("@dmc", this.dmc);
                        comando.Parameters.AddWithValue("@tel", this.tel);
                        comando.Parameters.AddWithValue("@cor", this.cor);
                        comando.Parameters.AddWithValue("@Esem", this.Esem);
                        //comando.Parameters.AddWithValue("@lba", this.lba);

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
    }
}
