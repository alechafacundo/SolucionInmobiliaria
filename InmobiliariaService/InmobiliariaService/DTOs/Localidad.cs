using System;
using System.Collections.Generic;
using System.Web;

namespace InmobiliariaService
{
    [Serializable]
    public class Localidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}