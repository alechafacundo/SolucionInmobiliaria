using InmobiliariaForms.InmobiliariaService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InmobiliariaForms
{

    public partial class frmBuscarInmueble : Form
    {
        bool yaCargo = false;
        public Vendedor Vendedor { get; set; }

        List<Inmueble> inmuebles = new List<Inmueble>();
        List<Vendedor> vendedores = new List<Vendedor>();
        List<Propiedad> propiedades = new List<Propiedad>();

        public frmBuscarInmueble()
        {
            InitializeComponent();
        }


        private void frmBuscarInmueble_Load(object sender, EventArgs e)
        {
            cbTipoInmueble.DataSource = Enum.GetNames(typeof(eTipoInmueble));
            cbTipoInmueble.SelectedItem = eTipoInmueble.Sin_Especificar;

            cbTipoOperacion.DataSource = Enum.GetNames(typeof(eTipoOperacion));
            cbTipoOperacion.SelectedItem = eTipoOperacion.Sin_Especificar;

            cbMoneda.DataSource = Enum.GetNames(typeof(eMoneda));
            cbMoneda.SelectedItem = eMoneda.Peso;

            cbAmbientes.DataSource = Enum.GetNames(typeof(eAmbientes));
            cbAmbientes.SelectedItem = eAmbientes.Sin_Especificar;

           
            if (vendedores.Count == 0)
            {
                vendedores = ServiceHelper.ws.GetVendedores().ToList();
            }

            if (inmuebles.Count() == 0)
            {
                inmuebles = ServiceHelper.ws.GetInmuebles().ToList();
            }

            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ",";
            nfi.NumberGroupSeparator = ".";

            propiedades = (from a in inmuebles
                           select new Propiedad
                           {
                               Id = a.Id,
                               Precio = a.Precio != null ? ((decimal)a.Precio).ToString("#,##0") : "0",
                               Disponible = a.Disponible,
                               Observaciones = a.Observaciones,
                               TipoInmueblePropiedad = ((eTipoInmueble)a.Tipo).ToString(),
                               Ambientes = ((eAmbientes)a.Ambientes).ToString(),
                               MonedaPropiedad = ((eMoneda)a.Moneda).ToString(),
                               OperacionPropiedad = ((eTipoOperacion)a.Operacion).ToString(),
                               Localidad = a.Localidad,
                               Calle = a.Calle,
                               Numero = a.Numero,
                               Fecha = a.Fecha,
                               CargadoPor = a.CargadoPor
                           }).ToList();

            gvResultado.DataSource = propiedades;
            gvResultado.Columns["Precio"].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("es-AR");
            gvResultado.AutoGenerateColumns = true;
            gvResultado.Columns["Id"].Visible = false;
            gvResultado.Columns["CargadoPor"].Visible = false;

            yaCargo = true;

        }

        private void FiltrarResultados(object sender, EventArgs e)
        {
            if (!yaCargo)
                return;

            decimal precioDesdePesos = numPrecioDesde.Value;
            decimal precioHastaPesos = numPrecioHasta.Value;

            if (cbMoneda.SelectedValue != null)
            {
                eMoneda moneda;
                Enum.TryParse<eMoneda>(cbMoneda.SelectedValue.ToString(), out moneda);

                if (moneda == eMoneda.Dolar)
                {
                    precioDesdePesos *= ServiceHelper.ValorDolar;
                    precioHastaPesos *= ServiceHelper.ValorDolar;
                }
            }

            try
            {
                Inmueble inmueble = new Inmueble();

                inmueble.Localidad = txLocalidad.Text.ToUpperInvariant();
                inmueble.Calle = txCalle.Text.ToUpperInvariant();
                inmueble.Disponible = chDisponible.Checked;

                List<Propiedad> aux = new List<Propiedad>();
                aux.AddRange(propiedades);

                if (inmueble.Disponible)
                {
                    aux.RemoveAll(x => !x.Disponible);
                }

                if (cbTipoInmueble.SelectedValue != null)
                {
                    eTipoInmueble tipoInmueblePropiedad;
                    Enum.TryParse<eTipoInmueble>(cbTipoInmueble.SelectedValue.ToString(), out tipoInmueblePropiedad);

                    if (tipoInmueblePropiedad != eTipoInmueble.Sin_Especificar)
                    {
                        aux.RemoveAll(x => x.TipoInmueblePropiedad != tipoInmueblePropiedad.ToString());

                    }
                }

                if (cbAmbientes.SelectedValue != null)
                {
                    eAmbientes ambientes;
                    Enum.TryParse<eAmbientes>(cbAmbientes.SelectedValue.ToString(), out ambientes);

                    if (ambientes != eAmbientes.Sin_Especificar)
                    {
                        aux.RemoveAll(x => x.Ambientes != ambientes.ToString());
                    }
                }

                if (cbTipoOperacion.SelectedValue != null)
                {
                    eTipoOperacion operacionPropiedad;
                    Enum.TryParse<eTipoOperacion>(cbTipoOperacion.SelectedValue.ToString(), out operacionPropiedad);

                    if (operacionPropiedad != eTipoOperacion.Sin_Especificar)
                    {
                        aux.RemoveAll(x => x.OperacionPropiedad != operacionPropiedad.ToString());

                    }
                }

                //if (cbMoneda.SelectedValue != null)
                //{
                //    eMoneda moneda;
                //    Enum.TryParse<eMoneda>(cbMoneda.SelectedValue.ToString(), out moneda);

                //    if (moneda != eMoneda.Sin_Especificar)
                //    {
                //        aux.RemoveAll(x => x.MonedaPropiedad != moneda.ToString());
                //    }

                //}

                if (!string.IsNullOrEmpty(inmueble.Calle))
                {
                    aux.RemoveAll(x => !x.Calle.Contains(inmueble.Calle));

                }

                if (!string.IsNullOrEmpty(inmueble.Localidad))
                {
                    aux.RemoveAll(x => !x.Localidad.Contains(inmueble.Localidad));
                    
                }

               
                if (numPrecioDesde.Value != 0)
                {
                    //aux.RemoveAll(x => Convert.ToDecimal(x.Precio, CultureInfo.CreateSpecificCulture("es-AR")) > numPrecioDesde.Value);

                    aux.RemoveAll(x => ((x.MonedaPropiedad == "Dolar" && ((Convert.ToDecimal(x.Precio, CultureInfo.CreateSpecificCulture("es-AR")) * ServiceHelper.ValorDolar) < precioDesdePesos))
                    || (x.MonedaPropiedad == "Peso" && Convert.ToDecimal(x.Precio, CultureInfo.CreateSpecificCulture("es-AR")) < precioDesdePesos)));
                }

                if (numPrecioHasta.Value != 0)
                {
                    //aux.RemoveAll(x => Convert.ToDecimal(x.Precio, CultureInfo.CreateSpecificCulture("es-AR")) > numPrecioHasta.Value);

                    aux.RemoveAll(x => ((x.MonedaPropiedad == "Dolar" && ((Convert.ToDecimal(x.Precio, CultureInfo.CreateSpecificCulture("es-AR")) * ServiceHelper.ValorDolar) > precioHastaPesos))
                    || (x.MonedaPropiedad == "Peso" && Convert.ToDecimal(x.Precio, CultureInfo.CreateSpecificCulture("es-AR")) > precioHastaPesos)));
                }

                gvResultado.DataSource = aux;

                gvResultado.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {
                EmailHelper.EnviarNotificacion(ex);
            }
        }

        private void btCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btImprimir_Click_1(object sender, EventArgs e)
        {
            DataGridView gvAux = new DataGridView();
            gvAux.Columns.Add("TipoInmueblePropiedad", "Tipo de Inmueble");
            gvAux.Columns.Add("OperacionPropiedad", "Tipo de Operación");
            gvAux.Columns.Add("Localidad", "Localidad");
            gvAux.Columns.Add("Calle", "Calle");
            gvAux.Columns.Add("Moneda", "Moneda");
            gvAux.Columns.Add("Precio", "Precio");
            gvAux.Columns.Add("Vendedor", "Vendedor");
            gvAux.Columns.Add("Ambientes", "Ambientes");

            foreach (DataGridViewRow row in gvResultado.Rows)
            {
               

                gvAux.Rows.Add(row.Cells["TipoInmueblePropiedad"].Value,
                row.Cells["OperacionPropiedad"].Value,
                row.Cells["Ambientes"].Value,
                row.Cells["Localidad"].Value,
                row.Cells["Calle"].Value + " " + row.Cells["Numero"].Value,
                row.Cells["MonedaPropiedad"].Value,
                row.Cells["Precio"].Value,
                vendedores.Find(x => x.Id == (int)row.Cells["CargadoPor"].Value).Nombre);

                //gvAux.Rows.Add(a);
            }

            PrinterHelper printerHelper = new PrinterHelper();
            printerHelper.gvListado = gvAux;
            printerHelper.SetValues();
            printerHelper.Imprimir();
        }

        private void btMasDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvResultado.SelectedRows.Count == 1)
                {
                    Inmueble inmueble = inmuebles.Find(x => x.Id == ((Propiedad)gvResultado.SelectedRows[0].DataBoundItem).Id);

                    frmInmueble frmInmueble = new frmInmueble();
                    frmInmueble.Inmueble = inmueble;

                    frmInmueble.MdiParent = (Form)this.Parent.Parent;
                    Panel p = (Panel)this.Parent.Parent.Controls.Find("pnlMdi", true).First();
                    p.Controls.Add(frmInmueble);

                    frmInmueble.BringToFront();
                    frmInmueble.StartPosition = FormStartPosition.Manual;

                    frmInmueble.Location = new Point(120, 0);
                    this.Close();
                    frmInmueble.Show();
                }
            }
            catch (Exception ex)
            {
                EmailHelper.EnviarNotificacion(ex);
            }
        }
    }

    public partial class Propiedad
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public string OperacionPropiedad { get; set; }
        public string TipoInmueblePropiedad { get; set; }
        public string Localidad { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
        public string EntreCalles { get; set; }
        public string Metros2Terreno { get; set; }
        public string SupCubierta { get; set; }
        public string MonedaPropiedad { get; set; }
        public string Precio { get; set; }
        public string Observaciones { get; set; }
        public int CargadoPor { get; set; }
        public string Contacto { get; set; }
        public string Referencia { get; set; }
        public string Otros { get; set; }
        public bool Disponible { get; set; }
        public string Ambientes { get; set; }
    }
}
