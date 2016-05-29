using System;
using InmobiliariaForms.InmobiliariaService;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InmobiliariaForms
{
  



    public partial class frmAgregarInteresado : Form
    {
        public static int MouseHoverTime { get; set; }
        frmInteresado frmInteresado;
        frmBuscarInteresado frmBuscarInteresado;
        public frmAgregarInteresado()
        {
            InitializeComponent();
        }

        private void pbAgregarInteresado1_MouseHover(object sender, EventArgs e)
        {
            pbAgregarInteresado1.Visible = false;
            pbAgregarInteresado2.Visible = true;
            MouseHoverTime = 1;
        }

        private void pbAgregarInteresado2_MouseLeave(object sender, EventArgs e)
        {
            pbAgregarInteresado1.Visible = true;
            pbAgregarInteresado2.Visible = false;
        }

        private void pbAgregarInteresado2_Click(object sender, EventArgs e)
        {

            if (frmInteresado == null || frmInteresado.IsDisposed)
                frmInteresado = new frmInteresado();

            //frmBuscarInmueble.Vendedor = this.Vendedor;
            frmInteresado.MdiParent = (Form)this.Parent.Parent;
            Panel p = (Panel)this.Parent.Parent.Controls.Find("pnlMdi", true).First();
            p.Controls.Add(frmInteresado);

            frmInteresado.BringToFront();
            frmInteresado.StartPosition = FormStartPosition.Manual;

            //int width = this.Controls.Find("netBarControl1", true)[0].Width;
            frmInteresado.Location = new Point(120, 0);
            this.Close();
            frmInteresado.Show();
        }


        private void pbBuscarInteresado2_Click(object sender, EventArgs e)
        {

            if (frmBuscarInteresado == null || frmBuscarInteresado.IsDisposed)
                frmBuscarInteresado = new frmBuscarInteresado();

            //frmBuscarInmueble.Vendedor = this.Vendedor;
            frmBuscarInteresado.MdiParent = (Form)this.Parent.Parent;
            Panel p = (Panel)this.Parent.Parent.Controls.Find("pnlMdi", true).First();
            p.Controls.Add(frmBuscarInteresado);

            frmBuscarInteresado.BringToFront();
            frmBuscarInteresado.StartPosition = FormStartPosition.Manual;

            //int width = this.Controls.Find("netBarControl1", true)[0].Width;
            frmBuscarInteresado.Location = new Point(120, 0);
            this.Close();
            frmBuscarInteresado.Show();
        }

        private void pbBuscarInteresado1_MouseMove(object sender, MouseEventArgs e)
        {
            pbBuscarInteresado1.Visible = false;
            pbBuscarInteresado2.Visible = true;
            MouseHoverTime = 1;
        }

        private void pbBuscarInteresado2_MouseLeave(object sender, EventArgs e)
        {
            pbBuscarInteresado1.Visible = true;
            pbBuscarInteresado2.Visible = false;
        }
    }
}
