using System;

namespace Estructurada04
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine("Dame el primer número");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame el segundo número");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame el terce número");
            z = int.Parse(Console.ReadLine());

            if ((z > y) && (y > x))
            {
                Console.WriteLine("Los números estan ordenados de menor a mayor");
            }
            else

                Console.WriteLine("Los números no estan ordenados de menor a mayor");

            if ((x + 1 == y) && (y + 1 == z))
            {
                Console.WriteLine("Los números son consecutivos");
            }
            else

                Console.WriteLine("Los números no son consecutivos");




        }
    }
}
