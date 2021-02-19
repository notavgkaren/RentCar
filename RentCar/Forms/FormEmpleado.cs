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
    public partial class FormEmpleado : Form
    {
        RentCarEntities db;
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            db = new RentCarEntities();
            empleadoBindingSource.DataSource = db.Empleadoes.ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using(FormEmpleadoAddEdit form = new FormEmpleadoAddEdit(null))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    empleadoBindingSource.DataSource = db.Empleadoes.ToList();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var emp = empleadoBindingSource.Current;
            if (emp == null) return;

            using (FormEmpleadoAddEdit form = new FormEmpleadoAddEdit(emp as Empleado))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    empleadoBindingSource.DataSource = db.Empleadoes.ToList();
                }
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if(empleadoBindingSource.Current != null)
            {
                var confirm = MessageBox.Show("Seguro que desea desactivar el empleado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(confirm == DialogResult.Yes)
                {
                    var emp = empleadoBindingSource.Current as Empleado;
                    emp.Estado = false;
                    db.SaveChanges();
                    empleadoBindingSource.DataSource = db.Empleadoes.ToList();
                }

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text;
            var query = db.Empleadoes.Where(q => q.Nombre.Contains(buscar)).ToList();
            empleadoBindingSource.DataSource = query;
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            empleadoBindingSource.DataSource = db.Empleadoes.ToList();
            txtBuscar.Clear();
        }
    }
}
