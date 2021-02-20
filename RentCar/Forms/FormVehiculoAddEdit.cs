using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.Forms
{
    public partial class FormVehiculoAddEdit : Form
    {
        RentCarEntities db;
        bool edit = false;

        public FormVehiculoAddEdit(Vehiculo vehiculo)
        {
            InitializeComponent();
            db = new RentCarEntities();
            if (vehiculo == null)
            {
                vehiculoBindingSource.DataSource = new Vehiculo();
                var c = vehiculoBindingSource.Current as Vehiculo;
                c.Estado = "Activo";
                db.Vehiculoes.Add(c);
            }
            else
            {
                label7.Text = "Editar";
                vehiculoBindingSource.DataSource = vehiculo;
                edit = true;
            }

            //TODO modelo combo box
        }

        private void FormVehiculoAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                //validacion de campos vacios
                foreach (Control item in this.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        if (string.IsNullOrEmpty(item.Text))
                        {
                            MessageBox.Show("Favor llene todos los campos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            item.Focus();
                            e.Cancel = true;
                            return;
                        }
                    }
                }

                //completar edicion
                if (edit)
                {
                    var c = vehiculoBindingSource.Current as Vehiculo;
                    var cc = db.Clientes.Where(q => q.ID.Equals(c.ID)).FirstOrDefault();
                    //TODO edicion
                }

                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
