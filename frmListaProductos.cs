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
    public partial class frmListaProductos : Form
    {
        public frmListaProductos()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Text != "")
            {
                dgListaProductos.Rows.Clear();
                string sentencia = $"SELECT * FROM TBLPRODUCTO WHERE strNombre like '%{txtBuscarProducto.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia); // Ejecutar la consulta

                foreach (DataRow row in dt.Rows)
                {
                    dgListaProductos.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
                    txtBuscarProducto.Text = ""; // Borrar contenido
                }
            }
            else
            {
                Llenar_Grid();
            }
        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            Llenar_Grid();
        }

        private void btnSalirLProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoLProductos_Click(object sender, EventArgs e)
        {
            frmEditarProductos Producto = new frmEditarProductos();
            Producto.IdProducto = 0;
            Producto.ShowDialog();
        }

        private void dgListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgListaProductos.Columns[e.ColumnIndex].Name == "borrarProducto")
            {
                int posActual = dgListaProductos.CurrentRow.Index;

                if (MessageBox.Show($"Seguro de borrar {dgListaProductos[1, posActual].Value.ToString()}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // MessageBox.Show($"Borrando índice {e.RowIndex} ID {dgCliente[0, posActual].Value.ToString()}");

                    int IdProducto = Convert.ToInt32(dgListaProductos[0, posActual].Value.ToString());
                    string sentencia = $"Exec Eliminar_Producto '{IdProducto}'";
                    string mensaje = Acceso.EjecutarComando(sentencia);
                    MessageBox.Show(mensaje);
                }
            }
            if (dgListaProductos.Columns[e.ColumnIndex].Name == "editarProducto")
            {
                int posActual = dgListaProductos.CurrentRow.Index;
                frmEditarProductos Producto = new frmEditarProductos();
                Producto.IdProducto = int.Parse(dgListaProductos[0, posActual].Value.ToString());
                Producto.ShowDialog();
            }

            Llenar_Grid();
        }

        DataTable dt = new DataTable();

        Acceso_datos Acceso = new Acceso_datos();
        public void Llenar_Grid()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    // dgListaProductos.Rows.Add(i, $"Producto {i}XXX{i * 2} ", $"{i * 12345}", $"{i * 456}");

            //}

            try
            {
                dgListaProductos.Rows.Clear();

                // Acceso.AbrirBd(); [dbo].[TBLPRODUCTO]

                string sentencia = $"SELECT IdProducto, StrNombre, NumPrecioVenta, NumStock, IdCategoria FROM [[DBFACTURAS]]].[dbo].[TBLPRODUCTO];";
                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    dgListaProductos.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }


    }
}
