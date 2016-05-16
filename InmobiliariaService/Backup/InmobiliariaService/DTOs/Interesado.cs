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
        public string Telefono { get; set; }
        public string Email { get; set; }
        public decimal? MontoDesde { get; set; }
        public decimal? MontoHasta { get; set; }
        //Enum
        public int TipoDeOperacion { get; set; }
        public int TipoDeInmueble { get; set; }
        public int? Dormitorios { get; set; }
        public bool ParaInversion { get; set; }
    }
}