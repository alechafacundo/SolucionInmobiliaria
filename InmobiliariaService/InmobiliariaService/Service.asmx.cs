using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;

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
            eTipoOperacion tipoOperacion, eMoneda moneda, Vendedor vendedor)
        {

        }

        [WebMethod]
        public void GuardarInmueble(Inmueble inmueble)
        {
            try
            {
                InmuebleDAO.GuardarInmueble(inmueble);
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
        public Inmueble[] GetInmueblesParaInteresado(Interesado interesado)
        {
            try
            {
                return InmuebleDAO.GetInmueblesParaInteresado(interesado).ToArray();
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
        public Vendedor Login(string dni, string password)
        {
            try
            {
                return VendedorDAO.Login(dni, password);
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
        public void NotificarSobreInmueble(Interesado interesado)
        {
            try
            {
                List<Inmueble> inmuebles = InmuebleDAO.GetInmueblesParaInteresado(interesado);
                EmailHelper.SendInmueblesInEmail(inmuebles);
            }
            catch (Exception ex)
            {
                EmailHelper.EnviarNotificacion(ex);
            }
        }

        [WebMethod]
        public void NotificarSobreInteresado(Inmueble inmueble)
        {
            try
            {
                List<Interesado> interesados = InteresadoDAO.GetInteresadosParaInmueble(inmueble);
                EmailHelper.SendInteresadosInEmail(interesados);
            }
            catch (Exception ex)
            {
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
                return DAOBase.DeleteEntity(inmueble);
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
    }

}