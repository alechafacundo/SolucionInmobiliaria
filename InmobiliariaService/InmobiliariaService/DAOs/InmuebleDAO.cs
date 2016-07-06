using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace InmobiliariaService
{
    public class InmuebleDAO : DAOBase
    {
        internal static int GuardarInmueble(Inmueble inmueble, bool importado = false)
        {
            try
            {
                if (inmueble.Id == 0)
                {
                    inmueble.Id = GetNextId(inmueble);
                    DAOBase.CreateEntity(inmueble);
                    return inmueble.Id;
                }
                else
                {
                    if (importado)
                    {
                        DAOBase.CreateEntity(inmueble);
                        return inmueble.Id;
                    }
                    DAOBase.UpdateEntity(inmueble);
                    return inmueble.Id;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        internal static List<Inmueble> GetInmueblesParaInteresado(Interesado interesado)
        {
            try
            {
                List<Inmueble> aux = GetInmuebles();

                
                if (interesado.TipoDeInmueble != (int)eTipoInmueble.Sin_Especificar)
                {
                    aux.RemoveAll(x => x.Tipo != interesado.TipoDeInmueble);
                    //aux = aux.Where(x => x.Tipo == (int)tipoInmueble).ToList();
                }
                
                if (interesado.TipoDeOperacion != (int)eTipoOperacion.Sin_Especificar)
                {
                    aux.RemoveAll(x => x.Operacion != (int)interesado.TipoDeOperacion);
                    //aux = aux.Where(x => x.Operacion == (int)tipoOperacion).ToList();
                }

                
                if (interesado.MontoDesde !=  null && interesado.MontoDesde != 0)
                {
                    aux.RemoveAll(x => x.Precio < interesado.MontoDesde);
                    //aux = aux.Where(x => x.Precio <= numPrecioHasta.Value).ToList();
                }

                if (interesado.MontoHasta != null && interesado.MontoHasta != 0)
                {
                    aux.RemoveAll(x => x.Precio > interesado.MontoHasta.Value);
                    //aux = aux.Where(x => x.Precio >= numPrecioDesde.Value).ToList();
                }


                return aux;


                //List<Inmueble> inmuebles = new List<Inmueble>();

                //string where = string.Empty;
                //if (interesado.Dormitorios != null && interesado.Dormitorios != string.Empty)
                //{
                //    where += "Dormitorios = " + interesado.Dormitorios;
                //}

                //if (interesado.MontoDesde != null && interesado.MontoDesde != 0)
                //{
                //    if (where != string.Empty)
                //        where += " AND ";

                //    where += "Precio >= " + interesado.MontoDesde;
                //}

                //if (interesado.MontoHasta != null && interesado.MontoHasta != 0)
                //{
                //    if (where != string.Empty)
                //        where += " AND ";

                //    where += "Precio <= " + interesado.MontoHasta;
                //}

                //DataTable dt = DAOBase.GetDataTableWhere(new Inmueble(), where);

                //if (dt.Rows.Count > 0)
                //{
                //    inmuebles = LlenarInmuebles(new Inmueble(), dt);
                //}

            }
            catch (Exception)
            {
                throw;
            }
        }

        internal static List<Inmueble> BuscarInmuebles(Inmueble inmueble, decimal? precioDesde, decimal? precioHasta)
        {
            try
            {
                List<Inmueble> inmuebles = new List<Inmueble>();
                DataTable dt = DAOBase.GetDataTable(new Inmueble(), string.Empty);
                if (dt.Rows.Count > 0)
                {
                    inmuebles = LlenarInmuebles(new Inmueble(), dt);

                    inmuebles = inmuebles.Where(x => x.Operacion == inmueble.Operacion).ToList();
                    inmuebles = inmuebles.Where(x => x.Tipo == inmueble.Tipo).ToList();

                    if (!string.IsNullOrEmpty(inmueble.Barrio))
                    {
                        inmuebles = inmuebles.Where(x => x.Barrio.Contains(inmueble.Barrio)).ToList();
                    }
                    if (!string.IsNullOrEmpty(inmueble.Baños))
                    {
                        inmuebles = inmuebles.Where(x => x.Baños.Contains(inmueble.Baños)).ToList();
                    }
                    if (!string.IsNullOrEmpty(inmueble.Dormitorios))
                    {
                        inmuebles = inmuebles.Where(x => x.Dormitorios.Contains(inmueble.Dormitorios)).ToList();
                    }
                    if (!string.IsNullOrEmpty(inmueble.Localidad))
                    {
                        inmuebles = inmuebles.Where(x => x.Localidad.Contains(inmueble.Localidad)).ToList();
                    }
                    if (precioDesde.HasValue)
                    {
                        inmuebles = inmuebles.Where(x => x.Precio > precioDesde.Value && x.Moneda == inmueble.Moneda).ToList();
                    }
                    if (precioHasta.HasValue)
                    {
                        inmuebles = inmuebles.Where(x => x.Precio < precioHasta.Value && x.Moneda == inmueble.Moneda).ToList();
                    }
                }

                return inmuebles;
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal static List<Inmueble> GetInmuebles()
        {
            try
            {
                //Instanciamos una lista de inmuebles que es la que vamos a retornar
                List<Inmueble> inmuebles = new List<Inmueble>();
                //Hasta aca la lista esta vacia

                //Le pedimos a la bd que nos de todos los inmuebles
                DataTable dt = DAOBase.GetDataTable(new Inmueble(), string.Empty);
                if (dt.Rows.Count > 0)
                {
                    //Aca llenamos la lista de inmuebles
                    inmuebles = LlenarInmuebles(new Inmueble(), dt);
                }

                //Retornamos la lista de inmuebles
                return inmuebles;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static List<Inmueble> LlenarInmuebles(Inmueble inmueble, DataTable dt)
        {
            List<Inmueble> dtos = new List<Inmueble>();

            foreach (DataRow dr in dt.Rows)
            {
                Inmueble aux = new Inmueble();
                PoblarObjetoDesdeDataRow(aux, dr);

                dtos.Add(aux);
            }

            return dtos;
        }
        internal static bool DeleteInmueble(Inmueble inmueble)
        {
           
            int inmuebleId = inmueble.Id;
         
            List<Foto> fotos = FotoDAO.GetFotosDelInmueble(inmuebleId);

            for (int i = 0; i < fotos.Count; i++)
            {
                Foto foto = fotos[i];
                DAOBase.DeleteEntity(foto);
            }

            bool pudoEliminar = DAOBase.DeleteEntity(inmueble);
            return pudoEliminar;
        }
    }
}