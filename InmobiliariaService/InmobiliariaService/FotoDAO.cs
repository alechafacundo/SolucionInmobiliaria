using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InmobiliariaService
{
    public class FotoDAO : DAOBase
    {
        internal static void CrearFoto(Foto foto)
        {
            try
            {
                if (foto.Id == null || foto.Id == 0)
                {
                    foto.Id = GetNextId(foto);
                    DAOBase.CreateEntity(foto);
                }
                else
                {
                    DAOBase.UpdateEntity(foto);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal static List<Foto> GetFotosDelInmueble(int inmuebleId)
        {
            try
            {
                //Instanciamos una lista de Fotos que es la que vamos a retornar
                List<Foto> fotos = new List<Foto>();
                //Hasta aca la lista esta vacia

                //Le pedimos a la bd que nos de todos los Fotos
                DataTable dt = DAOBase.GetDataTable(new Foto(), string.Format("InmuebleId = {0}", inmuebleId));
                if (dt.Rows.Count > 0)
                {
                    //Aca llenamos la lista de Fotos
                    fotos = LlenarFotos(new Foto(), dt);
                }

                //Retornamos la lista de vendedores
                return fotos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static List<Foto> LlenarFotos(Foto foto, DataTable dt)
        {
            try
            {
                List<Foto> dtos = new List<Foto>();

                foreach (DataRow dr in dt.Rows)
                {
                    Foto aux = new Foto();
                    PoblarObjetoDesdeDataRow(aux, dr);

                    dtos.Add(aux);
                }

                return dtos;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
