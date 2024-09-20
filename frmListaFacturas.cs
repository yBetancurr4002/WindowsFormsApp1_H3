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
    public partial class frmListaFacturas : Form
    {
        public frmListaFacturas()
        {
            InitializeComponent();
        }

        private void btnSalirLFactura_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevaLFactura_Click(object sender, EventArgs e)
        {
            frmFacturas Factura = new frmFacturas();
            Factura.IdFactura = 0;
            Factura.ShowDialog();
        }

        private void dgListaFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgListaFacturas.Columns[e.ColumnIndex].Name == "borrarFactura")
            {
                int posActual = dgListaFacturas.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"Borrando índice {e.RowIndex} ID {dgListaFacturas[0, posActual].Value.ToString()}");
                }
            }
            if (dgListaFacturas.Columns[e.ColumnIndex].Name == "editarFactura")
            {
                int posActual = dgListaFacturas.CurrentRow.Index;
                frmFacturas Factura = new frmFacturas();
                Factura.IdFactura = int.Parse(dgListaFacturas[0, posActual].Value.ToString());
                Factura.ShowDialog();
            }
        }

        public void llenarGrid()
        {
            for (int i = 0; i < 10; i++)
            {
                dgListaFacturas.Rows.Add(i, $"{i + 1}XXX{i * 2} ", $" Nombre{i + 1} Apellido {i + 1}", "01/01/2023", $"$10{i * 2}", "PAGADA");
            }
        }

        private void frmListaFacturas_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }
    }
}
