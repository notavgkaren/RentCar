namespace RentCar.Forms
{
    partial class FormCliente
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
            this.rentCarDataSet = new RentCar.RentCarDataSet();
            this.rentCarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjetaCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteCreditoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rentCarDataSet
            // 
            this.rentCarDataSet.DataSetName = "RentCarDataSet";
            this.rentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentCarDataSetBindingSource
            // 
            this.rentCarDataSetBindingSource.DataSource = this.rentCarDataSet;
            this.rentCarDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.tarjetaCRDataGridViewTextBoxColumn,
            this.limiteCreditoDataGridViewTextBoxColumn,
            this.tipoPersonaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 397);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(519, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Location = new System.Drawing.Point(681, 12);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(75, 23);
            this.btnDesactivar.TabIndex = 8;
            this.btnDesactivar.Text = "&Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(600, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarjetaCRDataGridViewTextBoxColumn
            // 
            this.tarjetaCRDataGridViewTextBoxColumn.DataPropertyName = "TarjetaCR";
            this.tarjetaCRDataGridViewTextBoxColumn.HeaderText = "TarjetaCR";
            this.tarjetaCRDataGridViewTextBoxColumn.Name = "tarjetaCRDataGridViewTextBoxColumn";
            this.tarjetaCRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // limiteCreditoDataGridViewTextBoxColumn
            // 
            this.limiteCreditoDataGridViewTextBoxColumn.DataPropertyName = "LimiteCredito";
            this.limiteCreditoDataGridViewTextBoxColumn.HeaderText = "LimiteCredito";
            this.limiteCreditoDataGridViewTextBoxColumn.Name = "limiteCreditoDataGridViewTextBoxColumn";
            this.limiteCreditoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoPersonaDataGridViewTextBoxColumn
            // 
            this.tipoPersonaDataGridViewTextBoxColumn.DataPropertyName = "TipoPersona";
            this.tipoPersonaDataGridViewTextBoxColumn.HeaderText = "TipoPersona";
            this.tipoPersonaDataGridViewTextBoxColumn.Name = "tipoPersonaDataGridViewTextBoxColumn";
            this.tipoPersonaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(RentCar.Cliente);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCliente";
            this.Text = "Manejar Clientes";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RentCarDataSet rentCarDataSet;
        private System.Windows.Forms.BindingSource rentCarDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarjetaCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteCreditoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewTextBoxColumn;
    }
}