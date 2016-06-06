﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace InmobiliariaService
{
    public static class EmailHelper
    {
        internal static List<Vendedor> vendedores;

        public static void SendInmueblesInEmail(List<Inmueble> inmuebles)
        {
            try
            {
                string cabecera = "Se han encontrado coincidencias en los siguientes Inmuebles con el Interesado ingresado:" + Environment.NewLine + Environment.NewLine;
                string cuerpo = string.Empty;

                foreach (Inmueble inmueble in inmuebles)
                {
                    string localidad = "N/A";
                    string calle = "N/A";
                    string numero = "N/A";
                    string piso = "N/A";
                    string departamento = "N/A";
                    string dormitorio = "N/A";
                    string baño = "N/A";
                    string comedor = "N/A";
                    string supCubierta = "0";
                    decimal valor = 0m;
                    string referencia = "N/A";

                    if (!string.IsNullOrEmpty(inmueble.Localidad))
                        localidad = inmueble.Localidad;
                    if (!string.IsNullOrEmpty(inmueble.Calle))
                        calle = inmueble.Calle;
                    if (!string.IsNullOrEmpty(inmueble.Numero))
                        numero = inmueble.Numero;
                    if (!string.IsNullOrEmpty(inmueble.Piso))
                        piso = inmueble.Piso;
                    if (!string.IsNullOrEmpty(inmueble.Departamento))
                        departamento = inmueble.Departamento;
                    if (!string.IsNullOrEmpty(inmueble.Baños))
                        baño = inmueble.Baños;
                    if (!string.IsNullOrEmpty(inmueble.Dormitorios))
                        dormitorio = inmueble.Dormitorios;
                    if (!string.IsNullOrEmpty(inmueble.Comedor))
                        comedor = inmueble.Comedor;
                    if (!string.IsNullOrEmpty(inmueble.SupCubierta))
                        supCubierta = inmueble.SupCubierta;
                    if (inmueble.Precio != null)
                        valor = (decimal)inmueble.Precio;
                    if (!string.IsNullOrEmpty(inmueble.Referencia))
                        referencia = inmueble.Referencia;


                    cuerpo += string.Format("- Hay un/a {0}, que está ubicado en {1}, más precisamente en la calle {2} N° {3} piso {4} departamento {5}.",
                        ((eTipoInmueble)inmueble.Tipo).ToString(), localidad, calle, numero, piso, departamento) + Environment.NewLine;
                    cuerpo += string.Format("El mismo está constituido por {0} dormitorio/s, {1} baño/s y {2} comedor/es. ", dormitorio, baño, comedor);
                    cuerpo += string.Format("Cuenta con una superficie cubierta de {0}.", supCubierta) + Environment.NewLine;
                    cuerpo += string.Format("Su valor de {0} es de {1}{2}", ((eTipoOperacion)inmueble.Operacion).ToString(), ((eMoneda)inmueble.Moneda).ToString(), valor.ToString()) + Environment.NewLine;
                    cuerpo += string.Format("La administración del mismo la posee {0} y puede ser ubicado al {1}", referencia, GetVendedorName(inmueble.CargadoPor)) + Environment.NewLine;
                }

                EnviarNotificacion(cabecera + cuerpo);

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        private static string GetVendedorName(int vendedorId)
        {
            string nombre = string.Empty;
            try
            {
                if (vendedores == null || vendedores.Count() > 0)
                    vendedores = VendedorDAO.GetVendedores();

                Vendedor vendedor = vendedores.Find(x => x.Id == vendedorId);
                if (vendedor != null)
                {
                    nombre = vendedor.Nombre;
                }

                return nombre;
            }
            catch (Exception)
            {
                return nombre;
            }
        }

        internal static void EnviarNotificacion(string mensaje)
        {
            try
            {
                //Sino nos van a bloquear la cuenta porque van a pensar que es spam
                //return;
                MailMessage message = new MailMessage();
                message.To.Add("duarte.fabricio.90@gmail.com");
                message.To.Add("alechaf@gmail.com");
                message.Subject = "Se encontraron coincidencias!";
                message.From = new System.Net.Mail.MailAddress("system_as@outlook.com", "SystemAs");
                message.Priority = MailPriority.High;

                string text = string.Format(mensaje);
                message.Body = text;

                SmtpClient smtpClient = new SmtpClient("smtp.live.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new System.Net.NetworkCredential("system_as@outlook.com", "q1w2e3r4t5");

                smtpClient.Send(message);
            }
            catch (Exception)
            {
            }
        }

        internal static void EnviarNotificacion(Exception ex)
        {
            try
            {
                //Sino nos van a bloquear la cuenta porque van a pensar que es spam
                return;
                MailMessage message = new MailMessage();
                message.To.Add("duarte.fabricio.90@gmail.com");
                message.To.Add("alechaf@gmail.com");
                message.Subject = "Error en Solución Inmobiliaria";
                message.From = new System.Net.Mail.MailAddress("system_as@outlook.com", "SystemAs");
                message.Priority = MailPriority.High;

                string text = string.Format("Error ocurrido en SolucionInmobiliaria: {0}", ex.Message);
                message.Body = text;

                SmtpClient smtpClient = new SmtpClient("smtp.live.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new System.Net.NetworkCredential("system_as@outlook.com", "q1w2e3r4t5");

                smtpClient.Send(message);
            }
            catch (Exception)
            {
            }
        }

    }
}