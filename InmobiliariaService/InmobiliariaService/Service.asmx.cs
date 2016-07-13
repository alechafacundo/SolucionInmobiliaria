﻿using System;
using System.Collections.Generic;
using System.Linq;
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
                List<Interesado> interesados = InteresadoDAO.GetInteresados();
                Interesado interesado = interesados.Find(x => x.Nombre == "Juan de los palotes");
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

            try
            {
                List<Inmueble> inmuebles = InmuebleDAO.GetInmueblesParaInteresado(interesado, cotizacion);
                if(inmuebles.Count > 0)
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
            try
            {
                List<Inmueble> inmuebles = InmuebleDAO.GetInmuebles();
                NotificarSobreInteresado(inmuebles.Find(x => x.Numero == "234"));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [WebMethod]
        public void NotificarSobreInteresado(Inmueble inmueble)
        {
            if (!inmueble.Disponible)
                return;

            try
            {
                List<Interesado> interesados = InteresadoDAO.GetInteresadosParaInmueble(inmueble);
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
    }

}