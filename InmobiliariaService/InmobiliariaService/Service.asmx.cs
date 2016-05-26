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
    }

}