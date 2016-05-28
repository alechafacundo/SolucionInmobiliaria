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
    public partial class frmBuscarInmueble : Form
    {
        public frmBuscarInmueble()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Inmueble inmueble = new Inmueble();

            eTipoInmueble tipoInmueble;
            Enum.TryParse(cbTipoInmueble.SelectedValue.ToString(), out tipoInmueble);
            inmueble.Tipo = (int)tipoInmueble;

            eTipoOperacion tipoOperacion;
            Enum.TryParse(cbTipoOperacion.SelectedValue.ToString(), out tipoOperacion);
            inmueble.Operacion = (int)tipoOperacion;

            eMoneda tipoMoneda;
            Enum.TryParse(cbMoneda.SelectedValue.ToString(), out tipoMoneda);
            inmueble.Moneda = (int)tipoMoneda;

            inmueble.Fecha = dateTimeFecha.Value;
            inmueble.Localidad = txLocalidad.Text.ToUpperInvariant();
            inmueble.Barrio = txBarrio.Text.ToUpperInvariant();
            inmueble.Dormitorios = txDorm.Text.ToUpperInvariant();
            inmueble.Patio = txPatio.Text.ToUpperInvariant();
            inmueble.Baños = txBaño.Text.ToUpperInvariant();
            inmueble.Garage = txGarage.Text.ToUpperInvariant();
            inmueble.Comedor = txComedor.Text.ToUpperInvariant();

            decimal? precioDesde = null;
            if (numPrecioDesde.Value != 0)
                precioDesde = numPrecioDesde.Value;

            decimal? precioHasta = null;
            if (numPrecioHasta.Value != 0)
                precioHasta = numPrecioHasta.Value;

            Service ws = new Service();
            List<Inmueble> inmuebles = ws.BuscarInmuebles(inmueble, precioDesde, precioHasta).ToList();
            gvResultado.DataSource = inmuebles;
            
        }

        private void frmBuscarInmueble_Load(object sender, EventArgs e)
        {
            try
            {
                cbTipoInmueble.DataSource = Enum.GetNames(typeof(eTipoInmueble));
                cbTipoInmueble.SelectedItem = null;

                cbTipoOperacion.DataSource = Enum.GetNames(typeof(eTipoOperacion));
                cbTipoOperacion.SelectedItem = null;

                cbMoneda.DataSource = Enum.GetNames(typeof(eMoneda));
                cbMoneda.SelectedItem = null;

                          
            }
            catch (Exception ex)
            {
                //ToDo: Fabri
                //Modulo de notificaciones
                throw;
            }
        }

        private void gvResultado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvResultado_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
