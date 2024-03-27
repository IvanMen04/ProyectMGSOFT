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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes fc = new FrmClientes();
            fc.Show(); 
            this.Hide(); 
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleado fe = new FrmEmpleado();
            fe.Show(); 
            this.Hide(); 
        }

        private void btnTrabajos_Click(object sender, EventArgs e)
        {
            FrmTrabajo ft = new FrmTrabajo();
            ft.Show(); 
            this.Hide(); 
        }

        private void btnBitacoras_Click(object sender, EventArgs e)
        {
            FrmBitacora fb = new FrmBitacora();
            fb.Show(); 
            this.Hide(); 
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmLogin fl = new FrmLogin();
            fl.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
