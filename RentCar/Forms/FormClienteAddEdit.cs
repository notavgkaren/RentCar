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
        public FormClienteAddEdit(Cliente cliente)
        {
            InitializeComponent();
            db = new RentCarEntities();
            if (cliente == null)
            {
                clienteBindingSource.DataSource = new Cliente();
                db.Clientes.Add(clienteBindingSource.Current as Cliente);
            }
            else
            {
                label7.Text = "Editar";
                clienteBindingSource.DataSource = cliente;
                //db.Clientes.Attach(clienteBindingSource.Current as Cliente);
            }
        }

        private void FormClienteAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Favor llene todos los campos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
