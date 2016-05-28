namespace InmobiliariaForms
{
    partial class Prueba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prueba));
            this.netBarControl1 = new NetBarControl.NetBarControl();
            this.netBarGroup6 = new NetBarControl.NetBarGroup();
            this.btNuevoVendedor = new NetBarControl.NetBarItem();
            this.btBuscarVendedor = new NetBarControl.NetBarItem();
            this.netBarGroup1 = new NetBarControl.NetBarGroup();
            this.btNuevoInteresado = new NetBarControl.NetBarItem();
            this.btBuscarInteresado = new NetBarControl.NetBarItem();
            this.netBarGroup2 = new NetBarControl.NetBarGroup();
            this.btNuevoInmueble = new NetBarControl.NetBarItem();
            this.btBuscarInmueble = new NetBarControl.NetBarItem();
            this.netBarGroup3 = new NetBarControl.NetBarGroup();
            this.netBarItem5 = new NetBarControl.NetBarItem();
            this.netBarItem6 = new NetBarControl.NetBarItem();
            this.netBarGroup4 = new NetBarControl.NetBarGroup();
            this.netBarItem7 = new NetBarControl.NetBarItem();
            this.netBarItem8 = new NetBarControl.NetBarItem();
            this.netBarGroup5 = new NetBarControl.NetBarGroup();
            this.netBarItem9 = new NetBarControl.NetBarItem();
            this.netBarItem10 = new NetBarControl.NetBarItem();
            this.SuspendLayout();
            // 
            // netBarControl1
            // 
            this.netBarControl1.ActiveGroup = this.netBarGroup6;
            this.netBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.netBarControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.netBarControl1.Groups.AddRange(new NetBarControl.NetBarGroup[] {
            this.netBarGroup1,
            this.netBarGroup2,
            this.netBarGroup3,
            this.netBarGroup4,
            this.netBarGroup5,
            this.netBarGroup6});
            this.netBarControl1.ItemsBackground.BackColor = System.Drawing.Color.Empty;
            this.netBarControl1.ItemsBackground.BackColor2 = System.Drawing.Color.Empty;
            this.netBarControl1.Location = new System.Drawing.Point(1, -1);
            this.netBarControl1.Name = "netBarControl1";
            this.netBarControl1.ShowExpandButton = false;
            this.netBarControl1.ShowHorizontalSplitter = false;
            this.netBarControl1.ShowOverflowPanel = false;
            this.netBarControl1.ShowPopupShadow = true;
            this.netBarControl1.ShowVerticalSplitter = false;
            this.netBarControl1.Size = new System.Drawing.Size(132, 535);
            this.netBarControl1.TabIndex = 2;
            this.netBarControl1.Text = "netBarControl1";
            // 
            // netBarGroup6
            // 
            this.netBarGroup6.Items.AddRange(new NetBarControl.NetBarItem[] {
            this.btNuevoVendedor,
            this.btBuscarVendedor});
            this.netBarGroup6.Name = "netBarGroup6";
            this.netBarGroup6.Style = NetBarControl.NetBarGroupStyle.LargeItemList;
            this.netBarGroup6.Text = "Vendedores";
            // 
            // btNuevoVendedor
            // 
            this.btNuevoVendedor.Font = new System.Drawing.Font("News Cycle", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevoVendedor.LargeImage = ((System.Drawing.Image)(resources.GetObject("btNuevoVendedor.LargeImage")));
            this.btNuevoVendedor.Name = "btNuevoVendedor";
            this.btNuevoVendedor.Text = "Nuevo Vendedor";
            this.btNuevoVendedor.ItemClick += new System.EventHandler(this.btNuevoVendedor_ItemClick);
            // 
            // btBuscarVendedor
            // 
            this.btBuscarVendedor.Font = new System.Drawing.Font("News Cycle", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarVendedor.LargeImage = ((System.Drawing.Image)(resources.GetObject("btBuscarVendedor.LargeImage")));
            this.btBuscarVendedor.Name = "btBuscarVendedor";
            this.btBuscarVendedor.Text = "Buscar Vendedor";
            // 
            // netBarGroup1
            // 
            this.netBarGroup1.Font = new System.Drawing.Font("News Cycle", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netBarGroup1.Items.AddRange(new NetBarControl.NetBarItem[] {
            this.btNuevoInteresado,
            this.btBuscarInteresado});
            this.netBarGroup1.Name = "netBarGroup1";
            this.netBarGroup1.Style = NetBarControl.NetBarGroupStyle.LargeItemList;
            this.netBarGroup1.Text = "Interesados";
            // 
            // btNuevoInteresado
            // 
            this.btNuevoInteresado.Font = new System.Drawing.Font("News Cycle", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevoInteresado.LargeImage = ((System.Drawing.Image)(resources.GetObject("btNuevoInteresado.LargeImage")));
            this.btNuevoInteresado.Name = "btNuevoInteresado";
            this.btNuevoInteresado.Text = "Nuevo Interesado";
            this.btNuevoInteresado.ItemClick += new System.EventHandler(this.btNuevoInteresado_ItemClick);
            // 
            // btBuscarInteresado
            // 
            this.btBuscarInteresado.Font = new System.Drawing.Font("News Cycle", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarInteresado.LargeImage = ((System.Drawing.Image)(resources.GetObject("btBuscarInteresado.LargeImage")));
            this.btBuscarInteresado.Name = "btBuscarInteresado";
            this.btBuscarInteresado.Text = "Buscar Interesado";
            // 
            // netBarGroup2
            // 
            this.netBarGroup2.Font = new System.Drawing.Font("News Cycle", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netBarGroup2.Items.AddRange(new NetBarControl.NetBarItem[] {
            this.btNuevoInmueble,
            this.btBuscarInmueble});
            this.netBarGroup2.Name = "netBarGroup2";
            this.netBarGroup2.Style = NetBarControl.NetBarGroupStyle.LargeItemList;
            this.netBarGroup2.Text = "Inmuebles";
            // 
            // btNuevoInmueble
            // 
            this.btNuevoInmueble.Font = new System.Drawing.Font("News Cycle", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevoInmueble.LargeImage = ((System.Drawing.Image)(resources.GetObject("btNuevoInmueble.LargeImage")));
            this.btNuevoInmueble.Name = "btNuevoInmueble";
            this.btNuevoInmueble.Text = "Nuevo Inmueble";
            this.btNuevoInmueble.ItemClick += new System.EventHandler(this.btNuevoInmueble_ItemClick);
            // 
            // btBuscarInmueble
            // 
            this.btBuscarInmueble.Font = new System.Drawing.Font("News Cycle", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarInmueble.LargeImage = ((System.Drawing.Image)(resources.GetObject("btBuscarInmueble.LargeImage")));
            this.btBuscarInmueble.Name = "btBuscarInmueble";
            this.btBuscarInmueble.Text = "Buscar Inmueble";
            // 
            // netBarGroup3
            // 
            this.netBarGroup3.Items.AddRange(new NetBarControl.NetBarItem[] {
            this.netBarItem5,
            this.netBarItem6});
            this.netBarGroup3.Name = "netBarGroup3";
            this.netBarGroup3.Style = NetBarControl.NetBarGroupStyle.LargeItemList;
            this.netBarGroup3.Text = "Vendedor";
            this.netBarGroup3.Visible = false;
            // 
            // netBarItem5
            // 
            this.netBarItem5.Name = "netBarItem5";
            this.netBarItem5.Text = "Nuevo Vendedor";
            // 
            // netBarItem6
            // 
            this.netBarItem6.Name = "netBarItem6";
            this.netBarItem6.Text = "Buscar Vendedor";
            // 
            // netBarGroup4
            // 
            this.netBarGroup4.Items.AddRange(new NetBarControl.NetBarItem[] {
            this.netBarItem7,
            this.netBarItem8});
            this.netBarGroup4.Name = "netBarGroup4";
            this.netBarGroup4.Style = NetBarControl.NetBarGroupStyle.LargeItemList;
            this.netBarGroup4.Text = "Localidad";
            this.netBarGroup4.Visible = false;
            // 
            // netBarItem7
            // 
            this.netBarItem7.Name = "netBarItem7";
            this.netBarItem7.Text = "Nueva Localidad";
            // 
            // netBarItem8
            // 
            this.netBarItem8.Name = "netBarItem8";
            this.netBarItem8.Text = "Buscar Localidad";
            // 
            // netBarGroup5
            // 
            this.netBarGroup5.Items.AddRange(new NetBarControl.NetBarItem[] {
            this.netBarItem9,
            this.netBarItem10});
            this.netBarGroup5.Name = "netBarGroup5";
            this.netBarGroup5.Style = NetBarControl.NetBarGroupStyle.LargeItemList;
            this.netBarGroup5.Text = "Barrio";
            this.netBarGroup5.Visible = false;
            // 
            // netBarItem9
            // 
            this.netBarItem9.Name = "netBarItem9";
            this.netBarItem9.Text = "Nuevo Barrio";
            // 
            // netBarItem10
            // 
            this.netBarItem10.Name = "netBarItem10";
            this.netBarItem10.Text = "Buscar Barrio";
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(767, 535);
            this.Controls.Add(this.netBarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prueba";
            this.Text = "Moran Villa Bienes Raices";
            this.ResumeLayout(false);

        }

        #endregion

        private NetBarControl.NetBarControl netBarControl1;
        private NetBarControl.NetBarGroup netBarGroup1;
        private NetBarControl.NetBarItem btNuevoInteresado;
        private NetBarControl.NetBarItem btBuscarInteresado;
        private NetBarControl.NetBarGroup netBarGroup2;
        private NetBarControl.NetBarItem btNuevoInmueble;
        private NetBarControl.NetBarItem btBuscarInmueble;
        private NetBarControl.NetBarGroup netBarGroup3;
        private NetBarControl.NetBarItem netBarItem5;
        private NetBarControl.NetBarItem netBarItem6;
        private NetBarControl.NetBarGroup netBarGroup4;
        private NetBarControl.NetBarItem netBarItem7;
        private NetBarControl.NetBarItem netBarItem8;
        private NetBarControl.NetBarGroup netBarGroup5;
        private NetBarControl.NetBarItem netBarItem9;
        private NetBarControl.NetBarItem netBarItem10;
        private NetBarControl.NetBarGroup netBarGroup6;
        private NetBarControl.NetBarItem btNuevoVendedor;
        private NetBarControl.NetBarItem btBuscarVendedor;
    }
}