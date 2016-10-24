using System;
using System.Collections.Generic;
using System.Web;

namespace InmobiliariaService
{
    [Serializable]
    public class Interesado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public decimal? MontoDesde { get; set; }
        public decimal? MontoHasta { get; set; }
        public int TipoDeMoneda { get; set; }
        public int TipoDeOperacion { get; set; }
        public int TipoDeInmueble { get; set; }
        public string Observaciones { get; set; }
        public bool Disponible { get; set; }
        public int Ambientes { get; set; }
        public string Localidad { get; set; }
    }
}