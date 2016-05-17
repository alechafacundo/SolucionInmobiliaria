namespace InmobiliariaForms
{
    partial class Home
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
            this.btInmueble = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inmuebleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarInmuebleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interesadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btInmueble
            // 
            this.btInmueble.Location = new System.Drawing.Point(34, 79);
            this.btInmueble.Name = "btInmueble";
            this.btInmueble.Size = new System.Drawing.Size(75, 23);
            this.btInmueble.TabIndex = 0;
            this.btInmueble.Text = "button1";
            this.btInmueble.UseVisualStyleBackColor = true;
            this.btInmueble.Click += new System.EventHandler(this.btInmueble_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inmuebleToolStripMenuItem,
            this.interesadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inmuebleToolStripMenuItem
            // 
            this.inmuebleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.buscarInmuebleToolStripMenuItem});
            this.inmuebleToolStripMenuItem.Name = "inmuebleToolStripMenuItem";
            this.inmuebleToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inmuebleToolStripMenuItem.Text = "Inmueble";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItem1.Text = "Nuevo Inmueble";
            // 
            // buscarInmuebleToolStripMenuItem
            // 
            this.buscarInmuebleToolStripMenuItem.Name = "buscarInmuebleToolStripMenuItem";
            this.buscarInmuebleToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.buscarInmuebleToolStripMenuItem.Text = "Buscar Inmueble";
            // 
            // interesadoToolStripMenuItem
            // 
            this.interesadoToolStripMenuItem.Name = "interesadoToolStripMenuItem";
            this.interesadoToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.interesadoToolStripMenuItem.Text = "Interesado";
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btInmueble);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NetBarControl.NetBarControl netBarControl1;
        private NetBarControl.NetBarGroup netBarGroup1;
        private NetBarControl.NetBarGroup netBarGroup2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private NetBarControl.NetBarItem netBarItem1;
        private NetBarControl.NetBarItem netBarItem2;
        private NetBarControl.NetBarItem netBarItem3;
        private NetBarControl.NetBarItem netBarItem4;
        private NetBarControl.NetBarGroup netBarGroup3;
        private NetBarControl.NetBarItem netBarItem5;
        private NetBarControl.NetBarItem netBarItem6;
        private NetBarControl.NetBarGroup netBarGroup4;
        private NetBarControl.NetBarItem netBarItem7;
        private NetBarControl.NetBarItem netBarItem8;
        private NetBarControl.NetBarGroup netBarGroup5;
        private NetBarControl.NetBarItem netBarItem9;
        private NetBarControl.NetBarItem netBarItem10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btInmueble;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inmuebleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarInmuebleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interesadoToolStripMenuItem;
    }
}

