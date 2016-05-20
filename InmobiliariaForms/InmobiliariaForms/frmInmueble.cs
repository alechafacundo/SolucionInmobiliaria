using InmobiliariaForms.InmobiliariaService;
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
       

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposObligatorios())
            {
                //Declaras una variable de tipo enum donde vas a guardar el valor seleccionado
                eTipoInmueble tipoInmueble;
                //Le decis que agarre el texto seleccionado y en base a ese texto lo transforme en tu enum
                Enum.TryParse<eTipoInmueble>(cbTipoInmueble.SelectedValue.ToString(), out tipoInmueble);
                //Con solo castear el valor del enum en un int ya tenes el valor
                int valor = (int)tipoInmueble;
                //Si le decis ToString() lo que h aces es transformarlo a texto
                string display = tipoInmueble.ToString();
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

        private void frmInmueble_Load(object sender, EventArgs e)
        {
            cbTipoInmueble.DataSource = Enum.GetNames(typeof(eTipoInmueble));
            cbTipoOperacion.DataSource = Enum.GetNames(typeof(eTipoOperacion));

            //cbTipoInmueble.Items.Clear();
            //cbTipoInmueble.Items.Add("Departamento");
            //cbTipoInmueble.Items.Add("Casa");
            //cbTipoInmueble.Items.Add("Terreno");
            //cbTipoOperacion.Items.Clear();
            //cbTipoOperacion.Items.Add("Venta");
            //cbTipoOperacion.Items.Add("Alquiler");
            //cbMoneda.Items.Clear();
            //cbMoneda.Items.Add("Peso");
            //cbMoneda.Items.Add("Dolar");
        }
        
    }
}
