using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class FrmClientes : Form
    {
        private DataSet dataSet = new DataSet();
        private string connectionString =("Data Source=localhost\\SQLEXPRESS;Initial Catalog=MGsoft;Integrated Security=True");
        
        public FrmClientes()
        {
            InitializeComponent();

            MostrarFechaActual();
           
            //dgClientes.CellEndEdit += dgClientes_CellEndEdit;
        }

        int idTrabajo = 1; 
        Cliente c = new Cliente();

        public void deshabilita()
        {
            // deshabilitando textboxs
             //txtidCliente.Enabled = false;
            txtnomCliente.Enabled = false;
            txtDomicilio.Enabled = false;
            txtTelefono.Enabled = false;
            
            // limpiando los textboxs
            txtidCliente.Clear();
            txtnomCliente.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();
            
            // deshabilitando los botones
            btnActualizar.Enabled = false;
            txtidCliente.Focus();
        }
        public void habilita()
        {
            txtidCliente.Enabled = true;
            txtnomCliente.Enabled = true;
            txtDomicilio.Enabled = true;
            txtTelefono.Enabled = true;
    
            btnActualizar.Enabled = true;
            txtidCliente.Focus();
        }

        public void llenarDgClientes()
        {
            dgClientes.DataSource = c.reporte();
        }

      

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenu fm = new FrmMenu();
            fm.Show();
            this.Hide();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mGsoftDataSet3.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter1.Fill(this.mGsoftDataSet3.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'mGsoftDataSet2.Trabajo' Puede moverla o quitarla según sea necesario.
            this.trabajoTableAdapter2.Fill(this.mGsoftDataSet2.Trabajo);
            // TODO: esta línea de código carga datos en la tabla 'mGsoftDataSet3.Clientes' Puede moverla o quitarla según sea necesario.
              //this.clientesTableAdapter1.Fill(this.mGsoftDataSet3.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'mGsoftDataSet2.Clientes' Puede moverla o quitarla según sea necesario.
               this.clientesTableAdapter.Fill(this.mGsoftDataSet2.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'mGsoftDataSet1.Trabajo' Puede moverla o quitarla según sea necesario.
              this.trabajoTableAdapter1.Fill(this.mGsoftDataSet1.Trabajo);
            // TODO: esta línea de código carga datos en la tabla 'mGsoftDataSet.Trabajo' Puede moverla o quitarla según sea necesario.
             this.trabajoTableAdapter.Fill(this.mGsoftDataSet.Trabajo);
            
            deshabilita();
            //LlenarDataGridView();
            MostrarFechaActual();
            llenarDgClientes();
        }

        private void txtidCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) this.Close();
            if (e.KeyChar == 13 && txtidCliente.Text != "") {

                string idBusqueda = txtidCliente.Text.Trim();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT nomCliente, Domicilio, Telefono, Fecha FROM Clientes WHERE idCliente = @idCliente";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@idCliente", idBusqueda);

             
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // Si se encontró el ID, llenar los campos
                            txtnomCliente.Text = reader["nomCliente"].ToString();
                            txtDomicilio.Text = reader["Domicilio"].ToString();
                            txtTelefono.Text = reader["Telefono"].ToString();
                            //lbArea.Text= reader["Areaaaaaaaaa"].ToString();
                            //lbEstadoTrabajo.Text = reader["Esatdooooooo"].ToString();
                            //txtTrabajo.Text = reader["Trabajo"].ToString();
                            
                        }
                }
                habilita();
                txtnomCliente.Focus();
            }
        }

        private void txtnomCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) 
            {
                txtidCliente.Clear();
                txtidCliente.Enabled = true;
                deshabilita();
                txtidCliente.Focus(); 
                
            }
            if (e.KeyChar == 13) txtDomicilio.Focus();
        }

        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) 
            {
                txtDomicilio.Clear();
                txtnomCliente.Clear();
                txtnomCliente.Enabled = true;
                txtnomCliente.Focus();
            }
            if (e.KeyChar == 13) txtTelefono.Focus();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) 
            {
                txtTelefono.Clear();
                txtDomicilio.Clear();
                txtDomicilio.Enabled = true;
                txtDomicilio.Focus(); 
            }

            if (e.KeyChar == 13) btnActualizar.Focus();
        }

        

        /*private void LlenarDataGridView()
        {
            // Crear un DataSet para almacenar los datos de las tablas
            DataSet dataSet = new DataSet();

            // Conexión y consultas SQL para obtener datos de las tablas
            string queryClientes = "SELECT idCliente, NomCliente, Domicilio, Telefono, Fecha FROM Clientes";
            string queryPedidos = "SELECT Trabajo, AreaTrabajo, EstadoTrabajo FROM Trabajo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear los adaptadores de datos para las consultas
                SqlDataAdapter adapterClientes = new SqlDataAdapter(queryClientes, connection);
                SqlDataAdapter adapterPedidos = new SqlDataAdapter(queryPedidos, connection);

                try
                {
                    // Abrir la conexión y llenar los DataTables del DataSet
                    connection.Open();
                    adapterClientes.Fill(dataSet, "Cliente");
                    adapterPedidos.Fill(dataSet, "Trabajo");
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error de conexión o consulta
                    MessageBox.Show("Error al llenar los DataTables: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                // Verificar si el DataSet y las tablas son nulos antes de asignar al DataGridView
                if (dataSet != null && dataSet.Tables["Clientes"] != null && dataSet.Tables["Trabajo"] != null)
                {
                    // Relacionar las tablas Clientes y Pedidos en el DataSet
                    DataRelation relation = new DataRelation("ClientesTrabajo",
                        dataSet.Tables["Clientes"].Columns["idCliente"],
                        dataSet.Tables["Trabajo"].Columns["idCliente"]);
                    dataSet.Relations.Add(relation);

                    // Asignar el DataSet como origen de datos del DataGridView
                    dgClientes.DataSource = dataSet;
                    dgClientes.DataMember = "Clientes";
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para mostrar.");
                }
            }
        }*/

       
        /*private void CargarDatos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Clientes values (IdCliente, nomCliente, Domicilio, Telefono, Fecha)"; // Tu consulta SQL para obtener los datos de MiTabla
               
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    connection.Close();

                    dgClientes.DataSource = dataTable; // Asignar el DataTable al DataSource del DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }*/

        /*public DataSet ObtenerDatos()
        {
            DataSet dataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Query para obtener los datos de la tabla Clientes
                string queryClientes = "SELECT * FROM Clientes";
                SqlDataAdapter adapterClientes = new SqlDataAdapter(queryClientes, connection);
                adapterClientes.Fill(dataSet, "Clientes");

                // Query para obtener los datos de la tabla Productos
                string queryProductos = "SELECT * FROM Trabajo values (Trabajo, AreaTrabajo, EstadoTrabajo)";
                SqlDataAdapter adapterProductos = new SqlDataAdapter(queryProductos, connection);
                adapterProductos.Fill(dataSet, "Trabajo");
            }

            return dataSet;
        }*/

        /*private void MostrarDatos()
        {
            DataSet dataSet = ObtenerDatos();

            // Puedes asignar directamente el DataSource del DataGridView a tu DataSet
            dgClientes.DataSource = dataSet.Tables["Trabajo"];
            // Y luego agregar otra tabla al DataSet
            dataSet.Tables.Add(dgClientes.DataSource as DataTable);

            // Ahora puedes mostrar ambas tablas en el DataGridView
            dgClientes.DataMember = "Trabajo";
            dgClientes.AutoGenerateColumns = true;

            // Agregar una columna para los productos
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Trabajo";
            comboBoxColumn.DataPropertyName = "TrabajoID"; // Esta debe ser la columna de relación entre Cliente y Producto
            comboBoxColumn.DataSource = dataSet.Tables["Productos"];
            comboBoxColumn.DisplayMember = "Nombre"; // Nombre del producto
            comboBoxColumn.ValueMember = "TrabajoID"; // ID del producto
            dgClientes.Columns.Add(comboBoxColumn);

            if (combinedTable != null);

        }*/

        private void MostrarFechaActual()
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        
        private bool modoEdicion = false;
        private int filaEditada = -1;

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //c.Fecha = c.Fecha2;
            c.idCliente = int.Parse(txtidCliente.Text);
            c.nomCliente = txtnomCliente.Text;
            c.Domicilio = txtDomicilio.Text;
            c.Telefono = txtTelefono.Text;
            c.Fecha = DateTime.Parse(lblFecha.Text);
            
            if (c.Guardar() == true)
            {
                llenarDgClientes();
                MessageBox.Show("Cliente Guardado con Éxito");
            }
            else
                MessageBox.Show("Error al guardar el Cliente");
            deshabilita();

            if (c.Actualizar() == true)
            {
                llenarDgClientes();
                MessageBox.Show("Cliente Editado con Éxito");
            }
            else
                MessageBox.Show("Error al Editar el Cliente");
            deshabilita();
     }

       

        /*private void dgClientes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Cuando se termina de editar una celda, actualizar el DataTable
            DataGridViewRow row = dgClientes.Rows[e.RowIndex];
            int rowIndex = combinedTable.Rows.IndexOf(((DataRowView)row.DataBoundItem).Row);

            // Actualizar el DataTable con los valores editados en el DataGridView
            combinedTable.Rows[rowIndex]["NomCliente"] = row.Cells["NomCliente"].Value;
            combinedTable.Rows[rowIndex]["Domicilio"] = row.Cells["Domicilio"].Value;
            combinedTable.Rows[rowIndex]["Telefono"] = row.Cells["Telefono"].Value;
            combinedTable.Rows[rowIndex]["Fecha"] = row.Cells["Fecha"].Value;
            combinedTable.Rows[rowIndex]["Trabajo"] = row.Cells["Trabajo"].Value;
            combinedTable.Rows[rowIndex]["AreaTrabajo"] = row.Cells["AreaTrabajo"].Value;
            combinedTable.Rows[rowIndex]["EstadoTrabajo"] = row.Cells["EstadoTrabajo"].Value;
            // Repetir para cada columna que desees actualizar
        }

        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cuando el usuario hace clic en una celda, marcamos la fila como editada
            if (modoEdicion)
            {
                filaEditada = e.RowIndex;
            }
        }

        private DataTable combinedTable;


        private void LlenarDataGridView()
        {
            // Eliminamos la declaración de DataSet dataSet = new DataSet();

            string query = "SELECT Clientes.idCliente, Clientes.NomCliente, Clientes.Domicilio, Clientes.Telefono, Clientes.Fecha, Trabajo.Trabajo, Trabajo.AreaTrabajo, Trabajo.EstadoTrabajo " +
                           "FROM Clientes " +
                           "INNER JOIN Trabajo ON Clientes.FKidTrabajo = Trabajo.idTrabajo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                try
                {
                    connection.Open();
                    adapter.Fill(dataSet, "ClientesTrabajo");

                    dgClientes.DataSource = dataSet.Tables["ClientesTrabajo"];

                    // Configurar el DataGridView
                    ConfigurarDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar el DataGridView: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }*/

        /*private void LlenarDataGridView()
        {
            DataSet dataSet = new DataSet();

            string queryClientes = "SELECT idCliente, NomCliente, Domicilio, Telefono, Fecha, FKidTrabajo FROM Clientes";
            string queryTrabajo = "SELECT idTrabajo, Trabajo, AreaTrabajo, EstadoTrabajo FROM Trabajo WHERE idTrabajo=idCliente"; // Asegúrate de incluir idTrabajo

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapterClientes = new SqlDataAdapter(queryClientes, connection);
                SqlDataAdapter adapterTrabajo = new SqlDataAdapter(queryTrabajo, connection);

                try
                {
                    connection.Open();
                    adapterClientes.Fill(dataSet, "Clientes");
                    adapterTrabajo.Fill(dataSet, "Trabajo");

                    Console.WriteLine("Filas en la tabla Clientes: " + dataSet.Tables["Clientes"].Rows.Count);
                    Console.WriteLine("Filas en la tabla Trabajo: " + dataSet.Tables["Trabajo"].Rows.Count);

                    foreach (DataTable table in dataSet.Tables)
                    {
                        Console.WriteLine("Tabla: " + table.TableName);
                        foreach (DataRow row in table.Rows)
                        {
                            foreach (DataColumn col in table.Columns)
                            {
                                Console.Write(row[col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar los DataTables: " + ex.Message);
                    return;
                }
                finally
                {
                    connection.Close();
                }

                if (dataSet.Tables.Count > 1 && dataSet.Tables["Clientes"] != null && dataSet.Tables["Trabajo"] != null)
                {
                    combinedTable = new DataTable(); // Inicializamos la DataTable a nivel de clase
                    combinedTable.Columns.Add("idCliente", typeof(int));
                    combinedTable.Columns.Add("NomCliente", typeof(string));
                    combinedTable.Columns.Add("Domicilio", typeof(string));
                    combinedTable.Columns.Add("Telefono", typeof(string));
                    combinedTable.Columns.Add("Fecha", typeof(DateTime));
                    combinedTable.Columns.Add("Trabajo", typeof(string));
                    combinedTable.Columns.Add("AreaTrabajo", typeof(string));
                    combinedTable.Columns.Add("EstadoTrabajo", typeof(string));
                   

                    foreach (DataRow clienteRow in dataSet.Tables["Clientes"].Rows)
                    {
                        int idCliente = (int)clienteRow["idCliente"];
                        string nomCliente = (string)clienteRow["NomCliente"];
                        string domicilio = (string)clienteRow["Domicilio"];
                        string telefono = (string)clienteRow["Telefono"];
                        DateTime fecha = (DateTime)clienteRow["Fecha"];

                        int fKTrabajo;
                        if (clienteRow["FKidTrabajo"] != DBNull.Value)
                        {
                            fKTrabajo = Convert.ToInt32(clienteRow["FKidTrabajo"]);
                        }
                        else
                        {
                            fKTrabajo = 0; // O algún otro valor predeterminado apropiado
                        }

                        DataRow[] trabajoRows = dataSet.Tables["Trabajo"].Select("idTrabajo = " + fKTrabajo);
                        foreach (DataRow trabajoRow in trabajoRows)
                        {
                            string trabajo = (string)trabajoRow["Trabajo"];
                            string areaTrabajo = (string)trabajoRow["AreaTrabajo"];
                            string estadoTrabajo = (string)trabajoRow["EstadoTrabajo"];

                            combinedTable.Rows.Add(idCliente, nomCliente, domicilio, telefono, fecha, trabajo, areaTrabajo, estadoTrabajo);
                        }
                    }

                    // Asignar la nueva DataTable como origen de datos del DataGridView
                    dgClientes.DataSource = combinedTable;

                    // Hacer el DataGridView editable
                    dgClientes.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para mostrar.");
                }
            }
        }*/

        /*private void ConfigurarDataGridView()
        {
            // Limpiar columnas existentes
            dgClientes.Columns.Clear();

            // Agregar las columnas que quieres mostrar en el DataGridView
            dgClientes.Columns.Add("idCliente", "ID Cliente");
            dgClientes.Columns.Add("NomCliente", "Nombre Cliente");
            dgClientes.Columns.Add("Domicilio", "Domicilio");
            dgClientes.Columns.Add("Telefono", "Teléfono");
            dgClientes.Columns.Add("Fecha", "Fecha");
            dgClientes.Columns.Add("Trabajo", "Trabajo");
            dgClientes.Columns.Add("AreaTrabajo", "Área de Trabajo");
            dgClientes.Columns.Add("EstadoTrabajo", "Estado de Trabajo");

            // Configurar DataPropertyName para las columnas existentes
            dgClientes.Columns["idCliente"].DataPropertyName = "idCliente";
            dgClientes.Columns["NomCliente"].DataPropertyName = "NomCliente";
            dgClientes.Columns["Domicilio"].DataPropertyName = "Domicilio";
            dgClientes.Columns["Telefono"].DataPropertyName = "Telefono";
            dgClientes.Columns["Fecha"].DataPropertyName = "Fecha";
            dgClientes.Columns["Trabajo"].DataPropertyName = "Trabajo";
            dgClientes.Columns["AreaTrabajo"].DataPropertyName = "AreaTrabajo";
            dgClientes.Columns["EstadoTrabajo"].DataPropertyName = "EstadoTrabajo";

            // Establecer el origen de datos
            dgClientes.DataSource = dataSet.Tables["ClientesTrabajo"];

            // Hacer el DataGridView editable
            dgClientes.ReadOnly = false;
        }*/

        /*private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgClientes.SelectedRows[0];
                int rowIndex = selectedRow.Index;

                if (rowIndex < combinedTable.Rows.Count)
                {
                    // Eliminar la fila del DataTable y del DataGridView
                    combinedTable.Rows[rowIndex].Delete();
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }*/

    }
   }


