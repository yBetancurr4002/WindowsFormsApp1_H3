namespace WindowsFormsApp1
{
    partial class frmListaClientes
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
            this.txtBuscarCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTituloLCientes = new MaterialSkin.Controls.MaterialLabel();
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.IDClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editarCliente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.borrarCliente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevoCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Depth = 0;
            this.txtBuscarCliente.Hint = "Buscar Cliente";
            this.txtBuscarCliente.Location = new System.Drawing.Point(34, 79);
            this.txtBuscarCliente.MaxLength = 32767;
            this.txtBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.PasswordChar = '\0';
            this.txtBuscarCliente.SelectedText = "";
            this.txtBuscarCliente.SelectionLength = 0;
            this.txtBuscarCliente.SelectionStart = 0;
            this.txtBuscarCliente.Size = new System.Drawing.Size(402, 23);
            this.txtBuscarCliente.TabIndex = 0;
            this.txtBuscarCliente.TabStop = false;
            this.txtBuscarCliente.UseSystemPasswordChar = false;
            // 
            // lblTituloLCientes
            // 
            this.lblTituloLCientes.AutoSize = true;
            this.lblTituloLCientes.Depth = 0;
            this.lblTituloLCientes.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloLCientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloLCientes.Location = new System.Drawing.Point(335, 9);
            this.lblTituloLCientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloLCientes.Name = "lblTituloLCientes";
            this.lblTituloLCientes.Size = new System.Drawing.Size(229, 19);
            this.lblTituloLCientes.TabIndex = 1;
            this.lblTituloLCientes.Text = "ADMINISTRACIÓN DE CLIENTES";
            // 
            // dgCliente
            // 
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDClientes,
            this.nombreCliente,
            this.documentoCliente,
            this.telCliente,
            this.editarCliente,
            this.borrarCliente});
            this.dgCliente.Location = new System.Drawing.Point(34, 121);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.Size = new System.Drawing.Size(896, 327);
            this.dgCliente.TabIndex = 2;
            this.dgCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCliente_CellContentClick);
            this.dgCliente.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCliente_CellContentClick);
            this.dgCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCliente_CellContentClick);
            // 
            // IDClientes
            // 
            this.IDClientes.HeaderText = "ID";
            this.IDClientes.Name = "IDClientes";
            // 
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "CLIENTE";
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Width = 250;
            // 
            // documentoCliente
            // 
            this.documentoCliente.HeaderText = "DOCUMENTO";
            this.documentoCliente.Name = "documentoCliente";
            this.documentoCliente.Width = 150;
            // 
            // telCliente
            // 
            this.telCliente.HeaderText = "TELÉFONO";
            this.telCliente.Name = "telCliente";
            this.telCliente.Width = 150;
            // 
            // editarCliente
            // 
            this.editarCliente.HeaderText = "EDITAR";
            this.editarCliente.Name = "editarCliente";
            this.editarCliente.Text = "EDITAR";
            this.editarCliente.UseColumnTextForButtonValue = true;
            // 
            // borrarCliente
            // 
            this.borrarCliente.HeaderText = "BORRAR";
            this.borrarCliente.Name = "borrarCliente";
            this.borrarCliente.Text = "BORRAR";
            this.borrarCliente.UseColumnTextForButtonValue = true;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.AutoSize = true;
            this.btnBuscarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarCliente.Depth = 0;
            this.btnBuscarCliente.Icon = null;
            this.btnBuscarCliente.Location = new System.Drawing.Point(552, 66);
            this.btnBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Primary = true;
            this.btnBuscarCliente.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarCliente.TabIndex = 3;
            this.btnBuscarCliente.Text = "BUSCAR";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.AutoSize = true;
            this.btnNuevoCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoCliente.Depth = 0;
            this.btnNuevoCliente.Icon = null;
            this.btnNuevoCliente.Location = new System.Drawing.Point(807, 66);
            this.btnNuevoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Primary = true;
            this.btnNuevoCliente.Size = new System.Drawing.Size(66, 36);
            this.btnNuevoCliente.TabIndex = 4;
            this.btnNuevoCliente.Text = "NUEVO";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnSalirCliente
            // 
            this.btnSalirCliente.AutoSize = true;
            this.btnSalirCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirCliente.Depth = 0;
            this.btnSalirCliente.Icon = null;
            this.btnSalirCliente.Location = new System.Drawing.Point(807, 475);
            this.btnSalirCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirCliente.Name = "btnSalirCliente";
            this.btnSalirCliente.Primary = true;
            this.btnSalirCliente.Size = new System.Drawing.Size(58, 36);
            this.btnSalirCliente.TabIndex = 5;
            this.btnSalirCliente.Text = "SALIR";
            this.btnSalirCliente.UseVisualStyleBackColor = true;
            this.btnSalirCliente.Click += new System.EventHandler(this.btnSalirCliente_Click);
            // 
            // frmListaClientes
            // 
            this.ClientSize = new System.Drawing.Size(977, 600);
            this.Controls.Add(this.btnSalirCliente);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.dgCliente);
            this.Controls.Add(this.lblTituloLCientes);
            this.Controls.Add(this.txtBuscarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaClientes";
            this.Load += new System.EventHandler(this.frmListaClientes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloClientes;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirClientes;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoClientes;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarClientes;
        private System.Windows.Forms.DataGridView dgClientes;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarCliente;
        private MaterialSkin.Controls.MaterialLabel lblTituloLCientes;
        private System.Windows.Forms.DataGridView dgCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telCliente;
        private System.Windows.Forms.DataGridViewButtonColumn editarCliente;
        private System.Windows.Forms.DataGridViewButtonColumn borrarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirCliente;
    }
}