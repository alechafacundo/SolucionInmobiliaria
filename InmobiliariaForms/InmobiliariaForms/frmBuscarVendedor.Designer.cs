﻿namespace InmobiliariaForms
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btBuscar = new System.Windows.Forms.Button();
            this.gvResultado = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.btBuscar);
            this.groupBox1.Controls.Add(this.panel1);
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
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::InmobiliariaForms.Properties.Resources.MV;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(220, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 100);
            this.panel1.TabIndex = 29;
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(54, 120);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(552, 20);
            this.txEmail.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Email:";
            // 
            // txCelular
            // 
            this.txCelular.Location = new System.Drawing.Point(330, 93);
            this.txCelular.Name = "txCelular";
            this.txCelular.Size = new System.Drawing.Size(276, 20);
            this.txCelular.TabIndex = 26;
            // 
            // txTelefono
            // 
            this.txTelefono.Location = new System.Drawing.Point(99, 92);
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(176, 20);
            this.txTelefono.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Telefono Laboral:";
            // 
            // txLegajo
            // 
            this.txLegajo.Location = new System.Drawing.Point(274, 65);
            this.txLegajo.Name = "txLegajo";
            this.txLegajo.Size = new System.Drawing.Size(224, 20);
            this.txLegajo.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Legajo:";
            // 
            // txDNI
            // 
            this.txDNI.Location = new System.Drawing.Point(54, 63);
            this.txDNI.Name = "txDNI";
            this.txDNI.Size = new System.Drawing.Size(142, 20);
            this.txDNI.TabIndex = 20;
            // 
            // txApellido
            // 
            this.txApellido.Location = new System.Drawing.Point(53, 37);
            this.txApellido.Name = "txApellido";
            this.txApellido.Size = new System.Drawing.Size(553, 20);
            this.txApellido.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "D.N.I.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apellido:";
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(53, 10);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(553, 20);
            this.txNombre.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre:";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Location = new System.Drawing.Point(498, 220);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(108, 23);
            this.btCancelar.TabIndex = 76;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(498, 190);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(108, 23);
            this.btBuscar.TabIndex = 75;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            // 
            // gvResultado
            // 
            this.gvResultado.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResultado.Location = new System.Drawing.Point(2, 258);
            this.gvResultado.Name = "gvResultado";
            this.gvResultado.Size = new System.Drawing.Size(612, 191);
            this.gvResultado.TabIndex = 44;
            // 
            // frmBuscarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(616, 453);
            this.Controls.Add(this.gvResultado);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscarVendedor";
            this.Text = "frmBuscarVendedor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView gvResultado;
    }
}