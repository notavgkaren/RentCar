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
    public partial class FormVehiculoAddEdit : Form
    {
        RentCarEntities db;
        bool edit = false;

        public FormVehiculoAddEdit(Vehiculo vehiculo)
        {
            InitializeComponent();
            db = new RentCarEntities();
            #region fill combobox
            //cb tipo vehiculo
            var tipos = db.Tipo_Vehiculo.Where(q => q.Estado.ToString() == "true").Select(q => q).ToList();
            cbTipo.DisplayMember = "Descripcion";
            cbTipo.ValueMember = "ID";
            cbTipo.DataSource = tipos;
            //cb marca
            var marcas = db.Marca_Vehiculo.Where(q => q.Estado.ToString() == "true").Select(q => q).ToList();
            cbMarca.DisplayMember = "Descripcion";
            cbMarca.ValueMember = "ID";
            cbMarca.DataSource = marcas;
            //cb modelo
            cambiarModelo();
            //cb combustible
            var combustible = db.Tipo_Combustible_Vehiculo.Where(q => q.Estado.ToString() == "true").Select(q => q).ToList();
            cbCombustible.DisplayMember = "Descripcion";
            cbCombustible.ValueMember = "ID";
            cbCombustible.DataSource = combustible;
            #endregion
            //crear o editar
            if (vehiculo == null)
            {
                vehiculoBindingSource.DataSource = new Vehiculo();
                var c = vehiculoBindingSource.Current as Vehiculo;
                c.Estado = "Activo";
            }
            else
            {
                label7.Text = "Editar";
                vehiculoBindingSource.DataSource = vehiculo;
                edit = true;
            }
        }

        private void FormVehiculoAddEdit_FormClosing(object sender, FormClosingEventArgs e)
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

                //completar edicion
                var c = vehiculoBindingSource.Current as Vehiculo;
                c.Tipo_Combustible_Vehiculo = (int?)cbCombustible.SelectedValue;
                c.Tipo_Vehiculo = (int?)cbTipo.SelectedValue;
                c.Marca_Vehiculo = (int?)cbMarca.SelectedValue;
                c.Modelo_Vehiculo = (int?)cbModelo.SelectedValue;
                if (edit)
                {                    
                    var cc = db.Vehiculoes.Where(q => q.ID.Equals(c.ID)).FirstOrDefault();
                    cc.Descripcion = c.Descripcion;
                    cc.ChasisNum = c.ChasisNum;
                    cc.MotorNum = c.MotorNum;
                    cc.PlacaNum = c.PlacaNum;
                    cc.Tipo_Combustible_Vehiculo = c.Tipo_Combustible_Vehiculo;
                    cc.Tipo_Vehiculo = c.Tipo_Vehiculo;
                    cc.Marca_Vehiculo = c.Marca_Vehiculo;
                    cc.Modelo_Vehiculo = c.Modelo_Vehiculo;
                }
                if (!edit)
                {
                    db.Vehiculoes.Add(c);
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }

        private void cambiarModelo()
        {
            var marcaSeleccionada = (int?)cbMarca.SelectedValue;
            var modelos = db.Modelo_Vehiculo.Where(q => q.Estado.ToString() == "true")
                .Where(q => q.marca == marcaSeleccionada)
                .Select(q => q)
                .ToList();
            cbModelo.DisplayMember = "Descripcion";
            cbModelo.ValueMember = "ID";
            cbModelo.DataSource = modelos;
        } 

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambiarModelo();
        }
    }
}
