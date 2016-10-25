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
            this.btEliminar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btGuardarFotos = new System.Windows.Forms.Button();
            this.btVerFotos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoInmueble = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txCalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txNumero = new System.Windows.Forms.TextBox();
            this.txPiso = new System.Windows.Forms.TextBox();
            this.txDepto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txEntreCalles = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txMtsTerreno = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txSupCubierta = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txObservaciones = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txComentariosInternos = new System.Windows.Forms.TextBox();
            this.txReferencia = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txContacto = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cbCargadoPor = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbTipoOperacion = new System.Windows.Forms.ComboBox();
            this.checkDisponible = new System.Windows.Forms.CheckBox();
            this.g = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbUbicacion = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txAntiguedad = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbCochera = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbAmbientes = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btPublicarWeb = new System.Windows.Forms.Button();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.g.SuspendLayout();
            this.SuspendLayout();
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEliminar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(7, 423);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(130, 31);
            this.btEliminar.TabIndex = 26;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Visible = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(354, 423);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(130, 31);
            this.btCancelar.TabIndex = 25;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btGuardar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(489, 423);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(130, 31);
            this.btGuardar.TabIndex = 24;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btGuardarFotos
            // 
            this.btGuardarFotos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btGuardarFotos.Enabled = false;
            this.btGuardarFotos.Location = new System.Drawing.Point(152, 428);
            this.btGuardarFotos.Name = "btGuardarFotos";
            this.btGuardarFotos.Size = new System.Drawing.Size(95, 23);
            this.btGuardarFotos.TabIndex = 28;
            this.btGuardarFotos.Text = "Agregar Fotos";
            this.btGuardarFotos.UseVisualStyleBackColor = false;
            this.btGuardarFotos.Click += new System.EventHandler(this.btGuardarFotos_Click);
            // 
            // btVerFotos
            // 
            this.btVerFotos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btVerFotos.Enabled = false;
            this.btVerFotos.Location = new System.Drawing.Point(253, 428);
            this.btVerFotos.Name = "btVerFotos";
            this.btVerFotos.Size = new System.Drawing.Size(95, 23);
            this.btVerFotos.TabIndex = 27;
            this.btVerFotos.Text = "Ver Fotos";
            this.btVerFotos.UseVisualStyleBackColor = false;
            this.btVerFotos.Click += new System.EventHandler(this.btVerFotos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Inmueble:";
            // 
            // cbTipoInmueble
            // 
            this.cbTipoInmueble.BackColor = System.Drawing.Color.Beige;
            this.cbTipoInmueble.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoInmueble.FormattingEnabled = true;
            this.cbTipoInmueble.Location = new System.Drawing.Point(103, 18);
            this.cbTipoInmueble.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTipoInmueble.Name = "cbTipoInmueble";
            this.cbTipoInmueble.Size = new System.Drawing.Size(121, 22);
            this.cbTipoInmueble.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operacion: ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(292, -72);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(106, 23);
            this.comboBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFecha.Location = new System.Drawing.Point(435, 17);
            this.dateTimeFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(171, 22);
            this.dateTimeFecha.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Localidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Calle: ";
            // 
            // txCalle
            // 
            this.txCalle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCalle.Location = new System.Drawing.Point(41, 48);
            this.txCalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txCalle.Name = "txCalle";
            this.txCalle.Size = new System.Drawing.Size(302, 22);
            this.txCalle.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(349, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nº:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(435, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "Piso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(522, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 14);
            this.label9.TabIndex = 14;
            this.label9.Text = "Depto:";
            // 
            // txNumero
            // 
            this.txNumero.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNumero.Location = new System.Drawing.Point(382, 48);
            this.txNumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txNumero.Name = "txNumero";
            this.txNumero.Size = new System.Drawing.Size(47, 22);
            this.txNumero.TabIndex = 5;
            // 
            // txPiso
            // 
            this.txPiso.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPiso.Location = new System.Drawing.Point(475, 48);
            this.txPiso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txPiso.Name = "txPiso";
            this.txPiso.Size = new System.Drawing.Size(41, 22);
            this.txPiso.TabIndex = 6;
            // 
            // txDepto
            // 
            this.txDepto.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDepto.Location = new System.Drawing.Point(570, 50);
            this.txDepto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txDepto.Name = "txDepto";
            this.txDepto.Size = new System.Drawing.Size(36, 22);
            this.txDepto.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 14);
            this.label10.TabIndex = 18;
            this.label10.Text = "Entre Calles: ";
            // 
            // txEntreCalles
            // 
            this.txEntreCalles.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEntreCalles.Location = new System.Drawing.Point(79, 78);
            this.txEntreCalles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txEntreCalles.Name = "txEntreCalles";
            this.txEntreCalles.Size = new System.Drawing.Size(255, 22);
            this.txEntreCalles.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 14);
            this.label11.TabIndex = 20;
            this.label11.Text = "Precio:";
            // 
            // numPrecio
            // 
            this.numPrecio.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrecio.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrecio.Location = new System.Drawing.Point(53, 108);
            this.numPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numPrecio.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(105, 22);
            this.numPrecio.TabIndex = 10;
            this.numPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrecio.ThousandsSeparator = true;
            // 
            // cbMoneda
            // 
            this.cbMoneda.BackColor = System.Drawing.Color.Beige;
            this.cbMoneda.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Location = new System.Drawing.Point(224, 107);
            this.cbMoneda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(60, 22);
            this.cbMoneda.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(290, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 14);
            this.label13.TabIndex = 24;
            this.label13.Text = "Mts Terreno: ";
            // 
            // txMtsTerreno
            // 
            this.txMtsTerreno.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMtsTerreno.Location = new System.Drawing.Point(373, 108);
            this.txMtsTerreno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txMtsTerreno.Name = "txMtsTerreno";
            this.txMtsTerreno.Size = new System.Drawing.Size(56, 22);
            this.txMtsTerreno.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(435, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 14);
            this.label14.TabIndex = 26;
            this.label14.Text = "Sup. Cubierta:";
            // 
            // txSupCubierta
            // 
            this.txSupCubierta.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSupCubierta.Location = new System.Drawing.Point(524, 108);
            this.txSupCubierta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txSupCubierta.Name = "txSupCubierta";
            this.txSupCubierta.Size = new System.Drawing.Size(65, 22);
            this.txSupCubierta.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 14);
            this.label16.TabIndex = 30;
            this.label16.Text = "Observaciones: ";
            // 
            // txObservaciones
            // 
            this.txObservaciones.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txObservaciones.Location = new System.Drawing.Point(7, 212);
            this.txObservaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txObservaciones.Multiline = true;
            this.txObservaciones.Name = "txObservaciones";
            this.txObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txObservaciones.Size = new System.Drawing.Size(600, 70);
            this.txObservaciones.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txComentariosInternos);
            this.groupBox1.Controls.Add(this.txReferencia);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txContacto);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.cbCargadoPor);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 290);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(602, 120);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 14);
            this.label5.TabIndex = 27;
            this.label5.Text = "Comentarios Internos:";
            // 
            // txComentariosInternos
            // 
            this.txComentariosInternos.Location = new System.Drawing.Point(11, 65);
            this.txComentariosInternos.Multiline = true;
            this.txComentariosInternos.Name = "txComentariosInternos";
            this.txComentariosInternos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txComentariosInternos.Size = new System.Drawing.Size(585, 48);
            this.txComentariosInternos.TabIndex = 23;
            // 
            // txReferencia
            // 
            this.txReferencia.Location = new System.Drawing.Point(474, 24);
            this.txReferencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txReferencia.Name = "txReferencia";
            this.txReferencia.Size = new System.Drawing.Size(122, 22);
            this.txReferencia.TabIndex = 22;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(407, 28);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 14);
            this.label25.TabIndex = 4;
            this.label25.Text = "Teléfono:";
            // 
            // txContacto
            // 
            this.txContacto.Location = new System.Drawing.Point(291, 23);
            this.txContacto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txContacto.Name = "txContacto";
            this.txContacto.Size = new System.Drawing.Size(110, 22);
            this.txContacto.TabIndex = 21;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(225, 28);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 14);
            this.label24.TabIndex = 2;
            this.label24.Text = "Contacto:";
            // 
            // cbCargadoPor
            // 
            this.cbCargadoPor.BackColor = System.Drawing.Color.Beige;
            this.cbCargadoPor.FormattingEnabled = true;
            this.cbCargadoPor.Location = new System.Drawing.Point(93, 23);
            this.cbCargadoPor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCargadoPor.Name = "cbCargadoPor";
            this.cbCargadoPor.Size = new System.Drawing.Size(126, 22);
            this.cbCargadoPor.TabIndex = 23;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 14);
            this.label23.TabIndex = 0;
            this.label23.Text = "Cargado por:";
            // 
            // cbTipoOperacion
            // 
            this.cbTipoOperacion.BackColor = System.Drawing.Color.Beige;
            this.cbTipoOperacion.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoOperacion.FormattingEnabled = true;
            this.cbTipoOperacion.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbTipoOperacion.Location = new System.Drawing.Point(294, 17);
            this.cbTipoOperacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTipoOperacion.Name = "cbTipoOperacion";
            this.cbTipoOperacion.Size = new System.Drawing.Size(95, 22);
            this.cbTipoOperacion.TabIndex = 2;
            // 
            // checkDisponible
            // 
            this.checkDisponible.AutoSize = true;
            this.checkDisponible.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkDisponible.Checked = true;
            this.checkDisponible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDisponible.Font = new System.Drawing.Font("Roboto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDisponible.Location = new System.Drawing.Point(8, 172);
            this.checkDisponible.Name = "checkDisponible";
            this.checkDisponible.Size = new System.Drawing.Size(96, 19);
            this.checkDisponible.TabIndex = 17;
            this.checkDisponible.Text = "Disponible";
            this.checkDisponible.UseVisualStyleBackColor = true;
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.g.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.g.Controls.Add(this.cbLocalidad);
            this.g.Controls.Add(this.cbEstado);
            this.g.Controls.Add(this.label20);
            this.g.Controls.Add(this.cbUbicacion);
            this.g.Controls.Add(this.label19);
            this.g.Controls.Add(this.txAntiguedad);
            this.g.Controls.Add(this.label18);
            this.g.Controls.Add(this.label15);
            this.g.Controls.Add(this.cbCochera);
            this.g.Controls.Add(this.label12);
            this.g.Controls.Add(this.cbAmbientes);
            this.g.Controls.Add(this.checkDisponible);
            this.g.Controls.Add(this.cbTipoOperacion);
            this.g.Controls.Add(this.groupBox1);
            this.g.Controls.Add(this.label17);
            this.g.Controls.Add(this.txObservaciones);
            this.g.Controls.Add(this.label16);
            this.g.Controls.Add(this.txSupCubierta);
            this.g.Controls.Add(this.label14);
            this.g.Controls.Add(this.txMtsTerreno);
            this.g.Controls.Add(this.label13);
            this.g.Controls.Add(this.cbMoneda);
            this.g.Controls.Add(this.numPrecio);
            this.g.Controls.Add(this.label11);
            this.g.Controls.Add(this.txEntreCalles);
            this.g.Controls.Add(this.label10);
            this.g.Controls.Add(this.txDepto);
            this.g.Controls.Add(this.txPiso);
            this.g.Controls.Add(this.txNumero);
            this.g.Controls.Add(this.label9);
            this.g.Controls.Add(this.label8);
            this.g.Controls.Add(this.label7);
            this.g.Controls.Add(this.txCalle);
            this.g.Controls.Add(this.label6);
            this.g.Controls.Add(this.label4);
            this.g.Controls.Add(this.dateTimeFecha);
            this.g.Controls.Add(this.label3);
            this.g.Controls.Add(this.comboBox2);
            this.g.Controls.Add(this.label2);
            this.g.Controls.Add(this.cbTipoInmueble);
            this.g.Controls.Add(this.label1);
            this.g.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.Location = new System.Drawing.Point(7, 3);
            this.g.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.g.Name = "g";
            this.g.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.g.Size = new System.Drawing.Size(612, 418);
            this.g.TabIndex = 1;
            this.g.TabStop = false;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(380, 169);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(136, 23);
            this.cbEstado.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(324, 173);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 15);
            this.label20.TabIndex = 53;
            this.label20.Text = "Estado:";
            // 
            // cbUbicacion
            // 
            this.cbUbicacion.FormattingEnabled = true;
            this.cbUbicacion.Location = new System.Drawing.Point(195, 170);
            this.cbUbicacion.Name = "cbUbicacion";
            this.cbUbicacion.Size = new System.Drawing.Size(121, 23);
            this.cbUbicacion.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(129, 173);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 15);
            this.label19.TabIndex = 51;
            this.label19.Text = "Ubicacion: ";
            // 
            // txAntiguedad
            // 
            this.txAntiguedad.Location = new System.Drawing.Point(429, 139);
            this.txAntiguedad.Name = "txAntiguedad";
            this.txAntiguedad.Size = new System.Drawing.Size(48, 23);
            this.txAntiguedad.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(349, 142);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 15);
            this.label18.TabIndex = 49;
            this.label18.Text = "Antiguedad:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(168, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 14);
            this.label15.TabIndex = 48;
            this.label15.Text = "Moneda:";
            // 
            // cbCochera
            // 
            this.cbCochera.FormattingEnabled = true;
            this.cbCochera.Location = new System.Drawing.Point(274, 138);
            this.cbCochera.Name = "cbCochera";
            this.cbCochera.Size = new System.Drawing.Size(63, 23);
            this.cbCochera.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(216, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 14);
            this.label12.TabIndex = 46;
            this.label12.Text = "Cochera: ";
            // 
            // cbAmbientes
            // 
            this.cbAmbientes.BackColor = System.Drawing.Color.Beige;
            this.cbAmbientes.FormattingEnabled = true;
            this.cbAmbientes.Location = new System.Drawing.Point(78, 139);
            this.cbAmbientes.Name = "cbAmbientes";
            this.cbAmbientes.Size = new System.Drawing.Size(121, 23);
            this.cbAmbientes.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 14);
            this.label17.TabIndex = 32;
            this.label17.Text = "Ambientes:";
            // 
            // btPublicarWeb
            // 
            this.btPublicarWeb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPublicarWeb.Enabled = false;
            this.btPublicarWeb.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPublicarWeb.Location = new System.Drawing.Point(354, 461);
            this.btPublicarWeb.Name = "btPublicarWeb";
            this.btPublicarWeb.Size = new System.Drawing.Size(265, 29);
            this.btPublicarWeb.TabIndex = 29;
            this.btPublicarWeb.Text = "Publicar Inmueble En la Web";
            this.btPublicarWeb.UseVisualStyleBackColor = false;
            this.btPublicarWeb.Click += new System.EventHandler(this.btPublicarWeb_Click);
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(407, 77);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(157, 23);
            this.cbLocalidad.TabIndex = 54;
            // 
            // frmInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(626, 502);
            this.Controls.Add(this.btPublicarWeb);
            this.Controls.Add(this.btVerFotos);
            this.Controls.Add(this.btGuardarFotos);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.g);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInmueble";
            this.Text = "Inmueble";
            this.Load += new System.EventHandler(this.frmInmueble_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.g.ResumeLayout(false);
            this.g.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btGuardarFotos;
        private System.Windows.Forms.Button btVerFotos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoInmueble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txCalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txNumero;
        private System.Windows.Forms.TextBox txPiso;
        private System.Windows.Forms.TextBox txDepto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txEntreCalles;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.ComboBox cbMoneda;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txMtsTerreno;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txSupCubierta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txObservaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txComentariosInternos;
        private System.Windows.Forms.TextBox txReferencia;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txContacto;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbCargadoPor;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbTipoOperacion;
        private System.Windows.Forms.CheckBox checkDisponible;
        private System.Windows.Forms.GroupBox g;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbCochera;
        private System.Windows.Forms.ComboBox cbUbicacion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txAntiguedad;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbAmbientes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btPublicarWeb;
        private System.Windows.Forms.ComboBox cbLocalidad;
    }
}