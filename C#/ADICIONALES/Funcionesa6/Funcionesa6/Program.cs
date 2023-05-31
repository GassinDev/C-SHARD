using System;

namespace Funcionesa6
{
    class Program
    {
        // Escribe la función rombo que te escribe un rombo en pantalla a base de asteriscos(la
        //pirámide del ejercicio 6 sería la cuarta parte del rombo).
        //Opcional: Hacerlo con el número de bucles más pequeño posible(se puede hacer sin
        //bucles incluso). 


        static void Rombo(int n)
        {
            int i, j;
            for (j = 1; j <= n ; j++)
            {
                for (i = 0; i < n-j; i++)
                {

                    Console.Write(" ");
                }

               for (i = 0; i < j*2; i++)
                {

                    Console.Write("*");
               }
               Console.WriteLine("");

            }
            for (j = n - 1; j >=0; j--)
            {
                for (i = 0; i < n - j; i++)
                {

                    Console.Write(" ");
                }

                for (i = j*2; i > 0; i--)
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
