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
    public partial class FormVehiculoTipo : Form
    {
        RentCarEntities db;
        public FormVehiculoTipo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using(FormVehiculoTipoAddEdit form = new FormVehiculoTipoAddEdit(null))
            {
                if (form.ShowDialog() == DialogResult.OK)
                    tipoVehiculoBindingSource.DataSource = db.Tipo_Vehiculo.ToList();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var tv = tipoVehiculoBindingSource.Current;
            if (tv == null) return;

            using(FormVehiculoTipoAddEdit form = new FormVehiculoTipoAddEdit(tv as Tipo_Vehiculo))
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    tipoVehiculoBindingSource.DataSource = db.Tipo_Vehiculo.ToList();
                }
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if(tipoVehiculoBindingSource != null)
            {
                var confirm = MessageBox.Show("Seguro que desea desactivar el tipo de vehiculo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    var tp = tipoVehiculoBindingSource.Current as Tipo_Vehiculo;
                    tp.Estado = false;
                    db.SaveChanges();
                    tipoVehiculoBindingSource.DataSource = db.Tipo_Vehiculo.ToList();
                }
            }
        }

        private void FormVehiculoTipo_Load(object sender, EventArgs e)
        {
            db = new RentCarEntities();
            tipoVehiculoBindingSource.DataSource = db.Tipo_Vehiculo.ToList();
        }
    }
}
