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

                Inmueble inmueble = new Inmueble();
                eTipoInmueble tipoInmueble;
                Enum.TryParse<eTipoInmueble>(cbTipoInmueble.SelectedValue.ToString(), out tipoInmueble);
                inmueble.Tipo = (int)tipoInmueble;
                eTipoOperacion tipoOperacion;
                Enum.TryParse<eTipoOperacion>(cbTipoOperacion.SelectedValue.ToString(), out tipoOperacion);
                inmueble.Operacion = (int)tipoOperacion;
                eMoneda tipoMoneda;
                Enum.TryParse<eMoneda>(cbMoneda.SelectedValue.ToString(), out tipoMoneda);
                inmueble.Moneda = (int)tipoMoneda;
                inmueble.Fecha = dateTimeFecha.Value;
                inmueble.Localidad = txLocalidad.Text;
                inmueble.Calle = txCalle.Text;
                inmueble.Barrio = txBarrio.Text;
                inmueble.Numero = txNumero.Text;
                inmueble.Piso = txPiso.Text;
                inmueble.Departamento = txDepto.Text;
                inmueble.EntreCalles = txEntreCalles.Text;
                inmueble.Metros2Terreno = txMtsTerreno.Text;
                inmueble.SupCubierta = txSupCubierta.Text;
                inmueble.ValorMetro2 = txValorMts.Text;
                inmueble.Observaciones = txObservaciones.Text;
                inmueble.Dormitorios = txDorm.Text;
                inmueble.Patio = txPatio.Text;
                inmueble.Baños = txBaño.Text;
                inmueble.Garage = txGarage.Text;
                inmueble.Comedor = txComedor.Text;
                inmueble.OtrasDependencias = txOtras.Text;
                inmueble.Contacto = txContacto.Text;
                inmueble.Referencia = txReferencia.Text;
                //aca Puse el Value del numericUpDown, decime si esta bien.
                inmueble.Precio = numPrecio.Value;




            }
        }

        private bool ValidarCamposObligatorios()
        {
            if (cbTipoInmueble == null)
            {
                return false;
            }
            if (true)
            {

            }
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
