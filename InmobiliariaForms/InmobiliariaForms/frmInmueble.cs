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
    public partial class frmInmueble : Form
    {
        public frmInmueble()
        {
            InitializeComponent();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTipoInmueble.Items.Clear();
            cbTipoInmueble.Items.Add("Departamento");
            cbTipoInmueble.Items.Add("Casa");
            cbTipoInmueble.Items.Add("Terreno");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTipoInmueble.Items.Clear();
            cbTipoInmueble.Items.Add("Venta");
            cbTipoInmueble.Items.Add("Alquiler");
         
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTipoInmueble.Items.Clear();
            cbTipoInmueble.Items.Add("$");
            cbTipoInmueble.Items.Add("U$S");
           
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposObligatorios())
            {

            }
        }

        private bool ValidarCamposObligatorios()
        {
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ToDo
            //Setear resultado en false
            //Cerrar Formulario
        }
    }
}
