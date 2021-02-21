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
    public partial class FormEmpleadoAddEdit : Form
    {
        RentCarEntities db;
        bool edit = false;
        public FormEmpleadoAddEdit(Empleado empleado)
        {
            InitializeComponent();
            db = new RentCarEntities();
            if(empleado == null)
            {
                empleadoBindingSource.DataSource = new Empleado();
                var e = empleadoBindingSource.Current as Empleado;
                e.Estado = true;
                db.Empleadoes.Add(e);
            }
            else
            {
                label7.Text = "Editar";
                empleadoBindingSource.DataSource = empleado;
                edit = true;
            }
        }

        private void FormEmpleadoAddEdit_FormClosing(object sender, FormClosingEventArgs e)
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

                if (Convert.ToInt32(txtPorciento.Text) < 0)
                {
                    MessageBox.Show("Favor revise el limite.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPorciento.Focus();
                    return;
                }

                // validacion de cedula
                bool valida = Utilidades.validaCedula(txtCedula.Text);
                if (!valida)
                {
                    MessageBox.Show("Favor revise la cedula.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCedula.Focus();
                    e.Cancel = true;
                    return;
                }

                //completar edicion
                if (edit)
                {
                    var em = empleadoBindingSource.Current as Empleado;
                    var ee = db.Empleadoes.Where(q => q.ID.Equals(em.ID)).FirstOrDefault();
                    ee.FechaIngreso = em.FechaIngreso;
                    ee.Nombre = em.Nombre;
                    ee.PorcientoComision = em.PorcientoComision;
                    ee.Tanda = em.Tanda;
                }

                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
