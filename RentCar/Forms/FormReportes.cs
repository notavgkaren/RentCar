using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.Forms
{
    public partial class FormReportes : Form
    {
        RentCarEntities db;
        public FormReportes()
        {
            InitializeComponent();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            db = new RentCarEntities();
            #region fill combobox
            //cb tipo vehiculo
            var vehiculos = db.Tipo_Vehiculo.Select(q => q).ToList();
            cbVehiculos.DisplayMember = "Descripcion";
            cbVehiculos.ValueMember = "ID";
            cbVehiculos.DataSource = vehiculos;
            //cb empleados
            var empleados = db.Empleadoes.Select(q => q).ToList();
            cbEmpleado.DisplayMember = "Nombre";
            cbEmpleado.ValueMember = "ID";
            cbEmpleado.DataSource = empleados;
            //cb vehiculo
            var clientes = db.Clientes.Select(q => q).ToList();
            cbCliente.DisplayMember = "Nombre";
            cbCliente.ValueMember = "ID";
            cbCliente.DataSource = clientes;
            #endregion
            //datasource
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var ds = from renta in db.Rentas.Select(q => q)
                     join empleado in db.Empleadoes.Select(q => q)
                         on renta.Empleado equals empleado.ID
                     join cliente in db.Clientes.Select(q => q)
                         on renta.Cliente equals cliente.ID
                     join vehiculo in db.Vehiculoes.Select(q => q)
                         on renta.Vehiculo equals vehiculo.ID
                    join tipoVehiculo in db.Tipo_Vehiculo.Select(q=>q)
                        on vehiculo.Tipo_Vehiculo equals tipoVehiculo.ID
                     select new
                     {
                         ID = renta.ID,
                         Vehiculo = vehiculo.Descripcion,
                         TipoVehiculo = tipoVehiculo.Descripcion,
                         Estado = renta.Estado,
                         Dias = renta.CantDias,
                         Renta = renta.FechaRenta,
                         Devolucion = renta.FechaDevolucion,
                         MontoDiario = renta.MontoDiario,
                         Cliente = cliente.Nombre,
                         Empleado = empleado.Nombre,
                         Comentario = renta.Comentario
                     };
            if (rbFechas.Checked)
            {
                DateTime inicio = dtp1.Value, final = dtp2.Value;
                ds = ds.Where(q => (q.Renta > inicio && q.Renta < final));
            }
            if (rbCliente.Checked)
            {
                ds = ds.Where(q => q.Cliente.Equals(cbCliente.Text));
            }
            if (rbEmpleados.Checked)
            {
                ds = ds.Where(q => q.Empleado.Equals(cbEmpleado.Text));
            }
            if (rbVehiculos.Checked)
            {
                ds = ds.Where(q => q.TipoVehiculo.Equals(cbVehiculos.Text));
            }
            //map columns
            dataGridView1.DataSource = ds.ToList();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            FormReportes_Load(sender, e);
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            var dt = (DataTable)dataGridView1.DataSource;

            #region export
            StringBuilder sb = new StringBuilder();
            foreach (DataRow dr in dt.Rows)
            {
                foreach (DataColumn dc in dt.Columns)
                    sb.Append(WriteCSV(dr[dc.ColumnName].ToString()) + ",");
                sb.Remove(sb.Length - 1, 1);
                sb.AppendLine();
            }
            File.WriteAllText(@"C:\Users\Aaron Martinez\Desktop\export.csv", sb.ToString());
            MessageBox.Show("Exportado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            #endregion
        }

        public static string WriteCSV(string input)
        {
            try
            {
                if (input == null)
                    return string.Empty;

                bool containsQuote = false;
                bool containsComma = false;
                int len = input.Length;
                for (int i = 0; i < len && (containsComma == false || containsQuote == false); i++)
                {
                    char ch = input[i];
                    if (ch == '"')
                        containsQuote = true;
                    else if (ch == ',')
                        containsComma = true;
                }

                if (containsQuote && containsComma)
                    input = input.Replace("\"", "\"\"");

                if (containsComma)
                    return "\"" + input + "\"";
                else
                    return input;
            }
            catch
            {
                throw;
            }
        }
    }
}
