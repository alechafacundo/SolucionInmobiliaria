namespace InmobiliariaForms
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
            this.cbAmbientes = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txApellido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkDisponible = new System.Windows.Forms.CheckBox();
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
            this.txEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.gvInmueblesParaInteresado = new System.Windows.Forms.DataGridView();
            this.lbInmuebles = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInmueblesParaInteresado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.cbAmbientes);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.btGuardar);
            this.groupBox1.Controls.Add(this.txApellido);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.checkDisponible);
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
            this.groupBox1.Controls.Add(this.txEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txTelefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbAmbientes
            // 
            this.cbAmbientes.BackColor = System.Drawing.Color.Beige;
            this.cbAmbientes.FormattingEnabled = true;
            this.cbAmbientes.Location = new System.Drawing.Point(187, 152);
            this.cbAmbientes.Name = "cbAmbientes";
            this.cbAmbientes.Size = new System.Drawing.Size(121, 22);
            this.cbAmbientes.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(117, 156);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 14);
            this.label17.TabIndex = 46;
            this.label17.Text = "Ambientes:";
            // 
            // txApellido
            // 
            this.txApellido.Location = new System.Drawing.Point(347, 15);
            this.txApellido.Name = "txApellido";
            this.txApellido.Size = new System.Drawing.Size(269, 22);
            this.txApellido.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 14);
            this.label10.TabIndex = 27;
            this.label10.Text = "Apellido:";
            // 
            // checkDisponible
            // 
            this.checkDisponible.AutoSize = true;
            this.checkDisponible.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkDisponible.Checked = true;
            this.checkDisponible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDisponible.Font = new System.Drawing.Font("Roboto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDisponible.Location = new System.Drawing.Point(11, 153);
            this.checkDisponible.Name = "checkDisponible";
            this.checkDisponible.Size = new System.Drawing.Size(86, 19);
            this.checkDisponible.TabIndex = 26;
            this.checkDisponible.Text = "Disponible";
            this.checkDisponible.UseVisualStyleBackColor = true;
            // 
            // txObservaciones
            // 
            this.txObservaciones.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txObservaciones.Location = new System.Drawing.Point(6, 199);
            this.txObservaciones.Multiline = true;
            this.txObservaciones.Name = "txObservaciones";
            this.txObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txObservaciones.Size = new System.Drawing.Size(609, 66);
            this.txObservaciones.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Observaciones:";
            // 
            // cbMoneda
            // 
            this.cbMoneda.BackColor = System.Drawing.Color.Beige;
            this.cbMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Location = new System.Drawing.Point(75, 85);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(133, 24);
            this.cbMoneda.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Moneda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo de Operación:";
            // 
            // cbTipoOperacion
            // 
            this.cbTipoOperacion.BackColor = System.Drawing.Color.Beige;
            this.cbTipoOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoOperacion.FormattingEnabled = true;
            this.cbTipoOperacion.Location = new System.Drawing.Point(427, 117);
            this.cbTipoOperacion.Name = "cbTipoOperacion";
            this.cbTipoOperacion.Size = new System.Drawing.Size(191, 23);
            this.cbTipoOperacion.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo de Inmueble:";
            // 
            // cbTipoInmueble
            // 
            this.cbTipoInmueble.BackColor = System.Drawing.Color.Beige;
            this.cbTipoInmueble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoInmueble.FormattingEnabled = true;
            this.cbTipoInmueble.Location = new System.Drawing.Point(132, 117);
            this.cbTipoInmueble.Name = "cbTipoInmueble";
            this.cbTipoInmueble.Size = new System.Drawing.Size(159, 23);
            this.cbTipoInmueble.TabIndex = 7;
            // 
            // numHasta
            // 
            this.numHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHasta.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHasta.Location = new System.Drawing.Point(330, 86);
            this.numHasta.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numHasta.Name = "numHasta";
            this.numHasta.Size = new System.Drawing.Size(152, 21);
            this.numHasta.TabIndex = 6;
            this.numHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numHasta.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Monto Hasta:";
            // 
            // txEmail
            // 
            this.txEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEmail.Location = new System.Drawing.Point(289, 52);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(328, 21);
            this.txEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // txTelefono
            // 
            this.txTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTelefono.Location = new System.Drawing.Point(75, 52);
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(165, 21);
            this.txTelefono.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teléfono:";
            // 
            // txNombre
            // 
            this.txNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNombre.Location = new System.Drawing.Point(73, 16);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(199, 21);
            this.txNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btEliminar
            // 
            this.btEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEliminar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(8, 267);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(130, 31);
            this.btEliminar.TabIndex = 13;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Visible = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(351, 271);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(130, 31);
            this.btCancelar.TabIndex = 12;
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
            this.btGuardar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(489, 271);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(130, 31);
            this.btGuardar.TabIndex = 11;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // gvInmueblesParaInteresado
            // 
            this.gvInmueblesParaInteresado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvInmueblesParaInteresado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvInmueblesParaInteresado.Location = new System.Drawing.Point(5, 321);
            this.gvInmueblesParaInteresado.MultiSelect = false;
            this.gvInmueblesParaInteresado.Name = "gvInmueblesParaInteresado";
            this.gvInmueblesParaInteresado.ReadOnly = true;
            this.gvInmueblesParaInteresado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvInmueblesParaInteresado.Size = new System.Drawing.Size(622, 87);
            this.gvInmueblesParaInteresado.TabIndex = 15;
            this.gvInmueblesParaInteresado.Visible = false;
            this.gvInmueblesParaInteresado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvInmueblesParaInteresado_CellContentClick);
            // 
            // lbInmuebles
            // 
            this.lbInmuebles.AutoSize = true;
            this.lbInmuebles.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInmuebles.Location = new System.Drawing.Point(5, 303);
            this.lbInmuebles.Name = "lbInmuebles";
            this.lbInmuebles.Size = new System.Drawing.Size(192, 15);
            this.lbInmuebles.TabIndex = 16;
            this.lbInmuebles.Text = "Inmuebles Para Este Interesado";
            this.lbInmuebles.Visible = false;
            // 
            // frmInteresado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(632, 413);
            this.Controls.Add(this.lbInmuebles);
            this.Controls.Add(this.gvInmueblesParaInteresado);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInteresado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Interesado";
            this.Load += new System.EventHandler(this.frmInteresado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInmueblesParaInteresado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTipoOperacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTipoInmueble;
        private System.Windows.Forms.NumericUpDown numHasta;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.TextBox txObservaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkDisponible;
        private System.Windows.Forms.DataGridView gvInmueblesParaInteresado;
        private System.Windows.Forms.Label lbInmuebles;
        private System.Windows.Forms.TextBox txApellido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbAmbientes;
        private System.Windows.Forms.Label label17;
    }
}