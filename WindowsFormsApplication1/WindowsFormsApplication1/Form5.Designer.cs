namespace WindowsFormsApplication1
{
    partial class FrmTrabajo
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
            this.lbEstadoTrabajo = new System.Windows.Forms.ListBox();
            this.lbAreaTrabajo = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTrabajo = new System.Windows.Forms.TextBox();
            this.dgtrabajo = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEmpleado = new System.Windows.Forms.ListBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtidTrabajo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtrabajo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEstadoTrabajo
            // 
            this.lbEstadoTrabajo.FormattingEnabled = true;
            this.lbEstadoTrabajo.Location = new System.Drawing.Point(25, 354);
            this.lbEstadoTrabajo.Name = "lbEstadoTrabajo";
            this.lbEstadoTrabajo.Size = new System.Drawing.Size(120, 17);
            this.lbEstadoTrabajo.TabIndex = 52;
            // 
            // lbAreaTrabajo
            // 
            this.lbAreaTrabajo.FormattingEnabled = true;
            this.lbAreaTrabajo.Location = new System.Drawing.Point(25, 244);
            this.lbAreaTrabajo.Name = "lbAreaTrabajo";
            this.lbAreaTrabajo.Size = new System.Drawing.Size(120, 17);
            this.lbAreaTrabajo.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Area de trabajo";
            // 
            // txtTrabajo
            // 
            this.txtTrabajo.Location = new System.Drawing.Point(25, 153);
            this.txtTrabajo.Multiline = true;
            this.txtTrabajo.Name = "txtTrabajo";
            this.txtTrabajo.Size = new System.Drawing.Size(243, 64);
            this.txtTrabajo.TabIndex = 48;
            this.txtTrabajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrabajo_KeyPress);
            // 
            // dgtrabajo
            // 
            this.dgtrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtrabajo.Location = new System.Drawing.Point(294, 74);
            this.dgtrabajo.Name = "dgtrabajo";
            this.dgtrabajo.Size = new System.Drawing.Size(589, 394);
            this.dgtrabajo.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Estado del trabajo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Fecha estimada de entrega";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Trabajo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Asignar trabajo a";
            // 
            // lbEmpleado
            // 
            this.lbEmpleado.FormattingEnabled = true;
            this.lbEmpleado.Location = new System.Drawing.Point(22, 413);
            this.lbEmpleado.Name = "lbEmpleado";
            this.lbEmpleado.Size = new System.Drawing.Size(120, 17);
            this.lbEmpleado.TabIndex = 53;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(346, 50);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(357, 20);
            this.txtbuscar.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Buscar";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(25, 299);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 57;
            this.lblFecha.Text = "Fecha";
            // 
            // txtidTrabajo
            // 
            this.txtidTrabajo.Location = new System.Drawing.Point(28, 100);
            this.txtidTrabajo.Name = "txtidTrabajo";
            this.txtidTrabajo.Size = new System.Drawing.Size(166, 20);
            this.txtidTrabajo.TabIndex = 59;
            this.txtidTrabajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidTrabajo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "IdTrabajo";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(641, 474);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(203, 55);
            this.btnRegresar.TabIndex = 68;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(408, 474);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(203, 55);
            this.btnActualizar.TabIndex = 69;
            this.btnActualizar.Text = "ACTUALIZAR Y GUARDAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // FrmTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 541);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtidTrabajo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbEmpleado);
            this.Controls.Add(this.lbEstadoTrabajo);
            this.Controls.Add(this.lbAreaTrabajo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTrabajo);
            this.Controls.Add(this.dgtrabajo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FrmTrabajo";
            this.Text = "Trabajos";
            this.Load += new System.EventHandler(this.FrmTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtrabajo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEstadoTrabajo;
        private System.Windows.Forms.ListBox lbAreaTrabajo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTrabajo;
        private System.Windows.Forms.DataGridView dgtrabajo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbEmpleado;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtidTrabajo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnActualizar;
    }
}