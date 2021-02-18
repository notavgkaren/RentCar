namespace RentCar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMod = new System.Windows.Forms.Panel();
            this.modClientes = new System.Windows.Forms.Button();
            this.modEmpleados = new System.Windows.Forms.Button();
            this.modVehiculos = new System.Windows.Forms.Button();
            this.modReporte = new System.Windows.Forms.Button();
            this.modRenta = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelModTitle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelModContenido = new System.Windows.Forms.Panel();
            this.panelMod.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelModTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMod
            // 
            this.panelMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(132)))));
            this.panelMod.Controls.Add(this.modClientes);
            this.panelMod.Controls.Add(this.modEmpleados);
            this.panelMod.Controls.Add(this.modVehiculos);
            this.panelMod.Controls.Add(this.modReporte);
            this.panelMod.Controls.Add(this.modRenta);
            this.panelMod.Controls.Add(this.panelLogo);
            this.panelMod.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMod.Location = new System.Drawing.Point(0, 0);
            this.panelMod.Name = "panelMod";
            this.panelMod.Size = new System.Drawing.Size(200, 450);
            this.panelMod.TabIndex = 0;
            // 
            // modClientes
            // 
            this.modClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.modClientes.FlatAppearance.BorderSize = 0;
            this.modClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modClientes.ForeColor = System.Drawing.Color.White;
            this.modClientes.Image = global::RentCar.Properties.Resources.Customer;
            this.modClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modClientes.Location = new System.Drawing.Point(0, 336);
            this.modClientes.Name = "modClientes";
            this.modClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.modClientes.Size = new System.Drawing.Size(200, 64);
            this.modClientes.TabIndex = 6;
            this.modClientes.Text = "   Clientes";
            this.modClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modClientes.UseVisualStyleBackColor = true;
            this.modClientes.Click += new System.EventHandler(this.modClientes_Click);
            // 
            // modEmpleados
            // 
            this.modEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.modEmpleados.FlatAppearance.BorderSize = 0;
            this.modEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modEmpleados.ForeColor = System.Drawing.Color.White;
            this.modEmpleados.Image = global::RentCar.Properties.Resources.Employee;
            this.modEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modEmpleados.Location = new System.Drawing.Point(0, 272);
            this.modEmpleados.Name = "modEmpleados";
            this.modEmpleados.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.modEmpleados.Size = new System.Drawing.Size(200, 64);
            this.modEmpleados.TabIndex = 5;
            this.modEmpleados.Text = "   Empleados";
            this.modEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modEmpleados.UseVisualStyleBackColor = true;
            this.modEmpleados.Click += new System.EventHandler(this.modEmpleados_Click);
            // 
            // modVehiculos
            // 
            this.modVehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.modVehiculos.FlatAppearance.BorderSize = 0;
            this.modVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modVehiculos.ForeColor = System.Drawing.Color.White;
            this.modVehiculos.Image = global::RentCar.Properties.Resources.Vehicles;
            this.modVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modVehiculos.Location = new System.Drawing.Point(0, 208);
            this.modVehiculos.Name = "modVehiculos";
            this.modVehiculos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.modVehiculos.Size = new System.Drawing.Size(200, 64);
            this.modVehiculos.TabIndex = 4;
            this.modVehiculos.Text = "   Vehiculos";
            this.modVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modVehiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modVehiculos.UseVisualStyleBackColor = true;
            this.modVehiculos.Click += new System.EventHandler(this.modVehiculos_Click);
            // 
            // modReporte
            // 
            this.modReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.modReporte.FlatAppearance.BorderSize = 0;
            this.modReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modReporte.ForeColor = System.Drawing.Color.White;
            this.modReporte.Image = global::RentCar.Properties.Resources.Reports;
            this.modReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modReporte.Location = new System.Drawing.Point(0, 144);
            this.modReporte.Name = "modReporte";
            this.modReporte.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.modReporte.Size = new System.Drawing.Size(200, 64);
            this.modReporte.TabIndex = 3;
            this.modReporte.Text = "   Reportes";
            this.modReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modReporte.UseVisualStyleBackColor = true;
            this.modReporte.Click += new System.EventHandler(this.modReporte_Click);
            // 
            // modRenta
            // 
            this.modRenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.modRenta.FlatAppearance.BorderSize = 0;
            this.modRenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modRenta.ForeColor = System.Drawing.Color.White;
            this.modRenta.Image = global::RentCar.Properties.Resources.Rental2;
            this.modRenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modRenta.Location = new System.Drawing.Point(0, 80);
            this.modRenta.Name = "modRenta";
            this.modRenta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.modRenta.Size = new System.Drawing.Size(200, 64);
            this.modRenta.TabIndex = 2;
            this.modRenta.Text = "   Renta";
            this.modRenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modRenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modRenta.UseVisualStyleBackColor = true;
            this.modRenta.Click += new System.EventHandler(this.modRenta_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(193)))), ((int)(((byte)(189)))));
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Renta de Vehiculos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::RentCar.Properties.Resources.RentCar1;
            this.pictureBox1.InitialImage = global::RentCar.Properties.Resources.RentCar1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "RentCar";
            // 
            // panelModTitle
            // 
            this.panelModTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(193)))), ((int)(((byte)(189)))));
            this.panelModTitle.Controls.Add(this.label3);
            this.panelModTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelModTitle.Location = new System.Drawing.Point(200, 0);
            this.panelModTitle.Name = "panelModTitle";
            this.panelModTitle.Size = new System.Drawing.Size(600, 80);
            this.panelModTitle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(227, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modulo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelModContenido
            // 
            this.panelModContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelModContenido.Location = new System.Drawing.Point(200, 80);
            this.panelModContenido.Name = "panelModContenido";
            this.panelModContenido.Size = new System.Drawing.Size(600, 370);
            this.panelModContenido.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelModContenido);
            this.Controls.Add(this.panelModTitle);
            this.Controls.Add(this.panelMod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RentCar";
            this.panelMod.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelModTitle.ResumeLayout(false);
            this.panelModTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMod;
        private System.Windows.Forms.Button modRenta;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button modClientes;
        private System.Windows.Forms.Button modEmpleados;
        private System.Windows.Forms.Button modVehiculos;
        private System.Windows.Forms.Button modReporte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelModTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelModContenido;
    }
}

