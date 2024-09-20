using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace WindowsFormsApp1
{
    public partial class frmPrincipal : MaterialForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void Principal_Click(object sender, EventArgs e)
        {

        } 

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmListaClientes ListaCliente = new frmListaClientes();
            AbrirForm(ListaCliente);
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AbrirForm (Form formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle= FormBorderStyle.None;
            this.pnlContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmListaProductos ListaProductos = new frmListaProductos();
            AbrirForm(ListaProductos);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmListaCategorias ListaCategorias = new frmListaCategorias();
            AbrirForm(ListaCategorias);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmListaFacturas listaFacturas = new frmListaFacturas();
            AbrirForm(listaFacturas);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            frmInformes NuevoInforme = new frmInformes();
            AbrirForm(NuevoInforme);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmListaEmpleados listaEmpleados = new frmListaEmpleados();
            AbrirForm(listaEmpleados);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmListaRoles ListaRoles = new frmListaRoles();
            AbrirForm(ListaRoles);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            frmAdminSeguridad AdminSeguridad = new frmAdminSeguridad();
            AbrirForm(AdminSeguridad);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmAyuda Ayuda = new frmAyuda();
            AbrirForm(Ayuda);
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            frmAcercaDe AcercaDe = new frmAcercaDe();
            AbrirForm(AcercaDe);
        }
    }
}
