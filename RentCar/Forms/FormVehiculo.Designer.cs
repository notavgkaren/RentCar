
namespace RentCar.Forms
{
    partial class FormVehiculo
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVerMas = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chasisNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCombustibleVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaVehiculo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloVehiculo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCombustibleVehiculo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVehiculo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(13, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(144, 20);
            this.txtBuscar.TabIndex = 26;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(501, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Location = new System.Drawing.Point(582, 8);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(75, 23);
            this.btnDesactivar.TabIndex = 21;
            this.btnDesactivar.Text = "&Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(244, 8);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(75, 23);
            this.btnRecargar.TabIndex = 22;
            this.btnRecargar.Text = "&Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(163, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(420, 8);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
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
            this.descripcionDataGridViewTextBoxColumn,
            this.chasisNumDataGridViewTextBoxColumn,
            this.motorNumDataGridViewTextBoxColumn,
            this.placaNumDataGridViewTextBoxColumn,
            this.tipoVehiculoDataGridViewTextBoxColumn,
            this.marcaVehiculoDataGridViewTextBoxColumn,
            this.modeloVehiculoDataGridViewTextBoxColumn,
            this.tipoCombustibleVehiculoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.marcaVehiculo1DataGridViewTextBoxColumn,
            this.modeloVehiculo1DataGridViewTextBoxColumn,
            this.tipoCombustibleVehiculo1DataGridViewTextBoxColumn,
            this.tipoVehiculo1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehiculoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 388);
            this.dataGridView1.TabIndex = 20;
            // 
            // btnVerMas
            // 
            this.btnVerMas.Location = new System.Drawing.Point(339, 8);
            this.btnVerMas.Name = "btnVerMas";
            this.btnVerMas.Size = new System.Drawing.Size(75, 23);
            this.btnVerMas.TabIndex = 24;
            this.btnVerMas.Text = "Ver &Mas";
            this.btnVerMas.UseVisualStyleBackColor = true;
            this.btnVerMas.Click += new System.EventHandler(this.btnVerMas_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // chasisNumDataGridViewTextBoxColumn
            // 
            this.chasisNumDataGridViewTextBoxColumn.DataPropertyName = "ChasisNum";
            this.chasisNumDataGridViewTextBoxColumn.HeaderText = "ChasisNum";
            this.chasisNumDataGridViewTextBoxColumn.Name = "chasisNumDataGridViewTextBoxColumn";
            // 
            // motorNumDataGridViewTextBoxColumn
            // 
            this.motorNumDataGridViewTextBoxColumn.DataPropertyName = "MotorNum";
            this.motorNumDataGridViewTextBoxColumn.HeaderText = "MotorNum";
            this.motorNumDataGridViewTextBoxColumn.Name = "motorNumDataGridViewTextBoxColumn";
            // 
            // placaNumDataGridViewTextBoxColumn
            // 
            this.placaNumDataGridViewTextBoxColumn.DataPropertyName = "PlacaNum";
            this.placaNumDataGridViewTextBoxColumn.HeaderText = "PlacaNum";
            this.placaNumDataGridViewTextBoxColumn.Name = "placaNumDataGridViewTextBoxColumn";
            // 
            // tipoVehiculoDataGridViewTextBoxColumn
            // 
            this.tipoVehiculoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Vehiculo";
            this.tipoVehiculoDataGridViewTextBoxColumn.HeaderText = "Tipo_Vehiculo";
            this.tipoVehiculoDataGridViewTextBoxColumn.Name = "tipoVehiculoDataGridViewTextBoxColumn";
            // 
            // marcaVehiculoDataGridViewTextBoxColumn
            // 
            this.marcaVehiculoDataGridViewTextBoxColumn.DataPropertyName = "Marca_Vehiculo";
            this.marcaVehiculoDataGridViewTextBoxColumn.HeaderText = "Marca_Vehiculo";
            this.marcaVehiculoDataGridViewTextBoxColumn.Name = "marcaVehiculoDataGridViewTextBoxColumn";
            // 
            // modeloVehiculoDataGridViewTextBoxColumn
            // 
            this.modeloVehiculoDataGridViewTextBoxColumn.DataPropertyName = "Modelo_Vehiculo";
            this.modeloVehiculoDataGridViewTextBoxColumn.HeaderText = "Modelo_Vehiculo";
            this.modeloVehiculoDataGridViewTextBoxColumn.Name = "modeloVehiculoDataGridViewTextBoxColumn";
            // 
            // tipoCombustibleVehiculoDataGridViewTextBoxColumn
            // 
            this.tipoCombustibleVehiculoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Combustible_Vehiculo";
            this.tipoCombustibleVehiculoDataGridViewTextBoxColumn.HeaderText = "Tipo_Combustible_Vehiculo";
            this.tipoCombustibleVehiculoDataGridViewTextBoxColumn.Name = "tipoCombustibleVehiculoDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // marcaVehiculo1DataGridViewTextBoxColumn
            // 
            this.marcaVehiculo1DataGridViewTextBoxColumn.DataPropertyName = "Marca_Vehiculo1";
            this.marcaVehiculo1DataGridViewTextBoxColumn.HeaderText = "Marca_Vehiculo1";
            this.marcaVehiculo1DataGridViewTextBoxColumn.Name = "marcaVehiculo1DataGridViewTextBoxColumn";
            // 
            // modeloVehiculo1DataGridViewTextBoxColumn
            // 
            this.modeloVehiculo1DataGridViewTextBoxColumn.DataPropertyName = "Modelo_Vehiculo1";
            this.modeloVehiculo1DataGridViewTextBoxColumn.HeaderText = "Modelo_Vehiculo1";
            this.modeloVehiculo1DataGridViewTextBoxColumn.Name = "modeloVehiculo1DataGridViewTextBoxColumn";
            // 
            // tipoCombustibleVehiculo1DataGridViewTextBoxColumn
            // 
            this.tipoCombustibleVehiculo1DataGridViewTextBoxColumn.DataPropertyName = "Tipo_Combustible_Vehiculo1";
            this.tipoCombustibleVehiculo1DataGridViewTextBoxColumn.HeaderText = "Tipo_Combustible_Vehiculo1";
            this.tipoCombustibleVehiculo1DataGridViewTextBoxColumn.Name = "tipoCombustibleVehiculo1DataGridViewTextBoxColumn";
            // 
            // tipoVehiculo1DataGridViewTextBoxColumn
            // 
            this.tipoVehiculo1DataGridViewTextBoxColumn.DataPropertyName = "Tipo_Vehiculo1";
            this.tipoVehiculo1DataGridViewTextBoxColumn.HeaderText = "Tipo_Vehiculo1";
            this.tipoVehiculo1DataGridViewTextBoxColumn.Name = "tipoVehiculo1DataGridViewTextBoxColumn";
            // 
            // vehiculoBindingSource
            // 
            this.vehiculoBindingSource.DataSource = typeof(RentCar.Vehiculo);
            // 
            // FormVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 441);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVerMas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormVehiculo";
            this.Text = "FormVehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chasisNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCombustibleVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaVehiculo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloVehiculo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCombustibleVehiculo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVehiculo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnVerMas;
    }
}