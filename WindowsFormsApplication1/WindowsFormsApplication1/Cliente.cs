using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Net;

namespace WindowsFormsApplication1
{
    class Cliente:cliente2

    {
        private int idc;
        private string nc; 
        private string dmc;
        private string tel; 
        private DateTime fch;
        
        /*private int fkid;
        private string trab;
        private string ArTrab;
        private string EsTr;
        private int idTr;
        private DateTime fch2;*/

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
       

        /*public void insertar(int idCliente, string nomCliente, string Domicilio, string Telefono, DateTime Fecha, string FKidTrabajo, string Trabajo, string AreaTrabajo, string EstadoTrabajo)
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
        }*/
        
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=MGsoft;Integrated Security=True";

       
        public override int idCliente { get { return this.idc; } set { this.idc = value; } }
        public override string nomCliente { get { return this.nc; } set { this.nc = value; } }
        public override string Domicilio { get { return this.dmc; } set { this.dmc = value; } }
        public override string Telefono { get { return this.tel; } set { this.tel = value; } }
        public  override DateTime Fecha { get { return this.fch; } set { this.fch = value; } }
        
        /*public override int FKidTrabajo { get { return this.fkid; } set { this.fkid = value; } }


        public override string Trabajo { get { return this.trab; } set { this.trab = value; } }
        public override string AreaTrabajo { get { return this.ArTrab; } set { this.ArTrab = value; } }
        public override string EstadoTrabajo { get { return this.EsTr; } set { this.EsTr = value; } }
        public override DateTime Fecha2 { get { return this.fch2; } set { this.fch2 = value; } }
        public override int idTrabajo { get { return this.idTr; } set { this.idTr = value; } }*/

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
                        comando.CommandText = "InsetarProductos";
                        comando.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetros para el stored procedure
                        comando.Parameters.AddWithValue("@idc", this.idc);
                        comando.Parameters.AddWithValue("@nc", this.nc);
                        comando.Parameters.AddWithValue("@dmc", this.dmc);
                        comando.Parameters.AddWithValue("@tel", this.tel);
                        comando.Parameters.AddWithValue("@fch", this.fch);
                        //comando.Parameters.AddWithValue("@fkid", this.fkid);

                        //comando.Parameters.AddWithValue("@fch2", this.fch2);
                        //comando.Parameters.AddWithValue("@trab", this.trab);
                        //comando.Parameters.AddWithValue("@ArTrab", this.ArTrab);
                        //comando.Parameters.AddWithValue("@EsTr", this.EsTr);
                       // comando.Parameters.AddWithValue("@idTr", this.idTr);


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
                        comando.CommandText = "UPDATE Clientes SET nomCliente = @nc, Domicilio = @dmc, Telefono = @tel, Fecha=@fch WHERE idCliente = @idc";
                        comando.Parameters.AddWithValue("@idc", this.idc);
                        comando.Parameters.AddWithValue("@nc", this.nc);
                        comando.Parameters.AddWithValue("@dmc", this.dmc);
                        comando.Parameters.AddWithValue("@tel", this.tel);
                        comando.Parameters.AddWithValue("@fch", this.fch);

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
                    comando.CommandText = "SELECT Clientes.idCliente, Clientes.NomCliente, Clientes.Domicilio, Clientes.Telefono, Clientes.Fecha FROM Clientes";

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
