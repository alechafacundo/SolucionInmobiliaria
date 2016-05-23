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
            Interesado interesado = new Interesado();
            

            eTipoInmueble tipoInmueble;
            Enum.TryParse<eTipoInmueble>(cbTipoInmueble.SelectedValue.ToString(), out tipoInmueble);
            interesado.TipoDeInmueble = (int)tipoInmueble;

            eTipoOperacion tipoOperacion;
            Enum.TryParse<eTipoOperacion>(cbTipoOperacion.SelectedValue.ToString(), out tipoOperacion);
            interesado.TipoDeOperacion = (int)tipoOperacion;

            eMoneda tipoMoneda;
            Enum.TryParse<eMoneda>(cbMoneda.SelectedValue.ToString(), out tipoMoneda);
            interesado.TipoDeMoneda = (int)tipoMoneda;

            
            interesado.Nombre = txNombre.Text;
            interesado.Email = txEmail.Text;      
            interesado.Dormitorios = txDorm.Text;
            interesado.Telefono = txTelefono.Text;

            decimal? precioDesde = null;
            if (numDesde.Value != 0)
                precioDesde = numDesde.Value;

            decimal? precioHasta = null;
            if (numHasta.Value != 0)
                precioHasta = numHasta.Value;




        }
    }
}
