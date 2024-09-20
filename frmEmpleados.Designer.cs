namespace WindowsFormsApp1
{
    partial class frmEmpleados
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
            this.dtpFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtDatosEmpleado = new System.Windows.Forms.TextBox();
            this.lblDatosEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.lblRetiroEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.lblIngresoEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.lblRolEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmailEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccionEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDocumentoEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.lblTituloEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.btnActualizarEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlContenedorEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedorEmpleados
            // 
            this.pnlContenedorEmpleados.Controls.Add(this.dtpFechaRetiro);
            this.pnlContenedorEmpleados.Controls.Add(this.dtpFechaIngreso);
            this.pnlContenedorEmpleados.Controls.Add(this.comboBox1);
            this.pnlContenedorEmpleados.Controls.Add(this.txtDatosEmpleado);
            this.pnlContenedorEmpleados.Controls.Add(this.lblDatosEmpleado);
            this.pnlContenedorEmpleados.Controls.Add(this.lblRetiroEmpleado);
            this.pnlContenedorEmpleados.Controls.Add(this.lblIngresoEmpleado);
            this.pnlContenedorEmpleados.Controls.Add(this.lblRolEmpleado);
            this.pnlContenedorEmpleados.Controls.Add(this.txtEmailEmpleado);
            this.pnlContenedorEmpleados.Controls.Add(this.txtTelEmpleado);
            this.pnlContenedorEmpleados.Controls.Add(this.txtDireccionEmpleado);
            this.pnlContenedorEmpleados.Controls.Add(this.txtDocumentoEmpleado);
            this.pnlContenedorEmpleados.Controls.Add(this.txtNombreEmpleado);
            this.pnlContenedorEmpleados.Controls.Add(this.txtIdEmpleado);
            this.pnlContenedorEmpleados.Location = new System.Drawing.Point(27, 86);
            this.pnlContenedorEmpleados.Name = "pnlContenedorEmpleados";
            this.pnlContenedorEmpleados.Size = new System.Drawing.Size(742, 271);
            this.pnlContenedorEmpleados.TabIndex = 0;
            // 
            // dtpFechaRetiro
            // 
            this.dtpFechaRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRetiro.Location = new System.Drawing.Point(547, 118);
            this.dtpFechaRetiro.Name = "dtpFechaRetiro";
            this.dtpFechaRetiro.Size = new System.Drawing.Size(124, 20);
            this.dtpFechaRetiro.TabIndex = 13;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(547, 85);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(124, 20);
            this.dtpFechaIngreso.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(547, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // txtDatosEmpleado
            // 
            this.txtDatosEmpleado.Location = new System.Drawing.Point(420, 182);
            this.txtDatosEmpleado.Multiline = true;
            this.txtDatosEmpleado.Name = "txtDatosEmpleado";
            this.txtDatosEmpleado.Size = new System.Drawing.Size(319, 69);
            this.txtDatosEmpleado.TabIndex = 10;
            // 
            // lblDatosEmpleado
            // 
            this.lblDatosEmpleado.AutoSize = true;
            this.lblDatosEmpleado.Depth = 0;
            this.lblDatosEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDatosEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatosEmpleado.Location = new System.Drawing.Point(416, 149);
            this.lblDatosEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDatosEmpleado.Name = "lblDatosEmpleado";
            this.lblDatosEmpleado.Size = new System.Drawing.Size(130, 19);
            this.lblDatosEmpleado.TabIndex = 9;
            this.lblDatosEmpleado.Text = "Datos adicionales";
            // 
            // lblRetiroEmpleado
            // 
            this.lblRetiroEmpleado.AutoSize = true;
            this.lblRetiroEmpleado.Depth = 0;
            this.lblRetiroEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRetiroEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRetiroEmpleado.Location = new System.Drawing.Point(416, 120);
            this.lblRetiroEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRetiroEmpleado.Name = "lblRetiroEmpleado";
            this.lblRetiroEmpleado.Size = new System.Drawing.Size(93, 19);
            this.lblRetiroEmpleado.TabIndex = 8;
            this.lblRetiroEmpleado.Text = "Fecha Retiro";
            // 
            // lblIngresoEmpleado
            // 
            this.lblIngresoEmpleado.AutoSize = true;
            this.lblIngresoEmpleado.Depth = 0;
            this.lblIngresoEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIngresoEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIngresoEmpleado.Location = new System.Drawing.Point(416, 87);
            this.lblIngresoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIngresoEmpleado.Name = "lblIngresoEmpleado";
            this.lblIngresoEmpleado.Size = new System.Drawing.Size(103, 19);
            this.lblIngresoEmpleado.TabIndex = 7;
            this.lblIngresoEmpleado.Text = "Fecha Ingreso";
            // 
            // lblRolEmpleado
            // 
            this.lblRolEmpleado.AutoSize = true;
            this.lblRolEmpleado.Depth = 0;
            this.lblRolEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRolEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRolEmpleado.Location = new System.Drawing.Point(416, 56);
            this.lblRolEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRolEmpleado.Name = "lblRolEmpleado";
            this.lblRolEmpleado.Size = new System.Drawing.Size(102, 19);
            this.lblRolEmpleado.TabIndex = 6;
            this.lblRolEmpleado.Text = "Rol Empleado";
            // 
            // txtEmailEmpleado
            // 
            this.txtEmailEmpleado.Depth = 0;
            this.txtEmailEmpleado.Hint = "Email";
            this.txtEmailEmpleado.Location = new System.Drawing.Point(34, 217);
            this.txtEmailEmpleado.MaxLength = 32767;
            this.txtEmailEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmailEmpleado.Name = "txtEmailEmpleado";
            this.txtEmailEmpleado.PasswordChar = '\0';
            this.txtEmailEmpleado.SelectedText = "";
            this.txtEmailEmpleado.SelectionLength = 0;
            this.txtEmailEmpleado.SelectionStart = 0;
            this.txtEmailEmpleado.Size = new System.Drawing.Size(294, 23);
            this.txtEmailEmpleado.TabIndex = 5;
            this.txtEmailEmpleado.TabStop = false;
            this.txtEmailEmpleado.UseSystemPasswordChar = false;
            // 
            // txtTelEmpleado
            // 
            this.txtTelEmpleado.Depth = 0;
            this.txtTelEmpleado.Hint = "Teléfono";
            this.txtTelEmpleado.Location = new System.Drawing.Point(34, 171);
            this.txtTelEmpleado.MaxLength = 32767;
            this.txtTelEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelEmpleado.Name = "txtTelEmpleado";
            this.txtTelEmpleado.PasswordChar = '\0';
            this.txtTelEmpleado.SelectedText = "";
            this.txtTelEmpleado.SelectionLength = 0;
            this.txtTelEmpleado.SelectionStart = 0;
            this.txtTelEmpleado.Size = new System.Drawing.Size(294, 23);
            this.txtTelEmpleado.TabIndex = 4;
            this.txtTelEmpleado.TabStop = false;
            this.txtTelEmpleado.UseSystemPasswordChar = false;
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.Depth = 0;
            this.txtDireccionEmpleado.Hint = "Dirección";
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(34, 129);
            this.txtDireccionEmpleado.MaxLength = 32767;
            this.txtDireccionEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.PasswordChar = '\0';
            this.txtDireccionEmpleado.SelectedText = "";
            this.txtDireccionEmpleado.SelectionLength = 0;
            this.txtDireccionEmpleado.SelectionStart = 0;
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(294, 23);
            this.txtDireccionEmpleado.TabIndex = 3;
            this.txtDireccionEmpleado.TabStop = false;
            this.txtDireccionEmpleado.UseSystemPasswordChar = false;
            this.txtDireccionEmpleado.Click += new System.EventHandler(this.materialSingleLineTextField3_Click);
            // 
            // txtDocumentoEmpleado
            // 
            this.txtDocumentoEmpleado.Depth = 0;
            this.txtDocumentoEmpleado.Hint = "Documento de identidad";
            this.txtDocumentoEmpleado.Location = new System.Drawing.Point(34, 87);
            this.txtDocumentoEmpleado.MaxLength = 32767;
            this.txtDocumentoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocumentoEmpleado.Name = "txtDocumentoEmpleado";
            this.txtDocumentoEmpleado.PasswordChar = '\0';
            this.txtDocumentoEmpleado.SelectedText = "";
            this.txtDocumentoEmpleado.SelectionLength = 0;
            this.txtDocumentoEmpleado.SelectionStart = 0;
            this.txtDocumentoEmpleado.Size = new System.Drawing.Size(294, 23);
            this.txtDocumentoEmpleado.TabIndex = 2;
            this.txtDocumentoEmpleado.TabStop = false;
            this.txtDocumentoEmpleado.UseSystemPasswordChar = false;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Depth = 0;
            this.txtNombreEmpleado.Hint = "Nombre del empleado";
            this.txtNombreEmpleado.Location = new System.Drawing.Point(34, 47);
            this.txtNombreEmpleado.MaxLength = 32767;
            this.txtNombreEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.PasswordChar = '\0';
            this.txtNombreEmpleado.SelectedText = "";
            this.txtNombreEmpleado.SelectionLength = 0;
            this.txtNombreEmpleado.SelectionStart = 0;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(294, 23);
            this.txtNombreEmpleado.TabIndex = 1;
            this.txtNombreEmpleado.TabStop = false;
            this.txtNombreEmpleado.UseSystemPasswordChar = false;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(34, 3);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtIdEmpleado.TabIndex = 0;
            // 
            // lblTituloEmpleado
            // 
            this.lblTituloEmpleado.AutoSize = true;
            this.lblTituloEmpleado.Depth = 0;
            this.lblTituloEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloEmpleado.Location = new System.Drawing.Point(289, 29);
            this.lblTituloEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloEmpleado.Name = "lblTituloEmpleado";
            this.lblTituloEmpleado.Size = new System.Drawing.Size(247, 19);
            this.lblTituloEmpleado.TabIndex = 1;
            this.lblTituloEmpleado.Text = "ADMINISTRACIÓN DE EMPLEADOS";
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.AutoSize = true;
            this.btnActualizarEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarEmpleado.Depth = 0;
            this.btnActualizarEmpleado.Icon = null;
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(214, 373);
            this.btnActualizarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Primary = true;
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarEmpleado.TabIndex = 2;
            this.btnActualizarEmpleado.Text = "ACTUALIZAR";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = true;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizarEmpleado_Click);
            // 
            // btnSalirEmpleado
            // 
            this.btnSalirEmpleado.AutoSize = true;
            this.btnSalirEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirEmpleado.Depth = 0;
            this.btnSalirEmpleado.Icon = null;
            this.btnSalirEmpleado.Location = new System.Drawing.Point(470, 373);
            this.btnSalirEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirEmpleado.Name = "btnSalirEmpleado";
            this.btnSalirEmpleado.Primary = true;
            this.btnSalirEmpleado.Size = new System.Drawing.Size(58, 36);
            this.btnSalirEmpleado.TabIndex = 3;
            this.btnSalirEmpleado.Text = "SALIR";
            this.btnSalirEmpleado.UseVisualStyleBackColor = true;
            this.btnSalirEmpleado.Click += new System.EventHandler(this.btnSalirEmpleado_Click);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirEmpleado);
            this.Controls.Add(this.btnActualizarEmpleado);
            this.Controls.Add(this.lblTituloEmpleado);
            this.Controls.Add(this.pnlContenedorEmpleados);
            this.Name = "frmEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.pnlContenedorEmpleados.ResumeLayout(false);
            this.pnlContenedorEmpleados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedorEmpleados;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtDatosEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblDatosEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblRetiroEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblIngresoEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblRolEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmailEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccionEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocumentoEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblTituloEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarEmpleado;
        private System.Windows.Forms.DateTimePicker dtpFechaRetiro;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirEmpleado;
    }
}