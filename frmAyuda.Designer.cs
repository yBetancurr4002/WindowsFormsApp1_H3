namespace WindowsFormsApp1
{
    partial class frmAyuda
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
            this.wbrAyuda = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbrAyuda
            // 
            this.wbrAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbrAyuda.Location = new System.Drawing.Point(0, 0);
            this.wbrAyuda.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrAyuda.Name = "wbrAyuda";
            this.wbrAyuda.Size = new System.Drawing.Size(800, 450);
            this.wbrAyuda.TabIndex = 0;
            this.wbrAyuda.Url = new System.Uri("https://learn.microsoft.com/es-es/docs/", System.UriKind.Absolute);
            // 
            // frmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wbrAyuda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAyuda";
            this.Text = "frmAyuda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbrAyuda;
    }
}