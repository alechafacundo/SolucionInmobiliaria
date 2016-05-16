using System;
using System.Collections.Generic;
using System.Web;

namespace InmobiliariaService
{
    [Serializable]
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
        public string Direccion { get; set; }
    }
}