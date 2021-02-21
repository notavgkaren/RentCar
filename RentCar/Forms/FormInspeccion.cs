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
    public partial class FormInspeccion : Form
    {
        RentCarEntities db;
        public FormInspeccion()
        {
            InitializeComponent();
            db = new RentCarEntities();
            #region fill combobox
            //cb vehiculo
            var vehiculos = db.Vehiculoes.Where(q => q.Estado.ToString() == "Activo").Select(q => q).ToList();
            cbVehiculo.DisplayMember = "Descripcion";
            cbVehiculo.ValueMember = "ID";
            cbVehiculo.DataSource = vehiculos;
            //cb empleados
            var empleados = db.Empleadoes.Where(q => q.Estado.ToString() == "true").Select(q => q).ToList();
            cbEmpleado.DisplayMember = "Nombre";
            cbEmpleado.ValueMember = "ID";
            cbEmpleado.DataSource = empleados;
            #endregion

            inspeccionBindingSource.DataSource = new Inspeccion();
            var n = inspeccionBindingSource.Current as Inspeccion;
        }

        private void FormInspeccion_FormClosing(object sender, FormClosingEventArgs e)
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
                var c = inspeccionBindingSource.Current as Inspeccion;
                c.Empleado = (int?)cbEmpleado.SelectedValue;
                c.Vehiculo = (int?)cbVehiculo.SelectedValue;
                c.CantCombustible = (string)cbCombustible.SelectedText;
                c.Fecha = DateTime.Now;

                db.Inspeccions.Add(c);                
                db.SaveChanges();

                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
