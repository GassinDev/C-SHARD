using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos__DInero_5_
{
    class Dinero
    {
        //ATRIBUTOS
        static List<Moneda> listaMonedas = new List<Moneda>();

        //CONSTRUCTOR
        static Dinero() 
        {
            listaMonedas.Add(new Moneda(TipoMoneda.Euro, 2, "€", 1m));
            listaMonedas.Add(new Moneda(TipoMoneda.Yen, 0, "¥", 0.0079m));
            listaMonedas.Add(new Moneda(TipoMoneda.Dollar, 2, "$", 0.92m));
        }

        //MÉTODOS
        static void ActualizaCambio(TipoMoneda t, decimal cambio)
        {
            Moneda m;
            m = Busca(t);
            m.CambioEuro = cambio;
        }
    }
}
