using System;

namespace BucleFor32
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n2, i, mayor = int.MinValue;

            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < 9; i++)
            {
                Console.WriteLine("Dime un número");
                n2 = int.Parse(Console.ReadLine());

                if (n2 > mayor)
                {
                    mayor = n2;
                }

            }
            Console.WriteLine("El valor máximo es " + mayor); 
        }
    }
}
