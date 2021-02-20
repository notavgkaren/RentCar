
namespace RentCar.Forms
{
    partial class FormVehiculoVerMas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTipo = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnModelos = new System.Windows.Forms.Button();
            this.btnCombustible = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.btnCombustible);
            this.panel1.Controls.Add(this.btnModelos);
            this.panel1.Controls.Add(this.btnMarcas);
            this.panel1.Controls.Add(this.btnTipo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 334);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 70);
            this.panel2.TabIndex = 1;
            // 
            // btnTipo
            // 
            this.btnTipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTipo.Location = new System.Drawing.Point(0, 70);
            this.btnTipo.Name = "btnTipo";
            this.btnTipo.Size = new System.Drawing.Size(246, 52);
            this.btnTipo.TabIndex = 2;
            this.btnTipo.Text = "&Tipos de Vehiculo";
            this.btnTipo.UseVisualStyleBackColor = true;
            this.btnTipo.Click += new System.EventHandler(this.btnTipo_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarcas.Location = new System.Drawing.Point(0, 122);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(246, 52);
            this.btnMarcas.TabIndex = 3;
            this.btnMarcas.Text = "&Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            // 
            // btnModelos
            // 
            this.btnModelos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModelos.Location = new System.Drawing.Point(0, 174);
            this.btnModelos.Name = "btnModelos";
            this.btnModelos.Size = new System.Drawing.Size(246, 52);
            this.btnModelos.TabIndex = 4;
            this.btnModelos.Text = "&Modelos";
            this.btnModelos.UseVisualStyleBackColor = true;
            // 
            // btnCombustible
            // 
            this.btnCombustible.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCombustible.Location = new System.Drawing.Point(0, 226);
            this.btnCombustible.Name = "btnCombustible";
            this.btnCombustible.Size = new System.Drawing.Size(246, 52);
            this.btnCombustible.TabIndex = 5;
            this.btnCombustible.Text = "Tipos de &Combustible";
            this.btnCombustible.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ver Mas...";
            // 
            // FormVehiculoVerMas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 334);
            this.Controls.Add(this.panel1);
            this.Name = "FormVehiculoVerMas";
            this.Text = "Ver Mas";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCombustible;
        private System.Windows.Forms.Button btnModelos;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnTipo;
        private System.Windows.Forms.Label label1;
    }
}