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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        // Conectar el frm a la BD

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string Respuesta;
            
            if (txtUsuario.Text != "" && txtContrasena.Text != string.Empty)
            {
                //  if (txtUsuario.Text == "admin" && txtContrasena.Text == "1234")
                Acceso_datos Acceso = new Acceso_datos();

                Respuesta = Acceso.ValidarUsuario(txtUsuario.Text, txtContrasena.Text);

                if (Respuesta != "")
                {
                    MessageBox.Show("Bienvenido " + Respuesta + "!");

                    // Abrir el Formulario principal

                    frmPrincipal NuevoFrmPrincipal = new frmPrincipal();
                    this.Hide(); // Oculta login
                    NuevoFrmPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA! 🚨");
                    txtUsuario.Text = "";
                    txtContrasena.Text = "";
                }
            }            
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
