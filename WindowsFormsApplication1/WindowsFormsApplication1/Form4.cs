using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }
        public void deshabilita()
        {
            // deshabilitando textboxs
            //txtidEmpleado.Enabled = false;
            txtnomEmpleado.Enabled = false;
            txtDomicilioEmp.Enabled = false;
            txtTelefonoEmp.Enabled = false;
            txtCorreo.Enabled = false;
            lbArea.Enabled = false;
            lbEstadoEmpleado.Enabled = false;
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
            lbEstadoEmpleado.Enabled = true;
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
            deshabilita();
        }

        private void txtidEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) this.Close();
            if (e.KeyChar == 13 && txtidEmpleado.Text != "")
            {
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
            if (e.KeyChar == 13) lbArea.Focus();
        }

    }
}