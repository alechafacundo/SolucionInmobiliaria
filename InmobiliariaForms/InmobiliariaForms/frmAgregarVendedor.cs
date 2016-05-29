using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InmobiliariaForms
{
    public partial class frmAgregarVendedor : Form
    {
        frmBuscarVendedor frmBuscarVendedor;
        frmVendedor frmVendedor;
        public static int MouseHoverTime { get; set; }
        public frmAgregarVendedor()
        {
            InitializeComponent();
        }

        private void pbAgregarVendedor1_MouseHover(object sender, EventArgs e)
        {
            pbAgregarVendedor1.Visible = false;
            pbAgregarVendedor2.Visible = true;
            MouseHoverTime = 1;
        }

        private void pbAgregarVendedor2_MouseLeave(object sender, EventArgs e)
        {
            pbAgregarVendedor1.Visible = true;
            pbAgregarVendedor2.Visible = false;
        }

        private void pbBuscarVendedor1_MouseHover(object sender, EventArgs e)
        {
            pbBuscarVendedor1.Visible = false;
            pbBuscarVendedor2.Visible = true;
            MouseHoverTime = 1;
        }

        private void pbBuscarVendedor2_MouseLeave(object sender, EventArgs e)
        {
            pbBuscarVendedor1.Visible = true;
            pbBuscarVendedor2.Visible = false;
        }

        private void pbAgregarVendedor2_Click(object sender, EventArgs e)
        {
            if (frmVendedor == null || frmVendedor.IsDisposed)
                frmVendedor = new frmVendedor();

            //frmBuscarInmueble.Vendedor = this.Vendedor; Que hace aca??
            frmVendedor.MdiParent = (Form)this.Parent.Parent;
            Panel p = (Panel)this.Parent.Parent.Controls.Find("pnlMdi", true).First();
            p.Controls.Add(frmVendedor);

            frmVendedor.BringToFront();
            frmVendedor.StartPosition = FormStartPosition.Manual;

            //int width = this.Controls.Find("netBarControl1", true)[0].Width;
            frmVendedor.Location = new Point(120, 0);
            this.Close();
            frmVendedor.Show();
        }

        private void pbBuscarVendedor2_Click(object sender, EventArgs e)
        {
            if (frmBuscarVendedor == null || frmBuscarVendedor.IsDisposed)
                frmBuscarVendedor = new frmBuscarVendedor();

            //frmBuscarInmueble.Vendedor = this.Vendedor;
            frmBuscarVendedor.MdiParent = (Form)this.Parent.Parent;
            Panel p = (Panel)this.Parent.Parent.Controls.Find("pnlMdi", true).First();
            p.Controls.Add(frmBuscarVendedor);

            frmBuscarVendedor.BringToFront();
            frmBuscarVendedor.StartPosition = FormStartPosition.Manual;

            //int width = this.Controls.Find("netBarControl1", true)[0].Width;
            frmBuscarVendedor.Location = new Point(120, 0);
            this.Close();
            frmBuscarVendedor.Show();
        }
    }
}
