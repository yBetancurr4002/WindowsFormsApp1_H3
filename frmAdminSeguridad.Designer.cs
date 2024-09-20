namespace WindowsFormsApp1
{
    partial class frmAdminSeguridad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlContenedorEmpleados = new System.Windows.Forms.Panel();
            this.cboEmpladoAdminSeg = new System.Windows.Forms.ComboBox();
            this.txtContrasenaAdminSeg = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEmpleadoAdminSeg = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsuarioAdminSeg = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnActualizarAdminSeg = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblTituloAdminSeg = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalirAdminSeg = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConsultarAdmin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminarAdmin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlContenedorEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedorEmpleados
            // 
            this.pnlContenedorEmpleados.Controls.Add(this.cboEmpladoAdminSeg);
            this.pnlContenedorEmpleados.Controls.Add(this.txtContrasenaAdminSeg);
            this.pnlContenedorEmpleados.Controls.Add(this.lblEmpleadoAdminSeg);
            this.pnlContenedorEmpleados.Controls.Add(this.txtUsuarioAdminSeg);
            this.pnlContenedorEmpleados.Location = new System.Drawing.Point(63, 89);
            this.pnlContenedorEmpleados.Name = "pnlContenedorEmpleados";
            this.pnlContenedorEmpleados.Size = new System.Drawing.Size(537, 207);
            this.pnlContenedorEmpleados.TabIndex = 5;
            // 
            // cboEmpladoAdminSeg
            // 
            this.cboEmpladoAdminSeg.FormattingEnabled = true;
            this.cboEmpladoAdminSeg.Location = new System.Drawing.Point(222, 32);
            this.cboEmpladoAdminSeg.Name = "cboEmpladoAdminSeg";
            this.cboEmpladoAdminSeg.Size = new System.Drawing.Size(277, 21);
            this.cboEmpladoAdminSeg.TabIndex = 13;
            // 
            // txtContrasenaAdminSeg
            // 
            this.txtContrasenaAdminSeg.Depth = 0;
            this.txtContrasenaAdminSeg.Hint = "Contraseña";
            this.txtContrasenaAdminSeg.Location = new System.Drawing.Point(34, 153);
            this.txtContrasenaAdminSeg.MaxLength = 32767;
            this.txtContrasenaAdminSeg.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContrasenaAdminSeg.Name = "txtContrasenaAdminSeg";
            this.txtContrasenaAdminSeg.PasswordChar = '\0';
            this.txtContrasenaAdminSeg.SelectedText = "";
            this.txtContrasenaAdminSeg.SelectionLength = 0;
            this.txtContrasenaAdminSeg.SelectionStart = 0;
            this.txtContrasenaAdminSeg.Size = new System.Drawing.Size(176, 23);
            this.txtContrasenaAdminSeg.TabIndex = 12;
            this.txtContrasenaAdminSeg.TabStop = false;
            this.txtContrasenaAdminSeg.UseSystemPasswordChar = false;
            // 
            // lblEmpleadoAdminSeg
            // 
            this.lblEmpleadoAdminSeg.AutoSize = true;
            this.lblEmpleadoAdminSeg.Depth = 0;
            this.lblEmpleadoAdminSeg.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmpleadoAdminSeg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmpleadoAdminSeg.Location = new System.Drawing.Point(30, 34);
            this.lblEmpleadoAdminSeg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpleadoAdminSeg.Name = "lblEmpleadoAdminSeg";
            this.lblEmpleadoAdminSeg.Size = new System.Drawing.Size(76, 19);
            this.lblEmpleadoAdminSeg.TabIndex = 11;
            this.lblEmpleadoAdminSeg.Text = "Empleado";
            // 
            // txtUsuarioAdminSeg
            // 
            this.txtUsuarioAdminSeg.Depth = 0;
            this.txtUsuarioAdminSeg.Hint = "Usuario";
            this.txtUsuarioAdminSeg.Location = new System.Drawing.Point(34, 98);
            this.txtUsuarioAdminSeg.MaxLength = 32767;
            this.txtUsuarioAdminSeg.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuarioAdminSeg.Name = "txtUsuarioAdminSeg";
            this.txtUsuarioAdminSeg.PasswordChar = '\0';
            this.txtUsuarioAdminSeg.SelectedText = "";
            this.txtUsuarioAdminSeg.SelectionLength = 0;
            this.txtUsuarioAdminSeg.SelectionStart = 0;
            this.txtUsuarioAdminSeg.Size = new System.Drawing.Size(176, 23);
            this.txtUsuarioAdminSeg.TabIndex = 1;
            this.txtUsuarioAdminSeg.TabStop = false;
            this.txtUsuarioAdminSeg.UseSystemPasswordChar = false;
            // 
            // btnActualizarAdminSeg
            // 
            this.btnActualizarAdminSeg.AutoSize = true;
            this.btnActualizarAdminSeg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarAdminSeg.Depth = 0;
            this.btnActualizarAdminSeg.Icon = null;
            this.btnActualizarAdminSeg.Location = new System.Drawing.Point(63, 330);
            this.btnActualizarAdminSeg.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarAdminSeg.Name = "btnActualizarAdminSeg";
            this.btnActualizarAdminSeg.Primary = true;
            this.btnActualizarAdminSeg.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarAdminSeg.TabIndex = 12;
            this.btnActualizarAdminSeg.Text = "ACTUALIZAR";
            this.btnActualizarAdminSeg.UseVisualStyleBackColor = true;
            this.btnActualizarAdminSeg.Click += new System.EventHandler(this.btnActualizarAdminSeg_Click);
            // 
            // lblTituloAdminSeg
            // 
            this.lblTituloAdminSeg.AutoSize = true;
            this.lblTituloAdminSeg.Depth = 0;
            this.lblTituloAdminSeg.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloAdminSeg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloAdminSeg.Location = new System.Drawing.Point(74, 30);
            this.lblTituloAdminSeg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloAdminSeg.Name = "lblTituloAdminSeg";
            this.lblTituloAdminSeg.Size = new System.Drawing.Size(329, 19);
            this.lblTituloAdminSeg.TabIndex = 13;
            this.lblTituloAdminSeg.Text = "ADMINISTRACIÓN DE USUARIOS DEL SISTEMA";
            // 
            // btnSalirAdminSeg
            // 
            this.btnSalirAdminSeg.AutoSize = true;
            this.btnSalirAdminSeg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirAdminSeg.Depth = 0;
            this.btnSalirAdminSeg.Icon = null;
            this.btnSalirAdminSeg.Location = new System.Drawing.Point(542, 330);
            this.btnSalirAdminSeg.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirAdminSeg.Name = "btnSalirAdminSeg";
            this.btnSalirAdminSeg.Primary = true;
            this.btnSalirAdminSeg.Size = new System.Drawing.Size(58, 36);
            this.btnSalirAdminSeg.TabIndex = 14;
            this.btnSalirAdminSeg.Text = "SALIR";
            this.btnSalirAdminSeg.UseVisualStyleBackColor = true;
            this.btnSalirAdminSeg.Click += new System.EventHandler(this.btnSalirAdminSeg_Click);
            // 
            // btnConsultarAdmin
            // 
            this.btnConsultarAdmin.AutoSize = true;
            this.btnConsultarAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultarAdmin.Depth = 0;
            this.btnConsultarAdmin.Icon = null;
            this.btnConsultarAdmin.Location = new System.Drawing.Point(232, 330);
            this.btnConsultarAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultarAdmin.Name = "btnConsultarAdmin";
            this.btnConsultarAdmin.Primary = true;
            this.btnConsultarAdmin.Size = new System.Drawing.Size(100, 36);
            this.btnConsultarAdmin.TabIndex = 15;
            this.btnConsultarAdmin.Text = "CONSULTAR";
            this.btnConsultarAdmin.UseVisualStyleBackColor = true;
            this.btnConsultarAdmin.Click += new System.EventHandler(this.btnNuevoAdmin_Click);
            // 
            // btnEliminarAdmin
            // 
            this.btnEliminarAdmin.AutoSize = true;
            this.btnEliminarAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarAdmin.Depth = 0;
            this.btnEliminarAdmin.Icon = null;
            this.btnEliminarAdmin.Location = new System.Drawing.Point(391, 330);
            this.btnEliminarAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarAdmin.Name = "btnEliminarAdmin";
            this.btnEliminarAdmin.Primary = true;
            this.btnEliminarAdmin.Size = new System.Drawing.Size(83, 36);
            this.btnEliminarAdmin.TabIndex = 16;
            this.btnEliminarAdmin.Text = "ELIMINAR";
            this.btnEliminarAdmin.UseVisualStyleBackColor = true;
            this.btnEliminarAdmin.Click += new System.EventHandler(this.btnEliminarAdmin_Click);
            // 
            // frmAdminSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 406);
            this.Controls.Add(this.btnEliminarAdmin);
            this.Controls.Add(this.btnConsultarAdmin);
            this.Controls.Add(this.btnSalirAdminSeg);
            this.Controls.Add(this.lblTituloAdminSeg);
            this.Controls.Add(this.btnActualizarAdminSeg);
            this.Controls.Add(this.pnlContenedorEmpleados);
            this.Name = "frmAdminSeguridad";
            this.Text = "frmAdminSeguridad";
            this.Load += new System.EventHandler(this.frmAdminSeguridad_Load);
            this.pnlContenedorEmpleados.ResumeLayout(false);
            this.pnlContenedorEmpleados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedorEmpleados;
        private MaterialSkin.Controls.MaterialLabel lblEmpleadoAdminSeg;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuarioAdminSeg;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarAdminSeg;
        private MaterialSkin.Controls.MaterialLabel lblTituloAdminSeg;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirAdminSeg;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContrasenaAdminSeg;
        private System.Windows.Forms.ComboBox cboEmpladoAdminSeg;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultarAdmin;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminarAdmin;
    }
}