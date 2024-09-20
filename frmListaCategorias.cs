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
    public partial class frmListaCategorias : Form
    {
        public frmListaCategorias()
        {
            InitializeComponent();
        }

        private void btnSalirCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoCategoria_Click(object sender, EventArgs e)
        {
            frmCategoriaProductos CategoriaProducto = new frmCategoriaProductos();
            CategoriaProducto.IdCategoria = 0;
            CategoriaProducto.ShowDialog();
        }

        private void frmListaCategorias_Load(object sender, EventArgs e)
        {
            // llenarGridCategoria();
            Llenar_Grid();
        }

        public void llenarGridCategoria()
        {
            var categories = new List<string> { "<categories>", "Son rojos", "Son azules", "Son verdes", "Son violestas" };

            int i = 0;
            foreach (var category in categories)
            {
                dgCategoriaProductos.Rows.Add(i, $"Categoría {i + 1}", $"{category}");
                i++;
            }
            // for (int i = 0; i < 10; i++)
            // {
            //     dgCategoriaProductos.Rows.Add(i, $"Producto {i}XXX{i*2} ", $"{i * 12345}", $"{i * 456}");
            // }
        }

        private void dgCategoriaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgCategoriaProductos.Columns[e.ColumnIndex].Name == "borrarCategoria")
            //{
            //    int posActual = dgCategoriaProductos.CurrentRow.Index;
            //    if (MessageBox.Show("Seguro de borrar", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        MessageBox.Show($"Borrando índice {e.RowIndex} ID {dgCategoriaProductos[0, posActual].Value.ToString()}");
            //    }
            //}
            //if (dgCategoriaProductos.Columns[e.ColumnIndex].Name == "editarCategoria")
            //{
            //    int posActual = dgCategoriaProductos.CurrentRow.Index;
            //    frmCategoriaProductos CategoriaProducto = new frmCategoriaProductos();
            //    CategoriaProducto.IdCategoria = int.Parse(dgCategoriaProductos[0, posActual].Value.ToString());
            //    CategoriaProducto.ShowDialog();
            //}
            if (dgCategoriaProductos.Columns[e.ColumnIndex].Name == "borrarCategoria")
            {
                int posActual = dgCategoriaProductos.CurrentRow.Index;
                if (MessageBox.Show("Seguro de borrar", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int IdCategoria = Convert.ToInt32(dgCategoriaProductos[0, posActual].Value.ToString());
                    string sentencia = $"Exec Eliminar_CategoriaProducto '{IdCategoria}'";
                    string mensaje = Acceso.EjecutarComando(sentencia);
                    MessageBox.Show(mensaje);
                }
            }
            if (dgCategoriaProductos.Columns[e.ColumnIndex].Name == "editarCategoria")
            {
                int posActual = dgCategoriaProductos.CurrentRow.Index;
                frmCategoriaProductos CategoriaProducto = new frmCategoriaProductos();
                CategoriaProducto.IdCategoria = int.Parse(dgCategoriaProductos[0, posActual].Value.ToString());
                CategoriaProducto.ShowDialog();
            }
        }

        DataTable dt = new DataTable();

        Acceso_datos Acceso = new Acceso_datos();

        private void Llenar_Grid()
        {
            try
            {
                dgCategoriaProductos.Rows.Clear();

                string sentencia = $"SELECT IdCategoria, StrDescripcion FROM [[DBFACTURAS]]].[dbo].[TBLCATEGORIA_PROD];";

                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    dgCategoriaProductos.Rows.Add(row[0], row[0], row[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            if (txtBuscarCategoria.Text != "")
            {
                dgCategoriaProductos.Rows.Clear();
                string sentencia = $"SELECT * FROM TBLCATEGORIA_PROD WHERE strDescripcion like '%{txtBuscarCategoria.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    dgCategoriaProductos.Rows.Add(row[0], row[0], row[1]);
                    txtBuscarCategoria.Text = "";
                }
            }
            else
            {
                Llenar_Grid();
            }
        }
    }
}
