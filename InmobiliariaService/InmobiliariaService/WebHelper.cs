using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using System.Web;
using System.Text;

namespace InmobiliariaService
{
    public class WebHelper
    {
        public void GetInmueblesWeb()
        {

            WebClient syncClient = new WebClient();
            //syncClient.Headers.Add("application / json");
            var contentString = syncClient.DownloadString("http://localhost/service/info.php");
            //var contentData = syncClient.DownloadData("http://localhost/service/info.php");

            // deserialize from json
            DataContractJsonSerializer ser =
                   new DataContractJsonSerializer(typeof(List<Rootobject>));

            // put the downloaded data in a memory stream
            //MemoryStream ms = new MemoryStream();
            //ms = new MemoryStream(Encoding.Unicode.GetBytes(contentString));

            //MemoryStream ms1 = new MemoryStream();
            //ms1 = new MemoryStream(contentData);
            ////ms = new MemoryStream(content);


            //List<Rootobject> result = ser.ReadObject(ms) as List<Rootobject>;
            //List<Rootobject> result1 = ser.ReadObject(ms1) as List<Rootobject>;


            // Create the Json serializer and parse the response
            Rootobject weatherData = new Rootobject();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Rootobject));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(contentString)))
            {
                weatherData = (Rootobject)serializer.ReadObject(ms);
            }

            List<Info> inmueblesWeb = weatherData.info.ToList();

            List<Inmueble> inmuebles = InmuebleDAO.GetInmuebles();

            foreach (Info inmuebleWeb in inmueblesWeb)
            {
                Inmueble inmueble = new Inmueble();
                string observaciones = string.Empty;
                observaciones += "Nombre en la web: " + inmuebleWeb.nombre_identitario + Environment.NewLine;
                observaciones += "Comentarios en la web: " + inmuebleWeb.comentarios + Environment.NewLine;
                observaciones += "Comentarios Internos: " + inmuebleWeb.comentarios_internos + Environment.NewLine;
                inmueble.Observaciones = observaciones;
                inmueble.Id = Convert.ToInt32(inmuebleWeb.id);
                //inmueble.Dormitorios = inmuebleWeb.ambientes;
                inmueble.Calle = inmuebleWeb.direccion;
                inmueble.Fecha = Convert.ToDateTime(inmuebleWeb.fecha);
                inmueble.Tipo = Convert.ToInt32(inmuebleWeb.tipo_inmueble);
                inmueble.Operacion = Convert.ToInt32(inmuebleWeb.tipo_operacion);

                if (!inmuebles.Exists(x => x.Id == inmueble.Id))
                {
                    InmuebleDAO.GuardarInmueble(inmueble, true);
                }
            }

            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri(URL);

            //// Add an Accept header for JSON format.
            //client.DefaultRequestHeaders.Accept.Add(
            //new MediaTypeWithQualityHeaderValue("application/json"));

            //// List data response.
            //HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call!
            //if (response.IsSuccessStatusCode)
            //{
            //    // Parse the response body. Blocking!
            //    var dataObjects = response.Content.ReadAsAsync<IEnumerable<DataObject>>().Result;
            //    foreach (var d in dataObjects)
            //    {
            //        Console.WriteLine("{0}", d.Name);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            //}




            // web client
            //WebClient client = new WebClient();
            //client.Headers["Content-type"] = "application/json";

            //// invoke the REST method
            //byte[] data = client.DownloadData("http://localhost/service/info.php");

            //// put the downloaded data in a memory stream
            //MemoryStream ms = new MemoryStream();
            //ms = new MemoryStream(data);

            //// deserialize from json
            //DataContractJsonSerializer ser =
            //       new DataContractJsonSerializer(typeof(List<InmuebleWeb>));

            //List<InmuebleWeb> result = ser.ReadObject(ms) as List<InmuebleWeb>;

            //return result;
        }
    }
}