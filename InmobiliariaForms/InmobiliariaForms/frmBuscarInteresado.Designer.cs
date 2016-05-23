namespace InmobiliariaForms
{
    partial class frmBuscarInteresado
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
            this.txDorm = new System.Windows.Forms.TextBox();
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
            this.gvResultado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // txDorm
            // 
            this.txDorm.Location = new System.Drawing.Point(84, 116);
            this.txDorm.Name = "txDorm";
            this.txDorm.Size = new System.Drawing.Size(58, 20);
            this.txDorm.TabIndex = 37;
            // 
            // cbMoneda
            // 
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Location = new System.Drawing.Point(58, 59);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(50, 21);
            this.cbMoneda.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(9, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Moneda:";
            // 
            // checkEsInversion
            // 
            this.checkEsInversion.AutoSize = true;
            this.checkEsInversion.BackColor = System.Drawing.Color.Transparent;
            this.checkEsInversion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkEsInversion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEsInversion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkEsInversion.Location = new System.Drawing.Point(460, 119);
            this.checkEsInversion.Name = "checkEsInversion";
            this.checkEsInversion.Size = new System.Drawing.Size(110, 18);
            this.checkEsInversion.TabIndex = 38;
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
            this.label8.Location = new System.Drawing.Point(9, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 14);
            this.label8.TabIndex = 41;
            this.label8.Text = "Dormitorios:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(329, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 14);
            this.label7.TabIndex = 40;
            this.label7.Text = "Tipo de Operación:";
            // 
            // cbTipoOperacion
            // 
            this.cbTipoOperacion.FormattingEnabled = true;
            this.cbTipoOperacion.Location = new System.Drawing.Point(429, 88);
            this.cbTipoOperacion.Name = "cbTipoOperacion";
            this.cbTipoOperacion.Size = new System.Drawing.Size(189, 21);
            this.cbTipoOperacion.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 14);
            this.label6.TabIndex = 39;
            this.label6.Text = "Tipo de Inmueble:";
            // 
            // cbTipoInmueble
            // 
            this.cbTipoInmueble.FormattingEnabled = true;
            this.cbTipoInmueble.Location = new System.Drawing.Point(110, 88);
            this.cbTipoInmueble.Name = "cbTipoInmueble";
            this.cbTipoInmueble.Size = new System.Drawing.Size(120, 21);
            this.cbTipoInmueble.TabIndex = 34;
            // 
            // numHasta
            // 
            this.numHasta.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHasta.Location = new System.Drawing.Point(457, 61);
            this.numHasta.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numHasta.Name = "numHasta";
            this.numHasta.Size = new System.Drawing.Size(163, 20);
            this.numHasta.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(381, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 14);
            this.label5.TabIndex = 35;
            this.label5.Text = "Monto Hasta:";
            // 
            // numDesde
            // 
            this.numDesde.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDesde.Location = new System.Drawing.Point(204, 60);
            this.numDesde.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numDesde.Name = "numDesde";
            this.numDesde.Size = new System.Drawing.Size(153, 20);
            this.numDesde.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(125, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 14);
            this.label4.TabIndex = 32;
            this.label4.Text = "Monto Desde:";
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(340, 33);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(281, 20);
            this.txEmail.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 14);
            this.label3.TabIndex = 30;
            this.label3.Text = "Email:";
            // 
            // txTelefono
            // 
            this.txTelefono.Location = new System.Drawing.Point(62, 33);
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(180, 20);
            this.txTelefono.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 26;
            this.label2.Text = "Teléfono:";
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(62, 6);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(556, 20);
            this.txNombre.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre:";
            // 
            // gvResultado
            // 
            this.gvResultado.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResultado.Location = new System.Drawing.Point(9, 257);
            this.gvResultado.Name = "gvResultado";
            this.gvResultado.Size = new System.Drawing.Size(612, 191);
            this.gvResultado.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::InmobiliariaForms.Properties.Resources.MV;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(216, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 100);
            this.panel1.TabIndex = 44;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(509, 224);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(108, 23);
            this.btCancelar.TabIndex = 52;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(509, 194);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(108, 23);
            this.btBuscar.TabIndex = 51;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // frmBuscarInteresado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(629, 453);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gvResultado);
            this.Controls.Add(this.txDorm);
            this.Controls.Add(this.cbMoneda);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkEsInversion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTipoOperacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTipoInmueble);
            this.Controls.Add(this.numHasta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numDesde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscarInteresado";
            this.Text = "frmBuscarInteresado";
            ((System.ComponentModel.ISupportInitialize)(this.numHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txDorm;
        private System.Windows.Forms.ComboBox cbMoneda;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.DataGridView gvResultado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btBuscar;
    }
}