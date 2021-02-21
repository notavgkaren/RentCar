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
    public partial class FormClienteAddEdit : Form
    {
        RentCarEntities db;
        bool edit = false;
        public FormClienteAddEdit(Cliente cliente)
        {
            InitializeComponent();
            db = new RentCarEntities();
            if (cliente == null)
            {
                clienteBindingSource.DataSource = new Cliente();
                var c = clienteBindingSource.Current as Cliente;
                c.Estado = true;
                db.Clientes.Add(c);
            }
            else
            {
                label7.Text = "Editar";
                clienteBindingSource.DataSource = cliente;
                edit = true;
            }
        }

        private void FormClienteAddEdit_FormClosing(object sender, FormClosingEventArgs e)
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

                if (Convert.ToInt32(txtLimite.Text)< 0)
                {
                    MessageBox.Show("Favor revise el limite.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLimite.Focus();
                    return;
                }

                // validacion de cedula
                bool valida = Utilidades.validaCedula(txtCedula.Text);
                if (!valida)
                {
                    MessageBox.Show("Favor revise la cedula.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCedula.Focus();
                    e.Cancel = true;
                    return;
                }

                //completar edicion
                if (edit)
                {
                    var c = clienteBindingSource.Current as Cliente;
                    var cc = db.Clientes.Where(q => q.ID.Equals(c.ID)).FirstOrDefault();
                    cc.Cedula = c.Cedula;
                    cc.LimiteCredito = c.LimiteCredito;
                    cc.Nombre = c.Nombre;
                    cc.TarjetaCR = c.TarjetaCR;
                    cc.TipoPersona = c.TipoPersona;
                }
                
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
