using System;

namespace EjerciciosAdicionales6
{
    class Program
    {
        static void Rombo(int n)
        {
            int i, j;
            for (j = 1; j <= n; j++)
            {
                for (i = 0; i < n - j; i++)
                {

                    Console.Write(" ");
                }

                for (i = 0; i < j * 2; i++)
                {

                    Console.Write("*");
                }
                Console.WriteLine("");

            }
            for (j = n - 1; j >= 0; j--)
            {
                for (i = 0; i < n - j; i++)
                {

                    Console.Write(" ");
                }

                for (i = j * 2; i > 0; i--)
                {

                    Console.Write("*");
                }
                Console.WriteLine("");

            }




        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            Rombo(n);





        }
    }
}
