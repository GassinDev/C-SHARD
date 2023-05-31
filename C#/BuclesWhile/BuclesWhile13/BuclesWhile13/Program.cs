using System;

namespace BuclesWhile13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n2 = 0, resultado;
            Console.WriteLine("Dime un número: ");
            n = int.Parse(Console.ReadLine());

            while (n2 <= 10)
            {

                resultado = n * n2;

                Console.WriteLine(n + " x " + n2 + " = " + resultado);

                n2++;
            }
        }
    }
}
