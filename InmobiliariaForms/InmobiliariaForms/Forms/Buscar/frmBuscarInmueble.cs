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


        private void frmBuscarInmueble_Load(object sender, EventArgs e)
        {
            cbTipoInmueble.DataSource = Enum.GetNames(typeof(eTipoInmueble));
            cbTipoInmueble.SelectedItem = eTipoInmueble.Sin_Especificar;

            cbTipoOperacion.DataSource = Enum.GetNames(typeof(eTipoOperacion));
            cbTipoOperacion.SelectedItem = eTipoOperacion.Sin_Especificar;

            cbMoneda.DataSource = Enum.GetNames(typeof(eMoneda));
            cbMoneda.SelectedItem = eMoneda.Sin_Especificar;

            //Para tener el maestro de Vendedores y poder ponerlos ahi
            if (vendedores.Count == 0)
            {
                vendedores = ServiceHelper.ws.GetVendedores().ToList();
            }

            if (inmuebles.Count() == 0)
            {
                inmuebles = ServiceHelper.ws.GetInmuebles().ToList();
            }

            //foreach (DataGridViewRow item in gvResultado.Rows)
            //{
            //    item.Cells["CargadoNombre"].Value = vendedores.Find(x => x.Id == (int)item.Cells["CargadoPor"].Value).FullName;
            //}

            gvResultado.DataSource = inmuebles;

            gvResultado.Columns.Add("TipoInmueble", "Tipo de Inmueble");
            gvResultado.Columns.Add("TipoOperacion", "Tipo de Operación");
            gvResultado.Columns.Add("Vendedor", "Vendedor");
            gvResultado.Columns.Add("TipoMoneda", "Moneda");

            foreach (DataGridViewRow row in gvResultado.Rows)
            {
                row.Cells["TipoInmueble"].Value = ((eTipoInmueble)(int)row.Cells["Tipo"].Value).ToString();
                row.Cells["TipoOperacion"].Value = ((eTipoOperacion)(int)row.Cells["Operacion"].Value).ToString();
                row.Cells["Vendedor"].Value = vendedores.Find(x => x.Id == (int)row.Cells["CargadoPor"].Value).FullName;
                row.Cells["TipoMoneda"].Value = ((eMoneda)(int)row.Cells["Moneda"].Value).ToString();
            }

            gvResultado.Columns["Id"].Visible = false;
            gvResultado.Columns["Tipo"].Visible = false;
            gvResultado.Columns["Operacion"].Visible = false;
            gvResultado.Columns["CargadoPor"].Visible = false;
            gvResultado.Columns["Moneda"].Visible = false;
        }

        private void FiltrarResultados(object sender, EventArgs e)
        {
            try
            {
                Inmueble inmueble = new Inmueble();
               
                inmueble.Localidad = txLocalidad.Text.ToUpperInvariant();
                inmueble.Barrio = txBarrio.Text.ToUpperInvariant();
                inmueble.Dormitorios = txDorm.Text.ToUpperInvariant();
                inmueble.Calle = txCalle.Text.ToUpperInvariant();
         

                List<Inmueble> aux = new List<Inmueble>();
                aux.AddRange(inmuebles);

                if (cbTipoInmueble.SelectedValue != null)
                {
                    eTipoInmueble tipoInmueble;
                    Enum.TryParse<eTipoInmueble>(cbTipoInmueble.SelectedValue.ToString(), out tipoInmueble);

                    if (tipoInmueble != eTipoInmueble.Sin_Especificar)
                    {
                        aux.RemoveAll(x => x.Tipo != (int)tipoInmueble);
                        //aux = aux.Where(x => x.Tipo == (int)tipoInmueble).ToList();
                    }
                }

                if (cbTipoOperacion.SelectedValue != null)
                {
                    eTipoOperacion tipoOperacion;
                    Enum.TryParse<eTipoOperacion>(cbTipoOperacion.SelectedValue.ToString(), out tipoOperacion);

                    if (tipoOperacion != eTipoOperacion.Sin_Especificar)
                    {
                        aux.RemoveAll(x => x.Operacion != (int)tipoOperacion);
                        //aux = aux.Where(x => x.Operacion == (int)tipoOperacion).ToList();
                    }
                }

                if (!string.IsNullOrEmpty(inmueble.Calle))
                {
                    aux.RemoveAll(x => !x.Calle.Contains(inmueble.Calle));
                    
                }

                if (!string.IsNullOrEmpty(inmueble.Localidad))
                {
                    aux.RemoveAll(x => !x.Localidad.Contains(inmueble.Localidad));
                    //aux.AddRange(inmuebles.Where(x => x.Localidad.ToUpperInvariant().Contains(inmueble.Localidad)).ToList());
                }

                if (!string.IsNullOrEmpty(inmueble.Barrio))
                {
                    aux.RemoveAll(x => !x.Barrio.Contains(inmueble.Barrio));
                    //aux.AddRange(inmuebles.Where(x => x.Barrio.ToUpperInvariant().Contains(inmueble.Barrio)).ToList());
                }

                if (numPrecioDesde.Value != 0)
                {
                    aux.RemoveAll(x => x.Precio < numPrecioDesde.Value);
                    //aux = aux.Where(x => x.Precio >= numPrecioDesde.Value).ToList();
                }
                if (numPrecioHasta.Value != 0)
                {
                    aux.RemoveAll(x => x.Precio > numPrecioHasta.Value);
                    //aux = aux.Where(x => x.Precio <= numPrecioHasta.Value).ToList();
                }

                gvResultado.DataSource = aux;

                foreach (DataGridViewRow row in gvResultado.Rows)
                {
                    row.Cells["TipoInmueble"].Value = ((eTipoInmueble)(int)row.Cells["Tipo"].Value).ToString();
                    row.Cells["TipoOperacion"].Value = ((eTipoOperacion)(int)row.Cells["Operacion"].Value).ToString();
                    row.Cells["Vendedor"].Value = vendedores.Find(x => x.Id == (int)row.Cells["CargadoPor"].Value).FullName;
                    row.Cells["TipoMoneda"].Value = ((eMoneda)(int)row.Cells["Moneda"].Value).ToString();
                }
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
            gvAux.Columns.Add("Tipo", "Tipo de Inmueble");
            gvAux.Columns.Add("Operacion", "Tipo de Operación");
            gvAux.Columns.Add("Localidad", "Localidad");
            gvAux.Columns.Add("Calle", "Calle");
            gvAux.Columns.Add("Moneda", "Moneda");
            gvAux.Columns.Add("Precio", "Precio");
            gvAux.Columns.Add("Vendedor", "Vendedor");

            foreach (DataGridViewRow row in gvResultado.Rows)
            {
                //DataGridViewRow a = (DataGridViewRow)gvAux.RowTemplate.Clone();
                //a.Cells["Tipo"].Value = row.Cells["TipoInmueble"].Value;
                //a.Cells["Operacion"].Value = row.Cells["TipoOperacion"].Value;
                //a.Cells["Localidad"].Value = row.Cells["Localidad"].Value;
                //a.Cells["Calle"].Value = row.Cells["Calle"].Value + " " + row.Cells["Numero"].Value;
                //a.Cells["Moneda"].Value = row.Cells["TipoMoneda"].Value;
                //a.Cells["Precio"].Value = row.Cells["Precio"].Value;
                //a.Cells["Vendedor"].Value = row.Cells["Vendedor"].Value;

                gvAux.Rows.Add(row.Cells["TipoInmueble"].Value,
                    row.Cells["TipoOperacion"].Value,
                    row.Cells["Localidad"].Value,
                    row.Cells["Calle"].Value + " " + row.Cells["Numero"].Value,
                    row.Cells["TipoMoneda"].Value,
                    row.Cells["Precio"].Value,
                    row.Cells["Vendedor"].Value);

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
                    Inmueble inmueble = (Inmueble)gvResultado.SelectedRows[0].DataBoundItem;

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
}
