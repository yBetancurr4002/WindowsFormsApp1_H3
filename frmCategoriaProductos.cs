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
    public partial class frmCategoriaProductos : Form
    {
        public frmCategoriaProductos()
        {
            InitializeComponent();
        }

        public int IdCategoria { get; set; }
        
        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Datos Actualizados");
            Guardar();
            this.Close();
        }

        private void btnSalirCateogria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCategoriaProductos_Load(object sender, EventArgs e)
        {
            //if (IdCategoria == 0)
            //{
            //    lblTituloCategoria.Text = "Ingreso nueva Categoria";
            //}
            //else
            //{
            //    txtIdCategoria.Text = IdCategoria.ToString();
            //    txtNombreCategoria.Text = "Nombre de categoría XXYYZZ";

            //}
            LlenarCategoria();
        }

        private void LlenarCategoria()
        {
            if (IdCategoria == 0)
            {
                lblTituloCategoria.Text = "Ingresa nueva categoría";
            }
            else
            {
                lblTituloCategoria.Text = "Actualizar Categoría";

                // Senetencia SQL
                string sentencia = $"SELECT * FROM TBLCATEGORIA_PROD WHERE IdCategoria = {IdCategoria}";

                // Data table asignación
                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    txtNombreCategoria.Text = row[0].ToString();
                    txtDescripcionCategoria.Text = row[1].ToString();
                }
            }
        }

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {

                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec actualizar_CategoriaProducto {IdCategoria}, '{txtDescripcionCategoria.Text}', '{DateTime.Now.Date.ToString("MM/dd/yyyy")}', 'YEISON'";

                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);
                    actualizado = false;
                }
            }
            return actualizado;
        }

        ErrorProvider MensajeError = new ErrorProvider();

        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtNombreCategoria.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreCategoria, "debe ingresar el nombre de la categoría");

                txtNombreCategoria.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtNombreCategoria, "");
            }
            if (txtDescripcionCategoria.Text == "")
            {
                MensajeError.SetError(txtDescripcionCategoria, "debe ingresar la descripción");
                txtDescripcionCategoria.Focus();
                errorCampos = false;
            }
            else 
            { 
                MensajeError.SetError(txtDescripcionCategoria, ""); 
            }
            if (!esNumerico(txtNombreCategoria.Text))
            {
                MensajeError.SetError(txtDescripcionCategoria, "El nombre debe ser numérico");
                txtDescripcionCategoria.Focus();
                return false;
            }
            MensajeError.SetError(txtNombreCategoria, "");
            return errorCampos;
        }

        private bool esNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
