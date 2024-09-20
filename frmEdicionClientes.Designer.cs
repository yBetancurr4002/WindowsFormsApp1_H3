namespace WindowsFormsApp1
{
    partial class frmEdicionClientes
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
            this.lblTituloCliente = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDocClient = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNumClient = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnActualizarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirClientes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNombreCliente = new MaterialSkin.Controls.MaterialLabel();
            this.lblDocCliente = new MaterialSkin.Controls.MaterialLabel();
            this.lblTelCliente = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmailCliente = new MaterialSkin.Controls.MaterialLabel();
            this.lblDireccionCliente = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lblTituloCliente
            // 
            this.lblTituloCliente.AutoSize = true;
            this.lblTituloCliente.Depth = 0;
            this.lblTituloCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloCliente.Location = new System.Drawing.Point(137, 40);
            this.lblTituloCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloCliente.Name = "lblTituloCliente";
            this.lblTituloCliente.Size = new System.Drawing.Size(196, 19);
            this.lblTituloCliente.TabIndex = 0;
            this.lblTituloCliente.Text = "NUEVO REGISTRO CLIENTE";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(35, 85);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 1;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Depth = 0;
            this.txtNombreCliente.Hint = "Nombre del cliente";
            this.txtNombreCliente.Location = new System.Drawing.Point(303, 125);
            this.txtNombreCliente.MaxLength = 32767;
            this.txtNombreCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.PasswordChar = '\0';
            this.txtNombreCliente.SelectedText = "";
            this.txtNombreCliente.SelectionLength = 0;
            this.txtNombreCliente.SelectionStart = 0;
            this.txtNombreCliente.Size = new System.Drawing.Size(304, 23);
            this.txtNombreCliente.TabIndex = 2;
            this.txtNombreCliente.TabStop = false;
            this.txtNombreCliente.UseSystemPasswordChar = false;
            this.txtNombreCliente.Click += new System.EventHandler(this.txtNombreCliente_Click);
            // 
            // txtDocClient
            // 
            this.txtDocClient.Depth = 0;
            this.txtDocClient.Hint = "Documento de identidad";
            this.txtDocClient.Location = new System.Drawing.Point(303, 177);
            this.txtDocClient.MaxLength = 32767;
            this.txtDocClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocClient.Name = "txtDocClient";
            this.txtDocClient.PasswordChar = '\0';
            this.txtDocClient.SelectedText = "";
            this.txtDocClient.SelectionLength = 0;
            this.txtDocClient.SelectionStart = 0;
            this.txtDocClient.Size = new System.Drawing.Size(304, 23);
            this.txtDocClient.TabIndex = 3;
            this.txtDocClient.TabStop = false;
            this.txtDocClient.UseSystemPasswordChar = false;
            // 
            // txtNumClient
            // 
            this.txtNumClient.Depth = 0;
            this.txtNumClient.Hint = "Número de teléfono";
            this.txtNumClient.Location = new System.Drawing.Point(303, 235);
            this.txtNumClient.MaxLength = 32767;
            this.txtNumClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumClient.Name = "txtNumClient";
            this.txtNumClient.PasswordChar = '\0';
            this.txtNumClient.SelectedText = "";
            this.txtNumClient.SelectionLength = 0;
            this.txtNumClient.SelectionStart = 0;
            this.txtNumClient.Size = new System.Drawing.Size(304, 23);
            this.txtNumClient.TabIndex = 4;
            this.txtNumClient.TabStop = false;
            this.txtNumClient.UseSystemPasswordChar = false;
            this.txtNumClient.Click += new System.EventHandler(this.txtNumClient_Click);
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.AutoSize = true;
            this.btnActualizarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarCliente.Depth = 0;
            this.btnActualizarCliente.Icon = null;
            this.btnActualizarCliente.Location = new System.Drawing.Point(141, 388);
            this.btnActualizarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Primary = true;
            this.btnActualizarCliente.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarCliente.TabIndex = 5;
            this.btnActualizarCliente.Text = "ACTUALIZAR";
            this.btnActualizarCliente.UseVisualStyleBackColor = true;
            this.btnActualizarCliente.Click += new System.EventHandler(this.btnActualizarCliente_Click);
            // 
            // btnSalirClientes
            // 
            this.btnSalirClientes.AutoSize = true;
            this.btnSalirClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirClientes.Depth = 0;
            this.btnSalirClientes.Icon = null;
            this.btnSalirClientes.Location = new System.Drawing.Point(388, 388);
            this.btnSalirClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirClientes.Name = "btnSalirClientes";
            this.btnSalirClientes.Primary = true;
            this.btnSalirClientes.Size = new System.Drawing.Size(58, 36);
            this.btnSalirClientes.TabIndex = 6;
            this.btnSalirClientes.Text = "SALIR";
            this.btnSalirClientes.UseVisualStyleBackColor = true;
            this.btnSalirClientes.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "Email";
            this.txtEmail.Location = new System.Drawing.Point(303, 287);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(304, 23);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TabStop = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Hint = "Dirección";
            this.txtDireccion.Location = new System.Drawing.Point(303, 333);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(304, 23);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.TabStop = false;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Depth = 0;
            this.lblNombreCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreCliente.Location = new System.Drawing.Point(31, 125);
            this.lblNombreCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(74, 19);
            this.lblNombreCliente.TabIndex = 9;
            this.lblNombreCliente.Text = "NOMBRE:";
            // 
            // lblDocCliente
            // 
            this.lblDocCliente.AutoSize = true;
            this.lblDocCliente.Depth = 0;
            this.lblDocCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDocCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDocCliente.Location = new System.Drawing.Point(31, 177);
            this.lblDocCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDocCliente.Name = "lblDocCliente";
            this.lblDocCliente.Size = new System.Drawing.Size(105, 19);
            this.lblDocCliente.TabIndex = 10;
            this.lblDocCliente.Text = "DOCUMENTO:";
            // 
            // lblTelCliente
            // 
            this.lblTelCliente.AutoSize = true;
            this.lblTelCliente.Depth = 0;
            this.lblTelCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTelCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTelCliente.Location = new System.Drawing.Point(31, 235);
            this.lblTelCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTelCliente.Name = "lblTelCliente";
            this.lblTelCliente.Size = new System.Drawing.Size(87, 19);
            this.lblTelCliente.TabIndex = 11;
            this.lblTelCliente.Text = "TELÉFONO:";
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Depth = 0;
            this.lblEmailCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmailCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmailCliente.Location = new System.Drawing.Point(27, 287);
            this.lblEmailCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(57, 19);
            this.lblEmailCliente.TabIndex = 12;
            this.lblEmailCliente.Text = "EMAIL:";
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Depth = 0;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDireccionCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDireccionCliente.Location = new System.Drawing.Point(31, 333);
            this.lblDireccionCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(90, 19);
            this.lblDireccionCliente.TabIndex = 13;
            this.lblDireccionCliente.Text = "DIRECCIÓN:";
            // 
            // frmEdicionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 436);
            this.Controls.Add(this.lblDireccionCliente);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.lblTelCliente);
            this.Controls.Add(this.lblDocCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSalirClientes);
            this.Controls.Add(this.btnActualizarCliente);
            this.Controls.Add(this.txtNumClient);
            this.Controls.Add(this.txtDocClient);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.lblTituloCliente);
            this.Name = "frmEdicionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmEdicionClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocClient;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumClient;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirClientes;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialLabel lblNombreCliente;
        private MaterialSkin.Controls.MaterialLabel lblDocCliente;
        private MaterialSkin.Controls.MaterialLabel lblTelCliente;
        private MaterialSkin.Controls.MaterialLabel lblEmailCliente;
        private MaterialSkin.Controls.MaterialLabel lblDireccionCliente;
    }
}