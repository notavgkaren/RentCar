
namespace RentCar.Forms
{
    partial class FormInspeccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInspeccion));
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbCombustible = new System.Windows.Forms.ComboBox();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.inspeccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.chkCristal = new System.Windows.Forms.CheckBox();
            this.chkGoma1 = new System.Windows.Forms.CheckBox();
            this.chkRepuesto = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.chkGoma4 = new System.Windows.Forms.CheckBox();
            this.chkGoma3 = new System.Windows.Forms.CheckBox();
            this.chkGoma2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbVehiculo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.inspeccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Empleado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Cantidad de Combustible";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Inspeccion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Location = new System.Drawing.Point(145, 404);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(163, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "&Proceder a Renta >>";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cbCombustible
            // 
            this.cbCombustible.DisplayMember = "ID";
            this.cbCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCombustible.FormattingEnabled = true;
            this.cbCombustible.Items.AddRange(new object[] {
            "Lleno",
            "3/4",
            "Medio",
            "1/4",
            "Res."});
            this.cbCombustible.Location = new System.Drawing.Point(145, 115);
            this.cbCombustible.Name = "cbCombustible";
            this.cbCombustible.Size = new System.Drawing.Size(163, 21);
            this.cbCombustible.TabIndex = 1;
            this.cbCombustible.ValueMember = "ID";
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(145, 81);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(163, 21);
            this.cbEmpleado.TabIndex = 0;
            // 
            // txtComentario
            // 
            this.txtComentario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inspeccionBindingSource, "Comentario", true));
            this.txtComentario.Location = new System.Drawing.Point(145, 337);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(163, 61);
            this.txtComentario.TabIndex = 10;
            // 
            // inspeccionBindingSource
            // 
            this.inspeccionBindingSource.DataSource = typeof(RentCar.Inspeccion);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Comentario";
            // 
            // chkCristal
            // 
            this.chkCristal.AutoSize = true;
            this.chkCristal.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.inspeccionBindingSource, "TieneRoturaCristal", true));
            this.chkCristal.Location = new System.Drawing.Point(145, 152);
            this.chkCristal.Name = "chkCristal";
            this.chkCristal.Size = new System.Drawing.Size(119, 17);
            this.chkCristal.TabIndex = 2;
            this.chkCristal.Text = "Tiene Rotura Cristal";
            this.chkCristal.UseVisualStyleBackColor = true;
            // 
            // chkGoma1
            // 
            this.chkGoma1.AutoSize = true;
            this.chkGoma1.Checked = true;
            this.chkGoma1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGoma1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.inspeccionBindingSource, "Goma1", true));
            this.chkGoma1.Location = new System.Drawing.Point(145, 263);
            this.chkGoma1.Name = "chkGoma1";
            this.chkGoma1.Size = new System.Drawing.Size(62, 17);
            this.chkGoma1.TabIndex = 6;
            this.chkGoma1.Text = "Sup Izq";
            this.chkGoma1.UseVisualStyleBackColor = true;
            // 
            // chkRepuesto
            // 
            this.chkRepuesto.AutoSize = true;
            this.chkRepuesto.Checked = true;
            this.chkRepuesto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRepuesto.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.inspeccionBindingSource, "TieneGomaRepuesto", true));
            this.chkRepuesto.Location = new System.Drawing.Point(145, 221);
            this.chkRepuesto.Name = "chkRepuesto";
            this.chkRepuesto.Size = new System.Drawing.Size(133, 17);
            this.chkRepuesto.TabIndex = 5;
            this.chkRepuesto.Text = "Tiene Goma Repuesto";
            this.chkRepuesto.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.inspeccionBindingSource, "TieneRalladuras", true));
            this.checkBox4.Location = new System.Drawing.Point(145, 198);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(106, 17);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Tiene Ralladuras";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // chkGoma4
            // 
            this.chkGoma4.AutoSize = true;
            this.chkGoma4.Checked = true;
            this.chkGoma4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGoma4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.inspeccionBindingSource, "Goma4", true));
            this.chkGoma4.Location = new System.Drawing.Point(246, 303);
            this.chkGoma4.Name = "chkGoma4";
            this.chkGoma4.Size = new System.Drawing.Size(58, 17);
            this.chkGoma4.TabIndex = 9;
            this.chkGoma4.Text = "Inf Der";
            this.chkGoma4.UseVisualStyleBackColor = true;
            // 
            // chkGoma3
            // 
            this.chkGoma3.AutoSize = true;
            this.chkGoma3.Checked = true;
            this.chkGoma3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGoma3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.inspeccionBindingSource, "Goma3", true));
            this.chkGoma3.Location = new System.Drawing.Point(145, 303);
            this.chkGoma3.Name = "chkGoma3";
            this.chkGoma3.Size = new System.Drawing.Size(55, 17);
            this.chkGoma3.TabIndex = 8;
            this.chkGoma3.Text = "Inf Izq";
            this.chkGoma3.UseVisualStyleBackColor = true;
            // 
            // chkGoma2
            // 
            this.chkGoma2.AutoSize = true;
            this.chkGoma2.Checked = true;
            this.chkGoma2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGoma2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.inspeccionBindingSource, "Goma2", true));
            this.chkGoma2.Location = new System.Drawing.Point(246, 263);
            this.chkGoma2.Name = "chkGoma2";
            this.chkGoma2.Size = new System.Drawing.Size(65, 17);
            this.chkGoma2.TabIndex = 7;
            this.chkGoma2.Text = "Sup Der";
            this.chkGoma2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Estado de Gomas";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.inspeccionBindingSource, "TieneGato", true));
            this.checkBox1.Location = new System.Drawing.Point(145, 175);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Tiene Gato";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Vehiculo";
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Location = new System.Drawing.Point(145, 54);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(163, 21);
            this.cbVehiculo.TabIndex = 17;
            // 
            // FormInspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 468);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbVehiculo);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkGoma2);
            this.Controls.Add(this.chkGoma3);
            this.Controls.Add(this.chkGoma4);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.chkRepuesto);
            this.Controls.Add(this.chkGoma1);
            this.Controls.Add(this.chkCristal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbCombustible);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInspeccion";
            this.Text = "Inspeccion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInspeccion_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.inspeccionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbCombustible;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkCristal;
        private System.Windows.Forms.CheckBox chkGoma1;
        private System.Windows.Forms.CheckBox chkRepuesto;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.BindingSource inspeccionBindingSource;
        private System.Windows.Forms.CheckBox chkGoma4;
        private System.Windows.Forms.CheckBox chkGoma3;
        private System.Windows.Forms.CheckBox chkGoma2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbVehiculo;
    }
}