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
                bool filtroAlgo = false;

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
                        aux.RemoveAll(x => x.TipoDeInmueble != (int)tipoInmueble);
                        //aux = aux.Where(x => x.Tipo == (int)tipoInmueble).ToList();
                    }
                }

                if (cbTipoOperacion.SelectedValue != null)
                {
                    eTipoOperacion tipoOperacion;
                    Enum.TryParse<eTipoOperacion>(cbTipoOperacion.SelectedValue.ToString(), out tipoOperacion);

                    if (tipoOperacion != eTipoOperacion.Sin_Especificar)
                    {
                        aux.RemoveAll(x => x.TipoDeOperacion != (int)tipoOperacion);
                        //aux = aux.Where(x => x.Operacion == (int)tipoOperacion).ToList();
                    }
                }

                if (cbMoneda.SelectedValue != null)
                    {
                        eMoneda moneda;
                        Enum.TryParse<eMoneda>(cbMoneda.SelectedValue.ToString(), out moneda);

                        if (moneda != eMoneda.Sin_Especificar)
                        {
                            aux.RemoveAll(x => x.TipoDeMoneda != (int)moneda);
                        }

                    }


                    if (!string.IsNullOrEmpty(interesado.Dormitorios))
                {
                    aux.AddRange(Interesados.Where(x => x.Dormitorios.ToUpperInvariant().Contains(interesado.Dormitorios.ToUpperInvariant())).ToList());
                    filtroAlgo = true;
                }

                if (!string.IsNullOrEmpty(interesado.Nombre))
                {
                    aux.AddRange(Interesados.Where(x => x.Nombre.ToUpperInvariant().Contains(interesado.Nombre.ToUpperInvariant())).ToList());
                    filtroAlgo = true;
                }
                if (!string.IsNullOrEmpty(interesado.Telefono))
                {
                    aux.AddRange(Interesados.Where(x => x.Telefono.ToUpperInvariant().Contains(interesado.Telefono.ToUpperInvariant())).ToList());
                    filtroAlgo = true;
                }

                if (!string.IsNullOrEmpty(interesado.Email))
                {
                    aux.AddRange(Interesados.Where(x => x.Email.ToUpperInvariant().Contains(interesado.Email.ToUpperInvariant())).ToList());
                    filtroAlgo = true;
                }


                if (!string.IsNullOrEmpty(interesado.Observaciones))
                {
                    aux.AddRange(Interesados.Where(x => x.Observaciones.ToUpperInvariant().Contains(interesado.Observaciones.ToUpperInvariant())).ToList());
                    filtroAlgo = true;
                }

                if (numDesde.Value != 0)
                {
                    aux.AddRange(Interesados.Where(x => x.MontoDesde < numDesde.Value));
                    filtroAlgo = true;
                }
                if (numHasta.Value != 0)
                {
                    aux.AddRange(Interesados.Where(x => x.MontoHasta > numHasta.Value));
                    filtroAlgo = true;
                }

                if (!filtroAlgo)
                    aux.AddRange(Interesados);

                aux = aux.Distinct().ToList();

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
            catch (Exception)
            {
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
            gvResultado.Columns["Id"].Visible = false;
        }
    }
    
}
