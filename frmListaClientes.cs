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
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }

        //public void llenarGrid()
        //{
        //    for (int i = 0; i < 20; i++)
        //    {
        //        dgCliente.Rows.Add(i, $"Nombre {i} Apellido 1 Apellido 2", $"{i * 12345}", $"{i * 456}");
        //    }
        //}

        //private void frmListaClientes_Load(object sender, EventArgs e)
        //{
        //    llenarGrid();
        //}

        

        
        private void btnNuevoClientes_Click(object sender, EventArgs e)
        {
            frmEdicionClientes Cliente = new frmEdicionClientes();
            Cliente.IdCliente = 0;
            Cliente.ShowDialog();
            Llenar_Grid();
        }

        private void btnSalirClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClientes.Columns[e.ColumnIndex].Name == "Borrar")
            {
                int posActual = dgClientes.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"Borrando índice {e.RowIndex} ID {dgClientes[0, posActual].Value.ToString()}");
                }

            }
            if (dgClientes.Columns[e.ColumnIndex].Name == "Editar") 
            {
                int posActual = dgClientes.CurrentRow.Index;
                frmEdicionClientes Cliente = new frmEdicionClientes();
                Cliente.IdCliente = int.Parse(dgClientes[0, posActual].Value.ToString());
                Cliente.ShowDialog();
            }
        }

        private void frmListaClientes_Load_1(object sender, EventArgs e)
        {
            Llenar_Grid();
        }

        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmEdicionClientes Cliente = new frmEdicionClientes();
            Cliente.IdCliente = 0;
            Cliente.ShowDialog();
            Llenar_Grid();
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCliente.Columns[e.ColumnIndex].Name == "borrarCliente")
            {
                int posActual = dgCliente.CurrentRow.Index;

                if (MessageBox.Show($"Seguro de borrar {dgCliente[1, posActual].Value.ToString()}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // MessageBox.Show($"Borrando índice {e.RowIndex} ID {dgCliente[0, posActual].Value.ToString()}");

                    int IdCliente = Convert.ToInt32(dgCliente[0, posActual].Value.ToString());
                    string sentencia = $"Exec Eliminar_cliente '{IdCliente}'";
                    string mensaje = Acceso.EjecutarComando(sentencia);
                    MessageBox.Show(mensaje);
                }
            }
            if (dgCliente.Columns[e.ColumnIndex].Name == "editarCliente")
            {
                int posActual = dgCliente.CurrentRow.Index;

                frmEdicionClientes Cliente = new frmEdicionClientes();
                Cliente.IdCliente = int.Parse(dgCliente[0, posActual].Value.ToString());
                Cliente.ShowDialog();
            }

            Llenar_Grid();
        }

        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();

        private void Llenar_Grid()
        {
            try
            {
                dgCliente.Rows.Clear();

                // Acceso.AbrirBd();

                string sentencia = $"SELECT IdCliente, StrNombre, NumDocumento, StrTelefono FROM [[DBFACTURAS]]].[dbo].[TBLCLIENTES];";
                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    dgCliente.Rows.Add(row[0], row[1], row[2], row[3]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtBuscarCliente.Text != "")
            {
                dgCliente.Rows.Clear();
                string sentencia = $"SELECT * FROM TBLCLIENTES WHERE strNombre like '%{txtBuscarCliente.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia); // Ejecutar la consulta

                foreach (DataRow row in dt.Rows)
                {
                    dgCliente.Rows.Add(row[0], row[1], row[2], row[3]);
                    txtBuscarCliente.Text = ""; // Borrar contenido
                }
            }
            else
            {
                Llenar_Grid();
            }
        }
        
    }
}
