using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace InmobiliariaForms
{
    internal static class ServiceHelper
    {
        internal static InmobiliariaService.Service ws = new InmobiliariaService.Service();

        public static void Connect()
        {
            try
            {
                //XmlDocument xmlDoc = LoadXmlDocument("Settings.xml");
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("App_Data/Settings.xml");
                ws.Url = xmlDoc.SelectSingleNode("Settings/url").InnerText;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
