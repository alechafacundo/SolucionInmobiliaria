﻿using System;
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

        internal static List<Interesado> GetInteresadosParaInmueble(Inmueble inmueble)
        {
            try
            {
                List<Interesado> interesados = new List<Interesado>();

                string where = "1 = 1";
                if (inmueble.Precio != null && inmueble.Precio != 0m)
                {
                    where += string.Format(" AND ((MontoDesde <= {0} AND MontoHasta >= {0}) OR (MontoDesde = 0 AND MontoHasta = 0))", inmueble.Precio);
                }

                where += string.Format(" AND TipoDeMoneda = {0}", inmueble.Moneda);

                if (inmueble.Tipo != (int)eTipoInmueble.Sin_Especificar)
                {
                    where += string.Format(" AND TipoDeInmueble = {0}", inmueble.Tipo);
                }

                if (inmueble.Operacion != (int)eTipoOperacion.Sin_Especificar)
                {
                    where += string.Format(" AND TipoDeOperacion = {0}", inmueble.Operacion);
                }

                DataTable dt = DAOBase.GetDataTableWhere(new Interesado(), where);
                if (dt.Rows.Count > 0)
                {
                    //Aca llenamos la lista de interesados
                    interesados = LlenarInteresados(new Interesado(), dt);
                }

                return interesados;
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
                //Instanciamos una lista de interesado que es la que vamos a retornar
                List<Interesado> interesado = new List<Interesado>();
                //Hasta aca la lista esta vacia

                //Le pedimos a la bd que nos de todos los interesado
                DataTable dt = DAOBase.GetDataTable(new Interesado(), string.Empty);
                if (dt.Rows.Count > 0)
                {
                    //Aca llenamos la lista de interesado
                    interesado = LlenarInteresados(new Interesado(), dt);
                }

                //Retornamos la lista de interesado
                return interesado;
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