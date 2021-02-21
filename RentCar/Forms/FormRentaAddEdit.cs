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
    public partial class FormRentaAddEdit : Form
    {
        RentCarEntities db;
        bool edit = false;
        int vehiculo = 1;
        public FormRentaAddEdit(Renta renta)
        {
            InitializeComponent();
            db = new RentCarEntities();
            #region fill combobox
            //cb vehiculo
            var vehiculos = db.Vehiculoes.Where(q => q.Estado.ToString() == "Activo").Select(q => q).ToList();
            cbVehiculo.DisplayMember = "Descripcion";
            cbVehiculo.ValueMember = "ID";
            cbVehiculo.DataSource = vehiculos;
            //cb empleados
            var empleados = db.Empleadoes.Where(q => q.Estado.ToString() == "true").Select(q => q).ToList();
            cbEmpleado.DisplayMember = "Nombre";
            cbEmpleado.ValueMember = "ID";
            cbEmpleado.DataSource = empleados;
            //cb vehiculo
            var clientes = db.Clientes.Where(q => q.Estado.ToString() == "true").Select(q => q).ToList();
            cbCliente.DisplayMember = "Nombre";
            cbCliente.ValueMember = "ID";
            cbCliente.DataSource = clientes;
            #endregion
            //crear o editar
            if (renta == null)
            {
                //fijar el cb de vehiculo
                var v = db.Inspeccions.Select(q => q).OrderByDescending(q => q.ID).FirstOrDefault();
                v.Estado = "Rentado";
                vehiculo = (int)v.Vehiculo;
                cbVehiculo.SelectedValue = vehiculo;
                cbVehiculo.Enabled = false;

                rentaBindingSource.DataSource = new Renta();
                var c = rentaBindingSource.Current as Renta;
                c.Estado = true;
            }
            else
            {
                label7.Text = "Editar";
                rentaBindingSource.DataSource = renta;
                edit = true;
            }
        }

        private void FormRentaAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                //validacion de campos vacios
                foreach (Control item in this.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        if (string.IsNullOrEmpty(item.Text))
                        {
                            MessageBox.Show("Favor llene todos los campos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            item.Focus();
                            e.Cancel = true;
                            return;
                        }
                    }
                }
                //validacion campos numericos
                if (Convert.ToInt32(txtDias.Text) < 0)
                {
                    MessageBox.Show("Favor revise los dias.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDias.Focus();
                    e.Cancel = true;
                    return;
                }
                if (Convert.ToInt32(txtMonto.Text) < 0)
                {
                    MessageBox.Show("Favor revise el Monto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMonto.Focus();
                    e.Cancel = true;
                    return;
                }
                //completar edicion
                var c = rentaBindingSource.Current as Renta;
                c.Cliente = (int?)cbCliente.SelectedValue;
                c.Empleado = (int?)cbEmpleado.SelectedValue;
                c.Vehiculo = vehiculo;
                c.FechaRenta = DateTime.Now;
                if (edit)
                {
                    var cc = db.Rentas.Where(q => q.ID.Equals(c.ID)).FirstOrDefault();
                    cc.Cliente = c.Cliente;
                    cc.Empleado = c.Empleado;
                    cc.Vehiculo = c.Vehiculo;
                    cc.Comentario = c.Comentario;
                    cc.FechaRenta = c.FechaRenta;
                    cc.MontoDiario = c.MontoDiario;
                    cc.CantDias = c.CantDias;
                }
                if (!edit)
                {
                    db.Rentas.Add(c);
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
            
        }
    }
}
