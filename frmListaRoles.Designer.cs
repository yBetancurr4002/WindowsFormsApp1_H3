namespace WindowsFormsApp1
{
    partial class frmListaRoles
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
            this.lblTituloLRoles = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscarLRoles = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscarLRoles = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgListaRolEmpleados = new System.Windows.Forms.DataGridView();
            this.btnNuevoLRoles = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirLRoles = new MaterialSkin.Controls.MaterialRaisedButton();
            this.IdRoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editarRoles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.borrarRoles = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaRolEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloLRoles
            // 
            this.lblTituloLRoles.AutoSize = true;
            this.lblTituloLRoles.Depth = 0;
            this.lblTituloLRoles.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloLRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloLRoles.Location = new System.Drawing.Point(237, 33);
            this.lblTituloLRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloLRoles.Name = "lblTituloLRoles";
            this.lblTituloLRoles.Size = new System.Drawing.Size(145, 19);
            this.lblTituloLRoles.TabIndex = 2;
            this.lblTituloLRoles.Text = "ROLES EMPLEADOS";
            // 
            // txtBuscarLRoles
            // 
            this.txtBuscarLRoles.Depth = 0;
            this.txtBuscarLRoles.Hint = "Buscar Rol";
            this.txtBuscarLRoles.Location = new System.Drawing.Point(64, 108);
            this.txtBuscarLRoles.MaxLength = 32767;
            this.txtBuscarLRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarLRoles.Name = "txtBuscarLRoles";
            this.txtBuscarLRoles.PasswordChar = '\0';
            this.txtBuscarLRoles.SelectedText = "";
            this.txtBuscarLRoles.SelectionLength = 0;
            this.txtBuscarLRoles.SelectionStart = 0;
            this.txtBuscarLRoles.Size = new System.Drawing.Size(268, 23);
            this.txtBuscarLRoles.TabIndex = 3;
            this.txtBuscarLRoles.TabStop = false;
            this.txtBuscarLRoles.UseSystemPasswordChar = false;
            // 
            // btnBuscarLRoles
            // 
            this.btnBuscarLRoles.AutoSize = true;
            this.btnBuscarLRoles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarLRoles.Depth = 0;
            this.btnBuscarLRoles.Icon = null;
            this.btnBuscarLRoles.Location = new System.Drawing.Point(375, 95);
            this.btnBuscarLRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarLRoles.Name = "btnBuscarLRoles";
            this.btnBuscarLRoles.Primary = true;
            this.btnBuscarLRoles.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarLRoles.TabIndex = 6;
            this.btnBuscarLRoles.Text = "BUSCAR";
            this.btnBuscarLRoles.UseVisualStyleBackColor = true;
            // 
            // dgListaRolEmpleados
            // 
            this.dgListaRolEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaRolEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRoles,
            this.CodigoRol,
            this.DescripcionRol,
            this.editarRoles,
            this.borrarRoles});
            this.dgListaRolEmpleados.Location = new System.Drawing.Point(102, 157);
            this.dgListaRolEmpleados.Name = "dgListaRolEmpleados";
            this.dgListaRolEmpleados.Size = new System.Drawing.Size(518, 221);
            this.dgListaRolEmpleados.TabIndex = 10;
            this.dgListaRolEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaRolEmpleados_CellContentClick);
            // 
            // btnNuevoLRoles
            // 
            this.btnNuevoLRoles.AutoSize = true;
            this.btnNuevoLRoles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoLRoles.Depth = 0;
            this.btnNuevoLRoles.Icon = null;
            this.btnNuevoLRoles.Location = new System.Drawing.Point(554, 95);
            this.btnNuevoLRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoLRoles.Name = "btnNuevoLRoles";
            this.btnNuevoLRoles.Primary = true;
            this.btnNuevoLRoles.Size = new System.Drawing.Size(66, 36);
            this.btnNuevoLRoles.TabIndex = 11;
            this.btnNuevoLRoles.Text = "NUEVO";
            this.btnNuevoLRoles.UseVisualStyleBackColor = true;
            this.btnNuevoLRoles.Click += new System.EventHandler(this.btnNuevoLRoles_Click);
            // 
            // btnSalirLRoles
            // 
            this.btnSalirLRoles.AutoSize = true;
            this.btnSalirLRoles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirLRoles.Depth = 0;
            this.btnSalirLRoles.Icon = null;
            this.btnSalirLRoles.Location = new System.Drawing.Point(554, 402);
            this.btnSalirLRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirLRoles.Name = "btnSalirLRoles";
            this.btnSalirLRoles.Primary = true;
            this.btnSalirLRoles.Size = new System.Drawing.Size(58, 36);
            this.btnSalirLRoles.TabIndex = 12;
            this.btnSalirLRoles.Text = "SALIR";
            this.btnSalirLRoles.UseVisualStyleBackColor = true;
            this.btnSalirLRoles.Click += new System.EventHandler(this.btnSalirLRoles_Click);
            // 
            // IdRoles
            // 
            this.IdRoles.HeaderText = "ID";
            this.IdRoles.Name = "IdRoles";
            this.IdRoles.Width = 60;
            // 
            // CodigoRol
            // 
            this.CodigoRol.HeaderText = "CÓDIGO";
            this.CodigoRol.Name = "CodigoRol";
            // 
            // DescripcionRol
            // 
            this.DescripcionRol.HeaderText = "DESCRIPCIÓN ROL";
            this.DescripcionRol.Name = "DescripcionRol";
            this.DescripcionRol.Width = 300;
            // 
            // editarRoles
            // 
            this.editarRoles.HeaderText = "EDITAR";
            this.editarRoles.Name = "editarRoles";
            this.editarRoles.Text = "EDITAR";
            this.editarRoles.UseColumnTextForButtonValue = true;
            this.editarRoles.Width = 80;
            // 
            // borrarRoles
            // 
            this.borrarRoles.HeaderText = "BORRAR";
            this.borrarRoles.Name = "borrarRoles";
            this.borrarRoles.Text = "BORRAR";
            this.borrarRoles.UseColumnTextForButtonValue = true;
            this.borrarRoles.Width = 80;
            // 
            // frmListaRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 476);
            this.Controls.Add(this.btnSalirLRoles);
            this.Controls.Add(this.btnNuevoLRoles);
            this.Controls.Add(this.dgListaRolEmpleados);
            this.Controls.Add(this.btnBuscarLRoles);
            this.Controls.Add(this.txtBuscarLRoles);
            this.Controls.Add(this.lblTituloLRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaRoles";
            this.Load += new System.EventHandler(this.frmListaRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaRolEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloLRoles;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarLRoles;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarLRoles;
        private System.Windows.Forms.DataGridView dgListaRolEmpleados;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoLRoles;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirLRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionRol;
        private System.Windows.Forms.DataGridViewButtonColumn editarRoles;
        private System.Windows.Forms.DataGridViewButtonColumn borrarRoles;
    }
}