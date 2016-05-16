using System;
using System.Collections.Generic;
using System.Web;

namespace InmobiliariaService
{
    public class Inmueble
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        //Enum
        public eTipoOperacion TipoOperacion { get; set; }
        public string TipoInmueble { get; set; }
        public int VendedorId { get; set; }
        public string Telefono { get; set; }
        public int? LocalidadId { get; set; }
        public int? BarrioId { get; set; }
        public string Calle { get; set; }
        public int? Numero { get; set; }
        public string EntreCalles { get; set; }
        public string Metros { get; set; }
        public decimal SupCubierta { get; set; }
        //Enum
        public string Moneda { get; set; }
        public decimal? Precio { get; set; }
        public string Observaciones { get; set; }
        public decimal? Dormitorios { get; set; }
        public int? Baños { get; set; }
        public int? Comedor { get; set; }
        public int? Cocina { get; set; }
        public int? Garage { get; set; }
        public int? Patio { get; set; }
        public string DependenciasOtras { get; set; }
        public decimal? ValorMetro2 { get; set; }
        public int UserId { get; set; }
        public string Contacto { get; set; }
        public string Referencia { get; set; }
        public string Otro { get; set; }
    }
}