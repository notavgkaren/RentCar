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
    public partial class FormVehiculoCombustibleAddEdit : Form
    {
        RentCarEntities db;
        bool edit = false;
        public FormVehiculoCombustibleAddEdit(Tipo_Combustible_Vehiculo comb)
        {
            InitializeComponent();
            db = new RentCarEntities();
            if (comb == null)
            {
                tipoCombustibleVehiculoBindingSource.DataSource = new Tipo_Combustible_Vehiculo();
                var c = tipoCombustibleVehiculoBindingSource.Current as Tipo_Combustible_Vehiculo;
                c.Estado = true;
                db.Tipo_Combustible_Vehiculo.Add(c);
            }
            else
            {
                label7.Text = "Editar";
                tipoCombustibleVehiculoBindingSource.DataSource = comb;
                edit = true;
            }
        }

        private void FormVehiculoCombustibleAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                //validacion de campos vacios
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Favor llene todos los campos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescripcion.Focus();
                    e.Cancel = true;
                    return;
                }

                //completar edicion
                if (edit)
                {
                    var c = tipoCombustibleVehiculoBindingSource.Current as Tipo_Combustible_Vehiculo;
                    var cc = db.Tipo_Combustible_Vehiculo.Where(q => q.ID.Equals(c.ID)).FirstOrDefault();
                    cc.Descripcion = c.Descripcion;                    
                }

                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
