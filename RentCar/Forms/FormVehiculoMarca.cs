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
    public partial class FormVehiculoMarca : Form
    {
        RentCarEntities db;
        public FormVehiculoMarca()
        {
            InitializeComponent();
        }

        private void FormVehiculoMarca_Load(object sender, EventArgs e)
        {
            db = new RentCarEntities();
            marcaVehiculoBindingSource.DataSource = db.Marca_Vehiculo.ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using(FormVehiculoMarcaAddEdit form = new FormVehiculoMarcaAddEdit(null))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    marcaVehiculoBindingSource.DataSource = db.Marca_Vehiculo.ToList(); 
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var m = marcaVehiculoBindingSource.Current;
            if (m == null) return;

            using (FormVehiculoMarcaAddEdit form = new FormVehiculoMarcaAddEdit(m as Marca_Vehiculo))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    marcaVehiculoBindingSource.DataSource = db.Marca_Vehiculo.ToList();
                }
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (marcaVehiculoBindingSource.Current != null)
            {
                var confirm = MessageBox.Show("Seguro que desea desactivar el cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    var obj = marcaVehiculoBindingSource.Current as Marca_Vehiculo;
                    obj.Estado = false;
                    db.SaveChanges();
                    marcaVehiculoBindingSource.DataSource = db.Marca_Vehiculo.ToList();
                }
            }
        }
    }
}
