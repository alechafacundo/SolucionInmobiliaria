
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
    public partial class frmVendedor : Form
    {
        public Vendedor Vendedor { get; set; }

        public frmVendedor()
        {
            InitializeComponent();
        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {
            try
            {
                if (Vendedor != null)
                {
                    btEliminar.Visible = true;
                    txApellido.Text = Vendedor.Apellido;
                    txNombre.Text = Vendedor.Nombre;
                    txTelefono.Text = Vendedor.Telefono;
                    txDNI.Text = Vendedor.DNI;
                    txEmail.Text = Vendedor.Email;
                    txLegajo.Text = Vendedor.Legajo;
                    txCelular.Text = Vendedor.Celular;
                    txPassword.Text = Vendedor.Password;
                    txConfirmarPassword.Text = Vendedor.Password;

                    lbPassword.Visible = false;
                    txPassword.Visible = false;
                    lbConfirmarPassword.Visible = false;
                    txConfirmarPassword.Visible = false;
                    //ToDo: Facu
                    //Falta poner el tx del Password. Poner uno para confirmar password, y en validar campos tienen que ser iguales
                }
            }
            catch (Exception ex)
            {
                Helper.EnviarNotificacion(ex);
                throw;
            }

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string validaciones = ValidarCampos();
                if (validaciones == string.Empty)
                {
                    if (Vendedor == null)
                    {
                        Vendedor = new Vendedor();
                    }
                    Vendedor.Nombre = txNombre.Text;
                    Vendedor.Apellido = txApellido.Text;
                    Vendedor.DNI = txDNI.Text;
                    Vendedor.Legajo = txLegajo.Text;
                    Vendedor.Telefono = txTelefono.Text;
                    Vendedor.Celular = txCelular.Text;
                    Vendedor.Email = txEmail.Text;
                    Vendedor.Password = txPassword.Text;

                    Service ws = new Service();
                    ws.GuardarVendedor(Vendedor);
                    MessageBox.Show("Vendedor guardado correctamente!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(validaciones, "Error validando la información.");
                }
            }
            catch (Exception ex)
            {
                Helper.EnviarNotificacion(ex);
                MessageBox.Show(ex.Message);
            }

        }
        private string ValidarCampos()
        {
            try
            {
                if (txApellido.Text == "")
                    return "Debe completar el Apellido para poder guardar el Vendedor.";
                //Esta es otra manera que mira si es vacio, es nullo, o es un espacio blanco, es como una manera mas cheta de hacer lo mismo que de arriba.
                if (string.IsNullOrEmpty(txDNI.Text))
                    return "Debe completar el DNI para poder guardar el Vendedor.";
                if (string.IsNullOrEmpty(txNombre.Text))
                    return "Debe completar el Nombre para poder guardar el Vendedor.";
                if (string.IsNullOrEmpty(txPassword.Text))
                    return "Debe completar el Password para poder guardar el Vendedor.";
                if (string.IsNullOrEmpty(txConfirmarPassword.Text))
                    return "Debe completar el campo Confirmar Password para poder guardar el Vendedor.";
                if (txPassword.Text != txConfirmarPassword.Text)
                    return "Los campos Password y Comnfirmar Password no coinciden.";
                return string.Empty;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
