namespace WindowsFormsApplication1
{
    partial class FrmClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mGsoftDataSet2 = new WindowsFormsApplication1.MGsoftDataSet2();
            this.txtnomCliente = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtTrabajo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.ListBox();
            this.trabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mGsoftDataSet = new WindowsFormsApplication1.MGsoftDataSet();
            this.lbEstadoTrabajo = new System.Windows.Forms.ListBox();
            this.trabajoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mGsoftDataSet1 = new WindowsFormsApplication1.MGsoftDataSet1();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtidCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.trabajoTableAdapter = new WindowsFormsApplication1.MGsoftDataSetTableAdapters.TrabajoTableAdapter();
            this.trabajoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trabajoTableAdapter1 = new WindowsFormsApplication1.MGsoftDataSet1TableAdapters.TrabajoTableAdapter();
            this.clientesTableAdapter = new WindowsFormsApplication1.MGsoftDataSet2TableAdapters.ClientesTableAdapter();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrabajoColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaTRABcolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoTrabColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKidTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Domicilio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trabajo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha estimada de entrega";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado del trabajo";
            // 
            // dgClientes
            // 
            this.dgClientes.AutoGenerateColumns = false;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.nomCliente,
            this.Domicilio,
            this.Telefono,
            this.TrabajoColum,
            this.AreaTRABcolum,
            this.Fecha,
            this.EstadoTrabColum,
            this.idClienteDataGridViewTextBoxColumn,
            this.nomClienteDataGridViewTextBoxColumn,
            this.domicilioDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.fKidTrabajoDataGridViewTextBoxColumn});
            this.dgClientes.DataSource = this.clientesBindingSource;
            this.dgClientes.Location = new System.Drawing.Point(319, 109);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.Size = new System.Drawing.Size(842, 480);
            this.dgClientes.TabIndex = 7;
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
            // txtnomCliente
            // 
            this.txtnomCliente.Location = new System.Drawing.Point(41, 162);
            this.txtnomCliente.Name = "txtnomCliente";
            this.txtnomCliente.Size = new System.Drawing.Size(166, 20);
            this.txtnomCliente.TabIndex = 8;
            this.txtnomCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnomCliente_KeyPress);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(41, 211);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(166, 20);
            this.txtDomicilio.TabIndex = 9;
            this.txtDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDomicilio_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(41, 263);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(166, 20);
            this.txtTelefono.TabIndex = 10;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtTrabajo
            // 
            this.txtTrabajo.Location = new System.Drawing.Point(41, 320);
            this.txtTrabajo.Multiline = true;
            this.txtTrabajo.Name = "txtTrabajo";
            this.txtTrabajo.Size = new System.Drawing.Size(243, 64);
            this.txtTrabajo.TabIndex = 12;
            this.txtTrabajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrabajo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Area de trabajo";
            // 
            // lbArea
            // 
            this.lbArea.DataSource = this.trabajoBindingSource;
            this.lbArea.DisplayMember = "AreaTrabajo";
            this.lbArea.FormattingEnabled = true;
            this.lbArea.Location = new System.Drawing.Point(44, 417);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(120, 17);
            this.lbArea.TabIndex = 17;
            // 
            // trabajoBindingSource
            // 
            this.trabajoBindingSource.DataMember = "Trabajo";
            this.trabajoBindingSource.DataSource = this.mGsoftDataSet;
            // 
            // mGsoftDataSet
            // 
            this.mGsoftDataSet.DataSetName = "MGsoftDataSet";
            this.mGsoftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbEstadoTrabajo
            // 
            this.lbEstadoTrabajo.DataSource = this.trabajoBindingSource2;
            this.lbEstadoTrabajo.DisplayMember = "EstadoTrabajo";
            this.lbEstadoTrabajo.FormattingEnabled = true;
            this.lbEstadoTrabajo.Location = new System.Drawing.Point(41, 518);
            this.lbEstadoTrabajo.Name = "lbEstadoTrabajo";
            this.lbEstadoTrabajo.Size = new System.Drawing.Size(120, 17);
            this.lbEstadoTrabajo.TabIndex = 35;
            // 
            // trabajoBindingSource2
            // 
            this.trabajoBindingSource2.DataMember = "Trabajo";
            this.trabajoBindingSource2.DataSource = this.mGsoftDataSet1;
            // 
            // mGsoftDataSet1
            // 
            this.mGsoftDataSet1.DataSetName = "MGsoftDataSet1";
            this.mGsoftDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(370, 83);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(453, 20);
            this.txtBuscar.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Buscar";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(40, 468);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 58;
            this.lblFecha.Text = "Fecha";
            // 
            // txtidCliente
            // 
            this.txtidCliente.Location = new System.Drawing.Point(41, 109);
            this.txtidCliente.Name = "txtidCliente";
            this.txtidCliente.Size = new System.Drawing.Size(166, 20);
            this.txtidCliente.TabIndex = 60;
            this.txtidCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidCliente_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "IdCliente";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(470, 595);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(203, 55);
            this.btnActualizar.TabIndex = 71;
            this.btnActualizar.Text = "ACTUALIZAR Y GUARDAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(703, 595);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(203, 55);
            this.btnRegresar.TabIndex = 70;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // trabajoTableAdapter
            // 
            this.trabajoTableAdapter.ClearBeforeFill = true;
            // 
            // trabajoBindingSource1
            // 
            this.trabajoBindingSource1.DataMember = "Trabajo";
            this.trabajoBindingSource1.DataSource = this.mGsoftDataSet;
            // 
            // trabajoTableAdapter1
            // 
            this.trabajoTableAdapter1.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "idCliente";
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            // 
            // nomCliente
            // 
            this.nomCliente.DataPropertyName = "nomCliente";
            this.nomCliente.HeaderText = "NomCliente";
            this.nomCliente.Name = "nomCliente";
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "Domicilio";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // TrabajoColum
            // 
            this.TrabajoColum.HeaderText = "Trabajo";
            this.TrabajoColum.Name = "TrabajoColum";
            // 
            // AreaTRABcolum
            // 
            this.AreaTRABcolum.HeaderText = "Area de Trabajo";
            this.AreaTRABcolum.Name = "AreaTRABcolum";
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // EstadoTrabColum
            // 
            this.EstadoTrabColum.HeaderText = "Estado del trabajo";
            this.EstadoTrabColum.Name = "EstadoTrabColum";
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            // 
            // nomClienteDataGridViewTextBoxColumn
            // 
            this.nomClienteDataGridViewTextBoxColumn.DataPropertyName = "nomCliente";
            this.nomClienteDataGridViewTextBoxColumn.HeaderText = "nomCliente";
            this.nomClienteDataGridViewTextBoxColumn.Name = "nomClienteDataGridViewTextBoxColumn";
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            this.domicilioDataGridViewTextBoxColumn.DataPropertyName = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // fKidTrabajoDataGridViewTextBoxColumn
            // 
            this.fKidTrabajoDataGridViewTextBoxColumn.DataPropertyName = "FKidTrabajo";
            this.fKidTrabajoDataGridViewTextBoxColumn.HeaderText = "FKidTrabajo";
            this.fKidTrabajoDataGridViewTextBoxColumn.Name = "fKidTrabajoDataGridViewTextBoxColumn";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 664);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtidCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbEstadoTrabajo);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTrabajo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtnomCliente);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.TextBox txtnomCliente;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtTrabajo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbArea;
        private System.Windows.Forms.ListBox lbEstadoTrabajo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtidCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegresar;
        private MGsoftDataSet mGsoftDataSet;
        private System.Windows.Forms.BindingSource trabajoBindingSource;
        private MGsoftDataSetTableAdapters.TrabajoTableAdapter trabajoTableAdapter;
        private System.Windows.Forms.BindingSource trabajoBindingSource1;
        private MGsoftDataSet1 mGsoftDataSet1;
        private System.Windows.Forms.BindingSource trabajoBindingSource2;
        private MGsoftDataSet1TableAdapters.TrabajoTableAdapter trabajoTableAdapter1;
        private MGsoftDataSet2 mGsoftDataSet2;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private MGsoftDataSet2TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrabajoColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaTRABcolum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoTrabColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidTrabajoDataGridViewTextBoxColumn;
    }
}