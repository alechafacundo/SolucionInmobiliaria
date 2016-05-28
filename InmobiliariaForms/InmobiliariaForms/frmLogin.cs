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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public Vendedor Vendedor { get; set; }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (Debug())
                return;
            //Esto vendría a ser como el ValidarCampos que siempre hacemos
            if (txUser.Text == string.Empty || txPassword.Text == string.Empty)
            {
                MessageBox.Show("Por favor introduzca Nombre de Usuario y Password",
                    "Error iniciando sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                Service ws = new Service();
                Vendedor vendedor = ws.Login(txUser.Text, txPassword.Text);
                if (vendedor != null)
                {
                    //Entro al sistema
                    this.Vendedor = vendedor;

                    MessageBox.Show("Bienvenido " + vendedor.Nombre + "!",
                        "Inicio de sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    //No entró
                    MessageBox.Show("Por favor verifique Nombre de Usuario y Password",
                        "Error iniciando sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Podemos hacer esto para ya tener el usuario logueado
                //if (usuario.Id != 0)
                //{
                //    this.Usuario = usuario;

                //    MessageBox.Show("Bienvenido " + txUser.Text + "!",
                //        "Inicio de sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                //    this.Close();
                //}
            }
            catch (Exception ex)
            {
            }
        }

        private bool Debug()
        {
            if (txUser.Text == "admin" && txPassword.Text == "admin")
            {
                Vendedor aux = new Vendedor();
                aux.Nombre = "Admin";
                aux.Id = 1;
                aux.DNI = "33998844";

                this.Vendedor = aux;
                MessageBox.Show("Bienvenido " + this.Vendedor.Nombre + "!",
                        "Inicio de sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                DialogResult = DialogResult.OK;
                this.Close();

                return true;
            }
            else
            {
                return false;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
