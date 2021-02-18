using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar
{
    public partial class Form1 : Form
    {
        private Button currentbtn;
        private int index;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            OpenChildForm(new Forms.FormRenta(), modRenta, "Renta y Devolucion");
            
        }

        private void EnableButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentbtn != (Button)btnSender)
                {
                    DisableButton();
                    currentbtn = (Button)btnSender;
                    currentbtn.BackColor = Color.FromArgb(143, 193, 189);
                    currentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMod.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(44, 140, 132);
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender, string formName)
        {
            if (activeForm != null)            
                activeForm.Close();
            EnableButton(btnSender);

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelModContenido.Controls.Add(childForm);
            this.panelModContenido.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label3.Text = formName;
            
        }

        private void modRenta_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormRenta(), sender, "Renta y Devolucion");
        }

        private void modReporte_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReportes(), sender, "Reportes");
        }

        private void modVehiculos_Click(object sender, EventArgs e)
        {
            EnableButton(sender);
        }

        private void modEmpleados_Click(object sender, EventArgs e)
        {
            EnableButton(sender);
        }

        private void modClientes_Click(object sender, EventArgs e)
        {
            EnableButton(sender);
        }

        //:(
        //https://www.youtube.com/watch?v=BtOEztT1Qzk
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
