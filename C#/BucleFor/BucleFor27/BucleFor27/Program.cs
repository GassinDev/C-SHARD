using System;

namespace BucleFor27
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador, n, resultado;

            Console.WriteLine(" Dime un número:");
            n = int.Parse(Console.ReadLine());

            for (contador = 1; contador <= 10; contador++)
            {
                resultado = contador * n;
                Console.WriteLine(n + " x " + contador + " = " + resultado);
            }

        }
    }
}
