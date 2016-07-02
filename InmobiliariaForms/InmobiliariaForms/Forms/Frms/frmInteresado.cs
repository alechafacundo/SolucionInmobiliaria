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
        public Interesado Interesado { get; set; }

        public frmInteresado()
        {
            InitializeComponent();
        }

        private void frmInteresado_Load(object sender, EventArgs e)
        {
            try
            {
                cbTipoInmueble.DataSource = Enum.GetNames(typeof(eTipoInmueble));
                cbTipoInmueble.SelectedItem = eTipoInmueble.Sin_Especificar;

                cbTipoOperacion.DataSource = Enum.GetNames(typeof(eTipoOperacion));
                cbTipoOperacion.SelectedItem = eTipoOperacion.Sin_Especificar;

                cbMoneda.DataSource = Enum.GetNames(typeof(eMoneda));
                cbMoneda.SelectedItem = eMoneda.Sin_Especificar;

                if (Interesado != null)
                {
                    btEliminar.Visible = true;

                    txNombre.Text = Interesado.Nombre;
                    txTelefono.Text = Interesado.Telefono;
                    txEmail.Text = Interesado.Email;
                    txDorm.Text = Interesado.Dormitorios;
                    cbMoneda.SelectedIndex = (int)Interesado.TipoDeMoneda;
                    cbTipoInmueble.SelectedIndex = (int)Interesado.TipoDeInmueble;
                    cbTipoOperacion.SelectedIndex = (int)Interesado.TipoDeOperacion;
                    numDesde.Value = Interesado.MontoDesde != null ? (decimal)Interesado.MontoDesde : 0;
                    numHasta.Value = Interesado.MontoHasta != null ? (decimal)Interesado.MontoHasta : 0;
                    txObservaciones.Text = Interesado.Observaciones; 

                }
            }
            catch (Exception ex)
            {
                EmailHelper.EnviarNotificacion(ex);
                throw;
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string errores = ValidarCamposObligatorios();
                if (errores == string.Empty)
                {
                    if (Interesado == null)
                        Interesado = new Interesado();

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
                    Interesado.Observaciones = txObservaciones.Text; 

                    //Ahora que ya tenes el interesado guardado lo tenes que mandar al web service para que lo guarde en la base de datos:
                    ServiceHelper.ws.GuardarInteresado(Interesado);
                    MessageBox.Show("Interesado guardado correctamente");

                    ServiceHelper.ws.NotificarSobreInmuebleAsync(Interesado);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(errores, "Errores de Validación");
                }
            }
            catch (Exception ex)
            {
                EmailHelper.EnviarNotificacion(ex);
                throw ex;
            }
        }

        private string ValidarCamposObligatorios()
        {
            try
            {
                if (cbTipoInmueble.SelectedItem != null)
                {
                    eTipoInmueble tipoInmueble;
                    Enum.TryParse<eTipoInmueble>(cbTipoInmueble.SelectedValue.ToString(), out tipoInmueble);

                    if (tipoInmueble == eTipoInmueble.Sin_Especificar)
                    {
                        return "Seleccione un tipo de Inmueble por favor";
                    }

                }

                if (cbMoneda.SelectedItem != null)
                {
                    eMoneda tipoMoneda;
                    Enum.TryParse<eMoneda>(cbMoneda.SelectedValue.ToString(), out tipoMoneda);

                    if (tipoMoneda == eMoneda.Sin_Especificar)
                    {
                        return "Seleccione un tipo de Moneda por favor";
                    }
                }

                if (cbTipoOperacion.SelectedItem != null)
                {
                    eTipoOperacion tipoOperacion;
                    Enum.TryParse<eTipoOperacion>(cbTipoOperacion.SelectedValue.ToString(), out tipoOperacion);

                    if (tipoOperacion == eTipoOperacion.Sin_Especificar)
                    {
                        return "Seleccione un tipo de Operación por favor";
                    }
                }

                if (string.IsNullOrEmpty(txNombre.Text))
                    return "Ingrese un Nombre por favor";          
              
                return string.Empty;
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            Interesado interesado = new Interesado();

            if (ServiceHelper.ws.EliminarInteresado(Interesado))
            {
                //tu metodo es de tipo void, por lo que no retorna nada, ese return no puede ir
                //lo que tenes que hacer es mostrar un cartel
                MessageBox.Show("El Interesado se elimino Correctamente", "Interesado");
                this.Close();
            }
            else 
            {
                MessageBox.Show("El Interesado NO se elimino", "Interesado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Todo: Fabri
        //ahi hice los check, no me acuerdo el codigo mañana los hago y te voy consultando jaja
    }
}
