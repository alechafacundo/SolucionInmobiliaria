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



            if (Interesado != null)
            {
                txNombre.Text = Interesado.Nombre;
                txTelefono.Text = Interesado.Telefono;
                txEmail.Text = Interesado.Email;
                numDesde.Value = Interesado.MontoDesde != null ? (decimal)Interesado.MontoDesde : 0;
                numHasta.Value = Interesado.MontoHasta != null ? (decimal)Interesado.MontoHasta : 0;
                //cbTipoInmueble
                
            }
        }

        
    }
}
