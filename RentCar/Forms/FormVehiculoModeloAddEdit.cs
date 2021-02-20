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
    public partial class FormVehiculoModeloAddEdit : Form
    {
        RentCarEntities db;
        bool edit = false;
        public FormVehiculoModeloAddEdit(Modelo_Vehiculo modelo)
        {
            InitializeComponent();
            db = new RentCarEntities();
            //llenar combobox
            #region fill combobox
            var marcas = db.Marca_Vehiculo.Where(q=>q.Estado.ToString()=="true").Select(q => q).ToList();
            cbMarca.DisplayMember = "Descripcion";
            cbMarca.ValueMember = "ID";
            cbMarca.DataSource = marcas;
            #endregion
            //crear o editar
            if (modelo == null)
            {
                modeloVehiculoBindingSource.DataSource = new Modelo_Vehiculo();
                var m = modeloVehiculoBindingSource.Current as Modelo_Vehiculo;
                m.Estado = true;
            }
            else
            {
                label7.Text = "Editar";
                modeloVehiculoBindingSource.DataSource = modelo;
                edit = true;
            }
        }

        private void FormVehiculoModeloAddEdit_FormClosing(object sender, FormClosingEventArgs e)
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
                var c = modeloVehiculoBindingSource.Current as Modelo_Vehiculo;                
                c.marca = (int?)cbMarca.SelectedValue;
                if (edit)
                {                    
                    var cc = db.Modelo_Vehiculo.Where(q => q.ID.Equals(c.ID)).FirstOrDefault();
                    cc.Descripcion = c.Descripcion;
                    cc.marca = c.marca;                    
                }
                if (!edit)
                {
                    db.Modelo_Vehiculo.Add(c);
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
