using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Globalization;

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
        public void Test(Barrio barrio, Inmueble inmueble, Interesado interesado, Localidad localidad, Vendedor vendedor, eTipoInmueble tipoInm, eTipoOperacion tipoOpe)
        {

        }

        [WebMethod]
        public Inmueble[] GetDummyInmuebles()
        {
            List<Inmueble> inmuebles = new List<Inmueble>();

            Inmueble inmueble = new Inmueble();
            inmueble.Baños = null;
            inmueble.BarrioId = 1;
            inmueble.Calle = "Aleman, M.A.";
            inmueble.Cocina = null;
            inmueble.Comedor = null;
            inmueble.Contacto = string.Empty;
            inmueble.DependenciasOtras = string.Empty;
            inmueble.Dormitorios = null;
            inmueble.EntreCalles = "Esquina Catrilo";
            inmueble.Fecha = DateTime.ParseExact("13/01/2015", "dd/mm/yyyy", CultureInfo.InvariantCulture);
            inmueble.Garage = null;
            inmueble.Id = 1;
            inmueble.LocalidadId = 1;
            inmueble.Metros = "";
            inmueble.Moneda = eMoneda.Peso.ToString();
            inmueble.Numero = null;
            inmueble.Observaciones = string.Empty;
            inmueble.Otro = string.Empty;
            inmueble.Patio = null;
            inmueble.Precio = 1200000;
            inmueble.Referencia = string.Empty;
            inmueble.SupCubierta = 95;
            inmueble.Telefono = string.Empty;
            inmueble.TipoInmueble = eTipoInmueble.Casa.ToString();
            inmueble.TipoOperacion = eTipoOperacion.Venta;
            inmueble.UserId = 1;
            inmueble.ValorMetro2 = null;
            inmueble.VendedorId = 1;

            Inmueble inmueble1 = new Inmueble();
            inmueble1.Fecha = DateTime.ParseExact("13/01/2015", "dd/mm/yyyy", CultureInfo.InvariantCulture);
            inmueble1.TipoOperacion = eTipoOperacion.Venta;
            inmueble1.TipoInmueble = eTipoInmueble.Casa.ToString();
            inmueble1.VendedorId = 1;
            inmueble1.Telefono = string.Empty;
            inmueble1.LocalidadId = 1;
            inmueble1.BarrioId = 1;
            inmueble1.Calle = "Aleman, M.A.";
            inmueble1.Numero = null;
            inmueble1.EntreCalles = "Esquina Catrilo";
            inmueble1.Metros = "95";
            inmueble1.SupCubierta = 95;
            inmueble1.Moneda = eMoneda.Peso.ToString();
            inmueble1.Precio = 1200000;
            inmueble1.Observaciones = string.Empty;
            inmueble1.Dormitorios = null;
            inmueble1.Baños = null;
            inmueble1.Comedor = null;
            inmueble1.Cocina = null;
            inmueble1.Garage = null;
            inmueble1.Patio = null;
            inmueble1.DependenciasOtras = string.Empty;
            inmueble1.ValorMetro2 = null;
            inmueble1.Contacto = string.Empty;
            inmueble1.Id = 1;
            inmueble1.Referencia = string.Empty;
            inmueble1.Otro = string.Empty;
            inmueble1.UserId = 1;
        }
    }
}