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
                inmueble.Localidad = txLocalidad.Text.ToUpperInvariant();
                inmueble.Calle = txCalle.Text.ToUpperInvariant();
                inmueble.Barrio = txBarrio.Text.ToUpperInvariant();
                inmueble.Numero = txNumero.Text.ToUpperInvariant();
                inmueble.Piso = txPiso.Text.ToUpperInvariant();
                inmueble.Departamento = txDepto.Text.ToUpperInvariant();
                inmueble.EntreCalles = txEntreCalles.Text.ToUpperInvariant();
                inmueble.Metros2Terreno = txMtsTerreno.Text.ToUpperInvariant();
                inmueble.SupCubierta = txSupCubierta.Text.ToUpperInvariant();
                inmueble.ValorMetro2 = txValorMts.Text.ToUpperInvariant();
                inmueble.Observaciones = txObservaciones.Text.ToUpperInvariant();
                inmueble.Dormitorios = txDorm.Text.ToUpperInvariant();
                inmueble.Patio = txPatio.Text.ToUpperInvariant();
                inmueble.Baños = txBaño.Text.ToUpperInvariant();
                inmueble.Garage = txGarage.Text.ToUpperInvariant();
                inmueble.Comedor = txComedor.Text.ToUpperInvariant();
                inmueble.OtrasDependencias = txOtras.Text.ToUpperInvariant();
                inmueble.Contacto = txContacto.Text.ToUpperInvariant();
                inmueble.Referencia = txReferencia.Text.ToUpperInvariant();
                inmueble.Precio = numPrecio.Value;
                inmueble.CargadoPor = ((Vendedor)cbCargadoPor.SelectedItem).Id;

                //faltan poner en el form
                inmueble.Cocina = "1";
                inmueble.Otros = "";

                //Ahora que ya tenes el inmueble guardado lo tenes que mandar al web service para que lo guarde en la base de datos:
                try
                {
                    Service ws = new Service();
                    ws.GuardarInmueble(inmueble);
                    MessageBox.Show("Se guardo joya papá!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
        
        private void frmInmueble_Load(object sender, EventArgs e)
        {
            try
            {
                cbTipoInmueble.DataSource = Enum.GetNames(typeof(eTipoInmueble));
                cbTipoInmueble.SelectedItem = null;

                cbTipoOperacion.DataSource = Enum.GetNames(typeof(eTipoOperacion));
                cbTipoOperacion.SelectedItem = null;

                cbMoneda.DataSource = Enum.GetNames(typeof(eMoneda));
                cbMoneda.SelectedItem = null;

                Service ws = new Service();
                List<Vendedor> vendedores = ws.GetVendedores().ToList();
                cbCargadoPor.DataSource = vendedores;
                cbCargadoPor.DisplayMember = "Nombre";
                cbCargadoPor.ValueMember = "Id";
                //cbCargadoPor.SelectedItem = null; 

                if (Inmueble != null)
                {
                    cbTipoInmueble.SelectedIndex = (int)Inmueble.Tipo;
                    cbTipoOperacion.SelectedIndex = (int)Inmueble.Operacion;

                    dateTimeFecha.Value = Inmueble.Fecha != null ? Inmueble.Fecha.Value : DateTime.Now;
                    txLocalidad.Text = Inmueble.Localidad;
                    txBarrio.Text = Inmueble.Barrio;
                    txCalle.Text = Inmueble.Calle;
                    txNumero.Text = Inmueble.Numero;
                    txPiso.Text = Inmueble.Piso;
                    txDepto.Text = Inmueble.Departamento;
                    txEntreCalles.Text = Inmueble.EntreCalles;
                    //numeric de precio, revisar 
                    numPrecio.Value = Inmueble.Precio != null ? (decimal)Inmueble.Precio : 0;
                    cbMoneda.SelectedIndex = Inmueble.Moneda;
                    txMtsTerreno.Text = Inmueble.Metros2Terreno;
                    txSupCubierta.Text = Inmueble.SupCubierta;
                    txValorMts.Text = Inmueble.ValorMetro2;
                    txObservaciones.Text = Inmueble.Observaciones;
                    txDorm.Text = Inmueble.Dormitorios;
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
