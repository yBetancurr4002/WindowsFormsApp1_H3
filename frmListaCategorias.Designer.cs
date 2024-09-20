namespace WindowsFormsApp1
{
    partial class frmListaCategorias
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
            this.lblTituloLCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscarCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgCategoriaProductos = new System.Windows.Forms.DataGridView();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editarCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            this.borrarCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscarCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevoCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoriaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloLCategoria
            // 
            this.lblTituloLCategoria.AutoSize = true;
            this.lblTituloLCategoria.Depth = 0;
            this.lblTituloLCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloLCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloLCategoria.Location = new System.Drawing.Point(214, 9);
            this.lblTituloLCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloLCategoria.Name = "lblTituloLCategoria";
            this.lblTituloLCategoria.Size = new System.Drawing.Size(203, 19);
            this.lblTituloLCategoria.TabIndex = 0;
            this.lblTituloLCategoria.Text = "CATEGORÍA DE PRODUCTOS";
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.Depth = 0;
            this.txtBuscarCategoria.Hint = "Buscar Categoria";
            this.txtBuscarCategoria.Location = new System.Drawing.Point(67, 81);
            this.txtBuscarCategoria.MaxLength = 32767;
            this.txtBuscarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.PasswordChar = '\0';
            this.txtBuscarCategoria.SelectedText = "";
            this.txtBuscarCategoria.SelectionLength = 0;
            this.txtBuscarCategoria.SelectionStart = 0;
            this.txtBuscarCategoria.Size = new System.Drawing.Size(290, 23);
            this.txtBuscarCategoria.TabIndex = 1;
            this.txtBuscarCategoria.TabStop = false;
            this.txtBuscarCategoria.UseSystemPasswordChar = false;
            // 
            // dgCategoriaProductos
            // 
            this.dgCategoriaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategoriaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoria,
            this.nombreCategoriaProducto,
            this.DescripcionCategoria,
            this.editarCategoria,
            this.borrarCategoria});
            this.dgCategoriaProductos.Location = new System.Drawing.Point(67, 127);
            this.dgCategoriaProductos.Name = "dgCategoriaProductos";
            this.dgCategoriaProductos.Size = new System.Drawing.Size(563, 245);
            this.dgCategoriaProductos.TabIndex = 2;
            this.dgCategoriaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategoriaProductos_CellContentClick);
            // 
            // idCategoria
            // 
            this.idCategoria.HeaderText = "ID";
            this.idCategoria.Name = "idCategoria";
            // 
            // nombreCategoriaProducto
            // 
            this.nombreCategoriaProducto.HeaderText = "Nombre de categoría";
            this.nombreCategoriaProducto.Name = "nombreCategoriaProducto";
            // 
            // DescripcionCategoria
            // 
            this.DescripcionCategoria.HeaderText = "DESCRIPCIÓN CATEGORÍA";
            this.DescripcionCategoria.Name = "DescripcionCategoria";
            this.DescripcionCategoria.Width = 300;
            // 
            // editarCategoria
            // 
            this.editarCategoria.HeaderText = "EDITAR";
            this.editarCategoria.Name = "editarCategoria";
            this.editarCategoria.Text = "EDITAR";
            this.editarCategoria.UseColumnTextForButtonValue = true;
            // 
            // borrarCategoria
            // 
            this.borrarCategoria.HeaderText = "BORRAR";
            this.borrarCategoria.Name = "borrarCategoria";
            this.borrarCategoria.Text = "BORRAR";
            this.borrarCategoria.UseColumnTextForButtonValue = true;
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.AutoSize = true;
            this.btnBuscarCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarCategoria.Depth = 0;
            this.btnBuscarCategoria.Icon = null;
            this.btnBuscarCategoria.Location = new System.Drawing.Point(410, 68);
            this.btnBuscarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Primary = true;
            this.btnBuscarCategoria.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarCategoria.TabIndex = 3;
            this.btnBuscarCategoria.Text = "BUSCAR";
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click);
            // 
            // btnNuevoCategoria
            // 
            this.btnNuevoCategoria.AutoSize = true;
            this.btnNuevoCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoCategoria.Depth = 0;
            this.btnNuevoCategoria.Icon = null;
            this.btnNuevoCategoria.Location = new System.Drawing.Point(615, 68);
            this.btnNuevoCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoCategoria.Name = "btnNuevoCategoria";
            this.btnNuevoCategoria.Primary = true;
            this.btnNuevoCategoria.Size = new System.Drawing.Size(66, 36);
            this.btnNuevoCategoria.TabIndex = 4;
            this.btnNuevoCategoria.Text = "NUEVO";
            this.btnNuevoCategoria.UseVisualStyleBackColor = true;
            this.btnNuevoCategoria.Click += new System.EventHandler(this.btnNuevoCategoria_Click);
            // 
            // btnSalirCategoria
            // 
            this.btnSalirCategoria.AutoSize = true;
            this.btnSalirCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirCategoria.Depth = 0;
            this.btnSalirCategoria.Icon = null;
            this.btnSalirCategoria.Location = new System.Drawing.Point(615, 390);
            this.btnSalirCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirCategoria.Name = "btnSalirCategoria";
            this.btnSalirCategoria.Primary = true;
            this.btnSalirCategoria.Size = new System.Drawing.Size(58, 36);
            this.btnSalirCategoria.TabIndex = 5;
            this.btnSalirCategoria.Text = "SALIR";
            this.btnSalirCategoria.UseVisualStyleBackColor = true;
            this.btnSalirCategoria.Click += new System.EventHandler(this.btnSalirCategoria_Click);
            // 
            // frmListaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirCategoria);
            this.Controls.Add(this.btnNuevoCategoria);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.dgCategoriaProductos);
            this.Controls.Add(this.txtBuscarCategoria);
            this.Controls.Add(this.lblTituloLCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaCategorias";
            this.Text = "frmListaCategorias";
            this.Load += new System.EventHandler(this.frmListaCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoriaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloLCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarCategoria;
        private System.Windows.Forms.DataGridView dgCategoriaProductos;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn editarCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn borrarCategoria;
    }
}