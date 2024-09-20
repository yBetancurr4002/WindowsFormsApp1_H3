namespace WindowsFormsApp1
{
    partial class frmRolEmpleados
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
            this.lblTituloRoles = new MaterialSkin.Controls.MaterialLabel();
            this.pnlContenedorEmpleados = new System.Windows.Forms.Panel();
            this.lblDescripcionRol = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescripcionRolEmpleados = new System.Windows.Forms.TextBox();
            this.txtNombreRolEmpleados = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdRolEmpleado = new System.Windows.Forms.TextBox();
            this.btnActualizarRolEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirRolEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlContenedorEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloRoles
            // 
            this.lblTituloRoles.AutoSize = true;
            this.lblTituloRoles.Depth = 0;
            this.lblTituloRoles.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloRoles.Location = new System.Drawing.Point(188, 47);
            this.lblTituloRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloRoles.Name = "lblTituloRoles";
            this.lblTituloRoles.Size = new System.Drawing.Size(150, 19);
            this.lblTituloRoles.TabIndex = 2;
            this.lblTituloRoles.Text = "ROL DE EMPLEADOS";
            // 
            // pnlContenedorEmpleados
            // 
            this.pnlContenedorEmpleados.Controls.Add(this.lblDescripcionRol);
            this.pnlContenedorEmpleados.Controls.Add(this.txtDescripcionRolEmpleados);
            this.pnlContenedorEmpleados.Controls.Add(this.txtNombreRolEmpleados);
            this.pnlContenedorEmpleados.Controls.Add(this.txtIdRolEmpleado);
            this.pnlContenedorEmpleados.Location = new System.Drawing.Point(31, 121);
            this.pnlContenedorEmpleados.Name = "pnlContenedorEmpleados";
            this.pnlContenedorEmpleados.Size = new System.Drawing.Size(537, 271);
            this.pnlContenedorEmpleados.TabIndex = 4;
            // 
            // lblDescripcionRol
            // 
            this.lblDescripcionRol.AutoSize = true;
            this.lblDescripcionRol.Depth = 0;
            this.lblDescripcionRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescripcionRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescripcionRol.Location = new System.Drawing.Point(54, 122);
            this.lblDescripcionRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcionRol.Name = "lblDescripcionRol";
            this.lblDescripcionRol.Size = new System.Drawing.Size(200, 19);
            this.lblDescripcionRol.TabIndex = 11;
            this.lblDescripcionRol.Text = "Descripción detallada del rol";
            // 
            // txtDescripcionRolEmpleados
            // 
            this.txtDescripcionRolEmpleados.Location = new System.Drawing.Point(34, 144);
            this.txtDescripcionRolEmpleados.Multiline = true;
            this.txtDescripcionRolEmpleados.Name = "txtDescripcionRolEmpleados";
            this.txtDescripcionRolEmpleados.Size = new System.Drawing.Size(448, 107);
            this.txtDescripcionRolEmpleados.TabIndex = 10;
            // 
            // txtNombreRolEmpleados
            // 
            this.txtNombreRolEmpleados.Depth = 0;
            this.txtNombreRolEmpleados.Hint = "Nombre del Rol";
            this.txtNombreRolEmpleados.Location = new System.Drawing.Point(34, 69);
            this.txtNombreRolEmpleados.MaxLength = 32767;
            this.txtNombreRolEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreRolEmpleados.Name = "txtNombreRolEmpleados";
            this.txtNombreRolEmpleados.PasswordChar = '\0';
            this.txtNombreRolEmpleados.SelectedText = "";
            this.txtNombreRolEmpleados.SelectionLength = 0;
            this.txtNombreRolEmpleados.SelectionStart = 0;
            this.txtNombreRolEmpleados.Size = new System.Drawing.Size(294, 23);
            this.txtNombreRolEmpleados.TabIndex = 1;
            this.txtNombreRolEmpleados.TabStop = false;
            this.txtNombreRolEmpleados.UseSystemPasswordChar = false;
            // 
            // txtIdRolEmpleado
            // 
            this.txtIdRolEmpleado.Location = new System.Drawing.Point(34, 16);
            this.txtIdRolEmpleado.Name = "txtIdRolEmpleado";
            this.txtIdRolEmpleado.Size = new System.Drawing.Size(53, 20);
            this.txtIdRolEmpleado.TabIndex = 0;
            // 
            // btnActualizarRolEmpleado
            // 
            this.btnActualizarRolEmpleado.AutoSize = true;
            this.btnActualizarRolEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarRolEmpleado.Depth = 0;
            this.btnActualizarRolEmpleado.Icon = null;
            this.btnActualizarRolEmpleado.Location = new System.Drawing.Point(129, 423);
            this.btnActualizarRolEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarRolEmpleado.Name = "btnActualizarRolEmpleado";
            this.btnActualizarRolEmpleado.Primary = true;
            this.btnActualizarRolEmpleado.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarRolEmpleado.TabIndex = 5;
            this.btnActualizarRolEmpleado.Text = "ACTUALIZAR";
            this.btnActualizarRolEmpleado.UseVisualStyleBackColor = true;
            this.btnActualizarRolEmpleado.Click += new System.EventHandler(this.btnActualizarRolEmpleado_Click);
            // 
            // btnSalirRolEmpleado
            // 
            this.btnSalirRolEmpleado.AutoSize = true;
            this.btnSalirRolEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirRolEmpleado.Depth = 0;
            this.btnSalirRolEmpleado.Icon = null;
            this.btnSalirRolEmpleado.Location = new System.Drawing.Point(370, 423);
            this.btnSalirRolEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirRolEmpleado.Name = "btnSalirRolEmpleado";
            this.btnSalirRolEmpleado.Primary = true;
            this.btnSalirRolEmpleado.Size = new System.Drawing.Size(58, 36);
            this.btnSalirRolEmpleado.TabIndex = 6;
            this.btnSalirRolEmpleado.Text = "SALIR";
            this.btnSalirRolEmpleado.UseVisualStyleBackColor = true;
            // 
            // frmRolEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 490);
            this.Controls.Add(this.btnSalirRolEmpleado);
            this.Controls.Add(this.btnActualizarRolEmpleado);
            this.Controls.Add(this.pnlContenedorEmpleados);
            this.Controls.Add(this.lblTituloRoles);
            this.Name = "frmRolEmpleados";
            this.Text = "frmRolEmpleados";
            this.Load += new System.EventHandler(this.frmRolEmpleados_Load);
            this.pnlContenedorEmpleados.ResumeLayout(false);
            this.pnlContenedorEmpleados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloRoles;
        private System.Windows.Forms.Panel pnlContenedorEmpleados;
        private System.Windows.Forms.TextBox txtDescripcionRolEmpleados;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreRolEmpleados;
        private System.Windows.Forms.TextBox txtIdRolEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblDescripcionRol;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarRolEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirRolEmpleado;
    }
}