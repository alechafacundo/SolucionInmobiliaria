using System;
using System.Collections.Generic;
using System.Text;

namespace InmobiliariaService
{
    public enum eTipoInmueble
	{
        Sin_Especificar = 0,
        Casa = 1,
        Terreno = 2,
        Departamento = 3,
        Quinta = 4,
        Local = 5,
        Oficina = 6,
        Galpon = 7
              

	}

    public enum eTipoOperacion
    {

        Venta = 0,
        Alquiler = 1
    }

    public enum eMoneda
    {
        Peso = 0,
        Dolar = 1
    }
}
