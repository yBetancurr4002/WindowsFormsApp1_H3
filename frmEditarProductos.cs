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
    public partial class frmEditarProductos : Form
    {
        public frmEditarProductos()
        {
            InitializeComponent();
        }

        private void btnSalirProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int IdProducto { get; set; }
        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();


        private void frmEditarProductos_Load(object sender, EventArgs e)
        {
            //if (IdProducto == 0)
            //{
            //    lblTituloProductos.Text = "Ingreso nuevo Producto";
            //}
            //else
            //{
            //    lblTituloProductos.Text = "Modificar Producto";
            //    txtCodigoProductos.Text = IdProducto.ToString();
            //    txtCompraProducto.Text = "$100.000";
            //    txtVentaProducto.Text = "$123.456";
            //    // txtDireccionEmpleado.Text = "Clle xxx";
            //    txtDetalleProductos.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.";
            //}

            LlenarProducto();
            LlenarComboCategorias();
        }

        private void LlenarProducto()
        {
            if (IdProducto == 0)
            {
                lblTituloProductos.Text = "Ingreso nuevo producto";
            }
            else
            {
                // Actualizar información
                lblTituloProductos.Text = "Actualización de cliente";

                string sentencia = $"SELECT * FROM TBLPRODUCTO WHERE IdProducto = {IdProducto}";
                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    txtNombreProducto.Text = row[1].ToString();
                    txtCodigoProductos.Text = row[2].ToString();
                    txtCompraProducto.Text = row[3].ToString();
                    txtVentaProducto.Text = row[4].ToString();
                    txtIdCategoria.Text = row[5].ToString();
                    txtStockProductos.Text = row[8].ToString();
                    txtRutaImagenProductos.Text = row[7].ToString();
                    txtDetalleProductos.Text = row[6].ToString();
                }
            }
        }

        private void btnActualizarProductos_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Datos Actualizados");
            Guardar();
            this.Close();
        }

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {

                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec actualizar_Producto {IdProducto},'{txtNombreProducto.Text}', '{txtCodigoProductos.Text}', '{txtCompraProducto.Text}', '{txtVentaProducto.Text}', '{txtIdCategoria.Text}', '{txtDetalleProductos.Text}', '{txtRutaImagenProductos.Text}', '{txtStockProductos.Text}', '{DateTime.Now.Date.ToString("MM/dd/yyyy")}', 'Javier'";

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
            if (txtNombreProducto.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreProducto, "debe ingresar el nombre del Producto");

                txtNombreProducto.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtNombreProducto, "");
            }
            if (txtCodigoProductos.Text == "")
            {
                MensajeError.SetError(txtCodigoProductos, "debe ingresar el código");
                txtCodigoProductos.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtCodigoProductos, ""); }
            if (!esNumerico(txtCodigoProductos.Text))
            {
                MensajeError.SetError(txtCodigoProductos, "El código debe ser numérico");
                txtCodigoProductos.Focus();
                return false;
            }
            MensajeError.SetError(txtCodigoProductos, "");
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

        private void LlenarComboCategorias()
        {
            DataTable dt = new DataTable();
            Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos
            dt = Acceso.CargarTabla("TBLCATEGORIA_PROD", "");
            cboCategoriaProductos.DataSource = dt;
            cboCategoriaProductos.DisplayMember = "StrDescripcion";
            cboCategoriaProductos.ValueMember = "IdCategoria";
            Acceso.CerrarBd();

            // Consultar();
        }
    }
}
