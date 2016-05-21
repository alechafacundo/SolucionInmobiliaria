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
        Inmueble Inmueble { get; set; }

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
            try
            {
                cbTipoInmueble.DataSource = Enum.GetNames(typeof(eTipoInmueble));
                cbTipoInmueble.SelectedItem = null;

                cbTipoOperacion.DataSource = Enum.GetNames(typeof(eTipoOperacion));
                cbTipoOperacion.SelectedItem = null;

                if (Inmueble != null)
                {
                    cbTipoInmueble.SelectedIndex = (int)Inmueble.Tipo;
                    cbTipoOperacion.SelectedIndex = (int)Inmueble.Operacion;
                    dateTimeFecha.Value = Inmueble.Fecha != null ? Inmueble.Fecha.Value : DateTime.Now;
                    txLocalidad.Text = Inmueble.Localidad;
                    txBarrio.Text = Inmueble.Barrio;
                    txCalle.Text = Inmueble.Calle;
                    txNumero.Text = Inmueble.Numero.HasValue ? Inmueble.Numero.ToString() : "";
                    txPiso.Text = Inmueble.Piso.HasValue ? Inmueble.Piso.ToString() : "";
                    txDepto.Text = Inmueble.Departamento;
                    txEntreCalles.Text = Inmueble.EntreCalles;
                    numPrecio.Value = Inmueble.Precio.HasValue ? Inmueble.Precio.Value : 0m;
                    cbMoneda.SelectedIndex = Inmueble.Moneda;
                    txMtsTerreno.Text = Inmueble.Metros2Terreno;
                    txSupCubierta.Text = Inmueble.SupCubierta;
                    txValorMts.Text = Inmueble.ValorMetro2.HasValue ? Inmueble.ValorMetro2.Value.ToString() : "";
                    txObservaciones.Text = Inmueble.Observaciones;
                    txDorm.Text = Inmueble.Dormitorios.HasValue ? Inmueble.Dormitorios.Value.ToString() : "";
                    txBaño.Text = Inmueble.Baños;
                    txGarage.Text = Inmueble.Garage;
                    txPatio.Text = Inmueble.Patio;
                    txOtras.Text = Inmueble.OtrasDependencias;
                    cbCargadoPor.SelectedValue = null; //Inmueble.CargadoPor
                    txContacto.Text = Inmueble.Contacto;
                    txReferencia.Text = Inmueble.Referencia;
                }
            }
            catch (Exception ex)
            {
                //ToDo: Fabri
                //Modulo de notificaciones
                throw;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
