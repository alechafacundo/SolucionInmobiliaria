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
    public partial class frmInmueble2 : Form
    {
        public static int MouseHoverTime { get; set; }
        frmInteresado frmInteresado;
        frmInmueble frmInmueble;
        frmBuscarInmueble frmBuscarInmueble;
        frmBuscarInteresado frmBuscarInteresado;
        frmVendedor frmVendedor;
        frmBuscarVendedor frmBuscarVendedor;

        //Vendedor Vendedor { get; set; }

        public frmInmueble2()
        {
            InitializeComponent();
        }

        private void pbAgregarInmueble1_MouseHover(object sender, EventArgs e)
        {
            pbAgregarInmueble1.Visible = false;
            pbAgregarInmueble2.Visible = true;
            MouseHoverTime = 1;
        }

        private void pbAgregarInmueble2_MouseLeave(object sender, EventArgs e)
        {
            pbAgregarInmueble1.Visible = true;
            pbAgregarInmueble2.Visible = false;
        }

        private void pbAgregarInmueble2_Click(object sender, EventArgs e)
        {
            if (frmInmueble == null || frmInmueble.IsDisposed)
                frmInmueble = new frmInmueble();

            frmInmueble.MdiParent = this;
            frmInmueble.BringToFront();
            frmInmueble.StartPosition = FormStartPosition.Manual;

            //int width = this.Controls.Find("netBarControl1", true)[0].Width;
            frmInmueble.Location = new Point(0,45);
            frmInmueble.Show();
        }
    }
}
