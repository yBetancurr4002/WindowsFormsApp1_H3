namespace WindowsFormsApp1
{
    partial class frmFacturas
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
            this.lblTituloFactura = new MaterialSkin.Controls.MaterialLabel();
            this.lblNumFactura = new MaterialSkin.Controls.MaterialLabel();
            this.lblClienteFactura = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmpleadoFactura = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.cboClienteFacturas = new System.Windows.Forms.ComboBox();
            this.cboEmpleadoFacturas = new System.Windows.Forms.ComboBox();
            this.lblFechaRegistro = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblEstadoFactura = new MaterialSkin.Controls.MaterialLabel();
            this.cboEstadoFactura = new System.Windows.Forms.ComboBox();
            this.txtDescuentoFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIvaFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTotalFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnActualizarFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlDetalleFactura = new System.Windows.Forms.Panel();
            this.lblDetalleFactura = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalirFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lblTituloFactura
            // 
            this.lblTituloFactura.AutoSize = true;
            this.lblTituloFactura.Depth = 0;
            this.lblTituloFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloFactura.Location = new System.Drawing.Point(212, 9);
            this.lblTituloFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloFactura.Name = "lblTituloFactura";
            this.lblTituloFactura.Size = new System.Drawing.Size(212, 19);
            this.lblTituloFactura.TabIndex = 0;
            this.lblTituloFactura.Text = "ADMINISTRACIÓN FACTURAS";
            // 
            // lblNumFactura
            // 
            this.lblNumFactura.AutoSize = true;
            this.lblNumFactura.Depth = 0;
            this.lblNumFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNumFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumFactura.Location = new System.Drawing.Point(58, 80);
            this.lblNumFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumFactura.Name = "lblNumFactura";
            this.lblNumFactura.Size = new System.Drawing.Size(88, 19);
            this.lblNumFactura.TabIndex = 1;
            this.lblNumFactura.Text = "Nro Factura";
            this.lblNumFactura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblClienteFactura
            // 
            this.lblClienteFactura.AutoSize = true;
            this.lblClienteFactura.Depth = 0;
            this.lblClienteFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblClienteFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblClienteFactura.Location = new System.Drawing.Point(58, 120);
            this.lblClienteFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblClienteFactura.Name = "lblClienteFactura";
            this.lblClienteFactura.Size = new System.Drawing.Size(56, 19);
            this.lblClienteFactura.TabIndex = 2;
            this.lblClienteFactura.Text = "Cliente";
            // 
            // lblEmpleadoFactura
            // 
            this.lblEmpleadoFactura.AutoSize = true;
            this.lblEmpleadoFactura.Depth = 0;
            this.lblEmpleadoFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmpleadoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmpleadoFactura.Location = new System.Drawing.Point(58, 163);
            this.lblEmpleadoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpleadoFactura.Name = "lblEmpleadoFactura";
            this.lblEmpleadoFactura.Size = new System.Drawing.Size(76, 19);
            this.lblEmpleadoFactura.TabIndex = 3;
            this.lblEmpleadoFactura.Text = "Empleado";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Location = new System.Drawing.Point(184, 78);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(165, 20);
            this.txtNumFactura.TabIndex = 4;
            // 
            // cboClienteFacturas
            // 
            this.cboClienteFacturas.FormattingEnabled = true;
            this.cboClienteFacturas.Location = new System.Drawing.Point(184, 117);
            this.cboClienteFacturas.Name = "cboClienteFacturas";
            this.cboClienteFacturas.Size = new System.Drawing.Size(255, 21);
            this.cboClienteFacturas.TabIndex = 5;
            // 
            // cboEmpleadoFacturas
            // 
            this.cboEmpleadoFacturas.FormattingEnabled = true;
            this.cboEmpleadoFacturas.Location = new System.Drawing.Point(184, 160);
            this.cboEmpleadoFacturas.Name = "cboEmpleadoFacturas";
            this.cboEmpleadoFacturas.Size = new System.Drawing.Size(255, 21);
            this.cboEmpleadoFacturas.TabIndex = 6;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Depth = 0;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaRegistro.Location = new System.Drawing.Point(483, 77);
            this.lblFechaRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(109, 19);
            this.lblFechaRegistro.TabIndex = 7;
            this.lblFechaRegistro.Text = "Fecha Registro";
            this.lblFechaRegistro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(487, 99);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(143, 20);
            this.dtpFechaRegistro.TabIndex = 8;
            this.dtpFechaRegistro.Value = new System.DateTime(2023, 2, 22, 15, 56, 39, 0);
            // 
            // lblEstadoFactura
            // 
            this.lblEstadoFactura.AutoSize = true;
            this.lblEstadoFactura.Depth = 0;
            this.lblEstadoFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoFactura.Location = new System.Drawing.Point(483, 141);
            this.lblEstadoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoFactura.Name = "lblEstadoFactura";
            this.lblEstadoFactura.Size = new System.Drawing.Size(110, 19);
            this.lblEstadoFactura.TabIndex = 9;
            this.lblEstadoFactura.Text = "Estado Factura";
            this.lblEstadoFactura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboEstadoFactura
            // 
            this.cboEstadoFactura.FormattingEnabled = true;
            this.cboEstadoFactura.Location = new System.Drawing.Point(487, 160);
            this.cboEstadoFactura.Name = "cboEstadoFactura";
            this.cboEstadoFactura.Size = new System.Drawing.Size(143, 21);
            this.cboEstadoFactura.TabIndex = 10;
            // 
            // txtDescuentoFactura
            // 
            this.txtDescuentoFactura.Depth = 0;
            this.txtDescuentoFactura.Hint = "Descuento";
            this.txtDescuentoFactura.Location = new System.Drawing.Point(61, 204);
            this.txtDescuentoFactura.MaxLength = 32767;
            this.txtDescuentoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescuentoFactura.Name = "txtDescuentoFactura";
            this.txtDescuentoFactura.PasswordChar = '\0';
            this.txtDescuentoFactura.SelectedText = "";
            this.txtDescuentoFactura.SelectionLength = 0;
            this.txtDescuentoFactura.SelectionStart = 0;
            this.txtDescuentoFactura.Size = new System.Drawing.Size(241, 23);
            this.txtDescuentoFactura.TabIndex = 11;
            this.txtDescuentoFactura.TabStop = false;
            this.txtDescuentoFactura.UseSystemPasswordChar = false;
            // 
            // txtIvaFactura
            // 
            this.txtIvaFactura.Depth = 0;
            this.txtIvaFactura.Hint = "Total IVA";
            this.txtIvaFactura.Location = new System.Drawing.Point(61, 233);
            this.txtIvaFactura.MaxLength = 32767;
            this.txtIvaFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIvaFactura.Name = "txtIvaFactura";
            this.txtIvaFactura.PasswordChar = '\0';
            this.txtIvaFactura.SelectedText = "";
            this.txtIvaFactura.SelectionLength = 0;
            this.txtIvaFactura.SelectionStart = 0;
            this.txtIvaFactura.Size = new System.Drawing.Size(241, 23);
            this.txtIvaFactura.TabIndex = 12;
            this.txtIvaFactura.TabStop = false;
            this.txtIvaFactura.UseSystemPasswordChar = false;
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Depth = 0;
            this.txtTotalFactura.Hint = "Total Factura";
            this.txtTotalFactura.Location = new System.Drawing.Point(61, 262);
            this.txtTotalFactura.MaxLength = 32767;
            this.txtTotalFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.PasswordChar = '\0';
            this.txtTotalFactura.SelectedText = "";
            this.txtTotalFactura.SelectionLength = 0;
            this.txtTotalFactura.SelectionStart = 0;
            this.txtTotalFactura.Size = new System.Drawing.Size(241, 23);
            this.txtTotalFactura.TabIndex = 13;
            this.txtTotalFactura.TabStop = false;
            this.txtTotalFactura.UseSystemPasswordChar = false;
            // 
            // btnActualizarFactura
            // 
            this.btnActualizarFactura.AutoSize = true;
            this.btnActualizarFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarFactura.Depth = 0;
            this.btnActualizarFactura.Icon = null;
            this.btnActualizarFactura.Location = new System.Drawing.Point(487, 249);
            this.btnActualizarFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarFactura.Name = "btnActualizarFactura";
            this.btnActualizarFactura.Primary = true;
            this.btnActualizarFactura.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarFactura.TabIndex = 14;
            this.btnActualizarFactura.Text = "ACTUALIZAR";
            this.btnActualizarFactura.UseVisualStyleBackColor = true;
            this.btnActualizarFactura.Click += new System.EventHandler(this.btnActualizarFactura_Click);
            // 
            // pnlDetalleFactura
            // 
            this.pnlDetalleFactura.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlDetalleFactura.Location = new System.Drawing.Point(61, 339);
            this.pnlDetalleFactura.Name = "pnlDetalleFactura";
            this.pnlDetalleFactura.Size = new System.Drawing.Size(367, 100);
            this.pnlDetalleFactura.TabIndex = 15;
            // 
            // lblDetalleFactura
            // 
            this.lblDetalleFactura.AutoSize = true;
            this.lblDetalleFactura.Depth = 0;
            this.lblDetalleFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDetalleFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetalleFactura.Location = new System.Drawing.Point(57, 317);
            this.lblDetalleFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetalleFactura.Name = "lblDetalleFactura";
            this.lblDetalleFactura.Size = new System.Drawing.Size(142, 19);
            this.lblDetalleFactura.TabIndex = 16;
            this.lblDetalleFactura.Text = "DETALLE FACTURA";
            this.lblDetalleFactura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSalirFactura
            // 
            this.btnSalirFactura.AutoSize = true;
            this.btnSalirFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirFactura.Depth = 0;
            this.btnSalirFactura.Icon = null;
            this.btnSalirFactura.Location = new System.Drawing.Point(487, 403);
            this.btnSalirFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirFactura.Name = "btnSalirFactura";
            this.btnSalirFactura.Primary = true;
            this.btnSalirFactura.Size = new System.Drawing.Size(58, 36);
            this.btnSalirFactura.TabIndex = 17;
            this.btnSalirFactura.Text = "SALIR";
            this.btnSalirFactura.UseVisualStyleBackColor = true;
            this.btnSalirFactura.Click += new System.EventHandler(this.btnSalirFactura_Click);
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 485);
            this.Controls.Add(this.btnSalirFactura);
            this.Controls.Add(this.lblDetalleFactura);
            this.Controls.Add(this.pnlDetalleFactura);
            this.Controls.Add(this.btnActualizarFactura);
            this.Controls.Add(this.txtTotalFactura);
            this.Controls.Add(this.txtIvaFactura);
            this.Controls.Add(this.txtDescuentoFactura);
            this.Controls.Add(this.cboEstadoFactura);
            this.Controls.Add(this.lblEstadoFactura);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.lblFechaRegistro);
            this.Controls.Add(this.cboEmpleadoFacturas);
            this.Controls.Add(this.cboClienteFacturas);
            this.Controls.Add(this.txtNumFactura);
            this.Controls.Add(this.lblEmpleadoFactura);
            this.Controls.Add(this.lblClienteFactura);
            this.Controls.Add(this.lblNumFactura);
            this.Controls.Add(this.lblTituloFactura);
            this.Name = "frmFacturas";
            this.Text = "frmFacturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloFactura;
        private MaterialSkin.Controls.MaterialLabel lblNumFactura;
        private MaterialSkin.Controls.MaterialLabel lblClienteFactura;
        private MaterialSkin.Controls.MaterialLabel lblEmpleadoFactura;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.ComboBox cboClienteFacturas;
        private System.Windows.Forms.ComboBox cboEmpleadoFacturas;
        private MaterialSkin.Controls.MaterialLabel lblFechaRegistro;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private MaterialSkin.Controls.MaterialLabel lblEstadoFactura;
        private System.Windows.Forms.ComboBox cboEstadoFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescuentoFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIvaFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotalFactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarFactura;
        private System.Windows.Forms.Panel pnlDetalleFactura;
        private MaterialSkin.Controls.MaterialLabel lblDetalleFactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirFactura;
    }
}