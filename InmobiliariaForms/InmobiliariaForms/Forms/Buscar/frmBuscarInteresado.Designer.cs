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
            this.gvResultado = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAmbientes = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txApellido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txObservaciones = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.chDisponible = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultado)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesde)).BeginInit();
            this.SuspendLayout();
            // 
            // gvResultado
            // 
            this.gvResultado.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResultado.Location = new System.Drawing.Point(9, 215);
            this.gvResultado.MultiSelect = false;
            this.gvResultado.Name = "gvResultado";
            this.gvResultado.ReadOnly = true;
            this.gvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvResultado.Size = new System.Drawing.Size(612, 154);
            this.gvResultado.TabIndex = 13;
            this.gvResultado.DoubleClick += new System.EventHandler(this.btBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLocalidad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbAmbientes);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txApellido);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txObservaciones);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbMoneda);
            this.groupBox1.Controls.Add(this.label12);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 185);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.BackColor = System.Drawing.Color.Beige;
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(298, 127);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(121, 23);
            this.cbLocalidad.TabIndex = 11;
            this.cbLocalidad.SelectedValueChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(232, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 80;
            this.label8.Text = "Provincia:";
            // 
            // cbAmbientes
            // 
            this.cbAmbientes.BackColor = System.Drawing.Color.Beige;
            this.cbAmbientes.FormattingEnabled = true;
            this.cbAmbientes.Location = new System.Drawing.Point(86, 127);
            this.cbAmbientes.Name = "cbAmbientes";
            this.cbAmbientes.Size = new System.Drawing.Size(121, 23);
            this.cbAmbientes.TabIndex = 10;
            this.cbAmbientes.SelectedValueChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 131);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 15);
            this.label17.TabIndex = 78;
            this.label17.Text = "Ambientes:";
            // 
            // txApellido
            // 
            this.txApellido.Location = new System.Drawing.Point(346, 20);
            this.txApellido.Name = "txApellido";
            this.txApellido.Size = new System.Drawing.Size(259, 21);
            this.txApellido.TabIndex = 2;
            this.txApellido.TextChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 76;
            this.label10.Text = "Apellido:";
            // 
            // txNombre
            // 
            this.txNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNombre.Location = new System.Drawing.Point(73, 20);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(213, 21);
            this.txNombre.TabIndex = 1;
            this.txNombre.TextChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Nombre:";
            // 
            // txObservaciones
            // 
            this.txObservaciones.Location = new System.Drawing.Point(107, 154);
            this.txObservaciones.Name = "txObservaciones";
            this.txObservaciones.Size = new System.Drawing.Size(498, 21);
            this.txObservaciones.TabIndex = 12;
            this.txObservaciones.TextChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 72;
            this.label9.Text = "Observaciones:";
            // 
            // cbMoneda
            // 
            this.cbMoneda.BackColor = System.Drawing.Color.Beige;
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Location = new System.Drawing.Point(62, 75);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(67, 23);
            this.cbMoneda.TabIndex = 5;
            this.cbMoneda.SelectedValueChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(9, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 15);
            this.label12.TabIndex = 71;
            this.label12.Text = "Moneda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(302, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 69;
            this.label7.Text = "Tipo de Operación:";
            // 
            // cbTipoOperacion
            // 
            this.cbTipoOperacion.BackColor = System.Drawing.Color.Beige;
            this.cbTipoOperacion.FormattingEnabled = true;
            this.cbTipoOperacion.Location = new System.Drawing.Point(416, 101);
            this.cbTipoOperacion.Name = "cbTipoOperacion";
            this.cbTipoOperacion.Size = new System.Drawing.Size(189, 23);
            this.cbTipoOperacion.TabIndex = 9;
            this.cbTipoOperacion.SelectedValueChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 68;
            this.label6.Text = "Tipo de Inmueble:";
            // 
            // cbTipoInmueble
            // 
            this.cbTipoInmueble.BackColor = System.Drawing.Color.Beige;
            this.cbTipoInmueble.FormattingEnabled = true;
            this.cbTipoInmueble.Location = new System.Drawing.Point(117, 101);
            this.cbTipoInmueble.Name = "cbTipoInmueble";
            this.cbTipoInmueble.Size = new System.Drawing.Size(147, 23);
            this.cbTipoInmueble.TabIndex = 8;
            this.cbTipoInmueble.SelectedValueChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // numHasta
            // 
            this.numHasta.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHasta.Location = new System.Drawing.Point(458, 75);
            this.numHasta.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numHasta.Name = "numHasta";
            this.numHasta.Size = new System.Drawing.Size(147, 21);
            this.numHasta.TabIndex = 7;
            this.numHasta.ThousandsSeparator = true;
            this.numHasta.ValueChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 64;
            this.label5.Text = "Monto Hasta:";
            // 
            // numDesde
            // 
            this.numDesde.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDesde.Location = new System.Drawing.Point(215, 75);
            this.numDesde.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numDesde.Name = "numDesde";
            this.numDesde.Size = new System.Drawing.Size(133, 21);
            this.numDesde.TabIndex = 6;
            this.numDesde.ThousandsSeparator = true;
            this.numDesde.ValueChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(134, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 61;
            this.label4.Text = "Monto Desde:";
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(291, 48);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(314, 21);
            this.txEmail.TabIndex = 4;
            this.txEmail.TextChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 59;
            this.label3.Text = "Email:";
            // 
            // txTelefono
            // 
            this.txTelefono.Location = new System.Drawing.Point(61, 48);
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(173, 21);
            this.txTelefono.TabIndex = 3;
            this.txTelefono.TextChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 55;
            this.label2.Text = "Teléfono:";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(301, 375);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(160, 31);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(467, 375);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(154, 31);
            this.btBuscar.TabIndex = 13;
            this.btBuscar.Text = "Mas Detalles";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.Location = new System.Drawing.Point(9, 375);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(140, 25);
            this.btImprimir.TabIndex = 15;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // chDisponible
            // 
            this.chDisponible.AutoSize = true;
            this.chDisponible.Location = new System.Drawing.Point(11, 192);
            this.chDisponible.Name = "chDisponible";
            this.chDisponible.Size = new System.Drawing.Size(180, 17);
            this.chDisponible.TabIndex = 76;
            this.chDisponible.Text = "Ver sólo Interesados disponibles ";
            this.chDisponible.UseVisualStyleBackColor = true;
            this.chDisponible.CheckedChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // frmBuscarInteresado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(629, 418);
            this.Controls.Add(this.chDisponible);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.gvResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscarInteresado";
            this.Text = "frmBuscarInteresado";
            this.Load += new System.EventHandler(this.frmBuscarInteresado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvResultado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.ComboBox cbMoneda;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txObservaciones;
        private System.Windows.Forms.CheckBox chDisponible;
        private System.Windows.Forms.TextBox txApellido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAmbientes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.Label label8;
    }
}