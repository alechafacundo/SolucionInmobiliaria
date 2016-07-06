using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace InmobiliariaService
{
    //public class InmuebleWeb
    //{
    //    //"id" => $id, "fecha" => $fecha, 'tipo_operacion' => $tipo_operacion, 'tipo_inmueble' => $tipo_inmueble, 'expensas' => expensas, 'nombre_identitario' => nombre_identitario, 'ambientes' => ambientes, 'direccion' => direccion, 'comentarios' => comentarios); 
    //    public int id { get; set; }
    //    public DateTime fecha { get; set; }
    //    public int tipo_operacion { get; set; }
    //    public int tipo_inmueble { get; set; }
    //    public decimal expensas { get; set; }
    //    public string nombre_identitario { get; set; }
    //    public int ambientes { get; set; }
    //    public string direccion { get; set; }
    //    public string comentarios { get; set; }
    //}

    [DataContract]
    public class Rootobject
    {
        [DataMember]
        public int status { get; set; }
        [DataMember]
        public Info[] info { get; set; }
    }

    [DataContract]
    public class Info
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string fecha { get; set; }
        [DataMember]
        public string tipo_operacion { get; set; }
        [DataMember]
        public string tipo_inmueble { get; set; }
        [DataMember]
        public string expensas { get; set; }
        [DataMember]
        public string nombre_identitario { get; set; }
        [DataMember]
        public string ambientes { get; set; }
        [DataMember]
        public string direccion { get; set; }
        [DataMember]
        public string comentarios { get; set; }
        [DataMember]
        public string comentarios_internos { get; set; }
    }

}