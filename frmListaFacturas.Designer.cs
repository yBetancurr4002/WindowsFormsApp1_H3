namespace WindowsFormsApp1
{
    partial class frmListaFacturas
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
            this.lblTituloLFactura = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscarLCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgListaFacturas = new System.Windows.Forms.DataGridView();
            this.btnNuevaLFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarLFacturas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirLFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.IdFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editarFactura = new System.Windows.Forms.DataGridViewButtonColumn();
            this.borrarFactura = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloLFactura
            // 
            this.lblTituloLFactura.AutoSize = true;
            this.lblTituloLFactura.Depth = 0;
            this.lblTituloLFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloLFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloLFactura.Location = new System.Drawing.Point(280, 9);
            this.lblTituloLFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloLFactura.Name = "lblTituloLFactura";
            this.lblTituloLFactura.Size = new System.Drawing.Size(212, 19);
            this.lblTituloLFactura.TabIndex = 0;
            this.lblTituloLFactura.Text = "ADMINISTRACIÓN FACTURAS";
            // 
            // txtBuscarLCliente
            // 
            this.txtBuscarLCliente.Depth = 0;
            this.txtBuscarLCliente.Hint = "Buscar por cliente";
            this.txtBuscarLCliente.Location = new System.Drawing.Point(25, 74);
            this.txtBuscarLCliente.MaxLength = 32767;
            this.txtBuscarLCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarLCliente.Name = "txtBuscarLCliente";
            this.txtBuscarLCliente.PasswordChar = '\0';
            this.txtBuscarLCliente.SelectedText = "";
            this.txtBuscarLCliente.SelectionLength = 0;
            this.txtBuscarLCliente.SelectionStart = 0;
            this.txtBuscarLCliente.Size = new System.Drawing.Size(268, 23);
            this.txtBuscarLCliente.TabIndex = 1;
            this.txtBuscarLCliente.TabStop = false;
            this.txtBuscarLCliente.UseSystemPasswordChar = false;
            // 
            // dgListaFacturas
            // 
            this.dgListaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFactura,
            this.NumeroFactura,
            this.Cliente,
            this.Emision,
            this.Valor,
            this.Estado,
            this.editarFactura,
            this.borrarFactura});
            this.dgListaFacturas.Location = new System.Drawing.Point(90, 103);
            this.dgListaFacturas.Name = "dgListaFacturas";
            this.dgListaFacturas.Size = new System.Drawing.Size(646, 267);
            this.dgListaFacturas.TabIndex = 2;
            this.dgListaFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaFacturas_CellContentClick);
            // 
            // btnNuevaLFactura
            // 
            this.btnNuevaLFactura.AutoSize = true;
            this.btnNuevaLFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevaLFactura.Depth = 0;
            this.btnNuevaLFactura.Icon = null;
            this.btnNuevaLFactura.Location = new System.Drawing.Point(606, 61);
            this.btnNuevaLFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevaLFactura.Name = "btnNuevaLFactura";
            this.btnNuevaLFactura.Primary = true;
            this.btnNuevaLFactura.Size = new System.Drawing.Size(130, 36);
            this.btnNuevaLFactura.TabIndex = 3;
            this.btnNuevaLFactura.Text = "NUEVA FACTURA";
            this.btnNuevaLFactura.UseVisualStyleBackColor = true;
            this.btnNuevaLFactura.Click += new System.EventHandler(this.btnNuevaLFactura_Click);
            // 
            // btnBuscarLFacturas
            // 
            this.btnBuscarLFacturas.AutoSize = true;
            this.btnBuscarLFacturas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarLFacturas.Depth = 0;
            this.btnBuscarLFacturas.Icon = null;
            this.btnBuscarLFacturas.Location = new System.Drawing.Point(376, 61);
            this.btnBuscarLFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarLFacturas.Name = "btnBuscarLFacturas";
            this.btnBuscarLFacturas.Primary = true;
            this.btnBuscarLFacturas.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarLFacturas.TabIndex = 4;
            this.btnBuscarLFacturas.Text = "BUSCAR";
            this.btnBuscarLFacturas.UseVisualStyleBackColor = true;
            // 
            // btnSalirLFactura
            // 
            this.btnSalirLFactura.AutoSize = true;
            this.btnSalirLFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirLFactura.Depth = 0;
            this.btnSalirLFactura.Icon = null;
            this.btnSalirLFactura.Location = new System.Drawing.Point(606, 376);
            this.btnSalirLFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirLFactura.Name = "btnSalirLFactura";
            this.btnSalirLFactura.Primary = true;
            this.btnSalirLFactura.Size = new System.Drawing.Size(58, 36);
            this.btnSalirLFactura.TabIndex = 5;
            this.btnSalirLFactura.Text = "SALIR";
            this.btnSalirLFactura.UseVisualStyleBackColor = true;
            this.btnSalirLFactura.Click += new System.EventHandler(this.btnSalirLFactura_Click);
            // 
            // IdFactura
            // 
            this.IdFactura.HeaderText = "ID";
            this.IdFactura.Name = "IdFactura";
            this.IdFactura.Width = 80;
            // 
            // NumeroFactura
            // 
            this.NumeroFactura.HeaderText = "NRO FACTURA";
            this.NumeroFactura.Name = "NumeroFactura";
            this.NumeroFactura.Width = 80;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "CLIENTE";
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 160;
            // 
            // Emision
            // 
            this.Emision.HeaderText = "EMISION";
            this.Emision.Name = "Emision";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "VALOR";
            this.Valor.Name = "Valor";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "ESTADO";
            this.Estado.Name = "Estado";
            // 
            // editarFactura
            // 
            this.editarFactura.HeaderText = "EDITAR";
            this.editarFactura.Name = "editarFactura";
            this.editarFactura.Text = "EDITAR";
            this.editarFactura.UseColumnTextForButtonValue = true;
            // 
            // borrarFactura
            // 
            this.borrarFactura.HeaderText = "BORRAR";
            this.borrarFactura.Name = "borrarFactura";
            this.borrarFactura.Text = "BORRAR";
            this.borrarFactura.UseColumnTextForButtonValue = true;
            // 
            // frmListaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirLFactura);
            this.Controls.Add(this.btnBuscarLFacturas);
            this.Controls.Add(this.btnNuevaLFactura);
            this.Controls.Add(this.dgListaFacturas);
            this.Controls.Add(this.txtBuscarLCliente);
            this.Controls.Add(this.lblTituloLFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaFacturas";
            this.Text = "frmListaFacturas";
            this.Load += new System.EventHandler(this.frmListaFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloLFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarLCliente;
        private System.Windows.Forms.DataGridView dgListaFacturas;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevaLFactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarLFacturas;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirLFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn editarFactura;
        private System.Windows.Forms.DataGridViewButtonColumn borrarFactura;
    }
}