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
        List<Interesado> Interesados = new List<Interesado>();
        public frmBuscarInteresado()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvResultado.SelectedRows.Count == 1)
                {
                    Interesado interesado = (Interesado)gvResultado.SelectedRows[0].DataBoundItem;

                    frmInteresado frmInteresado = new frmInteresado();
                    frmInteresado.Interesado = interesado;

                    frmInteresado.MdiParent = (Form)this.Parent.Parent;
                    Panel p = (Panel)this.Parent.Parent.Controls.Find("pnlMdi", true).First();
                    p.Controls.Add(frmInteresado);

                    frmInteresado.BringToFront();
                    frmInteresado.StartPosition = FormStartPosition.Manual;

                    //int width = this.Controls.Find("netBarControl1", true)[0].Width;
                    frmInteresado.Location = new Point(120, 0);
                    this.Close();
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
            try
            {
                Interesado interesado = new Interesado();

                interesado.Nombre = txNombre.Text;
                interesado.Email = txEmail.Text;
                interesado.Telefono = txTelefono.Text;
                interesado.Observaciones = txObservaciones.Text;
                interesado.Dormitorios = txDorm.Text;

                List<Interesado> aux = new List<Interesado>();
                aux.AddRange(Interesados);

                if (cbTipoInmueble.SelectedValue != null)
                {
                    eTipoInmueble tipoInmueble;
                    Enum.TryParse<eTipoInmueble>(cbTipoInmueble.SelectedValue.ToString(), out tipoInmueble);

                    if (tipoInmueble != eTipoInmueble.Sin_Especificar)
                    {
                        //aux.AddRange(Interesados.Where(x => x.TipoDeInmueble != (int)tipoInmueble).ToList());
                        aux.RemoveAll(x => x.TipoDeInmueble != (int)tipoInmueble);
                    }
                }

                if (cbTipoOperacion.SelectedValue != null)
                {
                    eTipoOperacion tipoOperacion;
                    Enum.TryParse<eTipoOperacion>(cbTipoOperacion.SelectedValue.ToString(), out tipoOperacion);

                    if (tipoOperacion != eTipoOperacion.Sin_Especificar)
                    {
                        //aux.AddRange(Interesados.Where(x => x.TipoDeOperacion != (int)tipoOperacion).ToList());
                        aux.RemoveAll(x => x.TipoDeOperacion != (int)tipoOperacion);
                    }
                }

                if (cbMoneda.SelectedValue != null)
                {
                    eMoneda moneda;
                    Enum.TryParse<eMoneda>(cbMoneda.SelectedValue.ToString(), out moneda);

                    if (moneda != eMoneda.Sin_Especificar)
                    {
                        aux.RemoveAll(x => x.TipoDeMoneda != (int)moneda);
                        //aux.AddRange(Interesados.Where(x => x.TipoDeMoneda != (int)moneda).ToList());
                    }

                }

                if (!string.IsNullOrEmpty(interesado.Dormitorios))
                {
                    aux.RemoveAll(x => !x.Dormitorios.ToUpperInvariant().Contains(interesado.Dormitorios.ToUpperInvariant()));
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
                    aux.RemoveAll(x => x.MontoDesde > numDesde.Value);
                    //aux.AddRange(Interesados.Where(x => x.MontoDesde < numDesde.Value));
                }
                if (numHasta.Value != 0)
                {
                    aux.RemoveAll(x => x.MontoHasta < numHasta.Value);
                    //aux.AddRange(Interesados.Where(x => x.MontoHasta > numHasta.Value));
                }

                gvResultado.DataSource = aux;
                gvResultado.Columns["Id"].Visible = false;
                gvResultado.Columns["FullName"].Visible = false;

                foreach (DataGridViewRow row in gvResultado.Rows)
                {
                    row.Cells["TipoInmueble"].Value = ((eTipoInmueble)(int)row.Cells["TipoDeInmueble"].Value).ToString();
                    row.Cells["TipoOperacion"].Value = ((eTipoOperacion)(int)row.Cells["TipoDeOperacion"].Value).ToString();
                    
                    row.Cells["TipoMoneda"].Value = ((eMoneda)(int)row.Cells["TipoDeMoneda"].Value).ToString();
                }
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

        private void frmBuscarInteresado_Load(object sender, EventArgs e)
        {
            cbTipoInmueble.DataSource = Enum.GetNames(typeof(eTipoInmueble));
            cbTipoInmueble.SelectedItem = eTipoInmueble.Sin_Especificar;

            cbTipoOperacion.DataSource = Enum.GetNames(typeof(eTipoOperacion));
            cbTipoOperacion.SelectedItem = eTipoOperacion.Sin_Especificar;

            cbMoneda.DataSource = Enum.GetNames(typeof(eMoneda));
            cbMoneda.SelectedItem = eMoneda.Sin_Especificar;

            if (Interesados.Count() == 0)
            {
                Interesados = ServiceHelper.ws.GetInteresados().ToList();
            }

            gvResultado.DataSource = Interesados;

            gvResultado.Columns.Add("TipoInmueble", "Tipo de Inmueble");
            gvResultado.Columns.Add("TipoOperacion", "Tipo de Operación");
            gvResultado.Columns.Add("TipoMoneda", "Moneda");
            gvResultado.Columns.Add("Nombre", "Nombre");
            gvResultado.Columns.Add("Telefono", "Telefono");
            gvResultado.Columns.Add("Email", "Email");

            foreach (DataGridViewRow row in gvResultado.Rows)
            {
                row.Cells["TipoInmueble"].Value = ((eTipoInmueble)(int)row.Cells["TipoDeInmueble"].Value).ToString();
                row.Cells["TipoOperacion"].Value = ((eTipoOperacion)(int)row.Cells["TipoDeOperacion"].Value).ToString();
                row.Cells["TipoMoneda"].Value = ((eMoneda)(int)row.Cells["TipoDeMoneda"].Value).ToString();
            }

            gvResultado.Columns["Id"].Visible = false;
   
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
          
            DataGridView gvAux = new DataGridView();
            gvAux.Columns.Add("Nombre", "Nombre");
            gvAux.Columns.Add("TipoInmueble", "Tipo de Inmueble");
            gvAux.Columns.Add("TipoOperacion", "Tipo de Operación");
            gvAux.Columns.Add("TipoMoneda", "Moneda");
            gvAux.Columns.Add("Monto Hasta", "Monto Hasta");
            gvAux.Columns.Add("Email", "Email");
            gvAux.Columns.Add("Telefono", "Telefono");

            foreach (DataGridViewRow row in gvResultado.Rows)
            {
                    gvAux.Rows.Add(row.Cells["Nombre"].Value,
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
    
}
