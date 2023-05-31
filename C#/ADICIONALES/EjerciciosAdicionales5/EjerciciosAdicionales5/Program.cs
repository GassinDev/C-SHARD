using System;

namespace EjerciciosAdicionales5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("¿ De cuánto quiere la pirámide churrita ? Entre 3 y 20. ");
            a = int.Parse(Console.ReadLine());

            TrianguloEstrellitas(a);
        }

        static void TrianguloEstrellitas (int a)
        {
            int i, j;

            while (a < 3 || a > 20)
            {
                Console.WriteLine("¿ De cuánto quiere la pirámide churrita ? Entre 3 y 20. ");
                a = int.Parse(Console.ReadLine());
            }

            for ( j = 0; j <= a - 1; j++)
            {
                for (i = 0; i <= j; i++)
                {
                    Console.Write("*");

                }
                Console.WriteLine(" ");

            }

            
                


            
        }
    }
}
