using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmListaEmpleados : Form
    {
        public frmListaEmpleados()
        {
            InitializeComponent();
        }

        private void dgListaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgListaEmpleados.Columns[e.ColumnIndex].Name == "borrarEmpleado")
            {
                int posActual = dgListaEmpleados.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"Borrando índice {e.RowIndex} ID {dgListaEmpleados[0, posActual].Value.ToString()}");
                }
            }
            if (dgListaEmpleados.Columns[e.ColumnIndex].Name == "editarEmpleado")
            {
                int posActual = dgListaEmpleados.CurrentRow.Index;
                frmEmpleados Empleado = new frmEmpleados();
                Empleado.IdEmplado = int.Parse(dgListaEmpleados[0, posActual].Value.ToString());
                Empleado.ShowDialog();
            }
        }

        private void frmListaEmpleados_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        public void llenarGrid()
        {
            for (int i = 0; i < 10; i++)
            {
                dgListaEmpleados.Rows.Add(i, $"Nombre {i} Apellido 1 Apellido 2", $"{i * 12345}", $"{i * 456}");
            }
        }

        private void btnSalirEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleados Empleado = new frmEmpleados();
            Empleado.IdEmplado = 0;
            Empleado.ShowDialog();
        }
    }
}
