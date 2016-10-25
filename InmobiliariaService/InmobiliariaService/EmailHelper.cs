using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace InmobiliariaService
{
    public static class EmailHelper
    {
        internal static List<Vendedor> vendedores;

        public static void SendInmueblesInEmail(List<Inmueble> inmuebles, Interesado interesado)
        {
            try
            {
                string cabecera = string.Empty;
                string nombre = "N/A";
                if (!string.IsNullOrEmpty(interesado.Nombre))
                    nombre = interesado.Nombre;
                if (!string.IsNullOrEmpty(interesado.Apellido))
                    nombre += " " + interesado.Apellido;

                cabecera += string.Format("Se han encontrado los siguientes Inmuebles con el Interesado  <b> {0} </b>:<br><br>", nombre ) + Environment.NewLine;

                string cuerpo = string.Empty;

                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalSeparator = ",";
                nfi.NumberGroupSeparator = ".";

                foreach (Inmueble inmueble in inmuebles.Where(x => x.Disponible))
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
                    string valor = "0";
                    string referencia = "N/A";
                    string contacto = "N/A";

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
                    //if (!string.IsNullOrEmpty(inmueble.Baños))
                    //    baño = inmueble.Baños;
                    //if (!string.IsNullOrEmpty(inmueble.Dormitorios))
                    //    dormitorio = inmueble.Dormitorios;
                    //if (!string.IsNullOrEmpty(inmueble.Comedor))
                    //    comedor = inmueble.Comedor;
                    if (!string.IsNullOrEmpty(inmueble.SupCubierta))
                        supCubierta = inmueble.SupCubierta;
                    if (inmueble.Precio != null)
                        valor = ((decimal)inmueble.Precio).ToString("#,##0");
                    if (!string.IsNullOrEmpty(inmueble.Referencia))
                        referencia = inmueble.Referencia;
                    if (!string.IsNullOrEmpty(inmueble.Contacto))
                        contacto = inmueble.Contacto;


                    cuerpo += string.Format("- {0}, ubicado en <b> {1} </b>, en la calle <b> {2} N° {3} </b> piso {4} departamento {5}.<br>",
                        ((eTipoInmueble)inmueble.Tipo).ToString(), localidad, calle, numero, piso, departamento) + Environment.NewLine;
                    cuerpo += string.Format("El mismo está constituido por {0} dormitorio/s, {1} baño/s y {2} comedor/es. Cuenta con una superficie cubierta de {3} Mts.<br>", dormitorio, baño, comedor, supCubierta);
                    cuerpo += string.Format("Su valor de {0} es de <b> {1} {2} </b>.<br>", ((eTipoOperacion)inmueble.Operacion).ToString(), ((eMoneda)inmueble.Moneda).ToString(), valor.ToString(CultureInfo.CreateSpecificCulture("es-Ar"))) + Environment.NewLine;
                    cuerpo += string.Format("El contacto del mismo es <b> {0} </b> puede ser ubicado al {1}.<br><br>", contacto, referencia) + Environment.NewLine;
                }

                EnviarNotificacion(cabecera + cuerpo);

            }
            catch (Exception)
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
                message.To.Add("santiago@moranvilla.com.ar");

                if (mensaje.ToUpperInvariant().Contains("ALQUILER"))
                    message.To.Add("alquileres@moranvilla.com.ar");
                else
                    message.To.Add("ventas@moranvilla.com.ar");

                message.CC.Add("santiago@moranvilla.com.ar");

                message.Bcc.Add("duarte.fabricio.90@gmail.com");
                message.Bcc.Add("alechaf@gmail.com");

                message.Subject = "Se encontraron coincidencias!";
                message.From = new System.Net.Mail.MailAddress("system_as@outlook.com", "SystemAs");
                message.Priority = MailPriority.High;
                message.IsBodyHtml = true;

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

        internal static void SendInteresadosInEmail(List<Interesado> interesados, Inmueble inmueble)
        {
            try
            {
                string cabecera = string.Empty;

                string localidad = "N/A";
                string calle = "N/A";
                string numero = "N/A";

                if (!string.IsNullOrEmpty(inmueble.Localidad))
                    localidad = inmueble.Localidad;

                if (!string.IsNullOrEmpty(inmueble.Calle))
                    calle = inmueble.Calle;

                if (!string.IsNullOrEmpty(inmueble.Numero))
                    numero = inmueble.Numero;

                
                cabecera += string.Format("Se han encontrado los siguientes Interesados para el Inmueble: {0}, ubicado en <b> {1} Nº{2} </b> de la localidad de {3} <br><br>", ((eTipoInmueble)inmueble.Tipo).ToString(), calle, numero, localidad) + Environment.NewLine;

                string cuerpo = string.Empty;

                foreach (Interesado interesado in interesados.Where(x => x.Disponible))
                {
                    string nombre = "N/A";
                    string telefono = "N/A";
                    string email = "N/A";
                  
                    if (!string.IsNullOrEmpty(interesado.Nombre))
                        nombre = interesado.Nombre;
                    if (!string.IsNullOrEmpty(interesado.Apellido))
                        nombre += " " + interesado.Apellido;
                    if (!string.IsNullOrEmpty(interesado.Telefono))
                        telefono = interesado.Telefono;
                    if (!string.IsNullOrEmpty(interesado.Email))
                        email = interesado.Email;

                    cuerpo += string.Format("- <b> {0} </b>.<br>", nombre) + Environment.NewLine;
                    cuerpo += string.Format("- Telefono: {0} <br> ", telefono) + Environment.NewLine;
                    cuerpo += string.Format("- Email: {0} <br><br>", email) + Environment.NewLine;
                    cuerpo += "<br><br>";
                }

                EnviarNotificacion(cabecera + cuerpo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal static void EnviarNotificacion(Exception ex)
        {
            try
            {
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