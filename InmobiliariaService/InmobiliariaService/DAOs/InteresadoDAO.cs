using System;
using System.Collections.Generic;
using System.Data;
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

        internal static List<Interesado> GetInteresados()
        {
            try
            {
                //Instanciamos una lista de vendedores que es la que vamos a retornar
                List<Interesado> vendedores = new List<Interesado>();
                //Hasta aca la lista esta vacia

                //Le pedimos a la bd que nos de todos los Vendedores
                DataTable dt = DAOBase.GetDataTable(new Interesado(), string.Empty);
                if (dt.Rows.Count > 0)
                {
                    //Aca llenamos la lista de vendedores
                    vendedores = LlenarInteresados(new Interesado(), dt);
                }

                //Retornamos la lista de vendedores
                return vendedores;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static List<Interesado> LlenarInteresados(Interesado vendedor, DataTable dt)
        {
            try
            {
                List<Interesado> dtos = new List<Interesado>();

                foreach (DataRow dr in dt.Rows)
                {
                    Interesado aux = new Interesado();
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