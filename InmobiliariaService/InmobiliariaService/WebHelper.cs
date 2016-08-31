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
            int webId = 0;

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


                char ch = (char)65279;
                string resultado2 = resultado.Trim(ch);
                webId = Convert.ToInt32(resultado2);
                
            }

            return webId;
        }

        public void InsertFoto(Foto foto, int webId)
        {
            try
            {
                string url = "http://www.moranvilla.com.ar/web/insertFormFoto";
                using (WebClient client = new WebClient())
                {
                    string id = Guid.NewGuid().ToString();
                    //Imagen original
                    var values = new NameValueCollection();
                    values["foto"] = Convert.ToBase64String(foto.Imagen, Base64FormattingOptions.None);
                    values["filename"] = id + ".jpg";
                    values["inmueble"] = webId.ToString();
                    values["nuevo"] = "si";

                    var result = client.UploadValues(url, values);

                    string hola = Encoding.UTF8.GetString(result);

                    values = new NameValueCollection();

                    //Imagen f75
                    Image image75 = ResizeImage(foto.Imagen, 44, 75, true);
                    byte[] img75;
                    using (var ms = new MemoryStream())
                    {
                        image75.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        img75 = ms.ToArray();
                    }
                    values["foto"] = Convert.ToBase64String(img75, Base64FormattingOptions.None);
                    values["filename"] = id + "_h75.jpg";
                    values["inmueble"] = webId.ToString();
                    values["nuevo"] = "no";

                    result = client.UploadValues(url, values);

                    hola = Encoding.UTF8.GetString(result);

                    //Imagen w280 
                    Image image280 = ResizeImage(foto.Imagen, 257, 430, false);
                    byte[] img280;
                    using (var ms = new MemoryStream())
                    {
                        image280.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        img280 = ms.ToArray();
                    }
                    values["foto"] = Convert.ToBase64String(img280, Base64FormattingOptions.None);
                    values["filename"] = id + "_w280.jpg";
                    values["inmueble"] = webId.ToString();
                    values["nuevo"] = "no";

                    result = client.UploadValues(url, values);

                    hola = Encoding.UTF8.GetString(result);
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        internal static Image ResizeImage(byte[] orginalbytes, int NewWidth, int MaxHeight, bool OnlyResizeIfWider)
        {
            Image originalImage;

            using (var ms = new MemoryStream(orginalbytes))
            {
                originalImage = Image.FromStream(ms);
            }

            // Prevent using images internal thumbnail
            originalImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            originalImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);

            //if (OnlyResizeIfWider)
            //{
            //    if (originalImage.Width <= NewWidth)
            //    {
            //        NewWidth = originalImage.Width;
            //    }
            //}

            //int NewHeight = originalImage.Height * NewWidth / originalImage.Width;
            //if (NewHeight > MaxHeight)
            //{
            //    // Resize with height instead
            //    NewWidth = originalImage.Width * MaxHeight / originalImage.Height;
            //    NewHeight = MaxHeight;
            //}

            System.Drawing.Image NewImage = originalImage.GetThumbnailImage(NewWidth, MaxHeight, null, IntPtr.Zero);

            // Clear handle to original file so that we can overwrite it if necessary
            originalImage.Dispose();

            return NewImage;
        }


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