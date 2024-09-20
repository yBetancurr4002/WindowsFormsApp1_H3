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
    public partial class frmRolEmpleados : Form
    {
        public frmRolEmpleados()
        {
            InitializeComponent();
        }

        public int IdRol { get; set; }

        private void frmRolEmpleados_Load(object sender, EventArgs e)
        {
            if (IdRol == 0)
            {
                lblTituloRoles.Text = "Ingreso nuevo Rol";
            }
            else
            {
                lblTituloRoles.Text = "Modificar Rol";
                txtIdRolEmpleado.Text = IdRol.ToString();
                txtNombreRolEmpleados.Text = "Rol XXYYZZ";
                txtDescripcionRolEmpleados.Text = "Morbi tristique senectus et netus et malesuada. Nisl nisi scelerisque eu ultrices vitae auctor eu. Eget nulla facilisi etiam dignissim diam quis. Mi eget mauris pharetra et ultrices neque ornare aenean. Hac habitasse platea dictumst vestibulum rhoncus. Lacus laoreet non curabitur gravida arcu ac. Fermentum et sollicitudin ac orci phasellus egestas tellus. Arcu cursus euismod quis viverra nibh cras pulvinar mattis nunc. Consequat id porta nibh venenatis cras sed felis eget. Amet mauris commodo quis imperdiet massa tincidunt. Mauris pharetra et ultrices neque ornare aenean euismod. Neque laoreet suspendisse interdum consectetur libero.";
            }
        }

        private void btnActualizarRolEmpleado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Actualizados");
        }
    }
}
