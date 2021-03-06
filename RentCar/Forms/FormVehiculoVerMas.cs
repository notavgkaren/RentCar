﻿using System;
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
    public partial class FormVehiculoVerMas : Form
    {
        public FormVehiculoVerMas()
        {
            InitializeComponent();
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            var form = new FormVehiculoTipo();
            form.Show();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            var form = new FormVehiculoMarca();
            form.Show();
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            var form = new FormVehiculoModelo();
            form.Show();
        }

        private void btnCombustible_Click(object sender, EventArgs e)
        {
            var form = new FormVehiculoCombustible();
            form.Show();
        }
    }
}
