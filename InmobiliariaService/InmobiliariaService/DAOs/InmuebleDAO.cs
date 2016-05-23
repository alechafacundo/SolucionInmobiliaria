using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace InmobiliariaService
{
    public class InmuebleDAO : DAOBase
    {

        internal static void GuardarInmueble(Inmueble inmueble)
        {
            try
            {
                if (inmueble.Id == null || inmueble.Id == 0)
                {
                    inmueble.Id = GetNextId(inmueble);
                    DAOBase.CreateEntity(inmueble);
                }
                else
                {
                    DAOBase.UpdateEntity(inmueble);
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
                List<Inmueble> inmuebles = new List<Inmueble>();

                string where = string.Empty;
                if (interesado.Dormitorios != null)
                {
                    where += "Dormitorios == " + interesado.Dormitorios;
                }

                if (interesado.MontoDesde != null)
                {
                    if (where != string.Empty)
                        where += " AND ";

                    where += "Precio >= " + interesado.MontoDesde;
                }

                if (interesado.MontoHasta != null)
                {
                    if (where != string.Empty)
                        where += " AND ";

                    where += "Precio <= " + interesado.MontoHasta;
                }

                DataTable dt = DAOBase.GetDataTableWhere(new Inmueble(), where);

                if (dt.Rows.Count > 0)
                {
                    inmuebles = LlenarInmuebles(new Inmueble(), dt);
                }

                return inmuebles;
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
    }
}