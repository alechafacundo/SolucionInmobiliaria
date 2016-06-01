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


            Service ws = new Service();

            if (Interesados.Count() == 0)
            {
                Interesados = ws.GetInteresados().ToList();
            }

            gvResultado.DataSource = Interesados;
        }

        private void FiltrarResultados(object sender, EventArgs e)
        {
            try
            {
                Interesado interesado = new Interesado();
                interesado.Nombre = txNombre.Text;
                interesado.Email = txEmail.Text;
                interesado.Telefono = txTelefono.Text;
              
              

                List<Interesado> aux = new List<Interesado>();

                if (!string.IsNullOrEmpty(interesado.Nombre))
                {
                    aux.AddRange(Interesados.Where(x => x.Nombre.ToUpperInvariant().Contains(interesado.Nombre.ToUpperInvariant())).ToList());
                }
                if (!string.IsNullOrEmpty(interesado.Telefono))
                {
                    aux.AddRange(Interesados.Where(x => x.Telefono.ToUpperInvariant().Contains(interesado.Telefono.ToUpperInvariant())).ToList());
                }
             
                if (!string.IsNullOrEmpty(interesado.Email))
                {
                    aux.AddRange(Interesados.Where(x => x.Email.ToUpperInvariant().Contains(interesado.Email.ToUpperInvariant())).ToList());
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
