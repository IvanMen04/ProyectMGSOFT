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
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mGsoftDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mGsoftDataSet2 = new WindowsFormsApplication1.MGsoftDataSet2();
            this.txtnomCliente = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtidCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.trabajoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fKClientesTrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mGsoftDataSet = new WindowsFormsApplication1.MGsoftDataSet();
            this.trabajoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mGsoftDataSet1 = new WindowsFormsApplication1.MGsoftDataSet1();
            this.trabajoTableAdapter = new WindowsFormsApplication1.MGsoftDataSetTableAdapters.TrabajoTableAdapter();
            this.trabajoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trabajoTableAdapter1 = new WindowsFormsApplication1.MGsoftDataSet1TableAdapters.TrabajoTableAdapter();
            this.clientesTableAdapter = new WindowsFormsApplication1.MGsoftDataSet2TableAdapters.ClientesTableAdapter();
            this.trabajoTableAdapter2 = new WindowsFormsApplication1.MGsoftDataSet2TableAdapters.TrabajoTableAdapter();
            this.mGsoftDataSet3 = new WindowsFormsApplication1.MGsoftDataSet3();
            this.mGsoftDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mGsoftDataSet4 = new WindowsFormsApplication1.MGsoftDataSet4();
            this.mGsoftDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter1 = new WindowsFormsApplication1.MGsoftDataSet3TableAdapters.ClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClientesTrabajoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
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
            // dgClientes
            // 
            this.dgClientes.AllowUserToOrderColumns = true;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(247, 109);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.Size = new System.Drawing.Size(720, 424);
            this.dgClientes.TabIndex = 7;
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.mGsoftDataSet2BindingSource;
            // 
            // mGsoftDataSet2BindingSource
            // 
            this.mGsoftDataSet2BindingSource.DataSource = this.mGsoftDataSet2;
            this.mGsoftDataSet2BindingSource.Position = 0;
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
            this.lblFecha.Location = new System.Drawing.Point(38, 305);
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
            this.btnActualizar.Location = new System.Drawing.Point(27, 347);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(203, 55);
            this.btnActualizar.TabIndex = 71;
            this.btnActualizar.Text = "ACTUALIZAR Y GUARDAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(800, 22);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(167, 44);
            this.btnRegresar.TabIndex = 70;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // trabajoBindingSource3
            // 
            this.trabajoBindingSource3.DataMember = "Trabajo";
            this.trabajoBindingSource3.DataSource = this.mGsoftDataSet2BindingSource;
            // 
            // fKClientesTrabajoBindingSource
            // 
            this.fKClientesTrabajoBindingSource.DataMember = "FK_Clientes_Trabajo";
            this.fKClientesTrabajoBindingSource.DataSource = this.trabajoBindingSource3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(88, 408);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(62, 44);
            this.btnEliminar.TabIndex = 74;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.mGsoftDataSet2;
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
            // trabajoTableAdapter2
            // 
            this.trabajoTableAdapter2.ClearBeforeFill = true;
            // 
            // mGsoftDataSet3
            // 
            this.mGsoftDataSet3.DataSetName = "MGsoftDataSet3";
            this.mGsoftDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mGsoftDataSet3BindingSource
            // 
            this.mGsoftDataSet3BindingSource.DataSource = this.mGsoftDataSet3;
            this.mGsoftDataSet3BindingSource.Position = 0;
            // 
            // mGsoftDataSet4
            // 
            this.mGsoftDataSet4.DataSetName = "MGsoftDataSet4";
            this.mGsoftDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mGsoftDataSet4BindingSource
            // 
            this.mGsoftDataSet4BindingSource.DataSource = this.mGsoftDataSet4;
            this.mGsoftDataSet4BindingSource.Position = 0;
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataMember = "Clientes";
            this.clientesBindingSource2.DataSource = this.mGsoftDataSet3;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 566);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtidCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtnomCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClientesTrabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGsoftDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.TextBox txtnomCliente;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtTelefono;
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
        private System.Windows.Forms.BindingSource mGsoftDataSet2BindingSource;
        private System.Windows.Forms.BindingSource trabajoBindingSource3;
        private MGsoftDataSet2TableAdapters.TrabajoTableAdapter trabajoTableAdapter2;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private MGsoftDataSet3 mGsoftDataSet3;
        private System.Windows.Forms.BindingSource mGsoftDataSet3BindingSource;
        private MGsoftDataSet4 mGsoftDataSet4;
        private System.Windows.Forms.BindingSource mGsoftDataSet4BindingSource;
        private System.Windows.Forms.BindingSource fKClientesTrabajoBindingSource;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private MGsoftDataSet3TableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private System.Windows.Forms.Button btnEliminar;
    }
}