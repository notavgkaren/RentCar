
namespace RentCar.Forms
{
    partial class FormVehiculoAddEdit
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbCombustible = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtChasis = new System.Windows.Forms.TextBox();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.tipoCombustibleVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoCombustibleVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaVehiculoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 31);
            this.label7.TabIndex = 25;
            this.label7.Text = "Agregar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Location = new System.Drawing.Point(214, 375);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cbCombustible
            // 
            this.cbCombustible.DisplayMember = "ID";
            this.cbCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCombustible.FormattingEnabled = true;
            this.cbCombustible.Location = new System.Drawing.Point(126, 348);
            this.cbCombustible.Name = "cbCombustible";
            this.cbCombustible.Size = new System.Drawing.Size(163, 21);
            this.cbCombustible.TabIndex = 20;
            this.cbCombustible.ValueMember = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tipo de Combustible";
            // 
            // txtLimite
            // 
            this.txtLimite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "PlacaNum", true));
            this.txtLimite.Location = new System.Drawing.Point(126, 205);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(163, 20);
            this.txtLimite.TabIndex = 19;
            // 
            // vehiculoBindingSource
            // 
            this.vehiculoBindingSource.DataSource = typeof(RentCar.Vehiculo);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Num. de Placa";
            // 
            // txtChasis
            // 
            this.txtChasis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "ChasisNum", true));
            this.txtChasis.Location = new System.Drawing.Point(126, 134);
            this.txtChasis.Name = "txtChasis";
            this.txtChasis.Size = new System.Drawing.Size(163, 20);
            this.txtChasis.TabIndex = 17;
            // 
            // txtMotor
            // 
            this.txtMotor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "MotorNum", true));
            this.txtMotor.Location = new System.Drawing.Point(126, 168);
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.Size = new System.Drawing.Size(163, 20);
            this.txtMotor.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Num. de Chasis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Num. de Motor";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "Descripcion", true));
            this.txtDescripcion.Location = new System.Drawing.Point(126, 56);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(163, 61);
            this.txtDescripcion.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Modelo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tipo de Vehiculo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Marca";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(126, 241);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(163, 21);
            this.cbTipo.TabIndex = 20;
            // 
            // cbMarca
            // 
            this.cbMarca.DisplayMember = "ID";
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(126, 275);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(163, 21);
            this.cbMarca.TabIndex = 20;
            this.cbMarca.ValueMember = "ID";
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // cbModelo
            // 
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(126, 312);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(163, 21);
            this.cbModelo.TabIndex = 20;
            // 
            // tipoCombustibleVehiculoBindingSource
            // 
            this.tipoCombustibleVehiculoBindingSource.DataSource = typeof(RentCar.Tipo_Combustible_Vehiculo);
            // 
            // tipoVehiculoBindingSource
            // 
            this.tipoVehiculoBindingSource.DataSource = typeof(RentCar.Tipo_Vehiculo);
            // 
            // marcaVehiculoBindingSource
            // 
            this.marcaVehiculoBindingSource.DataSource = typeof(RentCar.Marca_Vehiculo);
            // 
            // FormVehiculoAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 419);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbCombustible);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtChasis);
            this.Controls.Add(this.txtMotor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Name = "FormVehiculoAddEdit";
            this.Text = "Agregar/Editar Vehiculo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVehiculoAddEdit_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoCombustibleVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaVehiculoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbCombustible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChasis;
        private System.Windows.Forms.TextBox txtMotor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.BindingSource tipoVehiculoBindingSource;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.BindingSource marcaVehiculoBindingSource;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.BindingSource tipoCombustibleVehiculoBindingSource;
    }
}