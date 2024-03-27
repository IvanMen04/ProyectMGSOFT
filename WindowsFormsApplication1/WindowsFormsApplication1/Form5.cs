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
    public partial class FrmTrabajo : Form
    {
        public FrmTrabajo()
        {
            InitializeComponent();
        }
        public void deshabilita()
        {
            // deshabilitando textboxs
            //txtidTrabajo.Enabled = false;
            txtTrabajo.Enabled = false;
            lbAreaTrabajo.Enabled = false;
            lbEstadoTrabajo.Enabled = false;
            lbEmpleado.Enabled = false;
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
            lbAreaTrabajo.Enabled = true;
            lbEstadoTrabajo.Enabled = true;
            lbEmpleado.Enabled = true;
            btnActualizar.Enabled = true;
            txtidTrabajo.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenu fm = new FrmMenu();
            fm.Show();
            this.Hide();
        }

        private void FrmTrabajo_Load(object sender, EventArgs e)
        {
            deshabilita();
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
            if (e.KeyChar == 13) lbAreaTrabajo.Focus();
        }
    }
}
