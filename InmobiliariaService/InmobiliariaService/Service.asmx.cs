using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Services;
using System.Xml;

namespace InmobiliariaService
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Service : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";

        }

        [WebMethod]
        public void Test(Inmueble inmueble, Interesado interesado, eTipoInmueble tipoInmueble,
            eTipoOperacion tipoOperacion, eMoneda moneda, Vendedor vendedor, eAmbientes ambientes, eCochera cochera,
            eUbicacion ubicacion, eEstado estado)
        {

        }

        [WebMethod]
        public int GuardarInmueble(Inmueble inmueble)
        {
            try
            {
                return InmuebleDAO.GuardarInmueble(inmueble);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public void GuardarInteresado(Interesado interesado)
        {
            try
            {
                InteresadoDAO.CrearInteresado(interesado);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public void GuardarVendedor(Vendedor vendedor)
        {
            try
            {
                VendedorDAO.CrearVendedor(vendedor);
            }
            catch (Exception)
            {
                throw;
            }

        }

        [WebMethod]
        public Inmueble[] GetInmueblesParaInteresado(Interesado interesado, decimal cotizacion)
        {
            try
            {
                return InmuebleDAO.GetInmueblesParaInteresado(interesado, cotizacion).ToArray();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public Inmueble[] BuscarInmuebles(Inmueble inmueble, decimal? precioDesde, decimal? precioHasta)
        {
            try
            {
                return InmuebleDAO.BuscarInmuebles(inmueble, precioDesde, precioHasta).ToArray();
            }
            catch (Exception)
            {

                throw;
            }

        }


        [WebMethod]
        public Vendedor[] GetVendedores()
        {
            try
            {
                return VendedorDAO.GetVendedores().ToArray();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [WebMethod]
        public Interesado[] GetInteresados()
        {
            try
            {
                return InteresadoDAO.GetInteresados().ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public Inmueble[] GetInmuebles()
        {
            try
            {
                return InmuebleDAO.GetInmuebles().ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public Vendedor Login(string email, string password)
        {
            try
            {
                return VendedorDAO.Login(email, password);
            }
            catch (Exception ex)
            {
                //ToDo Fabri loguear ex
                throw ex;
            }
        }

        [WebMethod]
        public Foto[] GetFotosDelInmueble(int inmuebleId)
        {
            try
            {
                return FotoDAO.GetFotosDelInmueble(inmuebleId).ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public bool GuardarFoto(Foto foto)
        {
            try
            {
                FotoDAO.CrearFoto(foto);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void TestNotificarSobreInmueble()
        {
            try
            {
                //Este metodo es para probar el envio de los inmuebles
                List<Interesado> interesados = InteresadoDAO.GetInteresados();
                Interesado interesado = interesados.Find(x => x.Nombre == "Kevin");
                NotificarSobreInmueble(interesado, 14.5m);
            }
            catch (Exception ex)
            {
            }
        }

        [WebMethod]
        public void NotificarSobreInmueble(Interesado interesado, decimal cotizacion)
        {
            if (!interesado.Disponible)
                return;

            if (cotizacion == 0)
                cotizacion = GetDolar();

            try
            {
                List<Inmueble> inmuebles = InmuebleDAO.GetInmueblesParaInteresado(interesado, cotizacion);
                if (inmuebles.Count > 0)
                {
                    EmailHelper.SendInmueblesInEmail(inmuebles, interesado);
                }
            }
            catch (Exception ex)
            {
                EmailHelper.EnviarNotificacion(ex);
            }
        }

        [WebMethod]
        public void TestNotificarSobreInteresado()
        {
            //Este metodo es para probar el envio de los interesados para el inmueble que se detalla abajo
            try
            {
                List<Inmueble> inmuebles = InmuebleDAO.GetInmuebles();
                NotificarSobreInteresado(inmuebles.Find(x => x.Numero == "234"), 15.0m);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [WebMethod]
        public void NotificarSobreInteresado(Inmueble inmueble, decimal cotizacion)
        {
            if (!inmueble.Disponible)
                return;

            if (cotizacion == 0)
                cotizacion = GetDolar();

            try
            {
                List<Interesado> interesados = InteresadoDAO.GetInteresadosParaInmueble(inmueble, cotizacion);
                if (interesados.Count > 0)
                {
                    EmailHelper.SendInteresadosInEmail(interesados, inmueble);
                }
            }
            catch (Exception ex)
            {
                EmailHelper.EnviarNotificacion(ex);
            }
        }

        [WebMethod]
        public bool EliminarVendedor(Vendedor vendedor)
        {
            try
            {
                return DAOBase.DeleteEntity(vendedor);
            }
            catch (Exception ex)
            {
                EmailHelper.EnviarNotificacion(ex);
                throw ex;
            }
        }

        [WebMethod]
        public bool EliminarInmueble(Inmueble inmueble)
        {

            try
            {
                bool respuesta = InmuebleDAO.DeleteInmueble(inmueble);
                return respuesta;
                //return DAOBase.DeleteEntity(inmueble);
            }
            catch (Exception ex)
            {
                EmailHelper.EnviarNotificacion(ex);
                throw ex;
            }
        }

        [WebMethod]
        public bool EliminarInteresado(Interesado interesado)
        {
            try
            {
                return DAOBase.DeleteEntity(interesado);
            }
            catch (Exception ex)
            {
                EmailHelper.EnviarNotificacion(ex);
                throw ex;
            }
        }

        [WebMethod]
        public void GetInmueblesWeb()
        {
            try
            {
                WebHelper wHelper = new WebHelper();
                wHelper.GetInmueblesWeb();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public decimal GetDolar()
        {
            try
            {
                string xmlName = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "Settings.xml");

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlName);
                string valorDolar = xmlDoc.SelectSingleNode("dolar").InnerText;

                return Convert.ToDecimal(valorDolar);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public void SetDolar(decimal dolar)
        {
            string xmlName = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "Settings.xml");

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlName);
            XmlNode valorDolar = xmlDoc.SelectSingleNode("dolar");
            valorDolar.FirstChild.Value = dolar.ToString();

            xmlDoc.Save(xmlName);
        }

        [WebMethod]
        public bool SubirInmuebleWeb(int inmuebleId)
        {
            try
            {
                WebHelper helper = new WebHelper();
                List<Inmueble> inmuebles = InmuebleDAO.GetInmuebles();
                Inmueble inmueble = inmuebles.Find(x => x.Id == inmuebleId);
                int webId = helper.InsertInmueble(inmueble);

                inmueble.WebId = webId;
                InmuebleDAO.GuardarInmueble(inmueble);

                List<Foto> fotos = FotoDAO.GetFotosDelInmueble(inmueble.Id);
                foreach (Foto foto in fotos)
                {
                    helper.InsertFoto(foto, inmueble.WebId);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        [WebMethod]
        public void Test2()
        {
            List<Inmueble> inmuebles = InmuebleDAO.GetInmuebles();

            decimal cotizacion = GetDolar();

            foreach (Inmueble inmueble in inmuebles)
            {
                NotificarSobreInteresado(inmueble, cotizacion);
            }
        }
        [WebMethod]
        public void Test3(int interesadoId)
        {

            List<Interesado> interesados = new List<InmobiliariaService.Interesado>();
            interesados = InteresadoDAO.GetInteresados();
            Interesado interesado = interesados.Find(XmlAttribute => XmlAttribute.Id == interesadoId);

            decimal cotizacion = GetDolar();

            GetInmueblesParaInteresado(interesado, cotizacion);
        }
    }

}