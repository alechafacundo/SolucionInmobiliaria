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
            cbMoneda.SelectedItem = eMoneda.Peso;

            Service ws = new Service();

            //Para tener el maestro de Vendedores y poder ponerlos ahi
            if (vendedores.Count == 0)
            {
                vendedores = ws.GetVendedores().ToList();
            }

            if (inmuebles.Count() == 0)
            {   
                inmuebles = ws.GetInmuebles().ToList();
            }

            foreach (DataGridViewRow item in gvResultado.Rows)
            {
                item.Cells["CargadoNombre"].Value = vendedores.Find(x => x.Id == (int)item.Cells["CargadoPor"].Value).FullName;
            }

            gvResultado.DataSource = inmuebles;
            gvResultado.Columns["Id"].Visible = false;
            gvResultado.Columns["CargadoPor"].Visible = false;
            gvResultado.Columns.Add("CargadoNombre", "Cargado Por");
          
        }

        private void FiltrarResultados(object sender, EventArgs e)
        {
            try
            {
                Inmueble inmueble = new Inmueble();
                inmueble.Fecha = dateTimeFecha.Value;
                inmueble.Localidad = txLocalidad.Text.ToUpperInvariant();
                inmueble.Barrio = txBarrio.Text.ToUpperInvariant();
                inmueble.Dormitorios = txDorm.Text.ToUpperInvariant();
                inmueble.Patio = txPatio.Text.ToUpperInvariant();
                inmueble.Baños = txBaño.Text.ToUpperInvariant();
                inmueble.Garage = txGarage.Text.ToUpperInvariant();
                inmueble.Comedor = txComedor.Text.ToUpperInvariant(); 

                List<Inmueble> aux = new List<Inmueble>();
                aux = inmuebles;

                if ((int)cbTipoInmueble.SelectedValue != (int)eTipoInmueble.Sin_Especificar)
                {
                    aux = aux.Where(x => x.Tipo == (int)cbTipoInmueble.SelectedValue).ToList();
                }

                if ((int)cbTipoOperacion.SelectedValue != (int)eTipoOperacion.Sin_Especificar)
                {
                    aux = aux.Where(x => x.Operacion == (int)cbTipoOperacion.SelectedValue).ToList();
                }

                if (!string.IsNullOrEmpty(inmueble.Localidad))
                {
                    aux.AddRange(inmuebles.Where(x => x.Localidad.ToUpperInvariant().Contains(inmueble.Localidad.ToUpperInvariant())).ToList());
                }

                if (!string.IsNullOrEmpty(inmueble.Barrio))
                {
                    aux.AddRange(inmuebles.Where(x => x.Barrio.ToUpperInvariant().Contains(inmueble.Barrio.ToUpperInvariant())).ToList());
                }

                if (numPrecioDesde.Value != 0)
                {
                    aux = aux.Where(x => x.Precio >= numPrecioDesde.Value).ToList();
                }
                if (numPrecioHasta.Value != 0)
                {
                    aux = aux.Where(x => x.Precio <= numPrecioHasta.Value).ToList();
                }

                //gvResultado.DataSource = aux;

                //Inmueble inmueble = new Inmueble();
                //inmueble.Localidad = txLocalidad.Text;
                //inmueble.Barrio = txBarrio.Text;

                //aux = inmuebles.Where(x => x.Operacion == (int)cbTipoOperacion.SelectedValue).ToList();

            }
            catch (Exception)
            {
            }

        }

     
   
        private void btBuscar_Click_1(object sender, EventArgs e)
        {
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
                    }
                }
                catch (Exception ex)
                {
                    Helper.EnviarNotificacion(ex);
                    throw;

                }
            }
        }

        private void btCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btImprimir_Click_1(object sender, EventArgs e)
        {
            //DataGridView gvAux = new DataGridView();
            //gvAux.Columns.Add("Fecha", "Fecha");
            //gvAux.Columns.Add("Operacion", "Operación");
            //gvAux.Columns.Add("Tipo", "Tipo");
            //gvAux.Columns.Add("Fecha", "Fecha");
            //gvAux.Columns.Add("Fecha", "Fecha");
            //gvAux.Columns.Add("Fecha", "Fecha");
        }
    }
}
