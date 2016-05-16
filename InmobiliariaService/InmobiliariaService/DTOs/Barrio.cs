using System;
using System.Collections.Generic;
using System.Web;

namespace InmobiliariaService
{
    [Serializable]
    public class Barrio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int LocalidadId { get; set; }
    }
}