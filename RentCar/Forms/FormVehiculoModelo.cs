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
    public partial class FormVehiculoModelo : Form
    {
        RentCarEntities db;
        public FormVehiculoModelo()
        {
            InitializeComponent();
        }

        private void FormVehiculoModelo_Load(object sender, EventArgs e)
        {
            db = new RentCarEntities();
            //var m = db.Modelo_Vehiculo.Select(q => q.marca);
            modeloVehiculoBindingSource1.DataSource = db.Modelo_Vehiculo.ToList();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using(FormVehiculoModeloAddEdit form = new FormVehiculoModeloAddEdit(null))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    modeloVehiculoBindingSource1.DataSource = db.Clientes.ToList();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var m = modeloVehiculoBindingSource1.Current;
            if (m == null) return;

            using (FormVehiculoModeloAddEdit form = new FormVehiculoModeloAddEdit(m as Modelo_Vehiculo))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    modeloVehiculoBindingSource1.DataSource = db.Clientes.ToList();
                }
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (modeloVehiculoBindingSource1.Current != null)
            {
                var confirm = MessageBox.Show("Seguro que desea desactivar el modelo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    var obj = modeloVehiculoBindingSource1.Current as Modelo_Vehiculo;
                    obj.Estado = false;
                    db.SaveChanges();
                    modeloVehiculoBindingSource1.DataSource = db.Modelo_Vehiculo.ToList();
                }
            }
        }
    }
}
