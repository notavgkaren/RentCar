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
    public partial class FormVehiculoTipoAddEdit : Form
    {
        RentCarEntities db;
        bool edit = false;
        public FormVehiculoTipoAddEdit(Tipo_Vehiculo tv)
        {
            InitializeComponent();
            db = new RentCarEntities();
            if (tv == null)
            {
                tipoVehiculoBindingSource.DataSource = new Tipo_Vehiculo();
                var t = tipoVehiculoBindingSource.Current as Tipo_Vehiculo;
                t.Estado = true;
                db.Tipo_Vehiculo.Add(t);
            }
            else
            {
                label7.Text = "Editar";
                tipoVehiculoBindingSource.DataSource = tv;
                edit = true;
            }
        }

        private void FormVehiculoTipoAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
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
                    var t = tipoVehiculoBindingSource.Current as Tipo_Vehiculo;
                    var tt = db.Tipo_Vehiculo.Where(q => q.ID.Equals(t.ID)).FirstOrDefault();
                    tt.Descripcion = t.Descripcion;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
