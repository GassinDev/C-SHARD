using System;

namespace EjerciciosAdicionales1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Dame un número: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame otro número: ");
            b = int.Parse(Console.ReadLine());

           PrimosRelativos(a, b);

        }

        static void PrimosRelativos (int a, int b)
        {
            if ( MCD (a, b) == 1)
            {
                Console.WriteLine(a + " y " + b + " son primos relativos.");
            }
            else
            {
                Console.WriteLine(a + " y " + b + " no son primos relativos.");
            }
            
        }

        static int MCD(int a, int b)
        {
            int min, i;

            min = a < b ? a : b;

            i = min;

            while (a % i != 0 || b % i != 0)
            {
                i--;
            }

            return i;
        }






    }
}
