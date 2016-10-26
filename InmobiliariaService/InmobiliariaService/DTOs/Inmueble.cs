using System;
using System.Collections.Generic;
using System.Web;

namespace InmobiliariaService
{
    public class Inmueble
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public int Operacion { get; set; }
        public int Tipo { get; set; }
        public int Ambientes { get; set; }
        public bool Cochera { get; set; }
        public string Ubicacion { get; set; }
        public string Antiguedad { get; set; }
        public string Comentarios { get; set; }   
        public string Localidad { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
        public string EntreCalles { get; set; }
        public string Metros2Terreno { get; set; }
        public string SupCubierta { get; set; }
        public int Moneda { get; set; }
        public decimal? Precio { get; set; }
        public string Observaciones { get; set; }
        public int CargadoPor { get; set; }
        public string Contacto { get; set; }
        public string Referencia { get; set; }
        public bool Disponible { get; set; }
        public int Estado { get; set; }
        public int WebId { get; set; }
        public string Provincia { get; set; }
    }
}