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
    public partial class FormVehiculo : Form
    {
        RentCarEntities db;
        public FormVehiculo()
        {
            InitializeComponent();
        }
        private void FormVehiculo_Load(object sender, EventArgs e)
        {
            db = new RentCarEntities();
            vehiculoBindingSource.DataSource = db.Vehiculoes.ToList();
        }

        private void btnVerMas_Click(object sender, EventArgs e)
        {
            var form = new FormVehiculoVerMas();
            form.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (FormVehiculoAddEdit form = new FormVehiculoAddEdit(null))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    vehiculoBindingSource.DataSource = db.Vehiculoes.ToList();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var obj = vehiculoBindingSource.Current;
            if (obj == null)
                return;

            using (FormVehiculoAddEdit form = new FormVehiculoAddEdit(obj as Vehiculo))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    vehiculoBindingSource.DataSource = db.Vehiculoes.ToList();
                }
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (vehiculoBindingSource.Current != null)
            {
                var confirm = MessageBox.Show("Seguro que desea desactivar el vehiculo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    var obj = vehiculoBindingSource.Current as Vehiculo;
                    obj.Estado = "Inactivo";
                    db.SaveChanges();
                    vehiculoBindingSource.DataSource = db.Vehiculoes.ToList();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text;
            var query = db.Vehiculoes.Where(q => q.Descripcion.Contains(buscar)).ToList();
            vehiculoBindingSource.DataSource = query;
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            vehiculoBindingSource.DataSource = db.Vehiculoes.ToList();
            txtBuscar.Clear();
        }
    }
}
