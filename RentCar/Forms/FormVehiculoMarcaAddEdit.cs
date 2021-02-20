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
    public partial class FormVehiculoMarcaAddEdit : Form
    {
        RentCarEntities db;
        bool edit;
        public FormVehiculoMarcaAddEdit(Marca_Vehiculo marca)
        {
            InitializeComponent();
            db = new RentCarEntities();
            if (marca == null)
            {
                marcaVehiculoBindingSource.DataSource = new Marca_Vehiculo();
                var c = marcaVehiculoBindingSource.Current as Marca_Vehiculo;
                c.Estado = true;
                db.Marca_Vehiculo.Add(c);
            }
            else
            {
                label7.Text = "Editar";
                marcaVehiculoBindingSource.DataSource = marca;
                edit = true;
            }
        }

        private void FormVehiculoMarcaAddEdit_FormClosing(object sender, FormClosingEventArgs e)
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
                    var m = marcaVehiculoBindingSource.Current as Marca_Vehiculo;
                    var mm = db.Marca_Vehiculo.Where(q => q.ID.Equals(m.ID)).FirstOrDefault();
                    mm.Descripcion = m.Descripcion;                    
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
