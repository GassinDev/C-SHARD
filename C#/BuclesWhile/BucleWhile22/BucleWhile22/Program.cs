using System;

namespace BucleWhile22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 1, factorial = 1;

            Console.WriteLine("Dime un número ");
            n = int.Parse(Console.ReadLine());

            while (i<=n)
                {

                factorial = factorial * i;

                i++;
            }

            Console.WriteLine("El factorial de " + n + " es " + factorial);


        }
    }
}
