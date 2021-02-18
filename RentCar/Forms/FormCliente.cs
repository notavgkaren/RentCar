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

        //:(
        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
