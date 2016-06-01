using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InmobiliariaService
{
    public class FotoDAO
    {
        internal static void GuardarFoto(Foto foto)
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

        private static List<Foto> LlenarInmuebles(Foto foto, DataTable dt)
        {
            List<Foto> dtos = new List<Foto>();

            foreach (DataRow dr in dt.Rows)
            {
                Inmueble aux = new Inmueble();
                PoblarObjetoDesdeDataRow(aux, dr);

                dtos.Add(aux);
            }

            return dtos;
        }
    }
}