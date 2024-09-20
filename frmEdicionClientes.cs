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
    public partial class frmEdicionClientes : Form
    {
        public frmEdicionClientes()
        {
            InitializeComponent();
        }

        private void txtNumClient_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int IdCliente { get; set; }
        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();

        private void frmEdicionClientes_Load(object sender, EventArgs e)
        {
            //if (IdCliente == 0)
            //{
            //    lblTituloCliente.Text = "Ingreso nuevo cliente";
            //}
            //else
            //{
            //    lblTituloCliente.Text = "Modificar cliente";
            //    txtIdCliente.Text = IdCliente.ToString();
            //    txtNombreCliente.Text = "nombre 1 apellido";
            //    txtDocClient.Text = "123456";
            //    // txtDireccion.Text = "Clle xxx";
            //    txtNumClient.Text = "98765432";
            //}

            LlenarCliente();
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            
            Guardar();
            this.Close();
            // MessageBox.Show("Datos Actualizados");
        }

        private void LlenarCliente()
        {
            if (IdCliente == 0)
            {
                lblTituloCliente.Text = "Ingreso nuevo cliente";
                lblNombreCliente.Text = "";
                lblDocCliente.Text = "";
                lblTelCliente.Text = "";
                lblEmailCliente.Text = "";
                lblDireccionCliente.Text = "";
            }
            else
            {
                // Actualizar información
                lblTituloCliente.Text = "Actualización de cliente";

                string sentencia = $"SELECT * FROM TBLCLIENTES WHERE IdCliente = {IdCliente}";
                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    txtNombreCliente.Text = row[1].ToString();
                    txtDocClient.Text = row[2].ToString();
                    txtNumClient.Text = row[4].ToString();
                    txtDireccion.Text = row[3].ToString();
                    txtEmail.Text = row[5].ToString();
                }
            }
        }

        private void txtNombreCliente_Click(object sender, EventArgs e)
        {

        }

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                // {DateTime.Now.ToString()}
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec actualizar_Cliente {IdCliente},'{txtNombreCliente.Text}', '{txtDocClient.Text}', '{txtDireccion.Text}', '{txtNumClient.Text}', '{txtEmail.Text}',  'YEISON', '{DateTime.Now.Date.ToString("MM/dd/yyyy")}'";
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
            if (txtNombreCliente.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreCliente, "debe ingresar el nombre del Cliente");
                txtNombreCliente.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombreCliente, ""); }
            if (txtDocClient.Text == "")
            {
                MensajeError.SetError(txtDocClient, "debe ingresar el documento");
                txtDocClient.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtDocClient, ""); }
            if (!esNumerico(txtDocClient.Text))
            {
                MensajeError.SetError(txtDocClient, "El Documento debe ser numerico");
                txtDocClient.Focus();
                return false;
            }
            MensajeError.SetError(txtDocClient, "");
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
