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
            //get modelos
            var ds = from modelo in db.Modelo_Vehiculo.Select(q => q)
                           join marca in db.Marca_Vehiculo.Select(q => q) on modelo.marca equals marca.ID
                           select new
                           {
                               ID = modelo.ID,
                               Marca = marca.Descripcion,
                               Descripcion = modelo.Descripcion,
                               Estado = modelo.Estado
                           };
            //map columns
            dataGridView1.DataSource = ds.ToList();   
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {            
            using (FormVehiculoModeloAddEdit form = new FormVehiculoModeloAddEdit(null))
            {                
                if (form.ShowDialog() == DialogResult.OK)
                {
                    FormVehiculoModelo_Load(sender, e);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //buscar objeto seleccionado en db
            int o = (int) dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
            var obj = db.Modelo_Vehiculo.Select(q => q).Where(q => q.ID == o).FirstOrDefault();
            if (obj == null) return;

            using (FormVehiculoModeloAddEdit form = new FormVehiculoModeloAddEdit(obj as Modelo_Vehiculo))
            {

                if (form.ShowDialog() == DialogResult.OK)
                {
                    FormVehiculoModelo_Load(sender, e);
                }
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            int o = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
            var obj = db.Modelo_Vehiculo.Select(q => q).Where(q => q.ID == o).FirstOrDefault();
            if (obj == null) return;

            var confirm = MessageBox.Show("Seguro que desea desactivar el modelo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                obj.Estado = false;
                db.SaveChanges();
                FormVehiculoModelo_Load(sender, e);
            }
            
        }
    }
}
