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
        frmInteresado form1 = new frmInteresado();
        frmInmueble form2 = new frmInmueble();

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
        
       private void netBarItem3_ItemClick(object sender, EventArgs e)
        {
            //frmInmueble frm = new frmInmueble();
            //frm.Show();
            
            form1.Close();

            form2.TopLevel = false;
            form2.Visible = true;
            if (!Controls.Contains(form2))
                Controls.Add(form2);
            form2.Location = new Point(
               this.ClientSize.Width - this.form2.Width - 5,
               /*this.ClientSize.Height - this.form.Height*/ 90);
        }

        private void netBarItem1_ItemClick_1(object sender, EventArgs e)
        {
            //frmInteresado frm = new frmInteresado();
            //frm.Show();
            form1.TopLevel = false;
            form1.Visible = true;
            if(!Controls.Contains(form1))
                Controls.Add(form1);
            form1.Location = new Point(
               this.ClientSize.Width - this.form1.Width - 5,
               /*this.ClientSize.Height - this.form.Height*/ 90);
        }
    }
}
