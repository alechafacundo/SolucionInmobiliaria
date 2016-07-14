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
        FondoDeComercio = 6,
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
        Dolar = 2
    }

    public enum eAmbientes
    {
        Sin_Especificar = 0,
        Monoambiente = 1,
        Dos_Ambiente = 2,
        Tres_Ambientes = 3,
        Cuatro_Ambientes = 4,
        Cinco_O_Mas_Ambientes = 5
    }

    public enum eCochera
    {
        No = 0,
        Si = 1
    }

    public enum eUbicacion
    {
        Sin_Especificar = 0,
        Frente = 1,
        Contrafrente = 2,
        Lateral = 3,
        Interno = 4
    }

    public enum eEstado
    {
        Sin_Especificar = 0,
        Exelente = 1,
        Muy_Bueno = 2,
        Bueno = 3,
        Regular = 4,
        En_Construccion = 5,
        En_Pozo = 6,
        A_Estrenar = 7

    }
}
