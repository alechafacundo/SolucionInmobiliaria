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
            eTipoOperacion tipoOperacion, eMoneda moneda)
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
                List<Vendedor> vendedores = new List<Vendedor>();
                Vendedor v1 = new Vendedor();
                v1.Id = 1;
                v1.Nombre = "Facu";
                v1.Direccion = "Trejo 1070";
                vendedores.Add(v1);

                Vendedor v2 = new Vendedor();
                v2.Id = 2;
                v2.Nombre = "Fabri";
                v2.Direccion = "Corrientes 4315";
                vendedores.Add(v2);

                Vendedor v3 = new Vendedor();
                v3.Id = 3;
                v3.Nombre = "Gonza";
                v3.Direccion = "Cabaret 1320";
                vendedores.Add(v3);

                return vendedores.ToArray();

                return VendedorDAO.GetVendedores().ToArray();
            }
            catch (Exception)
            {

                throw;
            }
        } 
    }

}