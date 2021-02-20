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
    public partial class FormCliente : Form
    {
        RentCarEntities db;
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            db = new RentCarEntities();
            clienteBindingSource.DataSource = db.Clientes.ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using(FormClienteAddEdit form = new FormClienteAddEdit(null))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    clienteBindingSource.DataSource = db.Clientes.ToList();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var obj = clienteBindingSource.Current;
            if (obj == null)
                return;
            
            using (FormClienteAddEdit form = new FormClienteAddEdit(obj as Cliente))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    clienteBindingSource.DataSource = db.Clientes.ToList();
                }
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if(clienteBindingSource.Current != null)
            {
                var confirm = MessageBox.Show("Seguro que desea desactivar el cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(confirm == DialogResult.Yes)
                {
                    var obj = clienteBindingSource.Current as Cliente;
                    obj.Estado = false;
                    db.SaveChanges();
                    clienteBindingSource.DataSource = db.Clientes.ToList();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text;            
            var query = db.Clientes.Where(q => q.Nombre.Contains(buscar)).ToList();            
            clienteBindingSource.DataSource = query;           
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = db.Clientes.ToList();
            txtBuscar.Clear();
        }
    }
}
