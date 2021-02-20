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
            //get vehiculos
            var ds = from vehiculo in db.Vehiculoes.Select(q => q)
                     join marca in db.Marca_Vehiculo.Select(q => q) 
                        on vehiculo.Marca_Vehiculo equals marca.ID
                     join modelo in db.Modelo_Vehiculo.Select(q=>q) 
                        on vehiculo.Modelo_Vehiculo equals modelo.ID
                     join tipo in db.Tipo_Vehiculo.Select(q=>q) 
                        on vehiculo.Tipo_Vehiculo equals tipo.ID
                     join combustible in db.Tipo_Combustible_Vehiculo.Select(q=>q) 
                        on vehiculo.Tipo_Combustible_Vehiculo equals combustible.ID
                     select new
                     {
                         ID = vehiculo.ID,
                         Descripcion = vehiculo.Descripcion,
                         Estado = vehiculo.Estado,
                         Tipo = tipo.Descripcion,
                         Marca = marca.Descripcion,
                         Modelo = modelo.Descripcion,
                         Combustible = combustible.Descripcion,
                         Placa = vehiculo.PlacaNum,
                         Chasis = vehiculo.ChasisNum,
                         Motor = vehiculo.MotorNum
                     };
            //map columns
            dataGridView1.DataSource = ds.ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (FormVehiculoAddEdit form = new FormVehiculoAddEdit(null))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    FormVehiculo_Load(sender,e);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //buscar objeto seleccionado en db
            int o = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
            var obj = db.Vehiculoes.Select(q => q).Where(q => q.ID == o).FirstOrDefault();
            if (obj == null) return;
            //mandar el objeto encontrado al form de edicion
            using (FormVehiculoAddEdit form = new FormVehiculoAddEdit(obj as Vehiculo))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    FormVehiculo_Load(sender, e);
                }
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            int o = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
            var obj = db.Vehiculoes.Select(q => q).Where(q => q.ID == o).FirstOrDefault();
            if (obj == null) return;

            var confirm = MessageBox.Show("Seguro que desea desactivar el vehiculo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                obj.Estado = "Inactivo";
                db.SaveChanges();
                FormVehiculo_Load(sender, e);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text;
            //get vehiculos
            var ds = from vehiculo in db.Vehiculoes.Select(q => q)
                     join marca in db.Marca_Vehiculo.Select(q => q)
                        on vehiculo.Marca_Vehiculo equals marca.ID
                     join modelo in db.Modelo_Vehiculo.Select(q => q)
                        on vehiculo.Modelo_Vehiculo equals modelo.ID
                     join tipo in db.Tipo_Vehiculo.Select(q => q)
                        on vehiculo.Tipo_Vehiculo equals tipo.ID
                     join combustible in db.Tipo_Combustible_Vehiculo.Select(q => q)
                        on vehiculo.Tipo_Combustible_Vehiculo equals combustible.ID
                     select new
                     {
                         ID = vehiculo.ID,
                         Descripcion = vehiculo.Descripcion,
                         Estado = vehiculo.Estado,
                         Tipo = tipo.Descripcion,
                         Marca = marca.Descripcion,
                         Modelo = modelo.Descripcion,
                         Combustible = combustible.Descripcion,
                         Placa = vehiculo.PlacaNum,
                         Chasis = vehiculo.ChasisNum,
                         Motor = vehiculo.MotorNum
                     };
            ds = ds.Where(q => q.Descripcion.Contains(buscar));
            //map columns
            dataGridView1.DataSource = ds.ToList();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            FormVehiculo_Load(sender, e);
            txtBuscar.Clear();
        }
        private void btnVerMas_Click(object sender, EventArgs e)
        {
            var form = new FormVehiculoVerMas();
            form.Show();
        }
    }
}
