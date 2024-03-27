namespace WindowsFormsApplication1
{
    partial class FrmEmpleado
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
            this.lbArea = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmp = new System.Windows.Forms.TextBox();
            this.txtDomicilioEmp = new System.Windows.Forms.TextBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dgEmpleado = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEstadoEmpleado = new System.Windows.Forms.ListBox();
            this.txtnomEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtidEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // lbArea
            // 
            this.lbArea.FormattingEnabled = true;
            this.lbArea.Location = new System.Drawing.Point(34, 370);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(120, 17);
            this.lbArea.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Area de trabajo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(31, 315);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(166, 20);
            this.txtCorreo.TabIndex = 29;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // txtTelefonoEmp
            // 
            this.txtTelefonoEmp.Location = new System.Drawing.Point(31, 264);
            this.txtTelefonoEmp.Name = "txtTelefonoEmp";
            this.txtTelefonoEmp.Size = new System.Drawing.Size(166, 20);
            this.txtTelefonoEmp.TabIndex = 28;
            this.txtTelefonoEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoEmp_KeyPress);
            // 
            // txtDomicilioEmp
            // 
            this.txtDomicilioEmp.Location = new System.Drawing.Point(31, 212);
            this.txtDomicilioEmp.Name = "txtDomicilioEmp";
            this.txtDomicilioEmp.Size = new System.Drawing.Size(166, 20);
            this.txtDomicilioEmp.TabIndex = 27;
            this.txtDomicilioEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDomicilioEmp_KeyPress);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(422, 56);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(357, 20);
            this.txtbuscar.TabIndex = 26;
            // 
            // dgEmpleado
            // 
            this.dgEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleado.Location = new System.Drawing.Point(254, 82);
            this.dgEmpleado.Name = "dgEmpleado";
            this.dgEmpleado.Size = new System.Drawing.Size(651, 432);
            this.dgEmpleado.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Estado del empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Domicilio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Buscar";
            // 
            // lbEstadoEmpleado
            // 
            this.lbEstadoEmpleado.FormattingEnabled = true;
            this.lbEstadoEmpleado.Location = new System.Drawing.Point(34, 435);
            this.lbEstadoEmpleado.Name = "lbEstadoEmpleado";
            this.lbEstadoEmpleado.Size = new System.Drawing.Size(120, 17);
            this.lbEstadoEmpleado.TabIndex = 35;
            // 
            // txtnomEmpleado
            // 
            this.txtnomEmpleado.Location = new System.Drawing.Point(31, 163);
            this.txtnomEmpleado.Name = "txtnomEmpleado";
            this.txtnomEmpleado.Size = new System.Drawing.Size(166, 20);
            this.txtnomEmpleado.TabIndex = 37;
            this.txtnomEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnomEmpleado_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nombre empleado";
            // 
            // txtidEmpleado
            // 
            this.txtidEmpleado.Location = new System.Drawing.Point(31, 111);
            this.txtidEmpleado.Name = "txtidEmpleado";
            this.txtidEmpleado.Size = new System.Drawing.Size(166, 20);
            this.txtidEmpleado.TabIndex = 39;
            this.txtidEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidEmpleado_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "IdEmpleado";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(371, 520);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(203, 55);
            this.btnActualizar.TabIndex = 71;
            this.btnActualizar.Text = "ACTUALIZAR Y GUARDAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(604, 520);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(203, 55);
            this.btnRegresar.TabIndex = 70;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 588);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtidEmpleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnomEmpleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbEstadoEmpleado);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefonoEmp);
            this.Controls.Add(this.txtDomicilioEmp);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dgEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEmpleado";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefonoEmp;
        private System.Windows.Forms.TextBox txtDomicilioEmp;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dgEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbEstadoEmpleado;
        private System.Windows.Forms.TextBox txtnomEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtidEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegresar;
    }
}