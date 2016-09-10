namespace InmobiliariaForms
{
    partial class frmBuscarInmueble
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
            this.gvResultado = new System.Windows.Forms.DataGridView();
            this.g = new System.Windows.Forms.GroupBox();
            this.cbAmbientes = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txCalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numPrecioHasta = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipoOperacion = new System.Windows.Forms.ComboBox();
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numPrecioDesde = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txLocalidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoInmueble = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btMasDetalles = new System.Windows.Forms.Button();
            this.chDisponible = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultado)).BeginInit();
            this.g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioDesde)).BeginInit();
            this.SuspendLayout();
            // 
            // gvResultado
            // 
            this.gvResultado.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResultado.Location = new System.Drawing.Point(2, 172);
            this.gvResultado.MultiSelect = false;
            this.gvResultado.Name = "gvResultado";
            this.gvResultado.ReadOnly = true;
            this.gvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvResultado.Size = new System.Drawing.Size(626, 206);
            this.gvResultado.TabIndex = 5;
            this.gvResultado.DoubleClick += new System.EventHandler(this.btMasDetalles_Click);
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.Color.White;
            this.g.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.g.Controls.Add(this.cbAmbientes);
            this.g.Controls.Add(this.label17);
            this.g.Controls.Add(this.txCalle);
            this.g.Controls.Add(this.label3);
            this.g.Controls.Add(this.numPrecioHasta);
            this.g.Controls.Add(this.label6);
            this.g.Controls.Add(this.cbTipoOperacion);
            this.g.Controls.Add(this.cbMoneda);
            this.g.Controls.Add(this.label12);
            this.g.Controls.Add(this.numPrecioDesde);
            this.g.Controls.Add(this.label11);
            this.g.Controls.Add(this.txLocalidad);
            this.g.Controls.Add(this.label4);
            this.g.Controls.Add(this.comboBox2);
            this.g.Controls.Add(this.label2);
            this.g.Controls.Add(this.cbTipoInmueble);
            this.g.Controls.Add(this.label1);
            this.g.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.Location = new System.Drawing.Point(2, 1);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(626, 142);
            this.g.TabIndex = 4;
            this.g.TabStop = false;
            // 
            // cbAmbientes
            // 
            this.cbAmbientes.BackColor = System.Drawing.Color.Beige;
            this.cbAmbientes.FormattingEnabled = true;
            this.cbAmbientes.Location = new System.Drawing.Point(80, 81);
            this.cbAmbientes.Name = "cbAmbientes";
            this.cbAmbientes.Size = new System.Drawing.Size(190, 22);
            this.cbAmbientes.TabIndex = 5;
            this.cbAmbientes.SelectedValueChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 14);
            this.label17.TabIndex = 51;
            this.label17.Text = "Ambientes:";
            // 
            // txCalle
            // 
            this.txCalle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCalle.Location = new System.Drawing.Point(329, 53);
            this.txCalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txCalle.Name = "txCalle";
            this.txCalle.Size = new System.Drawing.Size(281, 22);
            this.txCalle.TabIndex = 4;
            this.txCalle.TextChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 50;
            this.label3.Text = "Calle: ";
            // 
            // numPrecioHasta
            // 
            this.numPrecioHasta.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrecioHasta.Location = new System.Drawing.Point(301, 109);
            this.numPrecioHasta.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numPrecioHasta.Name = "numPrecioHasta";
            this.numPrecioHasta.Size = new System.Drawing.Size(120, 22);
            this.numPrecioHasta.TabIndex = 7;
            this.numPrecioHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrecioHasta.ThousandsSeparator = true;
            this.numPrecioHasta.ValueChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 14);
            this.label6.TabIndex = 47;
            this.label6.Text = "Precio Hasta:";
            // 
            // cbTipoOperacion
            // 
            this.cbTipoOperacion.BackColor = System.Drawing.Color.Beige;
            this.cbTipoOperacion.FormattingEnabled = true;
            this.cbTipoOperacion.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbTipoOperacion.Location = new System.Drawing.Point(355, 21);
            this.cbTipoOperacion.Name = "cbTipoOperacion";
            this.cbTipoOperacion.Size = new System.Drawing.Size(207, 22);
            this.cbTipoOperacion.TabIndex = 2;
            this.cbTipoOperacion.SelectedValueChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // cbMoneda
            // 
            this.cbMoneda.BackColor = System.Drawing.Color.Beige;
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Location = new System.Drawing.Point(509, 111);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(101, 22);
            this.cbMoneda.TabIndex = 8;
            this.cbMoneda.SelectedValueChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(454, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 14);
            this.label12.TabIndex = 22;
            this.label12.Text = "Moneda:";
            // 
            // numPrecioDesde
            // 
            this.numPrecioDesde.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrecioDesde.Location = new System.Drawing.Point(87, 109);
            this.numPrecioDesde.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numPrecioDesde.Name = "numPrecioDesde";
            this.numPrecioDesde.Size = new System.Drawing.Size(120, 22);
            this.numPrecioDesde.TabIndex = 6;
            this.numPrecioDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrecioDesde.ThousandsSeparator = true;
            this.numPrecioDesde.ValueChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 14);
            this.label11.TabIndex = 20;
            this.label11.Text = "Precio Desde:";
            // 
            // txLocalidad
            // 
            this.txLocalidad.Location = new System.Drawing.Point(69, 53);
            this.txLocalidad.Name = "txLocalidad";
            this.txLocalidad.Size = new System.Drawing.Size(201, 22);
            this.txLocalidad.TabIndex = 3;
            this.txLocalidad.TextChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Localidad:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(334, -51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 22);
            this.comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operacion: ";
            // 
            // cbTipoInmueble
            // 
            this.cbTipoInmueble.BackColor = System.Drawing.Color.Beige;
            this.cbTipoInmueble.FormattingEnabled = true;
            this.cbTipoInmueble.Location = new System.Drawing.Point(108, 21);
            this.cbTipoInmueble.Name = "cbTipoInmueble";
            this.cbTipoInmueble.Size = new System.Drawing.Size(162, 22);
            this.cbTipoInmueble.TabIndex = 1;
            this.cbTipoInmueble.SelectedValueChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Inmueble:";
            // 
            // btImprimir
            // 
            this.btImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btImprimir.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.Location = new System.Drawing.Point(2, 387);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(140, 25);
            this.btImprimir.TabIndex = 11;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click_1);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(301, 384);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(160, 31);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click_1);
            // 
            // btMasDetalles
            // 
            this.btMasDetalles.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btMasDetalles.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMasDetalles.Location = new System.Drawing.Point(467, 384);
            this.btMasDetalles.Name = "btMasDetalles";
            this.btMasDetalles.Size = new System.Drawing.Size(160, 31);
            this.btMasDetalles.TabIndex = 9;
            this.btMasDetalles.Text = "Mas Detalles";
            this.btMasDetalles.UseVisualStyleBackColor = false;
            this.btMasDetalles.Click += new System.EventHandler(this.btMasDetalles_Click);
            // 
            // chDisponible
            // 
            this.chDisponible.AutoSize = true;
            this.chDisponible.Location = new System.Drawing.Point(2, 149);
            this.chDisponible.Name = "chDisponible";
            this.chDisponible.Size = new System.Drawing.Size(173, 17);
            this.chDisponible.TabIndex = 12;
            this.chDisponible.Text = "Ver sólo Inmuebles disponibles ";
            this.chDisponible.UseVisualStyleBackColor = true;
            this.chDisponible.CheckedChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // frmBuscarInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(632, 424);
            this.Controls.Add(this.chDisponible);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btMasDetalles);
            this.Controls.Add(this.gvResultado);
            this.Controls.Add(this.g);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscarInmueble";
            this.Text = "frmBuscarInmueble";
            this.Load += new System.EventHandler(this.frmBuscarInmueble_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvResultado)).EndInit();
            this.g.ResumeLayout(false);
            this.g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioDesde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvResultado;
        private System.Windows.Forms.GroupBox g;
        private System.Windows.Forms.NumericUpDown numPrecioHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTipoOperacion;
        private System.Windows.Forms.ComboBox cbMoneda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numPrecioDesde;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txLocalidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoInmueble;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btMasDetalles;
        private System.Windows.Forms.TextBox txCalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chDisponible;
        private System.Windows.Forms.ComboBox cbAmbientes;
        private System.Windows.Forms.Label label17;
    }
}