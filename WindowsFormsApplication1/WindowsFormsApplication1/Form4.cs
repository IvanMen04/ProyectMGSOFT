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
    public partial class FrmEmpleado : Form
    {
        private string connectionString = ("Data Source=localhost\\SQLEXPRESS;Initial Catalog=MGsoft;Integrated Security=True");

        public FrmEmpleado()
        {
            InitializeComponent();
        }

         Empleado emp= new Empleado();

        public void deshabilita()
        {
            // deshabilitando textboxs
            //txtidEmpleado.Enabled = false;
            txtnomEmpleado.Enabled = false;
            txtDomicilioEmp.Enabled = false;
            txtTelefonoEmp.Enabled = false;
            txtCorreo.Enabled = false;
            lbArea.Enabled = false;
            txtEstadoEmpleado.Enabled = false;
            // limpiando los textboxs
            txtidEmpleado.Clear();
            txtnomEmpleado.Clear();
            txtDomicilioEmp.Clear();
            txtTelefonoEmp.Clear();
            txtCorreo.Clear();
            // deshabilitando los botones
            btnActualizar.Enabled = false;
            txtidEmpleado.Focus();
        }
        public void habilita()
        {
            txtidEmpleado.Enabled = true;
            txtnomEmpleado.Enabled = true;
            txtDomicilioEmp.Enabled = true;
            txtTelefonoEmp.Enabled = true;
            txtCorreo.Enabled = true;
            lbArea.Enabled = true;
            txtEstadoEmpleado.Enabled = true;
            btnActualizar.Enabled = true;
            txtidEmpleado.Focus();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenu fm = new FrmMenu();
            fm.Show();
            this.Hide();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mGsoftDataSet2.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.mGsoftDataSet2.Empleado);
            deshabilita();
        }

        private void txtidEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) this.Close();
            if (e.KeyChar == 13 && txtidEmpleado.Text != "")
            {
                string idBusqueda = txtidEmpleado.Text.Trim();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT nomEmpleado, Domicilio, Telefono, Correo, EstadoEmpleado FROM Empleado WHERE idEmpleado = @idEmpleado";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@idEmpleado", idBusqueda);


                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Si se encontró el ID, llenar los campos
                        txtnomEmpleado.Text = reader["nomEmpleado"].ToString();
                        txtDomicilioEmp.Text = reader["Domicilio"].ToString();
                        txtTelefonoEmp.Text = reader["Telefono"].ToString();
                        txtCorreo.Text = reader["Correo"].ToString();
                        txtEstadoEmpleado.Text = reader["EstadoEmpleado"].ToString();
                        //lbArea.Text= reader["Areaaaaaaaaa"].ToString();
                    }
                }
                habilita();
                txtnomEmpleado.Focus();
                habilita();
                txtnomEmpleado.Focus();
            }

        }

        private void txtnomEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) 
            {
                txtidEmpleado.Clear();
                txtidEmpleado.Enabled = true;
                deshabilita();
                txtidEmpleado.Focus();
            } 
            if (e.KeyChar == 13) txtDomicilioEmp.Focus();
        }

        private void txtDomicilioEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                txtDomicilioEmp.Clear();
                txtnomEmpleado.Clear();
                txtnomEmpleado.Enabled = true;
                txtnomEmpleado.Focus();
            }
            if (e.KeyChar == 13) txtTelefonoEmp.Focus();
        }

        private void txtTelefonoEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                txtTelefonoEmp.Clear();
                txtDomicilioEmp.Clear();
                txtDomicilioEmp.Enabled = true;
                txtDomicilioEmp.Focus();
            }
            if (e.KeyChar == 13) txtCorreo.Focus();
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                txtCorreo.Clear();
                txtTelefonoEmp.Clear();
                txtTelefonoEmp.Enabled = true;
                txtTelefonoEmp.Focus();
            }
            if (e.KeyChar == 13) txtEstadoEmpleado.Focus();
        }

        private void txtEstadoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                txtEstadoEmpleado.Clear();
                txtCorreo.Clear();
                txtCorreo.Enabled = true;
                txtCorreo.Focus();
            }
            if (e.KeyChar == 13) btnActualizar.Focus();
        }

        private void CargarDatos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Empleados values (idEmpleado, nomEmpleado, Domicilio, Telefono, Correo, EstadoEmpleado)"; // Tu consulta SQL para obtener los datos de MiTabla
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    connection.Close();

                    dgEmpleado.DataSource = dataTable; // Asignar el DataTable al DataSource del DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            emp.idEmpleado = int.Parse(txtidEmpleado.Text);
            emp.nomEmpleado = txtnomEmpleado.Text;
            emp.Domicilio = txtDomicilioEmp.Text;
            emp.Telefono = txtTelefonoEmp.Text;
            emp.Correo = txtCorreo.Text;
            emp.EstadoEmpleado = txtEstadoEmpleado.Text;
 
            

            if (emp.Guardar() == true)
            {
                MessageBox.Show("Empleado Guardado con Éxito");
            }
            else
                MessageBox.Show("Error al guardar el Empleado");
            deshabilita();

            if (emp.Actualizar() == true)
            {
                MessageBox.Show("Empleado Editado con Éxito");
            }
            else
                MessageBox.Show("Error al Editar el Empleado");
            deshabilita();
        }
    }
}