using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using System.Web;
using System.Text;
using System.Collections.Specialized;
using System.Drawing;

namespace InmobiliariaService
{
    public class WebHelper
    {
        public int InsertInmueble(Inmueble inmueble)
        {
            int inmuebleId = 0;

            string url = "http://www.moranvilla.com.ar/web/insertFormInmueble";
            using (WebClient client = new WebClient())
            {
                var values = new NameValueCollection();
                values["fecha"] = inmueble.Fecha.Value.ToString("yyyy-MM-dd hh:mm:ss");
                values["tipo_operacion"] = inmueble.Operacion.ToString();
                values["tipo_inmueble"] = inmueble.Tipo.ToString();
                //values["ubicacion_interna"] = 
                //inmueble.expensas
                //inmueble.baulera
                values["pisos"] = inmueble.Piso;
                values["departamentos"] = inmueble.Departamento;
                //inmueble.ascensores
                values["nombre_identitario"] = inmueble.Calle + " " + inmueble.Numero;
                values["ambientes"] = inmueble.Ambientes.ToString();
                //values["localidad"]
                values["direccion"] = inmueble.Calle + " " + inmueble.Numero +
                    " " + inmueble.EntreCalles;
                //inmueble.suplibre
                values["superficie_cubierta"] = inmueble.SupCubierta;
                //anchoterreno
                //altoterreno
                //orientacion
                values["estado"] = inmueble.Estado.ToString();
                values["antiguedad"] = inmueble.Antiguedad;
                values["comentarios"] = inmueble.Observaciones;
                values["comentarios_internos"] = inmueble.Precio.ToString() + " " + inmueble.Comentarios;

                //va a la web y lo crea en mysql mediante php y me devuelve el id
                //para volverlo a ejecutar avisame y lo borro de la base
                var result = client.UploadValues(url, values);

                //ese id lo encodeo a un string
                string resultado = Encoding.UTF8.GetString(result).ToString().Trim();

                char[] r = Encoding.UTF8.GetChars(result);
                string a = Encoding.ASCII.GetString(result);
                string b = Encoding.Default.GetString(result);
                string c = Encoding.Unicode.GetString(result);

                for (int i = 0; i < r.Length; i++)
                {
                    int num2;
                    if (int.TryParse(r[i].ToString(), out num2))
                    {
                        // It was assigned.
                    }

                    num2 = Convert.ToInt32(r[i]);
                }

                int num3;
                if (int.TryParse(resultado, out num3))
                {
                    // It was assigned.
                }
                if (int.TryParse(a, out num3))
                {
                    // It was assigned.
                }
                if (int.TryParse(b, out num3))
                {
                    // It was assigned.
                }
                if (int.TryParse(c, out num3))
                {
                    // It was assigned.
                }


                Int32.TryParse(resultado.Trim(), System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out inmuebleId);

                inmuebleId = Convert.ToInt32(Convert.ToInt64(resultado));
            }

            return inmuebleId;

        }

        public void InsertFoto(Foto foto, int webId)
        {
            try
            {
                string url = "http://www.moranvilla.com.ar/web/insertFormFoto";
                using (WebClient client = new WebClient())
                {
                    var values = new NameValueCollection();
                    values["foto"] = Convert.ToBase64String(foto.Imagen, Base64FormattingOptions.None);
                    values["filename"] = Guid.NewGuid().ToString() + ".jpg";
                    values["inmueble"] = webId.ToString();

                    var result = client.UploadValues(url, values);

                    string hola = Encoding.UTF8.GetString(result);

                }
            }
            catch (WebException wex)
            {
                string pageContent = new StreamReader(wex.Response.GetResponseStream()).ReadToEnd().ToString();
                //return pageContent;
            }
            catch (Exception ex)
            {
            }
            
        }

        //internal static Image ResizeImage(byte[] orginalbytes, int NewWidth, int MaxHeight, bool OnlyResizeIfWider)
        //{
        //    Image originalImage;

        //    using (var ms = new MemoryStream(orginalbytes))
        //    {
        //        originalImage = Image.FromStream(ms);
        //    }

        //    // Prevent using images internal thumbnail
        //    originalImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
        //    originalImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);

        //    if (OnlyResizeIfWider)
        //    {
        //        if (originalImage.Width <= NewWidth)
        //        {
        //            NewWidth = originalImage.Width;
        //        }
        //    }

        //    int NewHeight = originalImage.Height * NewWidth / originalImage.Width;
        //    if (NewHeight > MaxHeight)
        //    {
        //        // Resize with height instead
        //        NewWidth = originalImage.Width * MaxHeight / originalImage.Height;
        //        NewHeight = MaxHeight;
        //    }

        //    System.Drawing.Image NewImage = originalImage.GetThumbnailImage(NewWidth, NewHeight, null, IntPtr.Zero);

        //    // Clear handle to original file so that we can overwrite it if necessary
        //    originalImage.Dispose();

        //    return NewImage;
        //}


        public void GetInmueblesWeb()
        {

            WebClient syncClient = new WebClient();
            //syncClient.Headers.Add("application / json");
            var contentString = syncClient.DownloadString("http://www.moranvilla.com.ar/webservice");
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