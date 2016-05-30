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
    public partial class frmBuscarVendedor : Form
    {
        List<Vendedor> Vendedores = new List<Vendedor>();

        public frmBuscarVendedor()
        {
            InitializeComponent();
        }

        private void btMasDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvResultado.SelectedRows.Count == 1)
                {
                    Vendedor vendedor = (Vendedor)gvResultado.SelectedRows[0].DataBoundItem;

                    frmVendedor frmVendedor = new frmVendedor();
                    frmVendedor.Vendedor = vendedor;

                    frmVendedor.MdiParent = (Form)this.Parent.Parent;
                    Panel p = (Panel)this.Parent.Parent.Controls.Find("pnlMdi", true).First();
                    p.Controls.Add(frmVendedor);

                    frmVendedor.BringToFront();
                    frmVendedor.StartPosition = FormStartPosition.Manual;

                    //int width = this.Controls.Find("netBarControl1", true)[0].Width;
                    frmVendedor.Location = new Point(120, 0);
                    this.Close();
                    frmVendedor.Show();
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

        private void frmBuscarVendedor_Load(object sender, EventArgs e)
        {
            Service ws = new Service();

            if (Vendedores.Count() == 0)
            {
                Vendedores = ws.GetVendedores().ToList();
            }

            gvResultado.DataSource = Vendedores;

        }

        private void FiltrarResultados(object sender, EventArgs e)
        {
            try
            {
                Vendedor vendedor = new Vendedor();
                vendedor.Nombre = txNombre.Text;
                vendedor.Apellido = txApellido.Text;
                vendedor.DNI = txDNI.Text;
                vendedor.Legajo = txLegajo.Text;
                vendedor.Telefono = txTelefono.Text;
                vendedor.Celular = txCelular.Text;
                vendedor.Email = txEmail.Text;

                List<Vendedor> aux = new List<Vendedor>();

                if (!string.IsNullOrEmpty(vendedor.Nombre))
                {
                    aux.AddRange(Vendedores.Where(x => x.Nombre.ToUpperInvariant().Contains(vendedor.Nombre.ToUpperInvariant())).ToList());
                }
                if (!string.IsNullOrEmpty(vendedor.Apellido))
                {
                    aux.AddRange(Vendedores.Where(x => x.Apellido.ToUpperInvariant().Contains(vendedor.Apellido.ToUpperInvariant())).ToList());
                }
                if (!string.IsNullOrEmpty(vendedor.DNI))
                {
                    aux.AddRange(Vendedores.Where(x => x.DNI.ToUpperInvariant().Contains(vendedor.DNI.ToUpperInvariant())).ToList());
                }
                if (!string.IsNullOrEmpty(vendedor.Legajo))
                {
                    aux.AddRange(Vendedores.Where(x => x.Legajo.ToUpperInvariant().Contains(vendedor.Legajo.ToUpperInvariant())).ToList());
                }
                if (!string.IsNullOrEmpty(vendedor.Telefono))
                {
                    aux.AddRange(Vendedores.Where(x => x.Telefono.ToUpperInvariant().Contains(vendedor.Telefono.ToUpperInvariant())).ToList());
                }
                if (!string.IsNullOrEmpty(vendedor.Celular))
                {
                    aux.AddRange(Vendedores.Where(x => x.Celular.ToUpperInvariant().Contains(vendedor.Celular.ToUpperInvariant())).ToList());
                }
                if (!string.IsNullOrEmpty(vendedor.Email))
                {
                    aux.AddRange(Vendedores.Where(x => x.Email.ToUpperInvariant().Contains(vendedor.Email.ToUpperInvariant())).ToList());
                }

                aux = aux.Distinct().ToList();

                gvResultado.DataSource = aux;
                gvResultado.Columns["Id"].Visible = false;
                gvResultado.Columns["FullName"].Visible = false;
            }
            catch (Exception)
            {
            }

        }
    }
}
