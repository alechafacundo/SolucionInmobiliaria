using InmobiliariaForms.InmobiliariaService;
using InmobiliariaForms.Properties;
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
    public partial class Prueba : Form
    {
        public static int MouseHoverTime { get; set; } 
        frmInteresado frmInteresado;
        frmInmueble frmInmueble;
        frmBuscarInmueble frmBuscarInmueble;
        frmBuscarInteresado frmBuscarInteresado;
        frmVendedor frmVendedor;
        frmBuscarVendedor frmBuscarVendedor;
        frmAgregarInmueble frmAgregarInmueble;
        frmAgregarInteresado frmAgregarInteresado;
        frmAgregarVendedor frmAgregarVendedor;

        Vendedor Vendedor { get; set; }

        public Prueba()
        {
            InitializeComponent();
        }
       
        private void Prueba_Load(object sender, EventArgs e)
        {
            using (frmLogin f = new frmLogin())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    //Para que no setee el vendedor y quede como nulo
                    if (f.Vendedor.Nombre == "admin")
                        return;

                    this.Vendedor = f.Vendedor;

                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void pbInmueble1_MouseHover(object sender, EventArgs e)
        {
            pbInmueble1.Visible = false;
            pbInmueble2.Visible = true;
            MouseHoverTime = 1; 
        
       }

        private void pbInmueble2_MouseLeave(object sender, EventArgs e)
        {
            pbInmueble1.Visible = true;
            pbInmueble2.Visible = false;
                
        }

        private void pbInteresado1_MouseHover(object sender, EventArgs e)
        {
            pbInteresado1.Visible = false;
            pbInteresado2.Visible = true;
            MouseHoverTime = 1;

        }

        private void pbInteresado2_MouseLeave(object sender, EventArgs e)
        {
            pbInteresado1.Visible = true;
            pbInteresado2.Visible = false;
        }

        private void pbVendedor1_MouseHover(object sender, EventArgs e)
        {
            pbVendedor1.Visible = false;
            pbVendedor2.Visible = true;
            MouseHoverTime = 1;

        }

        private void pbVendedor2_MouseLeave(object sender, EventArgs e)
        {
            pbVendedor1.Visible = true;
            pbVendedor2.Visible = false;
        }

        private void pbInmueble2_Click(object sender, EventArgs e)
        {
            if (frmAgregarInmueble == null || frmAgregarInmueble.IsDisposed)
                frmAgregarInmueble = new frmAgregarInmueble();

            frmAgregarInmueble.Vendedor = this.Vendedor;
            frmAgregarInmueble.MdiParent = this;
            pnlMdi.Controls.Add(frmAgregarInmueble);
            frmAgregarInmueble.BringToFront();
            frmAgregarInmueble.StartPosition = FormStartPosition.Manual;

            //int width = this.Controls.Find("netBarControl1", true)[0].Width;
            //frmAgregarInmueble.Location = new Point(121, 275);
            frmAgregarInmueble.Location = new Point(90, 10);
            frmAgregarInmueble.Show();
        }

        private void pbVendedor2_Click(object sender, EventArgs e)
        {
            if (frmAgregarVendedor == null || frmAgregarVendedor.IsDisposed)
                frmAgregarVendedor = new frmAgregarVendedor();

            frmAgregarVendedor.MdiParent = this;

            pnlMdi.Controls.Add(frmAgregarVendedor);

            frmAgregarVendedor.BringToFront();
            frmAgregarVendedor.StartPosition = FormStartPosition.Manual;

            //int width = this.Controls.Find("netBarControl1", true)[0].Width;
            frmAgregarVendedor.Location = new Point(90, 10);
            frmAgregarVendedor.Show();
        }

        private void pbInteresado2_Click(object sender, EventArgs e)
        {
            if (frmAgregarInteresado == null || frmAgregarInteresado.IsDisposed)
                frmAgregarInteresado = new frmAgregarInteresado();

            //frmAgregarInmueble.Vendedor = this.Vendedor;
            frmAgregarInteresado.MdiParent = this;
            pnlMdi.Controls.Add(frmAgregarInteresado);
            frmAgregarInteresado.BringToFront();
            frmAgregarInteresado.StartPosition = FormStartPosition.Manual;

            //int width = this.Controls.Find("netBarControl1", true)[0].Width;
            //frmAgregarInmueble.Location = new Point(121, 275);
            frmAgregarInteresado.Location = new Point(90, 10);
            frmAgregarInteresado.Show();
        }

        private void pbCerrar1_MouseHover(object sender, EventArgs e)
        {
            pbCerrar1.Visible = false;
            pbCerrar2.Visible = true;
            MouseHoverTime = 1;
        }

        private void pbCerrar2_MouseLeave(object sender, EventArgs e)
        {
            pbCerrar1.Visible = true;
            pbCerrar2.Visible = false;
        }

        private void pbMinimizar1_MouseHover(object sender, EventArgs e)
        {
            pbMinimizar1.Visible = false;
            pbMinimizar2.Visible = true;
            MouseHoverTime = 1;
        }

        private void pbMinimizar2_MouseLeave(object sender, EventArgs e)
        {
            pbMinimizar1.Visible = true;
            pbMinimizar2.Visible = false;
        }

        private void pbCerrar2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pbMinimizar2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbRefresh1_MouseHover(object sender, EventArgs e)
        {
            pbRefresh1.Visible = false;
            pbRefresh2.Visible = true;
            MouseHoverTime = 1;
        }

        private void pbRefresh2_MouseLeave(object sender, EventArgs e)
        {
            pbRefresh1.Visible = true;
            pbRefresh2.Visible = false;

        }

        private void pbRefresh2_Click(object sender, EventArgs e)
        {
            
            ServiceHelper.ws.HelloWorld();
        }

        private void btActualizarDolar_Click(object sender, EventArgs e)
        {
            ServiceHelper.ValorDolar = Convert.ToDecimal(txCotizacion.Text);
        }
    }
}
