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
            InmobiliariaService.Service ws = new InmobiliariaService.Service();
            string saludo = ws.HelloWorld();

            MessageBox.Show(saludo);
        }
    }
}
