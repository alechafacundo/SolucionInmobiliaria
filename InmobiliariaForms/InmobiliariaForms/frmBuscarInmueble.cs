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
        public Vendedor Vendedor { get; set; }

        List<Inmueble> inmuebles = new List<Inmueble>();
        List<Vendedor> vendedores = new List<Vendedor>();

        public frmBuscarInmueble()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
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

                //Para tener el maestro de Vendedores y poder ponerlos ahi
                if (vendedores.Count == 0)
                {
                    vendedores = ws.GetVendedores().ToList();
                }

                List<Inmueble> inmuebles = ws.BuscarInmuebles(inmueble, precioDesde, precioHasta).ToList();
                gvResultado.DataSource = inmuebles;

                gvResultado.Columns["Id"].Visible = false;
                gvResultado.Columns["Operacion"].Visible = false;
                gvResultado.Columns["Tipo"].Visible = false;
                gvResultado.Columns["Moneda"].Visible = false;
                gvResultado.Columns["CargadoPor"].Visible = false;
                gvResultado.Columns.Add("CargadoNombre", "Cargado Por");

                foreach (DataGridViewRow item in gvResultado.Rows)
                {
                    item.Cells["CargadoNombre"].Value = vendedores.Find(x => x.Id == (int)item.Cells["CargadoPor"].Value).FullName;
                }
            }
            catch (Exception ex)
            {
                Helper.EnviarNotificacion(ex);
                throw ex;
            }
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
                cbMoneda.SelectedItem = eMoneda.Peso;


                //Para mas adelante lo cambiamos así o vemos como lo hacemos
                //if (inmuebles.Count() == 0)
                //{
                //    Service ws = new Service();
                //    inmuebles = ws.GetInmuebles().ToList();
                //}

                //gvResultado.DataSource = inmuebles;
                //gvResultado.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {
                Helper.EnviarNotificacion(ex);
                throw;
            }
        }

        private void gvResultado_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gvResultado.SelectedRows.Count == 1)
                {
                    Inmueble inmueble = (Inmueble)gvResultado.SelectedRows[0].DataBoundItem;

                    Vendedor cargadoPor = vendedores.Find(x => x.Id == inmueble.CargadoPor);

                    frmInmueble frmInmueble = new frmInmueble();
                    frmInmueble.Vendedor = cargadoPor;
                    frmInmueble.Inmueble = inmueble;

                    frmInmueble.MdiParent = (Form)this.Parent.Parent;
                    Panel p = (Panel)this.Parent.Parent.Controls.Find("pnlMdi", true).First();
                    p.Controls.Add(frmInmueble);

                    frmInmueble.BringToFront();
                    frmInmueble.StartPosition = FormStartPosition.Manual;

                    //int width = this.Controls.Find("netBarControl1", true)[0].Width;
                    frmInmueble.Location = new Point(120, 0);
                    this.Close();
                    frmInmueble.Show();
                }
            }
            catch (Exception ex)
            {
                Helper.EnviarNotificacion(ex);
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
