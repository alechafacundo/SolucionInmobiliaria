using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InmobiliariaForms
{
    public partial class Home : Form
    {
        frmInteresado frmInteresado;
        frmInmueble frmInmueble;

        public Home()
        {
            InitializeComponent();
        }

     

        private void Home_Load(object sender, EventArgs e)
        {
            //InmobiliariaService.Service ws = new InmobiliariaService.Service();
            //string saludo = ws.HelloWorld();

            //MessageBox.Show(saludo);

        }
        

        private void btNuevoInteresado_ItemClick(object sender, EventArgs e)
        {
            if (frmInteresado == null || frmInteresado.IsDisposed)
                frmInteresado = new frmInteresado();

            frmInteresado.MdiParent = this;
            frmInteresado.BringToFront();
            frmInteresado.StartPosition = FormStartPosition.Manual;

            int width = this.Controls.Find("netBarControl1", true)[0].Width;

            frmInteresado.Location = new Point(width);
            frmInteresado.Show();
        }

        private void btNuevoInmueble_ItemClick(object sender, EventArgs e)
        {
            if (frmInmueble == null || frmInmueble.IsDisposed)
                frmInmueble = new frmInmueble();

            frmInmueble.MdiParent = this;
            frmInmueble.BringToFront();
            frmInmueble.StartPosition = FormStartPosition.Manual;

            int width = this.Controls.Find("netBarControl1", true)[0].Width;
            frmInmueble.Location = new Point(width);
            frmInmueble.Show();
        }

        private void btBuscarInmueble_ItemClick(object sender, EventArgs e)
        {

        }

        private void btBuscarInteresado_ItemClick(object sender, EventArgs e)
        {

        }
    }
}
