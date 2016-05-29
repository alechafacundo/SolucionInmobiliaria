namespace InmobiliariaForms
{
    partial class Inmueble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inmueble));
            this.pbAgregarInmueble1 = new System.Windows.Forms.PictureBox();
            this.pbAgregarInmueble2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarInmueble1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarInmueble2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAgregarInmueble1
            // 
            this.pbAgregarInmueble1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAgregarInmueble1.BackgroundImage")));
            this.pbAgregarInmueble1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAgregarInmueble1.Location = new System.Drawing.Point(13, 13);
            this.pbAgregarInmueble1.Name = "pbAgregarInmueble1";
            this.pbAgregarInmueble1.Size = new System.Drawing.Size(160, 25);
            this.pbAgregarInmueble1.TabIndex = 0;
            this.pbAgregarInmueble1.TabStop = false;
            this.pbAgregarInmueble1.MouseHover += new System.EventHandler(this.pbAgregarInmueble1_MouseHover);
            // 
            // pbAgregarInmueble2
            // 
            this.pbAgregarInmueble2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAgregarInmueble2.BackgroundImage")));
            this.pbAgregarInmueble2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAgregarInmueble2.Location = new System.Drawing.Point(13, 13);
            this.pbAgregarInmueble2.Name = "pbAgregarInmueble2";
            this.pbAgregarInmueble2.Size = new System.Drawing.Size(160, 25);
            this.pbAgregarInmueble2.TabIndex = 1;
            this.pbAgregarInmueble2.TabStop = false;
            this.pbAgregarInmueble2.Visible = false;
            this.pbAgregarInmueble2.Click += new System.EventHandler(this.pbAgregarInmueble2_Click);
            this.pbAgregarInmueble2.MouseLeave += new System.EventHandler(this.pbAgregarInmueble2_MouseLeave);
            // 
            // Inmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.pbAgregarInmueble2);
            this.Controls.Add(this.pbAgregarInmueble1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inmueble";
            this.Text = "Inmueble";
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarInmueble1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarInmueble2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAgregarInmueble1;
        private System.Windows.Forms.PictureBox pbAgregarInmueble2;
    }
}