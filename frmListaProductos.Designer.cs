namespace WindowsFormsApp1
{
    partial class frmListaProductos
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
            this.lblTituloLProductos = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscarProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevoLProductos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirLProductos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgListaProductos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.borrarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloLProductos
            // 
            this.lblTituloLProductos.AutoSize = true;
            this.lblTituloLProductos.Depth = 0;
            this.lblTituloLProductos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloLProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloLProductos.Location = new System.Drawing.Point(187, 9);
            this.lblTituloLProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloLProductos.Name = "lblTituloLProductos";
            this.lblTituloLProductos.Size = new System.Drawing.Size(246, 19);
            this.lblTituloLProductos.TabIndex = 0;
            this.lblTituloLProductos.Text = "ADMINISTRACIÓN DE PRODUCTOS";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Depth = 0;
            this.txtBuscarProducto.Hint = "Buscar Producto";
            this.txtBuscarProducto.Location = new System.Drawing.Point(73, 79);
            this.txtBuscarProducto.MaxLength = 32767;
            this.txtBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.PasswordChar = '\0';
            this.txtBuscarProducto.SelectedText = "";
            this.txtBuscarProducto.SelectionLength = 0;
            this.txtBuscarProducto.SelectionStart = 0;
            this.txtBuscarProducto.Size = new System.Drawing.Size(235, 23);
            this.txtBuscarProducto.TabIndex = 1;
            this.txtBuscarProducto.TabStop = false;
            this.txtBuscarProducto.UseSystemPasswordChar = false;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.AutoSize = true;
            this.btnBuscarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarProducto.Depth = 0;
            this.btnBuscarProducto.Icon = null;
            this.btnBuscarProducto.Location = new System.Drawing.Point(388, 66);
            this.btnBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Primary = true;
            this.btnBuscarProducto.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarProducto.TabIndex = 2;
            this.btnBuscarProducto.Text = "BUSCAR";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btnNuevoLProductos
            // 
            this.btnNuevoLProductos.AutoSize = true;
            this.btnNuevoLProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoLProductos.Depth = 0;
            this.btnNuevoLProductos.Icon = null;
            this.btnNuevoLProductos.Location = new System.Drawing.Point(610, 66);
            this.btnNuevoLProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoLProductos.Name = "btnNuevoLProductos";
            this.btnNuevoLProductos.Primary = true;
            this.btnNuevoLProductos.Size = new System.Drawing.Size(66, 36);
            this.btnNuevoLProductos.TabIndex = 3;
            this.btnNuevoLProductos.Text = "NUEVO";
            this.btnNuevoLProductos.UseVisualStyleBackColor = true;
            this.btnNuevoLProductos.Click += new System.EventHandler(this.btnNuevoLProductos_Click);
            // 
            // btnSalirLProductos
            // 
            this.btnSalirLProductos.AutoSize = true;
            this.btnSalirLProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirLProductos.Depth = 0;
            this.btnSalirLProductos.Icon = null;
            this.btnSalirLProductos.Location = new System.Drawing.Point(618, 402);
            this.btnSalirLProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirLProductos.Name = "btnSalirLProductos";
            this.btnSalirLProductos.Primary = true;
            this.btnSalirLProductos.Size = new System.Drawing.Size(58, 36);
            this.btnSalirLProductos.TabIndex = 4;
            this.btnSalirLProductos.Text = "SALIR";
            this.btnSalirLProductos.UseVisualStyleBackColor = true;
            this.btnSalirLProductos.Click += new System.EventHandler(this.btnSalirLProductos_Click);
            // 
            // dgListaProductos
            // 
            this.dgListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.NombreProducto,
            this.PrecioVenta,
            this.CantidadStock,
            this.Categoria,
            this.editarProducto,
            this.borrarProducto});
            this.dgListaProductos.Location = new System.Drawing.Point(55, 108);
            this.dgListaProductos.Name = "dgListaProductos";
            this.dgListaProductos.Size = new System.Drawing.Size(646, 276);
            this.dgListaProductos.TabIndex = 5;
            this.dgListaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaProductos_CellContentClick);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "ID";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Width = 60;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre del producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Width = 200;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            // 
            // CantidadStock
            // 
            this.CantidadStock.HeaderText = "Stock";
            this.CantidadStock.Name = "CantidadStock";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 150;
            // 
            // editarProducto
            // 
            this.editarProducto.HeaderText = "EDITAR";
            this.editarProducto.Name = "editarProducto";
            this.editarProducto.Text = "EDITAR";
            this.editarProducto.UseColumnTextForButtonValue = true;
            // 
            // borrarProducto
            // 
            this.borrarProducto.HeaderText = "BORRAR";
            this.borrarProducto.Name = "borrarProducto";
            this.borrarProducto.Text = "BORRAR";
            this.borrarProducto.UseColumnTextForButtonValue = true;
            // 
            // frmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.dgListaProductos);
            this.Controls.Add(this.btnSalirLProductos);
            this.Controls.Add(this.btnNuevoLProductos);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.lblTituloLProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaProductos";
            this.Load += new System.EventHandler(this.frmListaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloLProductos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarProducto;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarProducto;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoLProductos;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirLProductos;
        private System.Windows.Forms.DataGridView dgListaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewButtonColumn editarProducto;
        private System.Windows.Forms.DataGridViewButtonColumn borrarProducto;
    }
}