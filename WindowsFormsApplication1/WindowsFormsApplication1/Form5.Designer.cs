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
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTrabajo = new System.Windows.Forms.TextBox();
            this.dgtrabajo = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtidTrabajo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cbCliente = new System.Windows.Forms.Label();
            this.cbEstadoTrabajo = new System.Windows.Forms.ComboBox();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mGsoftDataSet2 = new WindowsFormsApplication1.MGsoftDataSet2();
            this.cbAreaTrabajo = new System.Windows.Forms.ComboBox();
            this.empleadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new WindowsFormsApplication1.MGsoftDataSet2TableAdapters.EmpleadoTableAdapter();
            this.clientesTableAdapter = new WindowsFormsApplication1.MGsoftDataSet2TableAdapters.ClientesTableAdapter();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKTrabajoIDEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabajoEmpleadoTableAdapter = new WindowsFormsApplication1.MGsoftDataSet2TableAdapters.TrabajoEmpleadoTableAdapter();
            this.empleadoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgtrabajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTrabajoIDEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource2)).BeginInit();
            this.SuspendLayout();
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
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cbCliente
            // 
            this.cbCliente.AutoSize = true;
            this.cbCliente.Location = new System.Drawing.Point(19, 449);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(108, 13);
            this.cbCliente.TabIndex = 70;
            this.cbCliente.Text = "Trabajo solicitado por";
            // 
            // cbEstadoTrabajo
            // 
            this.cbEstadoTrabajo.FormattingEnabled = true;
            this.cbEstadoTrabajo.Items.AddRange(new object[] {
            "En proceso",
            "Retrasado",
            "Cancelado",
            "Finalizado",
            "Finalizado con retraso"});
            this.cbEstadoTrabajo.Location = new System.Drawing.Point(25, 351);
            this.cbEstadoTrabajo.Name = "cbEstadoTrabajo";
            this.cbEstadoTrabajo.Size = new System.Drawing.Size(121, 21);
            this.cbEstadoTrabajo.TabIndex = 72;
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.DataSource = this.empleadoBindingSource2;
            this.cbEmpleado.DisplayMember = "nomEmpleado";
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(25, 413);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cbEmpleado.TabIndex = 73;
            this.cbEmpleado.ValueMember = "nomEmpleado";
            // 
            // cbxCliente
            // 
            this.cbxCliente.DataSource = this.clientesBindingSource;
            this.cbxCliente.DisplayMember = "nomCliente";
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(25, 465);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(121, 21);
            this.cbxCliente.TabIndex = 74;
            this.cbxCliente.ValueMember = "nomCliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.mGsoftDataSet2;
            // 
            // mGsoftDataSet2
            // 
            this.mGsoftDataSet2.DataSetName = "MGsoftDataSet2";
            this.mGsoftDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbAreaTrabajo
            // 
            this.cbAreaTrabajo.FormattingEnabled = true;
            this.cbAreaTrabajo.Items.AddRange(new object[] {
            "Tecnica",
            "Programacion",
            "Programacion Web",
            "Servidores"});
            this.cbAreaTrabajo.Location = new System.Drawing.Point(25, 244);
            this.cbAreaTrabajo.Name = "cbAreaTrabajo";
            this.cbAreaTrabajo.Size = new System.Drawing.Size(121, 21);
            this.cbAreaTrabajo.TabIndex = 75;
            // 
            // empleadoBindingSource1
            // 
            this.empleadoBindingSource1.DataMember = "Empleado";
            this.empleadoBindingSource1.DataSource = this.mGsoftDataSet2;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.mGsoftDataSet2;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.mGsoftDataSet2;
            // 
            // fKTrabajoIDEmpleadoBindingSource
            // 
            this.fKTrabajoIDEmpleadoBindingSource.DataMember = "FK_TrabajoIDEmpleado";
            this.fKTrabajoIDEmpleadoBindingSource.DataSource = this.empleadoBindingSource1;
            // 
            // trabajoEmpleadoTableAdapter
            // 
            this.trabajoEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // empleadoBindingSource2
            // 
            this.empleadoBindingSource2.DataMember = "Empleado";
            this.empleadoBindingSource2.DataSource = this.mGsoftDataSet2;
            // 
            // FrmTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 541);
            this.Controls.Add(this.cbAreaTrabajo);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.cbEstadoTrabajo);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtidTrabajo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTrabajo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgtrabajo);
            this.Name = "FrmTrabajo";
            this.Text = "Trabajos";
            this.Load += new System.EventHandler(this.FrmTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtrabajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTrabajoIDEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTrabajo;
        private System.Windows.Forms.DataGridView dgtrabajo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtidTrabajo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label cbCliente;
        private MGsoftDataSet2 mGsoftDataSet2;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private MGsoftDataSet2TableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.BindingSource empleadoBindingSource1;
        private System.Windows.Forms.ComboBox cbEstadoTrabajo;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.ComboBox cbAreaTrabajo;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private MGsoftDataSet2TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.BindingSource fKTrabajoIDEmpleadoBindingSource;
        private MGsoftDataSet2TableAdapters.TrabajoEmpleadoTableAdapter trabajoEmpleadoTableAdapter;
        private System.Windows.Forms.BindingSource empleadoBindingSource2;
    }
}