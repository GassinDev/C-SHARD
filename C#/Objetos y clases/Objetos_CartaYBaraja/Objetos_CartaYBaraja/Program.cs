using System;

namespace Objetos_CartaYBaraja
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartas c = new Cartas(10);
            Console.WriteLine(c.NumeroCarta + ", " + c.PaloCarta + ", " + c.NombreNumero + ", " + c.NombrePalo + ", " + c.NombreCarta + ", ValorTute: " + c.ValorTute + ", ValorMus: " + c.ValorMus + ", Valor7ymedia: " + c.Valor7ymedia);

            Baraja b = new Baraja(true);

            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine(b.Robar());
            }
        }
    }
}
