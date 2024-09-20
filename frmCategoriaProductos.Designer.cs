namespace WindowsFormsApp1
{
    partial class frmCategoriaProductos
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
            this.pnlContenedorCategoria = new System.Windows.Forms.Panel();
            this.txtNombreCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.lblTituloCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.btnActualizarCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirCateogria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.pnlContenedorCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedorCategoria
            // 
            this.pnlContenedorCategoria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlContenedorCategoria.Controls.Add(this.txtDescripcionCategoria);
            this.pnlContenedorCategoria.Controls.Add(this.txtNombreCategoria);
            this.pnlContenedorCategoria.Controls.Add(this.txtIdCategoria);
            this.pnlContenedorCategoria.Location = new System.Drawing.Point(31, 88);
            this.pnlContenedorCategoria.Name = "pnlContenedorCategoria";
            this.pnlContenedorCategoria.Size = new System.Drawing.Size(570, 205);
            this.pnlContenedorCategoria.TabIndex = 0;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Depth = 0;
            this.txtNombreCategoria.Hint = "Nombre Categoría";
            this.txtNombreCategoria.Location = new System.Drawing.Point(19, 85);
            this.txtNombreCategoria.MaxLength = 32767;
            this.txtNombreCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.PasswordChar = '\0';
            this.txtNombreCategoria.SelectedText = "";
            this.txtNombreCategoria.SelectionLength = 0;
            this.txtNombreCategoria.SelectionStart = 0;
            this.txtNombreCategoria.Size = new System.Drawing.Size(327, 23);
            this.txtNombreCategoria.TabIndex = 2;
            this.txtNombreCategoria.TabStop = false;
            this.txtNombreCategoria.UseSystemPasswordChar = false;
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(19, 18);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtIdCategoria.TabIndex = 1;
            // 
            // lblTituloCategoria
            // 
            this.lblTituloCategoria.AutoSize = true;
            this.lblTituloCategoria.Depth = 0;
            this.lblTituloCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloCategoria.Location = new System.Drawing.Point(140, 31);
            this.lblTituloCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloCategoria.Name = "lblTituloCategoria";
            this.lblTituloCategoria.Size = new System.Drawing.Size(203, 19);
            this.lblTituloCategoria.TabIndex = 1;
            this.lblTituloCategoria.Text = "CATEGORÍA DE PRODUCTOS";
            // 
            // btnActualizarCategoria
            // 
            this.btnActualizarCategoria.AutoSize = true;
            this.btnActualizarCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarCategoria.Depth = 0;
            this.btnActualizarCategoria.Icon = null;
            this.btnActualizarCategoria.Location = new System.Drawing.Point(50, 327);
            this.btnActualizarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarCategoria.Name = "btnActualizarCategoria";
            this.btnActualizarCategoria.Primary = true;
            this.btnActualizarCategoria.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarCategoria.TabIndex = 2;
            this.btnActualizarCategoria.Text = "ACTUALIZAR";
            this.btnActualizarCategoria.UseVisualStyleBackColor = true;
            this.btnActualizarCategoria.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btnSalirCateogria
            // 
            this.btnSalirCateogria.AutoSize = true;
            this.btnSalirCateogria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirCateogria.Depth = 0;
            this.btnSalirCateogria.Icon = null;
            this.btnSalirCateogria.Location = new System.Drawing.Point(390, 327);
            this.btnSalirCateogria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirCateogria.Name = "btnSalirCateogria";
            this.btnSalirCateogria.Primary = true;
            this.btnSalirCateogria.Size = new System.Drawing.Size(58, 36);
            this.btnSalirCateogria.TabIndex = 3;
            this.btnSalirCateogria.Text = "SALIR";
            this.btnSalirCateogria.UseVisualStyleBackColor = true;
            this.btnSalirCateogria.Click += new System.EventHandler(this.btnSalirCateogria_Click);
            // 
            // txtDescripcionCategoria
            // 
            this.txtDescripcionCategoria.Location = new System.Drawing.Point(19, 131);
            this.txtDescripcionCategoria.Multiline = true;
            this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            this.txtDescripcionCategoria.Size = new System.Drawing.Size(494, 55);
            this.txtDescripcionCategoria.TabIndex = 3;
            // 
            // frmCategoriaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 395);
            this.Controls.Add(this.btnSalirCateogria);
            this.Controls.Add(this.btnActualizarCategoria);
            this.Controls.Add(this.lblTituloCategoria);
            this.Controls.Add(this.pnlContenedorCategoria);
            this.Name = "frmCategoriaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoría de productos";
            this.Load += new System.EventHandler(this.frmCategoriaProductos_Load);
            this.pnlContenedorCategoria.ResumeLayout(false);
            this.pnlContenedorCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedorCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreCategoria;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private MaterialSkin.Controls.MaterialLabel lblTituloCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirCateogria;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
    }
}