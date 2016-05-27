﻿
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
        Vendedor Vendedor { get; set }
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {
            try

            { if (Vendedor != null)
               {
                txApellido.Text = Vendedor.Apellido;
                txNombre.Text = Vendedor.Nombre;
                txTelefono.Text = Vendedor.Telefono;
                txDNI.Text = Vendedor.DNI;
                txEmail.Text = Vendedor.Email;
                txLegajo.Text = Vendedor.Legajo; 
                txCelular.Text = Vendedor.Celular; 
               
               }
            catch (Exception ex)
            {  //ToDo: Fabri
                //Modulo de notificaciones
                throw;
            }

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Vendedor vendedor = new Vendedor();
                vendedor.Nombre = txNombre.Text;
                vendedor.Apellido = txApellido.Text;
                vendedor.DNI = txDNI.Text;
                vendedor.Legajo = txLegajo.Text;
                vendedor.Telefono = txTelefono.Text;
                vendedor.Celular = txCelular.Text;
                vendedor.Email = txEmail.Text;
                
            }
            try
            {
                Service ws = new Service();
                ws.GuardarVendedor(Vendedor);
                MessageBox.Show("Vendedor guardado correctamente!");
                //this.DialogResult = DialogResult.ok;
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool ValidarCampos()
        {
            if (txApellido == "")
            {
                return false;
            }
            if (true)
            {

            }
            return true;
        }
    }
}
