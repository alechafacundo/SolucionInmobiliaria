﻿namespace InmobiliariaForms
{
    partial class frmFotos
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
            this.pnlImagenes = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlImagenes
            // 
            this.pnlImagenes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImagenes.AutoScroll = true;
            this.pnlImagenes.Location = new System.Drawing.Point(12, 422);
            this.pnlImagenes.Name = "pnlImagenes";
            this.pnlImagenes.Size = new System.Drawing.Size(982, 211);
            this.pnlImagenes.TabIndex = 0;
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.Location = new System.Drawing.Point(147, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(708, 404);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // frmFotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 645);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.pnlImagenes);
            this.Name = "frmFotos";
            this.Text = "frmFotos";
            this.Load += new System.EventHandler(this.frmFotos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImagenes;
        private System.Windows.Forms.PictureBox picBox;
    }
}