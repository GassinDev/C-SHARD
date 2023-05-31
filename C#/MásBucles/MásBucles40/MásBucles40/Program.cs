using System;

namespace MásBucles40
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, divisores;

            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            divisores = 0;

            for ( i = 2; i < n; i++)
            {
                if ( n % i == 0)
                {
                    divisores++;
                    break;
                }
            }

            if (divisores == 0)
            {
                Console.WriteLine("Es primo");
            }
            else
            {
                Console.WriteLine("No es primo");
            }
        }
    }
}
