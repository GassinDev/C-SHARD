using System;

namespace Funciones01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Dame un número: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine(par(n));

            if(par(n))
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }


        static bool par(int n)
        {
            bool par;

            if (n % 2 == 0)
            {
                par = true;
            }
            else
            {
                par = false;
            }

            return par;
        }

    }
}
