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
    public partial class FormVehiculoCombustible : Form
    {
        RentCarEntities db;
        public FormVehiculoCombustible()
        {
            InitializeComponent();
        }

        private void FormVehiculoCombustible_Load(object sender, EventArgs e)
        {
            db = new RentCarEntities();
            tipoCombustibleVehiculoBindingSource.DataSource = db.Tipo_Combustible_Vehiculo.ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (FormVehiculoCombustibleAddEdit form = new FormVehiculoCombustibleAddEdit(null))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    tipoCombustibleVehiculoBindingSource.DataSource = db.Tipo_Combustible_Vehiculo.ToList();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var obj = tipoCombustibleVehiculoBindingSource.Current;
            if (obj == null)
                return;

            using (FormVehiculoCombustibleAddEdit form = new FormVehiculoCombustibleAddEdit(obj as Tipo_Combustible_Vehiculo))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    tipoCombustibleVehiculoBindingSource.DataSource = db.Tipo_Combustible_Vehiculo.ToList();
                }
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (tipoCombustibleVehiculoBindingSource.Current != null)
            {
                var confirm = MessageBox.Show("Seguro que desea desactivar el combustible?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    var obj = tipoCombustibleVehiculoBindingSource.Current as Tipo_Combustible_Vehiculo;
                    obj.Estado = false;
                    db.SaveChanges();
                    tipoCombustibleVehiculoBindingSource.DataSource = db.Tipo_Combustible_Vehiculo.ToList();
                }
            }
        }
    }
}
