using System;

namespace Funciones05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dime un número"); n = int.Parse(Console.ReadLine());

            Console.WriteLine("El signo de " + n + " es: " + Signo(n));

        }

        static int Signo(int n)
        {
            int resultado;

            if (n > 0)
            {
                resultado = 1;

            } else
            {
                if (n == 0)
                {
                    resultado = 0;
                }
             else

             
                resultado = - 1;
            }
             return resultado;


        }

    }
}
