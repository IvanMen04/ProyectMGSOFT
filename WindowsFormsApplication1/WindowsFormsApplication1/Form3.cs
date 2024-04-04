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
        private string connectionString =("Data Source=localhost\\SQLEXPRESS;Initial Catalog=MGsoft;Integrated Security=True");
        
        public FrmClientes()
        {
            InitializeComponent();

            MostrarFechaActual();

        }
       
        Cliente c = new Cliente();

        public void deshabilita()
        {
            // deshabilitando textboxs
             //txtidCliente.Enabled = false;
            txtnomCliente.Enabled = false;
            txtDomicilio.Enabled = false;
            txtTelefono.Enabled = false;
            
            txtTrabajo.Enabled = false;
            lbArea.Enabled = false;
            lbEstadoTrabajo.Enabled = false;
            // limpiando los textboxs
            txtidCliente.Clear();
            txtnomCliente.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();
            
            txtTrabajo.Clear();
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
        
            txtTrabajo.Enabled = true;
            lbArea.Enabled = true;
            lbEstadoTrabajo.Enabled = true;
            btnActualizar.Enabled = true;
            txtidCliente.Focus();
        }

        /*public void llenarDgClientes()
        {
            dgClientes.DataSource = c.reporte();
        }*/

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenu fm = new FrmMenu();
            fm.Show();
            this.Hide();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mGsoftDataSet2.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.mGsoftDataSet2.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'mGsoftDataSet1.Trabajo' Puede moverla o quitarla según sea necesario.
            this.trabajoTableAdapter1.Fill(this.mGsoftDataSet1.Trabajo);
            // TODO: esta línea de código carga datos en la tabla 'mGsoftDataSet.Trabajo' Puede moverla o quitarla según sea necesario.
            this.trabajoTableAdapter.Fill(this.mGsoftDataSet.Trabajo);
            deshabilita();
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

            if (e.KeyChar == 13) txtTrabajo.Focus();
        }

        private void txtTrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) 
            {
                txtTrabajo.Clear();
                txtTelefono.Clear();
                txtTelefono.Enabled = true;
                txtTelefono.Focus();
            }
            if (e.KeyChar == 13) lbArea.Focus();
        }

        private void CargarDatos()
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
        }

        private void MostrarFechaActual()
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            c.idCliente = int.Parse(txtidCliente.Text);
            c.nomCliente = txtnomCliente.Text;
            c.Domicilio = txtDomicilio.Text;
            c.Telefono = txtTelefono.Text;
            c.Fecha = DateTime.Parse(lblFecha.Text);

            if (c.Guardar() == true)
            {
                MessageBox.Show("Cliente Guardado con Éxito");
            }
            else
                MessageBox.Show("Error al guardar el Cliente");
            deshabilita();

            if (c.Actualizar() == true)
            {
                MessageBox.Show("Cliente Editado con Éxito");
            }
            else
                MessageBox.Show("Error al Editar el Cliente");
            deshabilita();
        }

    }
}
