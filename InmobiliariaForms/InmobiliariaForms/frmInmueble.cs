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
        private void frmInmueble_Load(object sender, EventArgs e)
        {
            cbTipoInmueble.Items.Clear();
            cbTipoInmueble.Items.Add("Departamento");
            cbTipoInmueble.Items.Add("Casa");
            cbTipoInmueble.Items.Add("Terreno");
            cbTipoOperacion.Items.Clear();
            cbTipoOperacion.Items.Add("Venta");
            cbTipoOperacion.Items.Add("Alquiler");
            cbMoneda.Items.Clear();
            cbMoneda.Items.Add("Peso");
            cbMoneda.Items.Add("Dolar");
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
