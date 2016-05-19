using System;
using System.Collections.Generic;
using System.Text;

namespace InmobiliariaService
{
    [Serializable]
    public enum eTipoInmueble
	{
        Casa = 0,
        Terreno = 1,
        Departamento = 2
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
