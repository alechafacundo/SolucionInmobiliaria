namespace InmobiliariaForms
{
    partial class frmInmueble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInmueble));
            this.g = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.SystemColors.Control;
            this.g.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("g.BackgroundImage")));
            this.g.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.g.Location = new System.Drawing.Point(4, 13);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(488, 237);
            this.g.TabIndex = 1;
            this.g.TabStop = false;
            this.g.Text = "Inmueble";
            // 
            // frmInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 262);
            this.Controls.Add(this.g);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInmueble";
            this.Text = "Inmueble";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox g;
    }
}