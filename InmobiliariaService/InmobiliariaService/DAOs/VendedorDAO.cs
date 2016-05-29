using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InmobiliariaService
{
    public class VendedorDAO : DAOBase
    {
        internal static void CrearVendedor(Vendedor vendedor)
        {
            try
            {
                if (vendedor.Id == null || vendedor.Id == 0)
                {
                    vendedor.Id = GetNextId(vendedor);
                    DAOBase.CreateEntity(vendedor);
                }
                else
                {
                    DAOBase.UpdateEntity(vendedor);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

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
            try
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
            catch (Exception)
            {

                throw;
            }
        }

        internal static Vendedor Login(string dni, string password)
        {
            try
            {
                List<Vendedor> vendedores = new List<Vendedor>();
                DataTable dt = DAOBase.GetDataTableWhere(new Vendedor(), string.Format("DNI = '{0}' AND Password = '{1}'", dni, password));

                if (dt.Rows.Count > 0)
                {
                    Vendedor vendedor = new Vendedor();
                    PoblarObjetoDesdeDataRow(vendedor, dt.Rows[0]);

                    return vendedor;
                }
                else
                {
                    return null;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}