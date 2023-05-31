using System;

namespace Estructurada01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.WriteLine("Dame un número");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame otro número");
            n2 = int.Parse(Console.ReadLine());

            if (n2 > n1)
            {
                Console.WriteLine("El resultado es " + (n2 - n1));
            }
            if (n1 > n2)
            {
                Console.WriteLine("El resultado es " + (n1 - n2));
            }

        }
    }
}
