using System;

namespace Estructurada08
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Dame el valor de a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame el valor de b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame el valor de c");
            c = int.Parse(Console.ReadLine());

            if ((a > b) && (b > c))
            {
                Console.WriteLine(" El mayor es " + a);
                Console.WriteLine(" El mediano es " + b);
                Console.WriteLine(" El menor es " + c);
            }
            else

            if ((a > c) && (c > b))
            {
                Console.WriteLine(" El mayor es " + a);
                Console.WriteLine(" El mediano es " + c);
                Console.WriteLine(" El menor es " + b);
            }
            else

            if ((b > a) && (a > c))
            {
                Console.WriteLine(" El mayor es " + b);
                Console.WriteLine(" El mediano es " + a);
                Console.WriteLine(" El menor es " + c);
            }
            else

            if ((c > a) && (a > b))
            {
                Console.WriteLine(" El mayor es " + c);
                Console.WriteLine(" El mediano es " + a);
                Console.WriteLine(" El menor es " + b);
            }
            else

            if ((b > c) && (c > a))
            {
                Console.WriteLine(" El mayor es " + b);
                Console.WriteLine(" El mediano es " + c);
                Console.WriteLine(" El menor es " + a);
            }
            else

            if ((c > b) && (b > a))
            {
                Console.WriteLine(" El mayor es " + c);
                Console.WriteLine(" El mediano es " + b);
                Console.WriteLine(" El menor es " + a);
            }
            else
            {

            }


        }
    }
}
