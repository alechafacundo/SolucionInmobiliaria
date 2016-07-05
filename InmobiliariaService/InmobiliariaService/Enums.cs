using System;
using System.Collections.Generic;
using System.Text;

namespace InmobiliariaService
{
    public enum eTipoInmueble
	{
        Sin_Especificar = 0,
        Terreno = 1,
        Departamento = 2,
        Casa = 3,
        Quinta = 4,
        Local = 5,
        Fondo de Comercio = 6,
        Oficina = 7,
        Galpon = 8
              

	}

    public enum eTipoOperacion
    {
        Sin_Especificar = 0,
        Venta = 1,
        Alquiler = 2
    }

    public enum eMoneda
    {
        Sin_Especificar = 0,
        Peso = 1,
        Dolar = 0
    }
}
