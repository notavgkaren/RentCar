namespace RentCar.Forms
{
    partial class FormReportes
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
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbFechas = new System.Windows.Forms.RadioButton();
            this.rbEmpleados = new System.Windows.Forms.RadioButton();
            this.rbVehiculos = new System.Windows.Forms.RadioButton();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbVehiculos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(577, 51);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 36;
            this.btnDevolver.Text = "&Exportar";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(577, 96);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(75, 23);
            this.btnRecargar.TabIndex = 37;
            this.btnRecargar.Text = "&Limpiar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(577, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 301);
            this.dataGridView1.TabIndex = 35;
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(12, 42);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(57, 17);
            this.rbCliente.TabIndex = 42;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // rbFechas
            // 
            this.rbFechas.AutoSize = true;
            this.rbFechas.Location = new System.Drawing.Point(12, 12);
            this.rbFechas.Name = "rbFechas";
            this.rbFechas.Size = new System.Drawing.Size(88, 17);
            this.rbFechas.TabIndex = 43;
            this.rbFechas.TabStop = true;
            this.rbFechas.Text = "Entre Fechas";
            this.rbFechas.UseVisualStyleBackColor = true;
            // 
            // rbEmpleados
            // 
            this.rbEmpleados.AutoSize = true;
            this.rbEmpleados.Location = new System.Drawing.Point(12, 70);
            this.rbEmpleados.Name = "rbEmpleados";
            this.rbEmpleados.Size = new System.Drawing.Size(72, 17);
            this.rbEmpleados.TabIndex = 44;
            this.rbEmpleados.TabStop = true;
            this.rbEmpleados.Text = "Empleado";
            this.rbEmpleados.UseVisualStyleBackColor = true;
            // 
            // rbVehiculos
            // 
            this.rbVehiculos.AutoSize = true;
            this.rbVehiculos.Location = new System.Drawing.Point(12, 102);
            this.rbVehiculos.Name = "rbVehiculos";
            this.rbVehiculos.Size = new System.Drawing.Size(110, 17);
            this.rbVehiculos.TabIndex = 45;
            this.rbVehiculos.TabStop = true;
            this.rbVehiculos.Text = "Tipo de Vehiculos";
            this.rbVehiculos.UseVisualStyleBackColor = true;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(334, 9);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 20);
            this.dtp2.TabIndex = 46;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(128, 9);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 20);
            this.dtp1.TabIndex = 47;
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(128, 69);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(200, 21);
            this.cbEmpleado.TabIndex = 48;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(128, 38);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(200, 21);
            this.cbCliente.TabIndex = 49;
            // 
            // cbVehiculos
            // 
            this.cbVehiculos.FormattingEnabled = true;
            this.cbVehiculos.Location = new System.Drawing.Point(128, 102);
            this.cbVehiculos.Name = "cbVehiculos";
            this.cbVehiculos.Size = new System.Drawing.Size(200, 21);
            this.cbVehiculos.TabIndex = 50;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 441);
            this.Controls.Add(this.cbVehiculos);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.rbVehiculos);
            this.Controls.Add(this.rbEmpleados);
            this.Controls.Add(this.rbFechas);
            this.Controls.Add(this.rbCliente);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbFechas;
        private System.Windows.Forms.RadioButton rbEmpleados;
        private System.Windows.Forms.RadioButton rbVehiculos;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbVehiculos;
    }
}