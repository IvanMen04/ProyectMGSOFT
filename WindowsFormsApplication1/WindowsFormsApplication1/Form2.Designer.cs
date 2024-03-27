namespace WindowsFormsApplication1
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnTrabajos = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBitacoras = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(47, 69);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(195, 85);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnTrabajos
            // 
            this.btnTrabajos.Location = new System.Drawing.Point(47, 202);
            this.btnTrabajos.Name = "btnTrabajos";
            this.btnTrabajos.Size = new System.Drawing.Size(195, 85);
            this.btnTrabajos.TabIndex = 1;
            this.btnTrabajos.Text = "TRABAJOS";
            this.btnTrabajos.UseVisualStyleBackColor = true;
            this.btnTrabajos.Click += new System.EventHandler(this.btnTrabajos_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(363, 69);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(195, 85);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "EMPLEADOS";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(337, 330);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 46);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBitacoras
            // 
            this.btnBitacoras.Location = new System.Drawing.Point(363, 202);
            this.btnBitacoras.Name = "btnBitacoras";
            this.btnBitacoras.Size = new System.Drawing.Size(195, 85);
            this.btnBitacoras.TabIndex = 4;
            this.btnBitacoras.Text = "BITACORA DE INCIDENCIAS";
            this.btnBitacoras.UseVisualStyleBackColor = true;
            this.btnBitacoras.Click += new System.EventHandler(this.btnBitacoras_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(192, 330);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(102, 46);
            this.btnRegresar.TabIndex = 70;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 406);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnBitacoras);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnTrabajos);
            this.Controls.Add(this.btnClientes);
            this.Name = "FrmMenu";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnTrabajos;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBitacoras;
        private System.Windows.Forms.Button btnRegresar;
    }
}