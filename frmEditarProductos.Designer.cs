namespace WindowsFormsApp1
{
    partial class frmEditarProductos
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
            this.lblTituloProductos = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnActualizarProductos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirProductos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtCodigoProductos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCompraProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtVentaProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtStockProductos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCategoriaProductos = new System.Windows.Forms.Label();
            this.txtRutaImagenProductos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDetalleProductos = new System.Windows.Forms.TextBox();
            this.lblDetalleProductos = new System.Windows.Forms.Label();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.cboCategoriaProductos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTituloProductos
            // 
            this.lblTituloProductos.AutoSize = true;
            this.lblTituloProductos.Depth = 0;
            this.lblTituloProductos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloProductos.Location = new System.Drawing.Point(254, 9);
            this.lblTituloProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloProductos.Name = "lblTituloProductos";
            this.lblTituloProductos.Size = new System.Drawing.Size(203, 19);
            this.lblTituloProductos.TabIndex = 0;
            this.lblTituloProductos.Text = "Administración de productos";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Depth = 0;
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Hint = "Nombre del producto";
            this.txtNombreProducto.Location = new System.Drawing.Point(48, 71);
            this.txtNombreProducto.MaxLength = 32767;
            this.txtNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PasswordChar = '\0';
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.SelectionLength = 0;
            this.txtNombreProducto.SelectionStart = 0;
            this.txtNombreProducto.Size = new System.Drawing.Size(307, 23);
            this.txtNombreProducto.TabIndex = 1;
            this.txtNombreProducto.TabStop = false;
            this.txtNombreProducto.UseSystemPasswordChar = false;
            // 
            // btnActualizarProductos
            // 
            this.btnActualizarProductos.AutoSize = true;
            this.btnActualizarProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarProductos.Depth = 0;
            this.btnActualizarProductos.Icon = null;
            this.btnActualizarProductos.Location = new System.Drawing.Point(197, 352);
            this.btnActualizarProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarProductos.Name = "btnActualizarProductos";
            this.btnActualizarProductos.Primary = true;
            this.btnActualizarProductos.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarProductos.TabIndex = 6;
            this.btnActualizarProductos.Text = "ACTUALIZAR";
            this.btnActualizarProductos.UseVisualStyleBackColor = true;
            this.btnActualizarProductos.Click += new System.EventHandler(this.btnActualizarProductos_Click);
            // 
            // btnSalirProductos
            // 
            this.btnSalirProductos.AutoSize = true;
            this.btnSalirProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirProductos.Depth = 0;
            this.btnSalirProductos.Icon = null;
            this.btnSalirProductos.Location = new System.Drawing.Point(465, 352);
            this.btnSalirProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirProductos.Name = "btnSalirProductos";
            this.btnSalirProductos.Primary = true;
            this.btnSalirProductos.Size = new System.Drawing.Size(58, 36);
            this.btnSalirProductos.TabIndex = 7;
            this.btnSalirProductos.Text = "SALIR";
            this.btnSalirProductos.UseVisualStyleBackColor = true;
            this.btnSalirProductos.Click += new System.EventHandler(this.btnSalirProductos_Click);
            // 
            // txtCodigoProductos
            // 
            this.txtCodigoProductos.Depth = 0;
            this.txtCodigoProductos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProductos.Hint = "Código del producto";
            this.txtCodigoProductos.Location = new System.Drawing.Point(48, 118);
            this.txtCodigoProductos.MaxLength = 32767;
            this.txtCodigoProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigoProductos.Name = "txtCodigoProductos";
            this.txtCodigoProductos.PasswordChar = '\0';
            this.txtCodigoProductos.SelectedText = "";
            this.txtCodigoProductos.SelectionLength = 0;
            this.txtCodigoProductos.SelectionStart = 0;
            this.txtCodigoProductos.Size = new System.Drawing.Size(307, 23);
            this.txtCodigoProductos.TabIndex = 8;
            this.txtCodigoProductos.TabStop = false;
            this.txtCodigoProductos.UseSystemPasswordChar = false;
            // 
            // txtCompraProducto
            // 
            this.txtCompraProducto.Depth = 0;
            this.txtCompraProducto.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompraProducto.Hint = "Precio de Compra";
            this.txtCompraProducto.Location = new System.Drawing.Point(48, 163);
            this.txtCompraProducto.MaxLength = 32767;
            this.txtCompraProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCompraProducto.Name = "txtCompraProducto";
            this.txtCompraProducto.PasswordChar = '\0';
            this.txtCompraProducto.SelectedText = "";
            this.txtCompraProducto.SelectionLength = 0;
            this.txtCompraProducto.SelectionStart = 0;
            this.txtCompraProducto.Size = new System.Drawing.Size(307, 23);
            this.txtCompraProducto.TabIndex = 9;
            this.txtCompraProducto.TabStop = false;
            this.txtCompraProducto.UseSystemPasswordChar = false;
            // 
            // txtVentaProducto
            // 
            this.txtVentaProducto.Depth = 0;
            this.txtVentaProducto.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVentaProducto.Hint = "Precio de Venta";
            this.txtVentaProducto.Location = new System.Drawing.Point(48, 216);
            this.txtVentaProducto.MaxLength = 32767;
            this.txtVentaProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtVentaProducto.Name = "txtVentaProducto";
            this.txtVentaProducto.PasswordChar = '\0';
            this.txtVentaProducto.SelectedText = "";
            this.txtVentaProducto.SelectionLength = 0;
            this.txtVentaProducto.SelectionStart = 0;
            this.txtVentaProducto.Size = new System.Drawing.Size(307, 23);
            this.txtVentaProducto.TabIndex = 10;
            this.txtVentaProducto.TabStop = false;
            this.txtVentaProducto.UseSystemPasswordChar = false;
            // 
            // txtStockProductos
            // 
            this.txtStockProductos.Depth = 0;
            this.txtStockProductos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockProductos.Hint = "Cantidad en stock";
            this.txtStockProductos.Location = new System.Drawing.Point(48, 264);
            this.txtStockProductos.MaxLength = 32767;
            this.txtStockProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStockProductos.Name = "txtStockProductos";
            this.txtStockProductos.PasswordChar = '\0';
            this.txtStockProductos.SelectedText = "";
            this.txtStockProductos.SelectionLength = 0;
            this.txtStockProductos.SelectionStart = 0;
            this.txtStockProductos.Size = new System.Drawing.Size(307, 23);
            this.txtStockProductos.TabIndex = 11;
            this.txtStockProductos.TabStop = false;
            this.txtStockProductos.UseSystemPasswordChar = false;
            // 
            // lblCategoriaProductos
            // 
            this.lblCategoriaProductos.AutoSize = true;
            this.lblCategoriaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaProductos.Location = new System.Drawing.Point(453, 71);
            this.lblCategoriaProductos.Name = "lblCategoriaProductos";
            this.lblCategoriaProductos.Size = new System.Drawing.Size(72, 18);
            this.lblCategoriaProductos.TabIndex = 13;
            this.lblCategoriaProductos.Text = "Categoría";
            // 
            // txtRutaImagenProductos
            // 
            this.txtRutaImagenProductos.Depth = 0;
            this.txtRutaImagenProductos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaImagenProductos.Hint = "Ruta de la imagen";
            this.txtRutaImagenProductos.Location = new System.Drawing.Point(455, 146);
            this.txtRutaImagenProductos.MaxLength = 32767;
            this.txtRutaImagenProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRutaImagenProductos.Name = "txtRutaImagenProductos";
            this.txtRutaImagenProductos.PasswordChar = '\0';
            this.txtRutaImagenProductos.SelectedText = "";
            this.txtRutaImagenProductos.SelectionLength = 0;
            this.txtRutaImagenProductos.SelectionStart = 0;
            this.txtRutaImagenProductos.Size = new System.Drawing.Size(307, 23);
            this.txtRutaImagenProductos.TabIndex = 14;
            this.txtRutaImagenProductos.TabStop = false;
            this.txtRutaImagenProductos.UseSystemPasswordChar = false;
            // 
            // txtDetalleProductos
            // 
            this.txtDetalleProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetalleProductos.Location = new System.Drawing.Point(456, 216);
            this.txtDetalleProductos.Multiline = true;
            this.txtDetalleProductos.Name = "txtDetalleProductos";
            this.txtDetalleProductos.Size = new System.Drawing.Size(306, 71);
            this.txtDetalleProductos.TabIndex = 15;
            // 
            // lblDetalleProductos
            // 
            this.lblDetalleProductos.AutoSize = true;
            this.lblDetalleProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleProductos.Location = new System.Drawing.Point(453, 181);
            this.lblDetalleProductos.Name = "lblDetalleProductos";
            this.lblDetalleProductos.Size = new System.Drawing.Size(147, 18);
            this.lblDetalleProductos.TabIndex = 16;
            this.lblDetalleProductos.Text = "Detalles del producto";
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(570, 71);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(192, 20);
            this.txtIdCategoria.TabIndex = 17;
            // 
            // cboCategoriaProductos
            // 
            this.cboCategoriaProductos.FormattingEnabled = true;
            this.cboCategoriaProductos.Location = new System.Drawing.Point(570, 109);
            this.cboCategoriaProductos.Name = "cboCategoriaProductos";
            this.cboCategoriaProductos.Size = new System.Drawing.Size(192, 21);
            this.cboCategoriaProductos.TabIndex = 18;
            // 
            // frmEditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboCategoriaProductos);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.lblDetalleProductos);
            this.Controls.Add(this.txtDetalleProductos);
            this.Controls.Add(this.txtRutaImagenProductos);
            this.Controls.Add(this.lblCategoriaProductos);
            this.Controls.Add(this.txtStockProductos);
            this.Controls.Add(this.txtVentaProducto);
            this.Controls.Add(this.txtCompraProducto);
            this.Controls.Add(this.txtCodigoProductos);
            this.Controls.Add(this.btnSalirProductos);
            this.Controls.Add(this.btnActualizarProductos);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblTituloProductos);
            this.Name = "frmEditarProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmEditarProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloProductos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreProducto;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarProductos;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirProductos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigoProductos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCompraProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtVentaProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtStockProductos;
        private System.Windows.Forms.Label lblCategoriaProductos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRutaImagenProductos;
        private System.Windows.Forms.TextBox txtDetalleProductos;
        private System.Windows.Forms.Label lblDetalleProductos;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.ComboBox cboCategoriaProductos;
    }
}