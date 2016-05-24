using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InmobiliariaService
{
    public class VendedorDAO : DAOBase
    {
        //internal static void CrearInteresado(Interesado interesado)
        //{
        //    try
        //    {
        //        if (interesado.Id == null || interesado.Id == 0)
        //        {
        //            interesado.Id = GetNextId(interesado);
        //            DAOBase.CreateEntity(interesado);
        //        }
        //        else
        //        {
        //            DAOBase.UpdateEntity(interesado);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        internal static List<Vendedor> GetVendedores()
        {
            try
            {
                //Instanciamos una lista de vendedores que es la que vamos a retornar
                List<Vendedor> vendedores = new List<Vendedor>();
                //Hasta aca la lista esta vacia

                //Le pedimos a la bd que nos de todos los Vendedores
                DataTable dt = DAOBase.GetDataTable(new Vendedor(), string.Empty);
                if (dt.Rows.Count > 0)
                {
                    //Aca llenamos la lista de vendedores
                    vendedores = LlenarVendedores(new Vendedor(), dt);
                }

                //Retornamos la lista de vendedores
                return vendedores;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static List<Vendedor> LlenarVendedores(Vendedor vendedor, DataTable dt)
        {
            List<Vendedor> dtos = new List<Vendedor>();

            foreach (DataRow dr in dt.Rows)
            {
                Vendedor aux = new Vendedor();
                PoblarObjetoDesdeDataRow(aux, dr);

                dtos.Add(aux);
            }

            return dtos;
        }
    }
}