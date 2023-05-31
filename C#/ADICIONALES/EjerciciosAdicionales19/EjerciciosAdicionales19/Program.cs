using System;

namespace EjerciciosAdicionales19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Dime un número");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime un número");
            b = int.Parse(Console.ReadLine());

            ProgresionAritmetica(a, b);
        }


        static void ProgresionAritmetica (int a, int b)
        {
            int i, resta;

            resta = b - a;
            for (i = 1; i <= 10; i++)
            {
                
                Console.Write(a +", ");

                a = a + resta;
            }

            
        }
    }
}
