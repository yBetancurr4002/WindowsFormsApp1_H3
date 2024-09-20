namespace WindowsFormsApp1
{
    partial class frmListaEmpleados
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
            this.lblTituloLEmpleados = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscarLEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscarLEmpleados = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevoEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgListaEmpleados = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editarEmpleado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.borrarEmpleado = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloLEmpleados
            // 
            this.lblTituloLEmpleados.AutoSize = true;
            this.lblTituloLEmpleados.Depth = 0;
            this.lblTituloLEmpleados.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloLEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloLEmpleados.Location = new System.Drawing.Point(205, 9);
            this.lblTituloLEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloLEmpleados.Name = "lblTituloLEmpleados";
            this.lblTituloLEmpleados.Size = new System.Drawing.Size(247, 19);
            this.lblTituloLEmpleados.TabIndex = 1;
            this.lblTituloLEmpleados.Text = "ADMINISTRACIÓN DE EMPLEADOS";
            // 
            // txtBuscarLEmpleado
            // 
            this.txtBuscarLEmpleado.Depth = 0;
            this.txtBuscarLEmpleado.Hint = "Buscar por empleado";
            this.txtBuscarLEmpleado.Location = new System.Drawing.Point(27, 80);
            this.txtBuscarLEmpleado.MaxLength = 32767;
            this.txtBuscarLEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarLEmpleado.Name = "txtBuscarLEmpleado";
            this.txtBuscarLEmpleado.PasswordChar = '\0';
            this.txtBuscarLEmpleado.SelectedText = "";
            this.txtBuscarLEmpleado.SelectionLength = 0;
            this.txtBuscarLEmpleado.SelectionStart = 0;
            this.txtBuscarLEmpleado.Size = new System.Drawing.Size(268, 23);
            this.txtBuscarLEmpleado.TabIndex = 2;
            this.txtBuscarLEmpleado.TabStop = false;
            this.txtBuscarLEmpleado.UseSystemPasswordChar = false;
            // 
            // btnBuscarLEmpleados
            // 
            this.btnBuscarLEmpleados.AutoSize = true;
            this.btnBuscarLEmpleados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarLEmpleados.Depth = 0;
            this.btnBuscarLEmpleados.Icon = null;
            this.btnBuscarLEmpleados.Location = new System.Drawing.Point(360, 67);
            this.btnBuscarLEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarLEmpleados.Name = "btnBuscarLEmpleados";
            this.btnBuscarLEmpleados.Primary = true;
            this.btnBuscarLEmpleados.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarLEmpleados.TabIndex = 5;
            this.btnBuscarLEmpleados.Text = "BUSCAR";
            this.btnBuscarLEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnSalirEmpleado
            // 
            this.btnSalirEmpleado.AutoSize = true;
            this.btnSalirEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirEmpleado.Depth = 0;
            this.btnSalirEmpleado.Icon = null;
            this.btnSalirEmpleado.Location = new System.Drawing.Point(558, 378);
            this.btnSalirEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirEmpleado.Name = "btnSalirEmpleado";
            this.btnSalirEmpleado.Primary = true;
            this.btnSalirEmpleado.Size = new System.Drawing.Size(58, 36);
            this.btnSalirEmpleado.TabIndex = 7;
            this.btnSalirEmpleado.Text = "SALIR";
            this.btnSalirEmpleado.UseVisualStyleBackColor = true;
            this.btnSalirEmpleado.Click += new System.EventHandler(this.btnSalirEmpleado_Click);
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.AutoSize = true;
            this.btnNuevoEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoEmpleado.Depth = 0;
            this.btnNuevoEmpleado.Icon = null;
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(558, 67);
            this.btnNuevoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Primary = true;
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(66, 36);
            this.btnNuevoEmpleado.TabIndex = 8;
            this.btnNuevoEmpleado.Text = "NUEVO";
            this.btnNuevoEmpleado.UseVisualStyleBackColor = true;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // dgListaEmpleados
            // 
            this.dgListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Empleado,
            this.Documento,
            this.Telefono,
            this.editarEmpleado,
            this.borrarEmpleado});
            this.dgListaEmpleados.Location = new System.Drawing.Point(131, 136);
            this.dgListaEmpleados.Name = "dgListaEmpleados";
            this.dgListaEmpleados.Size = new System.Drawing.Size(493, 221);
            this.dgListaEmpleados.TabIndex = 9;
            this.dgListaEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaEmpleados_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Width = 60;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "EMPLEADO";
            this.Empleado.Name = "Empleado";
            this.Empleado.Width = 180;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "DOCUMENTO";
            this.Documento.Name = "Documento";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "TELÉFONO";
            this.Telefono.Name = "Telefono";
            // 
            // editarEmpleado
            // 
            this.editarEmpleado.HeaderText = "EDITAR";
            this.editarEmpleado.Name = "editarEmpleado";
            this.editarEmpleado.Text = "EDITAR";
            this.editarEmpleado.UseColumnTextForButtonValue = true;
            this.editarEmpleado.Width = 80;
            // 
            // borrarEmpleado
            // 
            this.borrarEmpleado.HeaderText = "BORRAR";
            this.borrarEmpleado.Name = "borrarEmpleado";
            this.borrarEmpleado.Text = "BORRAR";
            this.borrarEmpleado.UseColumnTextForButtonValue = true;
            this.borrarEmpleado.Width = 80;
            // 
            // frmListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgListaEmpleados);
            this.Controls.Add(this.btnNuevoEmpleado);
            this.Controls.Add(this.btnSalirEmpleado);
            this.Controls.Add(this.btnBuscarLEmpleados);
            this.Controls.Add(this.txtBuscarLEmpleado);
            this.Controls.Add(this.lblTituloLEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaEmpleados";
            this.Text = "frmListaEmpleados";
            this.Load += new System.EventHandler(this.frmListaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloLEmpleados;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarLEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarLEmpleados;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoEmpleado;
        private System.Windows.Forms.DataGridView dgListaEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewButtonColumn editarEmpleado;
        private System.Windows.Forms.DataGridViewButtonColumn borrarEmpleado;
    }
}