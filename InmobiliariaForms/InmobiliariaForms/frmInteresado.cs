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


            //ToDo: Facu
            //Llenar cbTipoInmueble con eTipoInmueble
            //LLenar cbTipoOperacion con eTipoOperacion


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
                numDormitorios.Value = Interesado.Dormitorios != null ? (decimal)Interesado.Dormitorios : 0;
                //falta el chekEsInversion

                
                
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            //ToDo
            //Validar campos mandatorios o requeridos
            //Instanciar un interesado
            //Set properties del interesado
            //Invocar al ws y guardar el interesado
            //Mostrar Mensaje que lo guardo bien o lo guardo mal

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
            interesado.Telefono = txTelefono.Text;
            interesado.MontoDesde = numDesde.Value;
            interesado.MontoHasta = numHasta.Value;
            interesado.Dormitorios = txDorm.Text;
            //falta el CheckEsInversion



                        

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
