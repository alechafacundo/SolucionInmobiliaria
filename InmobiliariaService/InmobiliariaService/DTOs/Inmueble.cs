using System;
using System.Collections.Generic;
using System.Web;

namespace InmobiliariaService
{
    public class Inmueble
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }//
        public int Operacion { get; set; }//
        public int Tipo { get; set; }//
        //public string Nombre { get; set; }
        //public string Telefono { get; set; }
        public string Localidad { get; set; }//
        public string Barrio { get; set; }//
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
        public string EntreCalles { get; set; }
        public string Metros2Terreno { get; set; }
        public string SupCubierta { get; set; }
        public int Moneda { get; set; }
        public decimal? Precio { get; set; }//
        public string Observaciones { get; set; }
        public string Dormitorios { get; set; }//
        public string Baños { get; set; }
        public string Comedor { get; set; }
        public string Cocina { get; set; }
        public string Garage { get; set; }
        public string Patio { get; set; }
        public string OtrasDependencias { get; set; }
        public string ValorMetro2 { get; set; }
        public int CargadoPor { get; set; }
        public string Contacto { get; set; }
        public string Referencia { get; set; }
        public string Otros { get; set; }
        public bool Disponible { get; set; }
    }
}