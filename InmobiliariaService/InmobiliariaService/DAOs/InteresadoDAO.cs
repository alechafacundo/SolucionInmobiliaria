using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InmobiliariaService
{
    public class InteresadoDAO : DAOBase
    {

        internal static void CrearInteresado(Interesado interesado)
        {
            try
            {
                if (interesado.Id == null || interesado.Id == 0)
                {
                    interesado.Id = GetNextId(interesado);
                    DAOBase.CreateEntity(interesado);
                }
                else
                {
                    DAOBase.UpdateEntity(interesado);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}