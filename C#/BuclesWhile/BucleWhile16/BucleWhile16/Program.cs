using System;

namespace BucleWhile16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n2;

            Console.WriteLine(" Dime un número: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine(" Dime un número: ");
            n2 = int.Parse(Console.ReadLine());
            if (n < n2)
            {
                Console.WriteLine(" El mayor es " + n2 + " y el menor es " + n);
              
                

                while (n < n2)
                {
                    Console.WriteLine(n);
                    n = n + 2;

                }


            }else

                Console.WriteLine(" El mayor es " + n + " y el menor es " + n2);

            while (n > n2)
            {
                Console.WriteLine(n2);
                n2 = n2 + 2;
            }

        }
    }
}
