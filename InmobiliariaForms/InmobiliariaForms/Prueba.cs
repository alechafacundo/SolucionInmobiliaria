﻿using InmobiliariaForms.InmobiliariaService;
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
        Inmueble Inmueble;

        Vendedor Vendedor { get; set; }

        public Prueba()
        {
            InitializeComponent();
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
           
        }

        private void btNuevoVendedor_ItemClick(object sender, EventArgs e)
        {
            if (frmVendedor == null || frmVendedor.IsDisposed)
                frmVendedor = new frmVendedor();

            frmVendedor.MdiParent = this;
            frmVendedor.BringToFront();
            frmVendedor.StartPosition = FormStartPosition.Manual;

            int width = this.Controls.Find("netBarControl1", true)[0].Width;
            frmVendedor.Location = new Point(width);
            frmVendedor.Show();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            using (frmLogin f = new frmLogin())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    this.Vendedor = f.Vendedor;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void btBuscarVendedor_ItemClick(object sender, EventArgs e)
        {
            if (frmBuscarVendedor == null || frmBuscarVendedor.IsDisposed)
                frmBuscarVendedor = new frmBuscarVendedor();

            frmBuscarVendedor.MdiParent = this;
            frmBuscarVendedor.BringToFront();
            frmBuscarVendedor.StartPosition = FormStartPosition.Manual;

            int width = this.Controls.Find("netBarControl1", true)[0].Width;
            frmBuscarVendedor.Location = new Point(width);
            frmBuscarVendedor.Show();
        }

        private void btBuscarInteresado_ItemClick(object sender, EventArgs e)
        {
            if (frmBuscarInteresado == null || frmBuscarInteresado.IsDisposed)
                frmBuscarInteresado = new frmBuscarInteresado();

            frmBuscarInteresado.MdiParent = this;
            frmBuscarInteresado.BringToFront();
            frmBuscarInteresado.StartPosition = FormStartPosition.Manual;

            int width = this.Controls.Find("netBarControl1", true)[0].Width;
            frmBuscarInteresado.Location = new Point(width);
            frmBuscarInteresado.Show();
        }

        private void btBuscarInmueble_ItemClick(object sender, EventArgs e)
        {
            if (frmBuscarInmueble == null || frmBuscarInmueble.IsDisposed)
                frmBuscarInmueble = new frmBuscarInmueble();

            frmBuscarInmueble.MdiParent = this;
            frmBuscarInmueble.BringToFront();
            frmBuscarInmueble.StartPosition = FormStartPosition.Manual;

            int width = this.Controls.Find("netBarControl1", true)[0].Width;
            frmBuscarInmueble.Location = new Point(width);
            frmBuscarInmueble.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Inmueble == null || Inmueble.IsDisposed)
                Inmueble = new Inmueble();

            Inmueble.MdiParent = this;
            Inmueble.BringToFront();
            Inmueble.StartPosition = FormStartPosition.Manual;

            //int width = this.Controls.Find("netBarControl1", true)[0].Width;
            Inmueble.Location = new Point(121 , 275);
            Inmueble.Show();
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
    }
}
