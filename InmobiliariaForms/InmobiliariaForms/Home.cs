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
        
        private void netBarItem1_ItemClick(object sender, EventArgs e)
        {
            frmInteresado frm = new frmInteresado();
            frm.Show();
        }

        private void btInmueble_Click(object sender, EventArgs e)
        {
            frmInmueble frm = new frmInmueble();
            frm.Show();
        }
    }
}
