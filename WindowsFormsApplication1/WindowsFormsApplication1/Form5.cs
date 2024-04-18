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
    public partial class FrmTrabajo : Form
    {
        private string connectionString = ("Data Source=localhost\\SQLEXPRESS;Initial Catalog=MGsoft;Integrated Security=True");
        public FrmTrabajo()
        {
            InitializeComponent();
            MostrarFechaActual();
        }

        Trabajo t = new Trabajo();

        public void deshabilita()
        {
            // deshabilitando textboxs
            //txtidTrabajo.Enabled = false;
            txtTrabajo.Enabled = false;
            cbAreaTrabajo.Enabled = false;
            cbEstadoTrabajo.Enabled = false;
            cbEmpleado.Enabled = false;
            cbxCliente.Enabled = false;
            // limpiando los textboxs
            txtidTrabajo.Clear();
            txtTrabajo.Clear();
            // deshabilitando los botones
            btnActualizar.Enabled = false;
            txtidTrabajo.Focus();
        }
        public void habilita()
        {
            txtidTrabajo.Enabled = true;
            txtTrabajo.Enabled = true;
            cbAreaTrabajo.Enabled = true;
            cbEstadoTrabajo.Enabled = true;
            cbEmpleado.Enabled = true;
            cbxCliente.Enabled = true;
            btnActualizar.Enabled = true;
            txtidTrabajo.Focus();
        }

        public void llenardgTrabajo()
        {
            dgtrabajo.DataSource = t.reporte();
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenu fm = new FrmMenu();
            fm.Show();
            this.Hide();
        }

        private void FrmTrabajo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mGsoftDataSet2.TrabajoEmpleado' Puede moverla o quitarla según sea necesario.
            this.trabajoEmpleadoTableAdapter.Fill(this.mGsoftDataSet2.TrabajoEmpleado);
            // TODO: esta línea de código carga datos en la tabla 'mGsoftDataSet2.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.mGsoftDataSet2.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'mGsoftDataSet2.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.mGsoftDataSet2.Empleado);
            deshabilita();
            MostrarFechaActual();
            llenardgTrabajo();
        }

        private void txtidTrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) this.Close();
            if (e.KeyChar == 13 && txtidTrabajo.Text != "")
            {
                habilita();
                txtTrabajo.Focus();
            }
        }

        private void txtTrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                txtidTrabajo.Clear();
                txtidTrabajo.Enabled = true;
                deshabilita();
                txtidTrabajo.Focus();
            }
            if (e.KeyChar == 13) cbAreaTrabajo.Focus();
        }

        private void MostrarFechaActual()
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            t.idTrabajo = int.Parse(txtidTrabajo.Text);
            t.trabajo = txtTrabajo.Text;
            t.AreaTrabajo = cbAreaTrabajo.Text;
            t.Fecha = DateTime.Parse(lblFecha.Text);
            t.EstadoTrabajo = cbEstadoTrabajo.Text;
            t.Empleado = cbEmpleado.Text;
            t.Cliente = cbxCliente.Text;
            

            if (t.Guardar() == true)
            {
                llenardgTrabajo();
                MessageBox.Show("Cliente Guardado con Éxito");
            }
            else
                MessageBox.Show("Error al guardar el Cliente");
            deshabilita();

            if (t.Actualizar() == true)
            {
                llenardgTrabajo();
                MessageBox.Show("Cliente Editado con Éxito");
            }
            else
                MessageBox.Show("Error al Editar el Cliente");
            deshabilita();

        }
    }
}
