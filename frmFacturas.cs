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
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void btnSalirFactura_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int IdFactura { get; set; }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            if (IdFactura == 0)
            {
                lblTituloFactura.Text = "Ingreso nueva Factura";
            }
            else
            {
                lblTituloFactura.Text = "Modificar Factura";
                txtNumFactura.Text = IdFactura.ToString();
                txtDescuentoFactura.Text = "$100.000";
                txtIvaFactura.Text = "19%";
                txtTotalFactura.Text = "119.000";
            }
        }

        private void btnActualizarFactura_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Actualizados");
        }
    }
}
