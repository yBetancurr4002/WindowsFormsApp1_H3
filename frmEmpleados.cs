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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }

        public int IdEmplado { get; set; }

        private void btnSalirEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            if (IdEmplado == 0)
            {
                lblTituloEmpleado.Text = "Ingreso nuevo empleado";
            }
            else
            {
                lblTituloEmpleado.Text = "Modificar Empleado";
                txtIdEmpleado.Text = IdEmplado.ToString();
                txtNombreEmpleado.Text = "nombre 1 apellido";
                txtDocumentoEmpleado.Text = "123456";
                txtDireccionEmpleado.Text = "Clle xxx";
                txtTelEmpleado.Text = "98765432";
            }
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Actualizados");
        }
    }
}
