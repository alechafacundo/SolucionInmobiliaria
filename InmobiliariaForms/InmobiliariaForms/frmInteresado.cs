using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InmobiliariaForms.InmobiliariaService;

namespace InmobiliariaForms
{
    public partial class frmInteresado : Form
    {
        Interesado Interesado { get; set; }

        public frmInteresado()
        {
            InitializeComponent();
        }

        private void frmInteresado_Load(object sender, EventArgs e)
        {
            //ToDo: Facu
            //Acordate de que así no se tienen que llenar los combos, llenarlos como en el inmueble
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


            if (Interesado != null)
            {
                txNombre.Text = Interesado.Nombre;
                txTelefono.Text = Interesado.Telefono;
                txEmail.Text = Interesado.Email;
                txDorm.Text = Interesado.Dormitorios;
                cbMoneda.SelectedIndex = (int)Interesado.TipoDeMoneda;
                cbTipoInmueble.SelectedIndex = (int)Interesado.TipoDeInmueble;
                cbTipoOperacion.SelectedIndex = (int)Interesado.TipoDeOperacion;
                numDesde.Value = Interesado.MontoDesde != null ? (decimal)Interesado.MontoDesde : 0;
                numHasta.Value = Interesado.MontoHasta != null ? (decimal)Interesado.MontoHasta : 0;
                //Así se setea un CheckBox
                checkEsInversion.Checked = Interesado.ParaInversion;        

                
                
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            //ToDo: Facu
            //Validar campos mandatorios o requeridos
            //Mostrar Mensaje que lo guardo bien o lo guardo mal
            try
            {
                if (ValidarCampos())
                {
                    eTipoInmueble tipoInmueble;
                    Enum.TryParse<eTipoInmueble>(cbTipoInmueble.SelectedValue.ToString(), out tipoInmueble);
                    Interesado.TipoDeInmueble = (int)tipoInmueble;

                    eTipoOperacion tipoOperacion;
                    Enum.TryParse<eTipoOperacion>(cbTipoOperacion.SelectedValue.ToString(), out tipoOperacion);
                    Interesado.TipoDeOperacion = (int)tipoOperacion;

                    eMoneda tipoMoneda;
                    Enum.TryParse<eMoneda>(cbMoneda.SelectedValue.ToString(), out tipoMoneda);
                    Interesado.TipoDeMoneda = (int)tipoMoneda;

                    Interesado.Nombre = txNombre.Text;
                    Interesado.Email = txEmail.Text;
                    Interesado.Telefono = txTelefono.Text;
                    Interesado.MontoDesde = numDesde.Value;
                    Interesado.MontoHasta = numHasta.Value;
                    Interesado.Dormitorios = txDorm.Text;
                    //Asi se obtiene el checkbox
                    Interesado.ParaInversion = checkEsInversion.Checked;

                    //Ahora que ya tenes el interesado guardado lo tenes que mandar al web service para que lo guarde en la base de datos:
                    Service ws = new Service();
                    ws.GuardarInteresado(Interesado);

                    //Si llego hasta acá sin irse al catch entonces quiere decir que pudo guardar bien.
                    //Mostremos un msj diciendo que se guardo bien
                    //Cerremos el form poniendo el DialogResult en OK.
                }
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        private bool ValidarCampos()
        {
            return true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
