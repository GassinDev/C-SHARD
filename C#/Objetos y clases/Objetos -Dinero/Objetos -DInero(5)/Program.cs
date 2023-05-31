using System;

namespace Objetos__DInero_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Moneda m = new Moneda(TipoMoneda.Yen, 0, "¥", 0.0079m);
            Console.WriteLine(m);
        }
    }
}
