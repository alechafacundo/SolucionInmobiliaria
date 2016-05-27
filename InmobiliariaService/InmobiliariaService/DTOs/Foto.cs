using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InmobiliariaService
{
    [Serializable]
    public class Foto
    {
        public int Id { get; set; }
        public int InmobiliariaId { get; set; }
        public byte[] Imagen { get; set; }
    }
}