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
    public partial class frmBuscarInteresado : Form
    {
        public frmBuscarInteresado()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
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
            inmueble.Barrio = txBarrio.Text;
            inmueble.Dormitorios = txDorm.Text;
            inmueble.Patio = txPatio.Text;
            inmueble.Baños = txBaño.Text;
            inmueble.Garage = txGarage.Text;
            inmueble.Comedor = txComedor.Text;

            decimal? precioDesde = null;
            if (numPrecioDesde.Value != 0)
                precioDesde = numPrecioDesde.Value;

            decimal? precioHasta = null;
            if (numPrecioHasta.Value != 0)
                precioHasta = numPrecioHasta.Value;

            Service ws = new Service();
            List<Inmueble> inmuebles = ws.BuscarInmuebles(inmueble, precioDesde, precioHasta).ToList();
        }
    }
}
