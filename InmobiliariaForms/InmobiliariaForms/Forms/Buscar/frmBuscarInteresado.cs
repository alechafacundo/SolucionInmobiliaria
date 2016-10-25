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
    public partial class frmBuscarInteresado : Form
    {
        bool yaCargo = false;

        List<Interesado> Interesados = new List<Interesado>();

        List<Persona> Personas = new List<Persona>();

        public frmBuscarInteresado()
        {
            InitializeComponent();
        }

        private void frmBuscarInteresado_Load(object sender, EventArgs e)
        {
            cbTipoInmueble.DataSource = Enum.GetNames(typeof(eTipoInmueble));
            cbTipoInmueble.SelectedItem = eTipoInmueble.Sin_Especificar;

            cbTipoOperacion.DataSource = Enum.GetNames(typeof(eTipoOperacion));
            cbTipoOperacion.SelectedItem = eTipoOperacion.Sin_Especificar;

            cbMoneda.DataSource = Enum.GetNames(typeof(eMoneda));
            cbMoneda.SelectedItem = eMoneda.Sin_Especificar;

            cbAmbientes.DataSource = Enum.GetNames(typeof(eAmbientes));
            cbAmbientes.SelectedItem = eAmbientes.Sin_Especificar;

            cbLocalidad.DataSource = Enum.GetNames(typeof(eLocalidad));
            cbLocalidad.SelectedItem = eLocalidad.Sin_Especificar;

            if (Interesados.Count() == 0)
            {
                Interesados = ServiceHelper.ws.GetInteresados().ToList();
            }

            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ",";
            nfi.NumberGroupSeparator = ".";

            Personas = (from a in Interesados
                         select new Persona
                         {
                             Id = a.Id,
                             Ambientes = ((eAmbientes)a.Ambientes).ToString(),
                             Email = a.Email,
                             MontoDesde = a.MontoDesde != null ? ((decimal)a.MontoDesde).ToString("#,##0") : "0",
                             MontoHasta = a.MontoHasta != null ? ((decimal)a.MontoHasta).ToString("#,##0") : "0",
                             Nombre = a.Nombre,
                             Apellido = a.Apellido,
                             Disponible = a.Disponible,
                             Observaciones = a.Observaciones,
                             Telefono = a.Telefono,
                             TipoInmueble = ((eTipoInmueble)a.TipoDeInmueble).ToString(),
                             TipoMoneda = ((eMoneda)a.TipoDeMoneda).ToString(),
                             TipoOperacion = ((eTipoOperacion)a.TipoDeOperacion).ToString(),
                             Localidad = a.Localidad
                         }).ToList();

            gvResultado.DataSource = Personas;
            //gvResultado.Columns["MontoDesde"].ValueType = typeof(decimal);
            gvResultado.Columns["MontoDesde"].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("es-AR");
            gvResultado.AutoGenerateColumns = true;
            gvResultado.Columns["Id"].Visible = false;

            yaCargo = true;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvResultado.SelectedRows.Count == 1)
                {
                    Interesado interesado = Interesados.Find(x => x.Id == ((Persona)gvResultado.SelectedRows[0].DataBoundItem).Id);

                    frmInteresado frmInteresado = new frmInteresado();
                    frmInteresado.Interesado = interesado;

                    frmInteresado.MdiParent = (Form)this.Parent.Parent;
                    Panel p = (Panel)this.Parent.Parent.Controls.Find("pnlMdi", true).First();
                    p.Controls.Add(frmInteresado);

                    frmInteresado.BringToFront();
                    frmInteresado.StartPosition = FormStartPosition.Manual;

                    //int width = this.Controls.Find("netBarControl1", true)[0].Width;
                    frmInteresado.Location = new Point(120, 0);
                    //this.Close();
                    frmInteresado.Show();
                }
            }
            catch (Exception ex)
            {
                EmailHelper.EnviarNotificacion(ex);
                throw;
            }
        }

        private void FiltrarResultados(object sender, EventArgs e)
        {
            if (!yaCargo)
                return;

            decimal precioDesdePesos = numDesde.Value;
            decimal precioHastaPesos = numHasta.Value;

            if (cbMoneda.SelectedValue != null)
            {
                eMoneda moneda;
                Enum.TryParse<eMoneda>(cbMoneda.SelectedValue.ToString(), out moneda);

                if (moneda != eMoneda.Dolar)
                {
                    precioDesdePesos *= ServiceHelper.ValorDolar;
                    precioHastaPesos *= ServiceHelper.ValorDolar;
                }
            }

            try
            {
                Interesado interesado = new Interesado();

                interesado.Nombre = txNombre.Text;
                interesado.Apellido = txApellido.Text;
                interesado.Email = txEmail.Text;
                interesado.Telefono = txTelefono.Text;
                interesado.Observaciones = txObservaciones.Text;
                interesado.Disponible = chDisponible.Checked;

                List<Persona> aux = new List<Persona>();
                aux.AddRange(Personas);

                if (interesado.Disponible)
                {
                    aux.RemoveAll(x => !x.Disponible);
                }

                if (cbLocalidad.SelectedValue != null)
                {
                    /*if (cbLocalidad.SelectedValue != eLocalidad.Sin_Especificar)
                    {
                        aux.RemoveAll(x => x.TipoInmueble != cbLocalidad.SelectedValue.ToString());
                    }*/

                    eLocalidad localidad;
                    Enum.TryParse<eLocalidad>(cbLocalidad.SelectedValue.ToString(), out localidad);

                    if (localidad != eLocalidad.Sin_Especificar)
                    {
                        //aux.AddRange(Interesados.Where(x => x.TipoDeInmueble != (int)tipoInmueble).ToList());
                        aux.RemoveAll(x => x.Localidad != localidad.ToString());
                    }

                    /*eLocalidad localidad;
                    Enum.TryParse<eLocalidad>(cbLocalidad.SelectedValue.ToString(), out localidad);

                    if (tipoInmueble != eTipoInmueble.Sin_Especificar)
                    {
                        //aux.AddRange(Interesados.Where(x => x.TipoDeInmueble != (int)tipoInmueble).ToList());
                        aux.RemoveAll(x => x.TipoInmueble != tipoInmueble.ToString());
                    }*/
                }

                if (cbTipoInmueble.SelectedValue != null)
                {
                    eTipoInmueble tipoInmueble;
                    Enum.TryParse<eTipoInmueble>(cbTipoInmueble.SelectedValue.ToString(), out tipoInmueble);

                    if (tipoInmueble != eTipoInmueble.Sin_Especificar)
                    {
                        //aux.AddRange(Interesados.Where(x => x.TipoDeInmueble != (int)tipoInmueble).ToList());
                        aux.RemoveAll(x => x.TipoInmueble != tipoInmueble.ToString());
                    }
                }

                if (cbAmbientes.SelectedValue != null)
                {
                    eAmbientes ambientes;
                    Enum.TryParse<eAmbientes>(cbAmbientes.SelectedValue.ToString(), out ambientes);

                    if (ambientes != eAmbientes.Sin_Especificar)
                    {
                        //aux.AddRange(Interesados.Where(x => x.TipoDeInmueble != (int)tipoInmueble).ToList());
                        aux.RemoveAll(x => x.Ambientes != ambientes.ToString());
                    }
                }

                if (cbTipoOperacion.SelectedValue != null)
                {
                    eTipoOperacion tipoOperacion;
                    Enum.TryParse<eTipoOperacion>(cbTipoOperacion.SelectedValue.ToString(), out tipoOperacion);

                    if (tipoOperacion != eTipoOperacion.Sin_Especificar)
                    {
                        //aux.AddRange(Interesados.Where(x => x.TipoDeOperacion != (int)tipoOperacion).ToList());
                        aux.RemoveAll(x => x.TipoOperacion != tipoOperacion.ToString());
                    }
                }

                //if (cbMoneda.SelectedValue != null)
                //{
                //    eMoneda moneda;
                //    Enum.TryParse<eMoneda>(cbMoneda.SelectedValue.ToString(), out moneda);

                //    if (moneda != eMoneda.Sin_Especificar)
                //    {
                //        aux.RemoveAll(x => x.TipoMoneda != moneda.ToString());
                //        //aux.AddRange(Interesados.Where(x => x.TipoDeMoneda != (int)moneda).ToList());
                //    }

                //}

                if (!string.IsNullOrEmpty(interesado.Apellido))
                {
                    aux.RemoveAll(x => !x.Apellido.ToUpperInvariant().Contains(interesado.Apellido.ToUpperInvariant()));
                    //aux.AddRange(Interesados.Where(x => x.Dormitorios.ToUpperInvariant().Contains(interesado.Dormitorios.ToUpperInvariant())).ToList());
                }

                if (!string.IsNullOrEmpty(interesado.Nombre))
                {
                    aux.RemoveAll(x => !x.Nombre.ToUpperInvariant().Contains(interesado.Nombre.ToUpperInvariant()));
                    //aux.AddRange(Interesados.Where(x => x.Nombre.ToUpperInvariant().Contains(interesado.Nombre.ToUpperInvariant())).ToList());
                }
                if (!string.IsNullOrEmpty(interesado.Telefono))
                {
                    aux.RemoveAll(x => !x.Telefono.ToUpperInvariant().Contains(interesado.Telefono.ToUpperInvariant()));
                    //aux.AddRange(Interesados.Where(x => x.Telefono.ToUpperInvariant().Contains(interesado.Telefono.ToUpperInvariant())).ToList());
                }

                if (!string.IsNullOrEmpty(interesado.Email))
                {
                    aux.RemoveAll(x => !x.Email.ToUpperInvariant().Contains(interesado.Email.ToUpperInvariant()));
                    //aux.AddRange(Interesados.Where(x => x.Email.ToUpperInvariant().Contains(interesado.Email.ToUpperInvariant())).ToList());
                }


                if (!string.IsNullOrEmpty(interesado.Observaciones))
                {
                    aux.RemoveAll(x => !x.Observaciones.ToUpperInvariant().Contains(interesado.Observaciones.ToUpperInvariant()));
                    //aux.AddRange(Interesados.Where(x => x.Observaciones.ToUpperInvariant().Contains(interesado.Observaciones.ToUpperInvariant())).ToList());
                }

                if (numDesde.Value != 0)
                {
                    //aux.RemoveAll(x => Convert.ToDecimal(x.MontoDesde, CultureInfo.CreateSpecificCulture("es-AR")) > numDesde.Value);
                    aux.RemoveAll(x => Convert.ToDecimal(x.MontoDesde, CultureInfo.CreateSpecificCulture("es-AR")) > precioDesdePesos);
                }

                if (numHasta.Value != 0)
                {
                    //aux.RemoveAll(x => Convert.ToDecimal(x.MontoHasta, CultureInfo.CreateSpecificCulture("es-AR")) < numHasta.Value);
                    aux.RemoveAll(x => Convert.ToDecimal(x.MontoHasta, CultureInfo.CreateSpecificCulture("es-AR")) < precioHastaPesos);
                }

                gvResultado.DataSource = aux;
                gvResultado.Columns["Id"].Visible = false;
                //gvResultado.Columns["FullName"].Visible = false;

                //foreach (DataGridViewRow row in gvResultado.Rows)
                //{
                //    row.Cells["TipoInmueble"].Value = ((eTipoInmueble)(int)row.Cells["TipoDeInmueble"].Value).ToString();
                //    row.Cells["TipoOperacion"].Value = ((eTipoOperacion)(int)row.Cells["TipoDeOperacion"].Value).ToString();
                    
                //    row.Cells["TipoMoneda"].Value = ((eMoneda)(int)row.Cells["TipoDeMoneda"].Value).ToString();
                //}
            }
            catch (Exception ex)
            {
                EmailHelper.EnviarNotificacion(ex);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
          
            DataGridView gvAux = new DataGridView();
            gvAux.Columns.Add("Nombre", "Nombre");
            gvAux.Columns.Add("Apellido", "Apellido");
            gvAux.Columns.Add("TipoInmueble", "Tipo de Inmueble");
            gvAux.Columns.Add("TipoOperacion", "Tipo de Operación");
            gvAux.Columns.Add("TipoMoneda", "Moneda");
            gvAux.Columns.Add("Monto Hasta", "Monto Hasta");
            gvAux.Columns.Add("Email", "Email");
            gvAux.Columns.Add("Telefono", "Telefono");

            foreach (DataGridViewRow row in gvResultado.Rows)
            {
                    gvAux.Rows.Add(row.Cells["Nombre"].Value,
                        row.Cells["Apellido"].Value,
                    row.Cells["TipoInmueble"].Value,
                    row.Cells["TipoOperacion"].Value,
                    row.Cells["TipoMoneda"].Value,
                    row.Cells["MontoHasta"].Value,
                    row.Cells["Email"].Value,
                    row.Cells["Telefono"].Value);


                //gvAux.Rows.Add(a);
            }

            PrinterHelper printerHelper = new PrinterHelper();
            printerHelper.gvListado = gvAux;
            printerHelper.SetValues();
            printerHelper.Imprimir();
        }
        
    }

    public partial class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string MontoDesde { get; set; }        
        public string MontoHasta { get; set; }      
        public string TipoMoneda { get; set; }
        public string TipoOperacion { get; set; }
        public string TipoInmueble { get; set; }
        public string Ambientes { get; set; }
        public string Observaciones { get; set; }
        public bool Disponible { get; set; }
        public string Localidad { get; set; }
    }
}
