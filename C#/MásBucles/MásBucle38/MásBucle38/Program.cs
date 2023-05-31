using System;

namespace MásBucle38
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i;

            Console.WriteLine("Dime un número");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime otro número");
            b = int.Parse(Console.ReadLine());

            i = a;

            while ( i >= 1)
            {
                if ((a % i == 0) && (b % i == 0))
                {
                    Console.WriteLine("El m.c.d es " + i);
                    i = 1;
                }

                i--;
            }

        }
    }
}
