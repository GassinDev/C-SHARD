using System;

namespace Estructurada02
{
    class Program
    {
        static void Main(string[] args)
        {
            int anno;

            Console.WriteLine("Dame un año");
            anno = int.Parse(Console.ReadLine());

            if (anno % 4 == 0)
            {
                Console.WriteLine("El año " + anno + " es bisiesto");
            }
            else

            if (anno % 4 != 0)
            {
                Console.WriteLine("El año " + anno + " no es bisiesto");
            }
            else;
   
        }
    }
}
