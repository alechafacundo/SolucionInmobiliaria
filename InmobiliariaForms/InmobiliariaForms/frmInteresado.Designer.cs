﻿namespace InmobiliariaForms
{
    partial class frmInteresado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInteresado));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkEsInversion = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipoOperacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipoInmueble = new System.Windows.Forms.ComboBox();
            this.numHasta = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numDesde = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.txDorm = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesde)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.txDorm);
            this.groupBox1.Controls.Add(this.cbMoneda);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.checkEsInversion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbTipoOperacion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbTipoInmueble);
            this.groupBox1.Controls.Add(this.numHasta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numDesde);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txTelefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interesado";
            // 
            // cbMoneda
            // 
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Location = new System.Drawing.Point(55, 69);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(50, 22);
            this.cbMoneda.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(6, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 14);
            this.label12.TabIndex = 23;
            this.label12.Text = "Moneda:";
            // 
            // checkEsInversion
            // 
            this.checkEsInversion.AutoSize = true;
            this.checkEsInversion.BackColor = System.Drawing.Color.Transparent;
            this.checkEsInversion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkEsInversion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEsInversion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkEsInversion.Location = new System.Drawing.Point(352, 131);
            this.checkEsInversion.Name = "checkEsInversion";
            this.checkEsInversion.Size = new System.Drawing.Size(110, 18);
            this.checkEsInversion.TabIndex = 17;
            this.checkEsInversion.Text = "Es para Inversión";
            this.checkEsInversion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkEsInversion.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 14);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dormitorios:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(281, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo de Operación:";
            // 
            // cbTipoOperacion
            // 
            this.cbTipoOperacion.FormattingEnabled = true;
            this.cbTipoOperacion.Location = new System.Drawing.Point(381, 98);
            this.cbTipoOperacion.Name = "cbTipoOperacion";
            this.cbTipoOperacion.Size = new System.Drawing.Size(189, 22);
            this.cbTipoOperacion.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo de Inmueble:";
            // 
            // cbTipoInmueble
            // 
            this.cbTipoInmueble.FormattingEnabled = true;
            this.cbTipoInmueble.Location = new System.Drawing.Point(119, 98);
            this.cbTipoInmueble.Name = "cbTipoInmueble";
            this.cbTipoInmueble.Size = new System.Drawing.Size(120, 22);
            this.cbTipoInmueble.TabIndex = 10;
            // 
            // numHasta
            // 
            this.numHasta.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHasta.Location = new System.Drawing.Point(417, 70);
            this.numHasta.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numHasta.Name = "numHasta";
            this.numHasta.Size = new System.Drawing.Size(153, 22);
            this.numHasta.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(342, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Monto Hasta:";
            // 
            // numDesde
            // 
            this.numDesde.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDesde.Location = new System.Drawing.Point(185, 70);
            this.numDesde.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numDesde.Name = "numDesde";
            this.numDesde.Size = new System.Drawing.Size(153, 22);
            this.numDesde.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(106, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monto Desde:";
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(289, 43);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(281, 22);
            this.txEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // txTelefono
            // 
            this.txTelefono.Location = new System.Drawing.Point(59, 43);
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(180, 22);
            this.txTelefono.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teléfono:";
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(59, 16);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(511, 22);
            this.txNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btEliminar
            // 
            this.btEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(14, 271);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(160, 29);
            this.btEliminar.TabIndex = 2;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(293, 270);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(160, 29);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btGuardar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(454, 270);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(178, 28);
            this.btGuardar.TabIndex = 4;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            // 
            // txDorm
            // 
            this.txDorm.Location = new System.Drawing.Point(81, 126);
            this.txDorm.Name = "txDorm";
            this.txDorm.Size = new System.Drawing.Size(58, 22);
            this.txDorm.TabIndex = 25;
            // 
            // frmInteresado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(632, 303);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInteresado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Interesado";
            this.Load += new System.EventHandler(this.frmInteresado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkEsInversion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTipoOperacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTipoInmueble;
        private System.Windows.Forms.NumericUpDown numHasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbMoneda;
        private System.Windows.Forms.TextBox txDorm;
    }
}