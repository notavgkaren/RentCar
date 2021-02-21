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
    public partial class FormRenta : Form
    {
        RentCarEntities db;
        public FormRenta()
        {
            InitializeComponent();
        }

        private void FormRenta_Load(object sender, EventArgs e)
        {
            db = new RentCarEntities();
            //get rentas
            var ds = from renta in db.Rentas.Select(q => q)
                     join empleado in db.Empleadoes.Select(q => q)
                         on renta.Empleado equals empleado.ID
                     join cliente in db.Clientes.Select(q => q)
                         on renta.Cliente equals cliente.ID
                     join vehiculo in db.Vehiculoes.Select(q => q)
                         on renta.Vehiculo equals vehiculo.ID
                     select new
                     {
                         ID = renta.ID,
                         Vehiculo = vehiculo.Descripcion,
                         Estado = renta.Estado,
                         Dias = renta.CantDias,
                         Renta = renta.FechaRenta,
                         Devolucion = renta.FechaDevolucion,
                         MontoDiario = renta.MontoDiario,
                         Cliente = cliente.Nombre,
                         Empleado = empleado.Nombre,
                         Comentario = renta.Comentario
                     };
             //map columns
             dataGridView1.DataSource = ds.ToList();
        }

        private void btnRentar_Click(object sender, EventArgs e)
        {
            using(FormInspeccion form = new FormInspeccion())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (FormRentaAddEdit form1 = new FormRentaAddEdit(null))
                    {
                        if (form1.ShowDialog() == DialogResult.OK)
                        {
                            FormRenta_Load(sender, e);
                        }
                    }
                }
            }            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //buscar objeto seleccionado en la db
            int o = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
            var obj = db.Rentas.Select(q => q).Where(q => q.ID == o).FirstOrDefault();
            if (obj == null) return;
            //mandar el objeto encontrado al form de edicion
            using (FormRentaAddEdit form = new FormRentaAddEdit(obj as Renta))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    FormRenta_Load(sender, e);
                }
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            int o = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
            var obj = db.Rentas.Select(q => q).Where(q => q.ID == o).FirstOrDefault();
            if (obj == null) return;

            var confirm = MessageBox.Show("El vehiculo ha sido devuelto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                obj.Estado = false;
                obj.FechaDevolucion = DateTime.Now;
                var vehiculo = db.Vehiculoes.Select(q => q).Where(q => q.ID == obj.Vehiculo).FirstOrDefault();
                vehiculo.Estado = "Activo";
                db.SaveChanges();
                FormRenta_Load(sender, e);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text;
            //get rentas
            var ds = from renta in db.Rentas.Select(q => q)
                     join empleado in db.Empleadoes.Select(q => q)
                         on renta.Empleado equals empleado.ID
                     join cliente in db.Clientes.Select(q => q)
                         on renta.Cliente equals cliente.ID
                     join vehiculo in db.Vehiculoes.Select(q => q)
                         on renta.Vehiculo equals vehiculo.ID
                     select new
                     {
                         ID = renta.ID,
                         Vehiculo = vehiculo.Descripcion,
                         Estado = renta.Estado,
                         Dias = renta.CantDias,
                         Renta = renta.FechaRenta,
                         Devolucion = renta.FechaDevolucion,
                         MontoDiario = renta.MontoDiario,
                         Cliente = cliente.Nombre,
                         Empleado = empleado.Nombre,
                         Comentario = renta.Comentario
                     };
            ds = ds.Where(q => q.Vehiculo.Contains(buscar)
            ||q.Cliente.Contains(buscar)
            ||q.Empleado.Contains(buscar));
            //map columns
            dataGridView1.DataSource = ds.ToList();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            FormRenta_Load(sender, e);
            txtBuscar.Clear();
        }
    }
}
