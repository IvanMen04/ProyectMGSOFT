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
    public partial class FrmBitacora : Form
    {
        public FrmBitacora()
        {
            InitializeComponent();
        }

        public void deshabilita()
        {
             //deshabilitando textboxs
            //txtidTrabajo.Enabled = false;
        
            txtIncidencia.Enabled = false;
            txtObservaciones.Enabled = false;
            // limpiando los textboxs
            txtTrab.Clear();
            txtIncidencia.Clear();
            txtObservaciones.Clear();
            // deshabilitando los botones
            btnActualizar.Enabled = false;
            txtTrab.Focus();
        }
        public void habilita()
        {
            txtTrab.Enabled = true;
            txtIncidencia.Enabled = true;
            txtObservaciones.Enabled = true;
            btnActualizar.Enabled = true;
            txtTrab.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenu fm = new FrmMenu();
            fm.Show();
            this.Hide();
        }

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            deshabilita();
        }

        private void txtTrab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) this.Close();
            if (e.KeyChar == 13 && txtTrab.Text != "")
            {
                habilita();
                txtIncidencia.Focus();
            }
        }

        private void txtIncidencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                txtTrab.Focus();
                txtIncidencia.Clear();
                txtIncidencia.Enabled = true;
                deshabilita();
                txtTrab.Focus();
            }
            if (e.KeyChar == 13) txtObservaciones.Focus();
        }

        private void txtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                txtObservaciones.Clear();
                txtIncidencia.Enabled = true;
                deshabilita();
                txtIncidencia.Enabled = true;
                txtIncidencia.Focus();
            }
            if (e.KeyChar == 13) dgIncidencia.Focus();
        }

   
      
       

    }
}
