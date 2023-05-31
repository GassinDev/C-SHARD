using System;

namespace BucleWhile20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n2, i = 0, mayor;

            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());
            mayor = n;

            while (i < 9)
            {
                Console.WriteLine("Dime un número");
                n2 = int.Parse(Console.ReadLine());

                if (n2 > mayor)
                {
                    mayor = n2;
                }
                i++;
            }
            Console.WriteLine("El valor máximo es " + mayor);
        }
    }
}
