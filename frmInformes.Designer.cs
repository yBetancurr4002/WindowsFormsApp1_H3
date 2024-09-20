namespace WindowsFormsApp1
{
    partial class frmInformes
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
            this.lblGenerarInformes = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblSeleccioneInforme = new MaterialSkin.Controls.MaterialLabel();
            this.lblOrdenarInforme = new MaterialSkin.Controls.MaterialLabel();
            this.lblFinalInformes = new MaterialSkin.Controls.MaterialLabel();
            this.dtpInicioInformes = new System.Windows.Forms.DateTimePicker();
            this.dtpFinalInformes = new System.Windows.Forms.DateTimePicker();
            this.rdbEnPantalla = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbEnPdf = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbEnExcel = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnGenerarInforme = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirInformes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cboSeleccionInforme = new System.Windows.Forms.ComboBox();
            this.cboOrdenarInformes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblGenerarInformes
            // 
            this.lblGenerarInformes.AutoSize = true;
            this.lblGenerarInformes.Depth = 0;
            this.lblGenerarInformes.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGenerarInformes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGenerarInformes.Location = new System.Drawing.Point(118, 35);
            this.lblGenerarInformes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGenerarInformes.Name = "lblGenerarInformes";
            this.lblGenerarInformes.Size = new System.Drawing.Size(324, 19);
            this.lblGenerarInformes.TabIndex = 0;
            this.lblGenerarInformes.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(55, 225);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(90, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Fecha inicio";
            // 
            // lblSeleccioneInforme
            // 
            this.lblSeleccioneInforme.AutoSize = true;
            this.lblSeleccioneInforme.Depth = 0;
            this.lblSeleccioneInforme.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSeleccioneInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSeleccioneInforme.Location = new System.Drawing.Point(55, 152);
            this.lblSeleccioneInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSeleccioneInforme.Name = "lblSeleccioneInforme";
            this.lblSeleccioneInforme.Size = new System.Drawing.Size(166, 19);
            this.lblSeleccioneInforme.TabIndex = 2;
            this.lblSeleccioneInforme.Text = "SELECCIONE INFORME";
            // 
            // lblOrdenarInforme
            // 
            this.lblOrdenarInforme.AutoSize = true;
            this.lblOrdenarInforme.Depth = 0;
            this.lblOrdenarInforme.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOrdenarInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOrdenarInforme.Location = new System.Drawing.Point(457, 152);
            this.lblOrdenarInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOrdenarInforme.Name = "lblOrdenarInforme";
            this.lblOrdenarInforme.Size = new System.Drawing.Size(87, 19);
            this.lblOrdenarInforme.TabIndex = 3;
            this.lblOrdenarInforme.Text = "Ordenar por";
            // 
            // lblFinalInformes
            // 
            this.lblFinalInformes.AutoSize = true;
            this.lblFinalInformes.Depth = 0;
            this.lblFinalInformes.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFinalInformes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFinalInformes.Location = new System.Drawing.Point(402, 224);
            this.lblFinalInformes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFinalInformes.Name = "lblFinalInformes";
            this.lblFinalInformes.Size = new System.Drawing.Size(82, 19);
            this.lblFinalInformes.TabIndex = 4;
            this.lblFinalInformes.Text = "Fecha final";
            // 
            // dtpInicioInformes
            // 
            this.dtpInicioInformes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioInformes.Location = new System.Drawing.Point(171, 223);
            this.dtpInicioInformes.Name = "dtpInicioInformes";
            this.dtpInicioInformes.Size = new System.Drawing.Size(147, 20);
            this.dtpInicioInformes.TabIndex = 5;
            // 
            // dtpFinalInformes
            // 
            this.dtpFinalInformes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinalInformes.Location = new System.Drawing.Point(524, 223);
            this.dtpFinalInformes.Name = "dtpFinalInformes";
            this.dtpFinalInformes.Size = new System.Drawing.Size(147, 20);
            this.dtpFinalInformes.TabIndex = 6;
            // 
            // rdbEnPantalla
            // 
            this.rdbEnPantalla.AutoSize = true;
            this.rdbEnPantalla.Depth = 0;
            this.rdbEnPantalla.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbEnPantalla.Location = new System.Drawing.Point(140, 282);
            this.rdbEnPantalla.Margin = new System.Windows.Forms.Padding(0);
            this.rdbEnPantalla.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbEnPantalla.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbEnPantalla.Name = "rdbEnPantalla";
            this.rdbEnPantalla.Ripple = true;
            this.rdbEnPantalla.Size = new System.Drawing.Size(97, 30);
            this.rdbEnPantalla.TabIndex = 7;
            this.rdbEnPantalla.TabStop = true;
            this.rdbEnPantalla.Text = "En pantalla";
            this.rdbEnPantalla.UseVisualStyleBackColor = true;
            // 
            // rdbEnPdf
            // 
            this.rdbEnPdf.AutoSize = true;
            this.rdbEnPdf.Depth = 0;
            this.rdbEnPdf.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbEnPdf.Location = new System.Drawing.Point(336, 282);
            this.rdbEnPdf.Margin = new System.Windows.Forms.Padding(0);
            this.rdbEnPdf.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbEnPdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbEnPdf.Name = "rdbEnPdf";
            this.rdbEnPdf.Ripple = true;
            this.rdbEnPdf.Size = new System.Drawing.Size(73, 30);
            this.rdbEnPdf.TabIndex = 8;
            this.rdbEnPdf.TabStop = true;
            this.rdbEnPdf.Text = "En PDF";
            this.rdbEnPdf.UseVisualStyleBackColor = true;
            // 
            // rdbEnExcel
            // 
            this.rdbEnExcel.AutoSize = true;
            this.rdbEnExcel.Depth = 0;
            this.rdbEnExcel.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbEnExcel.Location = new System.Drawing.Point(508, 282);
            this.rdbEnExcel.Margin = new System.Windows.Forms.Padding(0);
            this.rdbEnExcel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbEnExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbEnExcel.Name = "rdbEnExcel";
            this.rdbEnExcel.Ripple = true;
            this.rdbEnExcel.Size = new System.Drawing.Size(81, 30);
            this.rdbEnExcel.TabIndex = 9;
            this.rdbEnExcel.TabStop = true;
            this.rdbEnExcel.Text = "En Excel";
            this.rdbEnExcel.UseVisualStyleBackColor = true;
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.AutoSize = true;
            this.btnGenerarInforme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerarInforme.Depth = 0;
            this.btnGenerarInforme.Icon = null;
            this.btnGenerarInforme.Location = new System.Drawing.Point(174, 363);
            this.btnGenerarInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Primary = true;
            this.btnGenerarInforme.Size = new System.Drawing.Size(144, 36);
            this.btnGenerarInforme.TabIndex = 10;
            this.btnGenerarInforme.Text = "GENERAR INFORME";
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // btnSalirInformes
            // 
            this.btnSalirInformes.AutoSize = true;
            this.btnSalirInformes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirInformes.Depth = 0;
            this.btnSalirInformes.Icon = null;
            this.btnSalirInformes.Location = new System.Drawing.Point(445, 363);
            this.btnSalirInformes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirInformes.Name = "btnSalirInformes";
            this.btnSalirInformes.Primary = true;
            this.btnSalirInformes.Size = new System.Drawing.Size(58, 36);
            this.btnSalirInformes.TabIndex = 11;
            this.btnSalirInformes.Text = "SALIR";
            this.btnSalirInformes.UseVisualStyleBackColor = true;
            this.btnSalirInformes.Click += new System.EventHandler(this.btnSalirInformes_Click);
            // 
            // cboSeleccionInforme
            // 
            this.cboSeleccionInforme.FormattingEnabled = true;
            this.cboSeleccionInforme.Location = new System.Drawing.Point(227, 150);
            this.cboSeleccionInforme.Name = "cboSeleccionInforme";
            this.cboSeleccionInforme.Size = new System.Drawing.Size(208, 21);
            this.cboSeleccionInforme.TabIndex = 12;
            // 
            // cboOrdenarInformes
            // 
            this.cboOrdenarInformes.FormattingEnabled = true;
            this.cboOrdenarInformes.Location = new System.Drawing.Point(550, 153);
            this.cboOrdenarInformes.Name = "cboOrdenarInformes";
            this.cboOrdenarInformes.Size = new System.Drawing.Size(121, 21);
            this.cboOrdenarInformes.TabIndex = 13;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.cboOrdenarInformes);
            this.Controls.Add(this.cboSeleccionInforme);
            this.Controls.Add(this.btnSalirInformes);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.rdbEnExcel);
            this.Controls.Add(this.rdbEnPdf);
            this.Controls.Add(this.rdbEnPantalla);
            this.Controls.Add(this.dtpFinalInformes);
            this.Controls.Add(this.dtpInicioInformes);
            this.Controls.Add(this.lblFinalInformes);
            this.Controls.Add(this.lblOrdenarInforme);
            this.Controls.Add(this.lblSeleccioneInforme);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblGenerarInformes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformes";
            this.Text = "frmInformes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblGenerarInformes;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblSeleccioneInforme;
        private MaterialSkin.Controls.MaterialLabel lblOrdenarInforme;
        private MaterialSkin.Controls.MaterialLabel lblFinalInformes;
        private System.Windows.Forms.DateTimePicker dtpInicioInformes;
        private System.Windows.Forms.DateTimePicker dtpFinalInformes;
        private MaterialSkin.Controls.MaterialRadioButton rdbEnPantalla;
        private MaterialSkin.Controls.MaterialRadioButton rdbEnPdf;
        private MaterialSkin.Controls.MaterialRadioButton rdbEnExcel;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerarInforme;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirInformes;
        private System.Windows.Forms.ComboBox cboSeleccionInforme;
        private System.Windows.Forms.ComboBox cboOrdenarInformes;
    }
}