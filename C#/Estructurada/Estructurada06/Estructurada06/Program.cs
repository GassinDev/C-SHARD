using System;

namespace Estructurada06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Dame un número");
            n = int.Parse(Console.ReadLine());

            if ((n < 10) && (n > -10))
            {
                Console.WriteLine("Tiene una cifra");
            }
            else
            if ((n < 100) && (n > -100))
            {
                Console.WriteLine("Tiene dos cifra");
            }
            else
            if ((n < 1000) && (n > -1000))
            {
                Console.WriteLine("Tiene tres cifra");
            }
            else
            if ((n < 10000) && (n > -10000))
            {
                Console.WriteLine("Tiene cuatro cifra");
            }
            else
            {
                Console.WriteLine("Tiene cinco cifra o más");
            }
            
            

            
        }
    }
}
