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
    public partial class frmAdminSeguridad : Form
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        private void btnSalirAdminSeg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdminSeguridad_Load(object sender, EventArgs e)
        {
            LlenarComboEmpleados();
		}

		private void LlenarComboEmpleados()
		{
			DataTable dt = new DataTable();
			Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos
			dt = Acceso.CargarTabla("TBLEMPLEADO", "");
			cboEmpladoAdminSeg.DataSource = dt;
			cboEmpladoAdminSeg.DisplayMember = "strNombre";
			cboEmpladoAdminSeg.ValueMember = "IdEmpleado";
			Acceso.CerrarBd();

			// Consultar();
		}

		private Boolean validar()
		{
			Boolean errorCampos = true;

			ErrorProvider MensajeError = new ErrorProvider();
			if (txtUsuarioAdminSeg.Text == string.Empty)
			{
				MensajeError.SetError(txtUsuarioAdminSeg, "debe ingresar un valor de Usuario");
				txtUsuarioAdminSeg.Focus();
				errorCampos = false;
			}
			else
			{
				MensajeError.SetError(txtUsuarioAdminSeg, "");
			}

			if (txtContrasenaAdminSeg.Text == "")
			{
				MensajeError.SetError(txtContrasenaAdminSeg, "Debe ingresar un valor de cédula");
				txtContrasenaAdminSeg.Focus();
				errorCampos = false;
			}

			else
			{
				MensajeError.SetError(txtContrasenaAdminSeg, "");
			}
			return errorCampos;
		}

		 private bool IsNumeric(string num)
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

		public bool Guardar()
		{
			Boolean actualizado = false;
			if (validar())
			{
				try
				{
					Acceso_datos Acceso = new Acceso_datos();
					string sentencia = $"Exec actualizar_Seguridad '{Convert.ToInt32(cboEmpladoAdminSeg.SelectedValue)}' ,'{txtUsuarioAdminSeg.Text}','{txtContrasenaAdminSeg.Text}','{DateTime.Now}','Javier'";
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

		public void Eliminar()
		{
			Acceso_datos Acceso = new Acceso_datos();
			string sentencia = $"Exec Eliminar_Seguridad '{ Convert.ToInt32(cboEmpladoAdminSeg.SelectedValue)}'";
			MessageBox.Show(Acceso.EjecutarComando(sentencia));
			txtUsuarioAdminSeg.Text = "";
			txtContrasenaAdminSeg.Text = "";
		}

		public void Consultar()
		{
			DataTable dt = new DataTable();
			string sentencia = "SELECT StrUsuario, StrClave FROM TBLSEGURIDAD WHERE IdEmpleado=" + cboEmpladoAdminSeg.SelectedValue.ToString();

			Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos
			dt = Acceso.EjecutarComandoDatos(sentencia);
			if (dt.Rows.Count > 0)
			{
				txtUsuarioAdminSeg.Text = dt.Rows[0]["StrUsuario"].ToString();
				txtContrasenaAdminSeg.Text = dt.Rows[0]["StrClave"].ToString();
			}
			else
			{
				MessageBox.Show("El usuario no dispone de datos de ingreso");
				txtUsuarioAdminSeg.Text = "";
				txtContrasenaAdminSeg.Text = "";
			}
		}

        private void btnNuevoAdmin_Click(object sender, EventArgs e)
        {
			Consultar();		
        }

        private void btnEliminarAdmin_Click(object sender, EventArgs e)
        {
			Eliminar();
        }

        private void btnActualizarAdminSeg_Click(object sender, EventArgs e)
        {
			Guardar();
        }
    }
}
