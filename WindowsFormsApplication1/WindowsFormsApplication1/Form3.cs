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
        public FrmClientes()
        {
            InitializeComponent();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            c.idCliente = int.Parse(txtidCliente.Text);
            c.nomCliente = txtnomCliente.Text;
            c.Domicilio = txtDomicilio.Text;
            c.Telefono = txtDomicilio.Text;
            if (c.Insertar() == true)
            {
                MessageBox.Show("Cliente Guardado con Éxito");
            }
            else
                MessageBox.Show("Error al guardar el Cliente");
            deshabilita();
            
        }
    }
}
