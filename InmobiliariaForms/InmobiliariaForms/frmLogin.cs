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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {

            //Esto vendría a ser como el ValidarCampos que siempre hacemos
            if (txUser.Text == string.Empty || txPassword.Text == string.Empty)
            {
                MessageBox.Show("Por favor introduzca Nombre de Usuario y Password",
                    "Error iniciando sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                InmobiliariaService.Service ws = new InmobiliariaService.Service();
                if (ws.Login(txUser.Text, txPassword.Text))
                {
                    //Entro al sistema
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
    }
}
