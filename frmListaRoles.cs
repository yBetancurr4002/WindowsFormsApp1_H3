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
    public partial class frmListaRoles : Form
    {
        public frmListaRoles()
        {
            InitializeComponent();
        }

        private void btnSalirLRoles_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaRoles_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void btnNuevoLRoles_Click(object sender, EventArgs e)
        {
            frmRolEmpleados Rol = new frmRolEmpleados();
            Rol.IdRol = 0;
            Rol.ShowDialog();
        }

        private void dgListaRolEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgListaRolEmpleados.Columns[e.ColumnIndex].Name == "borrarRoles")
            {
                int posActual = dgListaRolEmpleados.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"Borrando índice {e.RowIndex} ID {dgListaRolEmpleados[0, posActual].Value.ToString()}");
                }
            }
            if (dgListaRolEmpleados.Columns[e.ColumnIndex].Name == "editarRoles")
            {
                int posActual = dgListaRolEmpleados.CurrentRow.Index;
                frmRolEmpleados Rol = new frmRolEmpleados();
                Rol.IdRol = int.Parse(dgListaRolEmpleados[0, posActual].Value.ToString());
                Rol.ShowDialog();
            }
        }
        public void llenarGrid()
        {
            for (int i = 0; i < 20; i++)
            {
                dgListaRolEmpleados.Rows.Add(i, $"{i + 1}XXX{i * 2} ", $" Rol {i + 1} Función {i + 1 * i}");
            }
        }
    }
}
