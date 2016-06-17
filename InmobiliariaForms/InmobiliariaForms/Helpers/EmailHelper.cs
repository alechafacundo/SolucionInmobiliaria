using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace InmobiliariaForms
{
    public static class EmailHelper
    {
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
