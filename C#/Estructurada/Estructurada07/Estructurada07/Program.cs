using System;

namespace Estructurada07
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double raiz, resultado1, resultado2;

            Console.WriteLine("ax^2 + bx + c = 0");

            Console.WriteLine("Dame el valor de a");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Dame el valor de b");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Dame el valor de c");
            c = double.Parse(Console.ReadLine());

            raiz = (b * b) - (4 * a * c);

            if (raiz < 0)
            {
                Console.WriteLine("Tiene una solución");
                resultado1 = -b / (2 * a);
                Console.WriteLine("Solución " + resultado1);

            }
            else
            {
                Console.WriteLine("Tiene dos soluciones");
                resultado1 = -b / (2 * a);
                Console.WriteLine("Solución 1: " + resultado1);
                resultado2 = +b / (2 * a);
                Console.WriteLine("Solución 2: " + resultado2);

            } 
            


          
                

                
                
                
            

        




        }


    }
}
