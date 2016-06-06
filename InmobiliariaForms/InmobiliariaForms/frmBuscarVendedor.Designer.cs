namespace InmobiliariaForms
{
    partial class frmBuscarVendedor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txCelular = new System.Windows.Forms.TextBox();
            this.txTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txLegajo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txDNI = new System.Windows.Forms.TextBox();
            this.txApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btMasDetalles = new System.Windows.Forms.Button();
            this.gvResultado = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txCelular);
            this.groupBox1.Controls.Add(this.txTelefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txLegajo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txDNI);
            this.groupBox1.Controls.Add(this.txApellido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(58, 126);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(544, 22);
            this.txEmail.TabIndex = 28;
            this.txEmail.TextChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 14);
            this.label7.TabIndex = 27;
            this.label7.Text = "Email:";
            // 
            // txCelular
            // 
            this.txCelular.Location = new System.Drawing.Point(348, 98);
            this.txCelular.Name = "txCelular";
            this.txCelular.Size = new System.Drawing.Size(254, 22);
            this.txCelular.TabIndex = 26;
            this.txCelular.TextChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // txTelefono
            // 
            this.txTelefono.Location = new System.Drawing.Point(114, 99);
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(176, 22);
            this.txTelefono.TabIndex = 25;
            this.txTelefono.TextChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 14);
            this.label6.TabIndex = 24;
            this.label6.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 14);
            this.label5.TabIndex = 23;
            this.label5.Text = "Telefono Laboral:";
            // 
            // txLegajo
            // 
            this.txLegajo.Location = new System.Drawing.Point(286, 69);
            this.txLegajo.Name = "txLegajo";
            this.txLegajo.Size = new System.Drawing.Size(224, 22);
            this.txLegajo.TabIndex = 22;
            this.txLegajo.TextChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 21;
            this.label4.Text = "Legajo:";
            // 
            // txDNI
            // 
            this.txDNI.Location = new System.Drawing.Point(62, 69);
            this.txDNI.Name = "txDNI";
            this.txDNI.Size = new System.Drawing.Size(146, 22);
            this.txDNI.TabIndex = 20;
            this.txDNI.TextChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // txApellido
            // 
            this.txApellido.Location = new System.Drawing.Point(62, 41);
            this.txApellido.Name = "txApellido";
            this.txApellido.Size = new System.Drawing.Size(540, 22);
            this.txApellido.TabIndex = 19;
            this.txApellido.TextChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 14);
            this.label3.TabIndex = 18;
            this.label3.Text = "D.N.I.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apellido:";
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(62, 13);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(540, 22);
            this.txNombre.TabIndex = 16;
            this.txNombre.TextChanged += new System.EventHandler(this.FiltrarResultados);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre:";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(288, 343);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(160, 31);
            this.btCancelar.TabIndex = 76;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btMasDetalles
            // 
            this.btMasDetalles.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btMasDetalles.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMasDetalles.Location = new System.Drawing.Point(454, 343);
            this.btMasDetalles.Name = "btMasDetalles";
            this.btMasDetalles.Size = new System.Drawing.Size(160, 31);
            this.btMasDetalles.TabIndex = 75;
            this.btMasDetalles.Text = "Más Detalles";
            this.btMasDetalles.UseVisualStyleBackColor = false;
            this.btMasDetalles.Click += new System.EventHandler(this.btMasDetalles_Click);
            // 
            // gvResultado
            // 
            this.gvResultado.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResultado.Location = new System.Drawing.Point(2, 170);
            this.gvResultado.MultiSelect = false;
            this.gvResultado.Name = "gvResultado";
            this.gvResultado.ReadOnly = true;
            this.gvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvResultado.Size = new System.Drawing.Size(612, 170);
            this.gvResultado.TabIndex = 44;
           
            // frmBuscarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(616, 378);
            this.Controls.Add(this.btMasDetalles);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.gvResultado);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscarVendedor";
            this.Text = "frmBuscarVendedor";
            this.Load += new System.EventHandler(this.frmBuscarVendedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txCelular;
        private System.Windows.Forms.TextBox txTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txLegajo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txDNI;
        private System.Windows.Forms.TextBox txApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btMasDetalles;
        private System.Windows.Forms.DataGridView gvResultado;
    }
}