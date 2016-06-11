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
        public string Apellido { get; set;}
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Legajo { get; set; }
        //todo poner a DNI como int asi no admite letras
        public string Email { get; set; }
        public string DNI { get; set; }
        public string Password { get; set; }
        public string FullName { get { return Nombre + " " + Apellido;} set { value = Nombre + " " + Apellido; } }
    }
}